using Gako.Data.EntityBinder.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder.Setters
{
    internal abstract class Property<TEntity>
    {
        private protected Property(int index, PropertyInfo info)
        {
            this.Index = index;
            this.Info = info;
            this.Attribute = ConvertAttribute.GetOrDefault(info);
        }

        public int Index { get; }

        public PropertyInfo Info { get; }

        public Type Type => this.Info.PropertyType;

        public string Name => this.Info.Name;

        public ConvertAttribute Attribute { get; }

        public abstract void SetValue(TEntity entity, object value);

        public sealed override string ToString()
        {
            var typeNames = this.EnumerateGenericTypeParameters().Select(type => type.Name);

            var sb = new StringBuilder();
            sb.Append(this.GetType().Name);
            sb.Append('<');
            sb.Append(string.Join(", ", typeNames));
            sb.Append("> ");
            sb.Append(this.Name);

            return sb.ToString();
        }

        protected abstract IEnumerable<Type> EnumerateGenericTypeParameters();

        internal static Property<TEntity> Create(int index, PropertyInfo propInfo)
        {
            Type setterType;

            if (CustomConvertAttribute.GetOrNull(propInfo) != null)
            {
                setterType = typeof(CustomTypeProperty<,>).MakeGenericType(typeof(TEntity), propInfo.PropertyType);
            }
            else if (propInfo.PropertyType.IsEnum)
            {
                var enumUnderlyingType = Enum.GetUnderlyingType(propInfo.PropertyType);
                setterType = typeof(EnumProperty<,,>).MakeGenericType(typeof(TEntity), propInfo.PropertyType, enumUnderlyingType);
            }
            else if (propInfo.PropertyType.IsNullable())
            {
                var nullableUnderlyingType = Nullable.GetUnderlyingType(propInfo.PropertyType);
                if (nullableUnderlyingType.IsEnum)
                {
                    var enumUnderlyingType = Enum.GetUnderlyingType(nullableUnderlyingType);
                    setterType = typeof(NullableEnumProperty<,,>).MakeGenericType(typeof(TEntity), nullableUnderlyingType, enumUnderlyingType);
                }
                else
                {
                    setterType = typeof(NullableProperty<,>).MakeGenericType(typeof(TEntity), nullableUnderlyingType);
                }
            }
            else
            {
                setterType = typeof(StandardProperty<,>).MakeGenericType(typeof(TEntity), propInfo.PropertyType);
            }

            var setter = (Property<TEntity>)Activator.CreateInstance(setterType, index, propInfo);
            return setter;
        }
    }
}
