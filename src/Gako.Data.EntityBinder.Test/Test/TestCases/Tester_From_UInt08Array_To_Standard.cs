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
    public class Tester_From_UInt08Array_To_Standard : Tester
    {
        private static readonly byte[] EmptyByteArray = new byte[0];

        private static readonly string HelloString = "Hello, World";

        private static readonly byte[] HelloByteArray = Encoding.Unicode.GetBytes(HelloString);

        [TestCase] public void To_Object___From_EmptyArray() { this.Test<UInt08__[], Object__>(EmptyByteArray /**/, EmptyByteArray       /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From_EmptyArray() { this.Test<UInt08__[], SInt08__>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From_EmptyArray() { this.Test<UInt08__[], UInt08__>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From_EmptyArray() { this.Test<UInt08__[], SInt16__>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From_EmptyArray() { this.Test<UInt08__[], UInt16__>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From_EmptyArray() { this.Test<UInt08__[], SInt32__>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From_EmptyArray() { this.Test<UInt08__[], UInt32__>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt64___From_EmptyArray() { this.Test<UInt08__[], SInt64__>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt64___From_EmptyArray() { this.Test<UInt08__[], UInt64__>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Single___From_EmptyArray() { this.Test<UInt08__[], Single__>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Double___From_EmptyArray() { this.Test<UInt08__[], Double__>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Decimal__From_EmptyArray() { this.Test<UInt08__[], Decimal_>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Boolean__From_EmptyArray() { this.Test<UInt08__[], Boolean_>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_DateTime_From_EmptyArray() { this.Test<UInt08__[], DateTime>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_TimeSpan_From_EmptyArray() { this.Test<UInt08__[], TimeSpan>(EmptyByteArray /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_String___From_EmptyArray() { this.Test<UInt08__[], String__>(EmptyByteArray /**/, Expected.ErrorRaised /**/, string.Empty); }
        [TestCase] public void To_String___From___MaxValue() { this.Test<UInt08__[], String__>(HelloByteArray /**/, Expected.ErrorRaised /**/, HelloString); }
    }
}
