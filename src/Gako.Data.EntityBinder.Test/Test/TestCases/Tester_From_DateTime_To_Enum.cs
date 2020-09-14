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
    public class Tester_From_DateTime_To_Enum : Tester
    {
        [TestCase] public void To_EnumSInt08_From_MinValue() { this.Test<DateTime, EnumSInt08>(DateTime.MinValue, Expected.ErrorRaised, (EnumSInt08)DateTime.MinValue.Ticks); }
        [TestCase] public void To_EnumSInt08_From_MaxValue() { this.Test<DateTime, EnumSInt08>(DateTime.MaxValue, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt08_From_MinValue() { this.Test<DateTime, EnumUInt08>(DateTime.MinValue, Expected.ErrorRaised, (EnumUInt08)DateTime.MinValue.Ticks); }
        [TestCase] public void To_EnumUInt08_From_MaxValue() { this.Test<DateTime, EnumUInt08>(DateTime.MaxValue, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt16_From_MinValue() { this.Test<DateTime, EnumSInt16>(DateTime.MinValue, Expected.ErrorRaised, (EnumSInt16)DateTime.MinValue.Ticks); }
        [TestCase] public void To_EnumSInt16_From_MaxValue() { this.Test<DateTime, EnumSInt16>(DateTime.MaxValue, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt16_From_MinValue() { this.Test<DateTime, EnumUInt16>(DateTime.MinValue, Expected.ErrorRaised, (EnumUInt16)DateTime.MinValue.Ticks); }
        [TestCase] public void To_EnumUInt16_From_MaxValue() { this.Test<DateTime, EnumUInt16>(DateTime.MaxValue, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt32_From_MinValue() { this.Test<DateTime, EnumSInt32>(DateTime.MinValue, Expected.ErrorRaised, (EnumSInt32)DateTime.MinValue.Ticks); }
        [TestCase] public void To_EnumSInt32_From_MaxValue() { this.Test<DateTime, EnumSInt32>(DateTime.MaxValue, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt32_From_MinValue() { this.Test<DateTime, EnumUInt32>(DateTime.MinValue, Expected.ErrorRaised, (EnumUInt32)DateTime.MinValue.Ticks); }
        [TestCase] public void To_EnumUInt32_From_MaxValue() { this.Test<DateTime, EnumUInt32>(DateTime.MaxValue, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt64_From_MinValue() { this.Test<DateTime, EnumSInt64>(DateTime.MinValue, Expected.ErrorRaised, (EnumSInt64)DateTime.MinValue.Ticks); }
        [TestCase] public void To_EnumSInt64_From_MaxValue() { this.Test<DateTime, EnumSInt64>(DateTime.MaxValue, Expected.ErrorRaised, (EnumSInt64)DateTime.MaxValue.Ticks); }
        [TestCase] public void To_EnumUInt64_From_MinValue() { this.Test<DateTime, EnumUInt64>(DateTime.MinValue, Expected.ErrorRaised, (EnumUInt64)DateTime.MinValue.Ticks); }
        [TestCase] public void To_EnumUInt64_From_MaxValue() { this.Test<DateTime, EnumUInt64>(DateTime.MaxValue, Expected.ErrorRaised, (EnumUInt64)DateTime.MaxValue.Ticks); }
    }
}
