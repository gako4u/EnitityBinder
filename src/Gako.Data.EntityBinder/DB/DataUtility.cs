using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder.DB
{
    public static class DataUtility
    {
        public static IEnumerable<TEntity> Read<TEntity>(
            this IDbCommand command
            , CommandBehavior behavior = CommandBehavior.Default
            , Func<TEntity> createEntity = null
        )
        {
            return
                DataUtility.ReadInternal<TEntity>(
                    command
                    , behavior
                    , createEntity ?? InstanceCreator<TEntity>.Func
                );
        }

        private static IEnumerable<TEntity> ReadInternal<TEntity>(
            IDbCommand command
            , CommandBehavior behavior
            , Func<TEntity> createEntity
        )
        {
            var entityBinder = EntityBinder<TEntity>.Instance;

            IReadOnlyList<int> propertyIndices = null;

            int rowNumber = 0;

            using (var reader = command.ExecuteReader())
            {
                if (propertyIndices == null)
                {
                    var fieldNames = Enumerable.Range(0, reader.FieldCount).Select(fieldIndex => reader.GetName(fieldIndex));
                    propertyIndices = entityBinder.GetPropertyIndices(fieldNames).ToArray();
                }

                rowNumber++;
                var entity = createEntity();

                // 各列を処理する。
                for (int fieldIndex = 0; fieldIndex < reader.FieldCount; fieldIndex++)
                {
                    try
                    {
                        int propIndex = propertyIndices[fieldIndex];
                        object value = reader.GetValue(fieldIndex);
                        if (DBNull.Value.Equals(value)) { value = null; }
                        entityBinder.SetValueTo(entity, propIndex, value);
                    }
                    catch (Exception e)
                    {
                        int colNumber = fieldIndex + 1;
                        string colName = reader.GetName(fieldIndex);
                        throw new EntityBinderException(string.Format("{0}行{1}列 {2}: エラーが発生しました。", rowNumber, colNumber, colName), e);
                    }
                }

                yield return entity;
            }
        }
    }
}
