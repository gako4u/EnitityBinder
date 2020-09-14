
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder
{
    /// <summary>
    /// フォーマットを指定して文字列に変換します。
    /// 参考:
    /// https://docs.microsoft.com/ja-jp/dotnet/api/system.string.format?view=netcore-3.1#remarks-top
    /// </summary>
    public class FormatAttribute : CustomConvertAttribute
    {
        public FormatAttribute(string formatString) : this(null, formatString)
        {
        }

        public FormatAttribute(int alignment, string formatString) : this((int?)alignment, formatString)
        {
        }

        private FormatAttribute(int? alignment, string formatString)
        {
            this.Alignment = alignment;
            this.FormatString = formatString;
            this.Format = this.CreateFormat(alignment, formatString);
        }

        public int? Alignment { get; }

        public string FormatString { get; }

        private string Format { get; }

        private string CreateFormat(int? alignment, string formatString)
        {
            string result =
                "{0"
                + (alignment == null ? string.Empty : "," + alignment.Value.ToString())
                + (string.IsNullOrWhiteSpace(formatString) ? string.Empty : ":" + formatString)
                + "}";

            return result;
        }

        public override object Convert(object value)
        {
            string result = string.Format(this.Format, value);
            return result;
        }
    }
}
