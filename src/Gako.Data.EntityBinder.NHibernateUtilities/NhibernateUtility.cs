using NHibernate;
using NHibernate.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder.NHibernateUtilities
{
    /// <summary>
    /// </summary>
    public static partial class NhibernateUtility
    {
        /// <summary>
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        public static IList<TEntity> EntityList<TEntity>(this IQuery query) where TEntity : new()
        {
            query.SetResultTransformer(new EntityTransformer<TEntity>());
            var result = query.List<TEntity>();
            return result;
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        public static IList<TEntity> EntityList<TEntity>(this IQuery query, Func<TEntity> entityCreateor)
        {
            query.SetResultTransformer(new EntityTransformer<TEntity>(entityCreateor));
            var result = query.List<TEntity>();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="name"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static IQuery SetNullableBoolean(this IQuery query, string name, bool? val) => query.SetParameter(name, val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="name"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static IQuery SetNullableDateTime(this IQuery query, string name, DateTime? val) => query.SetParameter(name, val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="name"></param>
        /// <param name="val"></param>
        /// <returns></returns>

        public static IQuery SetNullableDecimal(this IQuery query, string name, decimal? val) => query.SetParameter(name, val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="name"></param>
        /// <param name="val"></param>
        /// <returns></returns>

        public static IQuery SetNullableDouble(this IQuery query, string name, double? val) => query.SetParameter(name, val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="name"></param>
        /// <param name="val"></param>
        /// <returns></returns>

        public static IQuery SetNullableEnum<T>(this IQuery query, string name, T? val) where T : struct, Enum => query.SetParameter(name, val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="name"></param>
        /// <param name="val"></param>
        /// <returns></returns>

        public static IQuery SetNullableInt16(this IQuery query, string name, short? val) => query.SetParameter(name, val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="name"></param>
        /// <param name="val"></param>
        /// <returns></returns>

        public static IQuery SetNullableInt32(this IQuery query, string name, int? val) => query.SetParameter(name, val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="name"></param>
        /// <param name="val"></param>
        /// <returns></returns>

        public static IQuery SetNullableInt64(this IQuery query, string name, long? val) => query.SetParameter(name, val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="name"></param>
        /// <param name="val"></param>
        /// <returns></returns>

        public static IQuery SetNullableSingle(this IQuery query, string name, float? val) => query.SetParameter(name, val);
    }
}
