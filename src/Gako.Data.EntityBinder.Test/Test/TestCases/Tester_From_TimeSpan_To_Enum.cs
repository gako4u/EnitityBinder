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
    public class Tester_From_TimeSpan_To_Enum : Tester
    {
        [TestCase] public void To_EnumSInt08_From_MinValue() { this.Test<TimeSpan, EnumSInt08>(TimeSpan.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt08_From_Zero____() { this.Test<TimeSpan, EnumSInt08>(TimeSpan.Zero     /**/, Expected.ErrorRaised, (EnumSInt08)SysConvert.ToUInt08__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_EnumSInt08_From_MaxValue() { this.Test<TimeSpan, EnumSInt08>(TimeSpan.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt08_From_MinValue() { this.Test<TimeSpan, EnumUInt08>(TimeSpan.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt08_From_Zero____() { this.Test<TimeSpan, EnumUInt08>(TimeSpan.Zero     /**/, Expected.ErrorRaised, (EnumUInt08)SysConvert.ToUInt08__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_EnumUInt08_From_MaxValue() { this.Test<TimeSpan, EnumUInt08>(TimeSpan.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt16_From_MinValue() { this.Test<TimeSpan, EnumSInt16>(TimeSpan.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt16_From_Zero____() { this.Test<TimeSpan, EnumSInt16>(TimeSpan.Zero     /**/, Expected.ErrorRaised, (EnumSInt16)SysConvert.ToUInt16__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_EnumSInt16_From_MaxValue() { this.Test<TimeSpan, EnumSInt16>(TimeSpan.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt16_From_MinValue() { this.Test<TimeSpan, EnumUInt16>(TimeSpan.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt16_From_Zero____() { this.Test<TimeSpan, EnumUInt16>(TimeSpan.Zero     /**/, Expected.ErrorRaised, (EnumUInt16)SysConvert.ToUInt16__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_EnumUInt16_From_MaxValue() { this.Test<TimeSpan, EnumUInt16>(TimeSpan.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt32_From_MinValue() { this.Test<TimeSpan, EnumSInt32>(TimeSpan.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt32_From_Zero____() { this.Test<TimeSpan, EnumSInt32>(TimeSpan.Zero     /**/, Expected.ErrorRaised, (EnumSInt32)SysConvert.ToUInt32__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_EnumSInt32_From_MaxValue() { this.Test<TimeSpan, EnumSInt32>(TimeSpan.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt32_From_MinValue() { this.Test<TimeSpan, EnumUInt32>(TimeSpan.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt32_From_Zero____() { this.Test<TimeSpan, EnumUInt32>(TimeSpan.Zero     /**/, Expected.ErrorRaised, (EnumUInt32)SysConvert.ToUInt32__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_EnumUInt32_From_MaxValue() { this.Test<TimeSpan, EnumUInt32>(TimeSpan.MaxValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt64_From_MinValue() { this.Test<TimeSpan, EnumSInt64>(TimeSpan.MinValue /**/, Expected.ErrorRaised, (EnumSInt64)SysConvert.ToSInt64__(TimeSpan.MinValue.Ticks)); }
        [TestCase] public void To_EnumSInt64_From_Zero____() { this.Test<TimeSpan, EnumSInt64>(TimeSpan.Zero     /**/, Expected.ErrorRaised, (EnumSInt64)SysConvert.ToUInt64__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_EnumSInt64_From_MaxValue() { this.Test<TimeSpan, EnumSInt64>(TimeSpan.MaxValue /**/, Expected.ErrorRaised, (EnumSInt64)SysConvert.ToSInt64__(TimeSpan.MaxValue.Ticks)); }
        [TestCase] public void To_EnumUInt64_From_MinValue() { this.Test<TimeSpan, EnumUInt64>(TimeSpan.MinValue /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt64_From_Zero____() { this.Test<TimeSpan, EnumUInt64>(TimeSpan.Zero     /**/, Expected.ErrorRaised, (EnumUInt64)SysConvert.ToUInt64__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_EnumUInt64_From_MaxValue() { this.Test<TimeSpan, EnumUInt64>(TimeSpan.MaxValue /**/, Expected.ErrorRaised, (EnumUInt64)SysConvert.ToUInt64__(TimeSpan.MaxValue.Ticks)); }
    }
}
