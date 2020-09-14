using Gako.Data.EntityBinder;
using NHibernate.Transform;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gako.Data.EntityBinder.NHibernateUtilities
{
    public class EntityTransformer<TEntity> : IResultTransformer
    {
        public EntityTransformer() : this(InstanceCreator<TEntity>.Func)
        {
        }

        public EntityTransformer(Func<TEntity> entityCreator)
        {
            this.createEntity = entityCreator;
            this.entityBinder = EntityBinder<TEntity>.Instance;
        }

        private readonly Func<TEntity> createEntity;

        private readonly EntityBinder<TEntity> entityBinder;

        private IReadOnlyList<int> propertyIndices = null;

        private int rowNumber = 0;

        public IList TransformList(IList collection) => collection;

        public object TransformTuple(object[] tuple, string[] aliases)
        {
            if (this.propertyIndices == null)
            {
                this.propertyIndices = this.entityBinder.GetPropertyIndices(aliases).ToArray();
            }

            this.rowNumber++;
            var entity = this.createEntity();

            // 各列を処理する。
            for (int colIdx = 0; colIdx < tuple.Length; colIdx++)
            {
                try
                {
                    int propIndex = this.propertyIndices[colIdx];
                    object value = tuple[colIdx];
                    this.entityBinder.SetValueTo(entity, propIndex, value);
                }
                catch (Exception e)
                {
                    int colNumber = colIdx + 1;
                    string colName = aliases[colIdx];
                    throw new NhibernateUtilityException(string.Format("{0}行{1}列 {2}: エラーが発生しました。", this.rowNumber, colNumber, colName), e);
                }
            }

            return entity;
        }
    }
}
