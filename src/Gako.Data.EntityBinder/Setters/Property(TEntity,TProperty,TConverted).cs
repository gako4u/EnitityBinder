using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder.Setters
{
    internal abstract class Property<TEntity, TProperty, TConverted> : Property<TEntity>
    {
        protected Property(int index, PropertyInfo info) : base(index, info)
        {
            this.setter = this.CreateSetter();

            switch (this.Attribute.Behavior)
            {
                case ConvertBehavior.Convert: /* */ this.converter = PropertyHelper<TConverted>.convert; break;
                case ConvertBehavior.Cast:    /* */ this.converter = PropertyHelper<TConverted>.cast; break;
                default:                      /* */ this.converter = PropertyHelper<TConverted>.cast; break;
            }
        }

        private readonly Action<TEntity, TProperty> setter;

        protected readonly Convert<TConverted> converter;

        private Action<TEntity, TProperty> CreateSetter()
        {
            //var parameterEntity = System.Linq.Expressions.Expression.Parameter(typeof(TEntity), "entity");
            //var parameterValue = System.Linq.Expressions.Expression.Parameter(typeof(TProperty), "value");
            //var property = System.Linq.Expressions.Expression.Property(parameterEntity, this.Info);
            //var body = System.Linq.Expressions.Expression.Assign(property, parameterValue);
            //var lambda = System.Linq.Expressions.Expression.Lambda<Action<TEntity, TProperty>>(body, parameterEntity, parameterValue);
            //return lambda.Compile();

            var setMethod = this.Info.GetSetMethod(true);
            var setDelegate = setMethod.CreateDelegate(typeof(Action<TEntity, TProperty>));
            return (Action<TEntity, TProperty>)setDelegate;
        }

        public override sealed void SetValue(TEntity entity, object value)
        {
            try
            {
                TProperty converted;
                try
                {
                    converted = this.Convert(value);
                }
                catch (Exception e)
                {
                    string fromName = value?.GetType().Name ?? "null";
                    string errorMessage = string.Format("{0} -> {1}", fromName, typeof(TProperty).Name);
                    throw new InvalidCastException(errorMessage, e);
                }

                this.setter(entity, converted);
            }
            catch (Exception e)
            {
                string srcValueString = value == null ? "null" : string.Format("{0} 型の値 {1}", value.GetType().Name, value);
                string errorMessage = string.Format("{0}: {1} を {2} に設定できません。", this.Name, srcValueString, this.Type.Name);
                throw new EntityBinderException(errorMessage, e);
            }
        }

        protected abstract TProperty Convert(object value);
    }

    internal static class PropertyHelper<TConverted>
    {
        public static readonly Convert<TConverted> cast = PropertyHelper.Cast<TConverted>;

        public static readonly Convert<TConverted> convert = PropertyHelper.Convert<TConverted>;
    }

    internal static class PropertyHelper
    {
        public static TConverted Cast<TConverted>(object value)
        {
            if (value is TConverted converted)
            {
                return converted;
            }

            var valueType = value.GetType();
            if (Assignment.Castable<TConverted>(valueType))
            {
                return Assignment.Cast<TConverted>(value);
            }

            throw new InvalidCastException("暗黙的なキャストが失敗しました。");
        }

        public static TConverted Convert<TConverted>(object value)
        {
            var valueType = value.GetType();
            if (Assignment.Convertible<TConverted>(valueType))
            {
                return Assignment.Convert<TConverted>(value);
            }

            throw new ArithmeticException("変換が失敗しました。");
        }
    }
}
