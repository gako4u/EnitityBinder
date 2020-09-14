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
    public class Tester_From_Decimal_To_Enum : Tester
    {
        [TestCase] public void To_EnumSInt08_From_MinValue() { this.Test<Decimal_, EnumSInt08>(Decimal_.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt08_From_Zero____() { this.Test<Decimal_, EnumSInt08>(Decimal_.Zero     /**/, Expected.ErrorRaised, (EnumSInt08)(SInt08__)Decimal_.Zero); }
        [TestCase] public void To_EnumSInt08_From_MaxValue() { this.Test<Decimal_, EnumSInt08>(Decimal_.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt08_From_MinValue() { this.Test<Decimal_, EnumUInt08>(Decimal_.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt08_From_Zero____() { this.Test<Decimal_, EnumUInt08>(Decimal_.Zero     /**/, Expected.ErrorRaised, (EnumUInt08)(UInt08__)Decimal_.Zero); }
        [TestCase] public void To_EnumUInt08_From_MaxValue() { this.Test<Decimal_, EnumUInt08>(Decimal_.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt16_From_MinValue() { this.Test<Decimal_, EnumSInt16>(Decimal_.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt16_From_Zero____() { this.Test<Decimal_, EnumSInt16>(Decimal_.Zero     /**/, Expected.ErrorRaised, (EnumSInt16)(SInt16__)Decimal_.Zero); }
        [TestCase] public void To_EnumSInt16_From_MaxValue() { this.Test<Decimal_, EnumSInt16>(Decimal_.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt16_From_MinValue() { this.Test<Decimal_, EnumUInt16>(Decimal_.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt16_From_Zero____() { this.Test<Decimal_, EnumUInt16>(Decimal_.Zero     /**/, Expected.ErrorRaised, (EnumUInt16)(UInt16__)Decimal_.Zero); }
        [TestCase] public void To_EnumUInt16_From_MaxValue() { this.Test<Decimal_, EnumUInt16>(Decimal_.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt32_From_MinValue() { this.Test<Decimal_, EnumSInt32>(Decimal_.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt32_From_Zero____() { this.Test<Decimal_, EnumSInt32>(Decimal_.Zero     /**/, Expected.ErrorRaised, (EnumSInt32)(SInt32__)Decimal_.Zero); }
        [TestCase] public void To_EnumSInt32_From_MaxValue() { this.Test<Decimal_, EnumSInt32>(Decimal_.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt32_From_MinValue() { this.Test<Decimal_, EnumUInt32>(Decimal_.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt32_From_Zero____() { this.Test<Decimal_, EnumUInt32>(Decimal_.Zero     /**/, Expected.ErrorRaised, (EnumUInt32)(UInt32__)Decimal_.Zero); }
        [TestCase] public void To_EnumUInt32_From_MaxValue() { this.Test<Decimal_, EnumUInt32>(Decimal_.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt64_From_MinValue() { this.Test<Decimal_, EnumSInt64>(Decimal_.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt64_From_Zero____() { this.Test<Decimal_, EnumSInt64>(Decimal_.Zero     /**/, Expected.ErrorRaised, (EnumSInt64)(SInt64__)Decimal_.Zero); }
        [TestCase] public void To_EnumSInt64_From_MaxValue() { this.Test<Decimal_, EnumSInt64>(Decimal_.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt64_From_MinValue() { this.Test<Decimal_, EnumUInt64>(Decimal_.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt64_From_Zero____() { this.Test<Decimal_, EnumUInt64>(Decimal_.Zero     /**/, Expected.ErrorRaised, (EnumUInt64)(UInt64__)Decimal_.Zero); }
        [TestCase] public void To_EnumUInt64_From_MaxValue() { this.Test<Decimal_, EnumUInt64>(Decimal_.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
    }
}
