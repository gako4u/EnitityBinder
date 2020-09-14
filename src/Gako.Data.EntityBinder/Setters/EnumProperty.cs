using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Gako.Data.EntityBinder.Setters
{
    internal class EnumProperty<TEntity, TEnum, TUnderlying> : Property<TEntity, TEnum, TUnderlying>
        where TEnum : struct, Enum
        where TUnderlying : struct
    {
        public EnumProperty(int index, PropertyInfo info) : base(index, info)
        {
            this.toEnum = EnumConverter<TUnderlying, TEnum>.Converter;
        }

        private readonly Func<TUnderlying, TEnum> toEnum;

        protected override IEnumerable<Type> EnumerateGenericTypeParameters()
        {
            yield return typeof(TEntity);
            yield return typeof(TEnum);
            yield return typeof(TUnderlying);
        }

        protected override TEnum Convert(object value) =>
            value == null
                ? default
                : this.toEnum(this.converter(value));
    }
}
