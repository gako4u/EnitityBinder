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
    public class Tester_From_SInt32_To_Enum : Tester
    {
        private static readonly SInt32__ SInt32_Zero = 0;

        [TestCase] public void To_EnumSInt08_From_MinValue() { this.Test<SInt32__, EnumSInt08>(SInt32__.MinValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt08_From_Zero____() { this.Test<SInt32__, EnumSInt08>(SInt32_Zero       /**/, Expected.ErrorRaised          /**/, (EnumSInt08)(SInt08__)SInt32_Zero); }
        [TestCase] public void To_EnumSInt08_From_MaxValue() { this.Test<SInt32__, EnumSInt08>(SInt32__.MaxValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt08_From_MinValue() { this.Test<SInt32__, EnumUInt08>(SInt32__.MinValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt08_From_Zero____() { this.Test<SInt32__, EnumUInt08>(SInt32_Zero       /**/, Expected.ErrorRaised          /**/, (EnumUInt08)(UInt08__)SInt32_Zero); }
        [TestCase] public void To_EnumUInt08_From_MaxValue() { this.Test<SInt32__, EnumUInt08>(SInt32__.MaxValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt16_From_MinValue() { this.Test<SInt32__, EnumSInt16>(SInt32__.MinValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt16_From_Zero____() { this.Test<SInt32__, EnumSInt16>(SInt32_Zero       /**/, Expected.ErrorRaised          /**/, (EnumSInt16)(SInt16__)SInt32_Zero); }
        [TestCase] public void To_EnumSInt16_From_MaxValue() { this.Test<SInt32__, EnumSInt16>(SInt32__.MaxValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt16_From_MinValue() { this.Test<SInt32__, EnumUInt16>(SInt32__.MinValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt16_From_Zero____() { this.Test<SInt32__, EnumUInt16>(SInt32_Zero       /**/, Expected.ErrorRaised          /**/, (EnumUInt16)(UInt16__)SInt32_Zero); }
        [TestCase] public void To_EnumUInt16_From_MaxValue() { this.Test<SInt32__, EnumUInt16>(SInt32__.MaxValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt32_From_MinValue() { this.Test<SInt32__, EnumSInt32>(SInt32__.MinValue /**/, (EnumSInt32)SInt32__.MinValue /**/, (EnumSInt32)SInt32__.MinValue); }
        [TestCase] public void To_EnumSInt32_From_Zero____() { this.Test<SInt32__, EnumSInt32>(SInt32_Zero       /**/, (EnumSInt32)SInt32_Zero       /**/, (EnumSInt32)SInt32_Zero); }
        [TestCase] public void To_EnumSInt32_From_MaxValue() { this.Test<SInt32__, EnumSInt32>(SInt32__.MaxValue /**/, (EnumSInt32)SInt32__.MaxValue /**/, (EnumSInt32)SInt32__.MaxValue); }
        [TestCase] public void To_EnumUInt32_From_MinValue() { this.Test<SInt32__, EnumUInt32>(SInt32__.MinValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt32_From_Zero____() { this.Test<SInt32__, EnumUInt32>(SInt32_Zero       /**/, Expected.ErrorRaised          /**/, (EnumUInt32)(UInt32__)SInt32_Zero); }
        [TestCase] public void To_EnumUInt32_From_MaxValue() { this.Test<SInt32__, EnumUInt32>(SInt32__.MaxValue /**/, Expected.ErrorRaised          /**/, (EnumUInt32)(UInt32__)SInt32__.MaxValue); }
        [TestCase] public void To_EnumSInt64_From_MinValue() { this.Test<SInt32__, EnumSInt64>(SInt32__.MinValue /**/, (EnumSInt64)SInt32__.MinValue /**/, (EnumSInt64)(SInt64__)SInt32__.MinValue); }
        [TestCase] public void To_EnumSInt64_From_Zero____() { this.Test<SInt32__, EnumSInt64>(SInt32_Zero       /**/, (EnumSInt64)SInt32_Zero       /**/, (EnumSInt64)(SInt64__)SInt32_Zero); }
        [TestCase] public void To_EnumSInt64_From_MaxValue() { this.Test<SInt32__, EnumSInt64>(SInt32__.MaxValue /**/, (EnumSInt64)SInt32__.MaxValue /**/, (EnumSInt64)(SInt64__)SInt32__.MaxValue); }
        [TestCase] public void To_EnumUInt64_From_MinValue() { this.Test<SInt32__, EnumUInt64>(SInt32__.MinValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt64_From_Zero____() { this.Test<SInt32__, EnumUInt64>(SInt32_Zero       /**/, Expected.ErrorRaised          /**/, (EnumUInt64)(UInt64__)SInt32_Zero); }
        [TestCase] public void To_EnumUInt64_From_MaxValue() { this.Test<SInt32__, EnumUInt64>(SInt32__.MaxValue /**/, Expected.ErrorRaised          /**/, (EnumUInt64)(UInt64__)SInt32__.MaxValue); }
    }
}
