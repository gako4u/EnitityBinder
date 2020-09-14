using System;
using System.Reflection;

namespace Gako.Data.EntityBinder
{
    /// <summary>
    /// 値を設定する前に行う任意の変換処理を実装するための基本クラスです。
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public abstract class CustomConvertAttribute : Attribute
    {
        /// <summary>
        /// 指定された値をプロパティの型に変換します。
        /// </summary>
        /// <param name="value">変換する値。</param>
        /// <returns>プロパティの型に変換された値。</returns>
        public abstract object Convert(object value);

        internal static CustomConvertAttribute GetOrNull(PropertyInfo propInfo)
        {
            return propInfo.GetCustomAttribute<CustomConvertAttribute>();
        }
    }
}
