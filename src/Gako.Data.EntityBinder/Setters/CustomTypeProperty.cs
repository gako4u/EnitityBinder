using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Gako.Data.EntityBinder.Setters
{
    internal class CustomTypeProperty<TEntity, TProperty> : Property<TEntity, TProperty, TProperty>
    {
        public CustomTypeProperty(int index, PropertyInfo info) : base(index, info)
        {
            this.attribute = CustomConvertAttribute.GetOrNull(this.Info);
        }

        private readonly CustomConvertAttribute attribute;

        protected override IEnumerable<Type> EnumerateGenericTypeParameters()
        {
            yield return typeof(TEntity);
            yield return typeof(TProperty);
        }

        protected override TProperty Convert(object value) => (TProperty)this.attribute.Convert(value);
    }
}
