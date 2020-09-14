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
    public class Tester_From_SInt64_To_Enum : Tester
    {
        private static readonly SInt64__ SInt64___Zero = 0;

        [TestCase] public void To_EnumSInt08_From_MinValue() { this.Test<SInt64__, EnumSInt08>(SInt64__.MinValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt08_From_Zero____() { this.Test<SInt64__, EnumSInt08>(SInt64___Zero     /**/, Expected.ErrorRaised          /**/, (EnumSInt08)(SInt08__)SInt64___Zero); }
        [TestCase] public void To_EnumSInt08_From_MaxValue() { this.Test<SInt64__, EnumSInt08>(SInt64__.MaxValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt08_From_MinValue() { this.Test<SInt64__, EnumUInt08>(SInt64__.MinValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt08_From_Zero____() { this.Test<SInt64__, EnumUInt08>(SInt64___Zero     /**/, Expected.ErrorRaised          /**/, (EnumUInt08)(UInt08__)SInt64___Zero); }
        [TestCase] public void To_EnumUInt08_From_MaxValue() { this.Test<SInt64__, EnumUInt08>(SInt64__.MaxValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt16_From_MinValue() { this.Test<SInt64__, EnumSInt16>(SInt64__.MinValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt16_From_Zero____() { this.Test<SInt64__, EnumSInt16>(SInt64___Zero     /**/, Expected.ErrorRaised          /**/, (EnumSInt16)(SInt16__)SInt64___Zero); }
        [TestCase] public void To_EnumSInt16_From_MaxValue() { this.Test<SInt64__, EnumSInt16>(SInt64__.MaxValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt16_From_MinValue() { this.Test<SInt64__, EnumUInt16>(SInt64__.MinValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt16_From_Zero____() { this.Test<SInt64__, EnumUInt16>(SInt64___Zero     /**/, Expected.ErrorRaised          /**/, (EnumUInt16)(UInt16__)SInt64___Zero); }
        [TestCase] public void To_EnumUInt16_From_MaxValue() { this.Test<SInt64__, EnumUInt16>(SInt64__.MaxValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt32_From_MinValue() { this.Test<SInt64__, EnumSInt32>(SInt64__.MinValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt32_From_Zero____() { this.Test<SInt64__, EnumSInt32>(SInt64___Zero     /**/, Expected.ErrorRaised          /**/, (EnumSInt32)SInt64___Zero); }
        [TestCase] public void To_EnumSInt32_From_MaxValue() { this.Test<SInt64__, EnumSInt32>(SInt64__.MaxValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt32_From_MinValue() { this.Test<SInt64__, EnumUInt32>(SInt64__.MinValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt32_From_Zero____() { this.Test<SInt64__, EnumUInt32>(SInt64___Zero     /**/, Expected.ErrorRaised          /**/, (EnumUInt32)(UInt64__)SInt64___Zero); }
        [TestCase] public void To_EnumUInt32_From_MaxValue() { this.Test<SInt64__, EnumUInt32>(SInt64__.MaxValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt64_From_MinValue() { this.Test<SInt64__, EnumSInt64>(SInt64__.MinValue /**/, (EnumSInt64)SInt64__.MinValue /**/, (EnumSInt64)SInt64__.MinValue); }
        [TestCase] public void To_EnumSInt64_From_Zero____() { this.Test<SInt64__, EnumSInt64>(SInt64___Zero     /**/, (EnumSInt64)SInt64___Zero     /**/, (EnumSInt64)SInt64___Zero); }
        [TestCase] public void To_EnumSInt64_From_MaxValue() { this.Test<SInt64__, EnumSInt64>(SInt64__.MaxValue /**/, (EnumSInt64)SInt64__.MaxValue /**/, (EnumSInt64)SInt64__.MaxValue); }
        [TestCase] public void To_EnumUInt64_From_MinValue() { this.Test<SInt64__, EnumUInt64>(SInt64__.MinValue /**/, Expected.ErrorRaised          /**/, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt64_From_Zero____() { this.Test<SInt64__, EnumUInt64>(SInt64___Zero     /**/, Expected.ErrorRaised          /**/, (EnumUInt64)(UInt64__)SInt64___Zero); }
        [TestCase] public void To_EnumUInt64_From_MaxValue() { this.Test<SInt64__, EnumUInt64>(SInt64__.MaxValue /**/, Expected.ErrorRaised          /**/, (EnumUInt64)(UInt64__)SInt64__.MaxValue); }
    }
}
