using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Anything.Test;
using Test.Anything.Test.Enums;

namespace NHibernateUtility.Test
{
    public class Tester_From_String_To_Enum : Tester
    {
        private static readonly string String_Hello = "Hello, World!";

        private static readonly string String__Zero = "0";

        [TestCase] public void To_EnumSInt08_From_MinValue() { this.Test<string, EnumSInt08>(String_Hello /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt08_From_Zero____() { this.Test<string, EnumSInt08>(String__Zero /**/, Expected.ErrorRaised /**/, (EnumSInt08)SysConvert.ToSInt08__(String__Zero)); }
        [TestCase] public void To_EnumUInt08_From_MinValue() { this.Test<string, EnumUInt08>(String_Hello /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt08_From_Zero____() { this.Test<string, EnumUInt08>(String__Zero /**/, Expected.ErrorRaised /**/, (EnumUInt08)SysConvert.ToUInt08__(String__Zero)); }
        [TestCase] public void To_EnumSInt16_From_MinValue() { this.Test<string, EnumSInt16>(String_Hello /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt16_From_Zero____() { this.Test<string, EnumSInt16>(String__Zero /**/, Expected.ErrorRaised /**/, (EnumSInt16)SysConvert.ToSInt16__(String__Zero)); }
        [TestCase] public void To_EnumUInt16_From_MinValue() { this.Test<string, EnumUInt16>(String_Hello /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt16_From_Zero____() { this.Test<string, EnumUInt16>(String__Zero /**/, Expected.ErrorRaised /**/, (EnumUInt16)SysConvert.ToUInt16__(String__Zero)); }
        [TestCase] public void To_EnumSInt32_From_MinValue() { this.Test<string, EnumSInt32>(String_Hello /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt32_From_Zero____() { this.Test<string, EnumSInt32>(String__Zero /**/, Expected.ErrorRaised /**/, (EnumSInt32)SysConvert.ToSInt32__(String__Zero)); }
        [TestCase] public void To_EnumUInt32_From_MinValue() { this.Test<string, EnumUInt32>(String_Hello /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt32_From_Zero____() { this.Test<string, EnumUInt32>(String__Zero /**/, Expected.ErrorRaised /**/, (EnumUInt32)SysConvert.ToUInt32__(String__Zero)); }
        [TestCase] public void To_EnumSInt64_From_MinValue() { this.Test<string, EnumSInt64>(String_Hello /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt64_From_Zero____() { this.Test<string, EnumSInt64>(String__Zero /**/, Expected.ErrorRaised /**/, (EnumSInt64)SysConvert.ToSInt64__(String__Zero)); }
        [TestCase] public void To_EnumUInt64_From_MinValue() { this.Test<string, EnumUInt64>(String_Hello /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt64_From_Zero____() { this.Test<string, EnumUInt64>(String__Zero /**/, Expected.ErrorRaised /**/, (EnumUInt64)SysConvert.ToUInt64__(String__Zero)); }
    }
}
