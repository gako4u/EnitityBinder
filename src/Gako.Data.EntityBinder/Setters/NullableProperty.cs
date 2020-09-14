using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Gako.Data.EntityBinder.Setters
{
    internal class NullableProperty<TEntity, TUnderlying> : Property<TEntity, TUnderlying?, TUnderlying>
        where TUnderlying : struct
    {
        public NullableProperty(int index, PropertyInfo info) : base(index, info)
        {
        }

        protected override IEnumerable<Type> EnumerateGenericTypeParameters()
        {
            yield return typeof(TEntity);
            yield return typeof(TUnderlying);
        }

        protected override TUnderlying? Convert(object value) =>
            value == null
                ? null
                : (TUnderlying?)this.converter(value);
    }
}
