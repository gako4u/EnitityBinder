using Gako.Data.EntityBinder.Setters;
using Gako.Data.EntityBinder.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder
{
    public class EntityBinder<TEntity>
    {
        private EntityBinder()
        {
            var entityType = typeof(TEntity);

            this.propertyArray =
                entityType
                    .GetAccessibleProperties()
                    .Select((propInfo, idx) => Property<TEntity>.Create(idx, propInfo))
                    .ToArray();

            this.propertyDictionary = new FixedSizeDictionary<string, Property<TEntity>>(0.75f, this.propertyArray, prop => prop.Name);
        }

        private readonly Property<TEntity>[] propertyArray;

        private readonly FixedSizeDictionary<string, Property<TEntity>> propertyDictionary;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(this.GetType().Name);
            sb.Append('<');
            sb.Append(typeof(TEntity).Name);
            sb.Append('>');

            return sb.ToString();
        }

        public IEnumerable<int> GetPropertyIndices(IEnumerable<string> propertyNames)
        {
            return
                propertyNames
                    .Select(alias =>
                        {
                            var prop = this.propertyDictionary.GetOrDefault(alias, null);
                            return prop?.Index ?? EntityBinder<TEntity>.EmptyIndex;
                        }
                    );
        }

        public void SetValueTo(TEntity entity, int propertyIndex, object value)
        {
            if (EntityBinder<TEntity>.EmptyIndex != propertyIndex)
            {
                Property<TEntity> prop;

                try
                {
                    prop = this.propertyArray[propertyIndex];
                }
                catch (ArgumentOutOfRangeException e)
                {
                    throw new EntityBinderException($"{nameof(propertyIndex)} が範囲外です。", e);
                }

                prop.SetValue(entity, value);
            }
        }

        public void SetValueTo(TEntity entity, string propertyName, object value)
        {
            var prop = this.propertyDictionary.GetOrDefault(propertyName, null);
            prop?.SetValue(entity, value);
        }

        static EntityBinder()
        {
            EntityBinder<TEntity>.Instance = new EntityBinder<TEntity>();
        }

        private const int EmptyIndex = -1;

        public static EntityBinder<TEntity> Instance { get; }
    }
}
