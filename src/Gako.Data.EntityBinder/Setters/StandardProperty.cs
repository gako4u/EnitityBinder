using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder.Setters
{
    internal class StandardProperty<TEntity, TProperty> : Property<TEntity, TProperty, TProperty>
    {
        public StandardProperty(int index, PropertyInfo info) : base(index, info)
        {
        }

        protected override IEnumerable<Type> EnumerateGenericTypeParameters()
        {
            yield return typeof(TEntity);
            yield return typeof(TProperty);
        }

        protected override TProperty Convert(object value) => 
            value == null
                ? default
                : this.converter(value);
    }
}
