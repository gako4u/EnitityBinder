using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder
{
    /// <summary>
    /// 指定したエンコーディングでデコードします。
    /// </summary>
    public class DecodeAttribute : CustomConvertAttribute
    {
        /// <summary>
        /// 指定したエンコーディングを使って文字列に変換します。
        /// </summary>
        /// <param name="codePage"></param>
        public DecodeAttribute(CodePage codePage) : this((int)codePage)
        {
        }

        /// <summary>
        /// 指定したエンコーディングを使って文字列に変換します。
        /// </summary>
        /// <param name="codePage"></param>
        public DecodeAttribute(int codePage)
        {
            this.Encoding = Encoding.GetEncoding(codePage);
        }

        public Encoding Encoding { get; }

        public override object Convert(object value) =>
            value == null
                ? null
                : this.Encoding.GetString((byte[])value);
    }
}
