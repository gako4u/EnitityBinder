using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder
{
    /// <summary>
    /// インスタンスを作成する機能を提供します。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class InstanceCreator<T>
    {
        /// <summary>
        /// コンストラクター。
        /// </summary>
        static InstanceCreator()
        {
            var ctor = typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
            InstanceCreator<T>.Func = Expression.Lambda<Func<T>>(Expression.New(ctor)).Compile();
        }

        /// <summary>
        /// インスタンスを作成します。
        /// </summary>
        public static readonly Func<T> Func;

        /// <summary>
        /// インスタンスを作成します。
        /// </summary>
        public static T Create()
        {
            return InstanceCreator<T>.Func();
        }
    }
}
