using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Anything.Test;
using Test.Anything.Test.Enums;
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
    public class Tester_From_Double_To_Enum : Tester
    {
        private static readonly Double__ Double_Zero = 0;

        [TestCase] public void To_EnumSInt08_From_MinValue() { this.Test<Double__, EnumSInt08>(Double__.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt08_From_Zero____() { this.Test<Double__, EnumSInt08>(Double_Zero       /**/, Expected.ErrorRaised, (EnumSInt08)(SInt08__)Double_Zero); }
        [TestCase] public void To_EnumSInt08_From_MaxValue() { this.Test<Double__, EnumSInt08>(Double__.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt08_From_MinValue() { this.Test<Double__, EnumUInt08>(Double__.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt08_From_Zero____() { this.Test<Double__, EnumUInt08>(Double_Zero       /**/, Expected.ErrorRaised, (EnumUInt08)(UInt08__)Double_Zero); }
        [TestCase] public void To_EnumUInt08_From_MaxValue() { this.Test<Double__, EnumUInt08>(Double__.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt16_From_MinValue() { this.Test<Double__, EnumSInt16>(Double__.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt16_From_Zero____() { this.Test<Double__, EnumSInt16>(Double_Zero       /**/, Expected.ErrorRaised, (EnumSInt16)(SInt16__)Double_Zero); }
        [TestCase] public void To_EnumSInt16_From_MaxValue() { this.Test<Double__, EnumSInt16>(Double__.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt16_From_MinValue() { this.Test<Double__, EnumUInt16>(Double__.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt16_From_Zero____() { this.Test<Double__, EnumUInt16>(Double_Zero       /**/, Expected.ErrorRaised, (EnumUInt16)(UInt16__)Double_Zero); }
        [TestCase] public void To_EnumUInt16_From_MaxValue() { this.Test<Double__, EnumUInt16>(Double__.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt32_From_MinValue() { this.Test<Double__, EnumSInt32>(Double__.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt32_From_Zero____() { this.Test<Double__, EnumSInt32>(Double_Zero       /**/, Expected.ErrorRaised, (EnumSInt32)(SInt32__)Double_Zero); }
        [TestCase] public void To_EnumSInt32_From_MaxValue() { this.Test<Double__, EnumSInt32>(Double__.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt32_From_MinValue() { this.Test<Double__, EnumUInt32>(Double__.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt32_From_Zero____() { this.Test<Double__, EnumUInt32>(Double_Zero       /**/, Expected.ErrorRaised, (EnumUInt32)(UInt32__)Double_Zero); }
        [TestCase] public void To_EnumUInt32_From_MaxValue() { this.Test<Double__, EnumUInt32>(Double__.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt64_From_MinValue() { this.Test<Double__, EnumSInt64>(Double__.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt64_From_Zero____() { this.Test<Double__, EnumSInt64>(Double_Zero       /**/, Expected.ErrorRaised, (EnumSInt64)(SInt64__)Double_Zero); }
        [TestCase] public void To_EnumSInt64_From_MaxValue() { this.Test<Double__, EnumSInt64>(Double__.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt64_From_MinValue() { this.Test<Double__, EnumUInt64>(Double__.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt64_From_Zero____() { this.Test<Double__, EnumUInt64>(Double_Zero       /**/, Expected.ErrorRaised, (EnumUInt64)(UInt64__)Double_Zero); }
        [TestCase] public void To_EnumUInt64_From_MaxValue() { this.Test<Double__, EnumUInt64>(Double__.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
    }
}
