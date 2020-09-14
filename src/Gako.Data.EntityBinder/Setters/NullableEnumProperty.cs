using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Gako.Data.EntityBinder.Setters
{
    internal class NullableEnumProperty<TEntity, TEnum, TEnumUnderlying> : Property<TEntity, TEnum?, TEnumUnderlying>
        where TEnum : struct, Enum
        where TEnumUnderlying : struct
    {
        public NullableEnumProperty(int index, PropertyInfo info) : base(index, info)
        {
            this.toEnum = EnumConverter<TEnumUnderlying, TEnum>.Converter;
        }

        private readonly Func<TEnumUnderlying, TEnum> toEnum;

        protected override IEnumerable<Type> EnumerateGenericTypeParameters()
        {
            yield return typeof(TEntity);
            yield return typeof(TEnum);
            yield return typeof(TEnumUnderlying);
        }

        protected override TEnum? Convert(object value) =>
            value == null
                ? null
                : (TEnum?)this.toEnum(this.converter(value));
    }
}
