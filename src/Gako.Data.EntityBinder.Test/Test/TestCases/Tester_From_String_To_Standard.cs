using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Anything.Test;
using Object__ = System.Object;
using SInt08__ = System.SByte;
using UInt08__ = System.Byte;
using SInt16__ = System.Int16;
using UInt16__ = System.UInt16;
using SInt32__ = System.Int32;
using UInt32__ = System.UInt32;
using SInt64__ = System.Int64;
using UInt64__ = System.UInt64;
using Single__ = System.Single;
using Double__ = System.Double;
using Decimal_ = System.Decimal;
using Boolean_ = System.Boolean;
using String__ = System.String;

namespace NHibernateUtility.Test
{
    public class Tester_From_String_To_Standard : Tester
    {
        private static readonly String__ String_Hello = "Hello, World!";

        private static readonly String__ String__Zero = "0";

        private static readonly String__ String__true = "true";

        private static readonly String__ String__Date = "2020-12-31";

        [TestCase] public void To_Object___From_Zero__() { this.Test<String__, Object__>(String__Zero, String__Zero         /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From_Hello_() { this.Test<String__, Object__>(String_Hello, String_Hello         /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From_Zero__() { this.Test<String__, SInt08__>(String__Zero, Expected.ErrorRaised /**/, SInt08__.Parse(String__Zero)); }
        [TestCase] public void To_SInt08___From_Hello_() { this.Test<String__, SInt08__>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From_Zero__() { this.Test<String__, UInt08__>(String__Zero, Expected.ErrorRaised /**/, UInt08__.Parse(String__Zero)); }
        [TestCase] public void To_UInt08___From_Hello_() { this.Test<String__, UInt08__>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From_Zero__() { this.Test<String__, SInt16__>(String__Zero, Expected.ErrorRaised /**/, SInt16__.Parse(String__Zero)); }
        [TestCase] public void To_SInt16___From_Hello_() { this.Test<String__, SInt16__>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From_Zero__() { this.Test<String__, UInt16__>(String__Zero, Expected.ErrorRaised /**/, UInt16__.Parse(String__Zero)); }
        [TestCase] public void To_UInt16___From_Hello_() { this.Test<String__, UInt16__>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From_Zero__() { this.Test<String__, SInt32__>(String__Zero, Expected.ErrorRaised /**/, SInt32__.Parse(String__Zero)); }
        [TestCase] public void To_SInt32___From_Hello_() { this.Test<String__, SInt32__>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From_Zero__() { this.Test<String__, UInt32__>(String__Zero, Expected.ErrorRaised /**/, UInt32__.Parse(String__Zero)); }
        [TestCase] public void To_UInt32___From_Hello_() { this.Test<String__, UInt32__>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt64___From_Zero__() { this.Test<String__, SInt64__>(String__Zero, Expected.ErrorRaised /**/, SInt64__.Parse(String__Zero)); }
        [TestCase] public void To_SInt64___From_Hello_() { this.Test<String__, SInt64__>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt64___From_Zero__() { this.Test<String__, UInt64__>(String__Zero, Expected.ErrorRaised /**/, UInt64__.Parse(String__Zero)); }
        [TestCase] public void To_UInt64___From_Hello_() { this.Test<String__, UInt64__>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Single___From_Zero__() { this.Test<String__, Single__>(String__Zero, Expected.ErrorRaised /**/, Single__.Parse(String__Zero)); }
        [TestCase] public void To_Single___From_Hello_() { this.Test<String__, Single__>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Double___From_Zero__() { this.Test<String__, Double__>(String__Zero, Expected.ErrorRaised /**/, Double__.Parse(String__Zero)); }
        [TestCase] public void To_Double___From_Hello_() { this.Test<String__, Double__>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Decimal__From_Zero__() { this.Test<String__, Decimal_>(String__Zero, Expected.ErrorRaised /**/, Decimal_.Parse(String__Zero)); }
        [TestCase] public void To_Decimal__From_Hello_() { this.Test<String__, Decimal_>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Boolean__From_true__() { this.Test<String__, Boolean_>(String__true, Expected.ErrorRaised /**/, Boolean_.Parse(String__true)); }
        [TestCase] public void To_Boolean__From_Hello_() { this.Test<String__, Boolean_>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_DateTime_From_Date__() { this.Test<String__, DateTime>(String__Date, Expected.ErrorRaised /**/, DateTime.Parse(String__Date)); }
        [TestCase] public void To_DateTime_From_Hello_() { this.Test<String__, DateTime>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_TimeSpan_From_Zero__() { this.Test<String__, TimeSpan>(String__Zero, Expected.ErrorRaised /**/, TimeSpan.Parse(String__Zero)); }
        [TestCase] public void To_TimeSpan_From_Hello_() { this.Test<String__, TimeSpan>(String_Hello, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_String___From_Zero__() { this.Test<String__, String__>(String__Zero, String__Zero         /**/, String__Zero); }
        [TestCase] public void To_String___From_Hello_() { this.Test<String__, String__>(String_Hello, String_Hello         /**/, String_Hello); }
    }
}
