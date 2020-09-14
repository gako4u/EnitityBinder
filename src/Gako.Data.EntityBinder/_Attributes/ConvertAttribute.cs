using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder
{
    /// <summary>
    /// 値を設定する前の変換方法を指定します。
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class ConvertAttribute : Attribute
    {
        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="behavior"></param>
        public ConvertAttribute(ConvertBehavior behavior)
        {
            this.Behavior = behavior;
        }

        internal ConvertBehavior Behavior { get; }

        private static readonly ConvertAttribute Default = new ConvertAttribute(ConvertBehavior.Cast);

        internal static ConvertAttribute GetOrDefault(PropertyInfo info)
        {
            var attrs = info.GetCustomAttributes<ConvertAttribute>(true);
            return attrs.FirstOrDefault() ?? ConvertAttribute.Default;
        }
    }
}
