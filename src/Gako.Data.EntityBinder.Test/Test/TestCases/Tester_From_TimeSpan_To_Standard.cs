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
    public class Tester_From_TimeSpan_To_Standard : Tester
    {
        [TestCase] public void To_Object___From_MinValue() { this.Test<TimeSpan, Object__>(TimeSpan.MinValue /**/, TimeSpan.MinValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From_Zero____() { this.Test<TimeSpan, Object__>(TimeSpan.Zero     /**/, TimeSpan.Zero        /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From_MaxValue() { this.Test<TimeSpan, Object__>(TimeSpan.MaxValue /**/, TimeSpan.MaxValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From_MinValue() { this.Test<TimeSpan, SInt08__>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From_Zero____() { this.Test<TimeSpan, SInt08__>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, SysConvert.ToSInt08__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_SInt08___From_MaxValue() { this.Test<TimeSpan, SInt08__>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From_MinValue() { this.Test<TimeSpan, UInt08__>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From_Zero____() { this.Test<TimeSpan, UInt08__>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, SysConvert.ToUInt08__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_UInt08___From_MaxValue() { this.Test<TimeSpan, UInt08__>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From_MinValue() { this.Test<TimeSpan, SInt16__>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From_Zero____() { this.Test<TimeSpan, SInt16__>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, SysConvert.ToSInt16__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_SInt16___From_MaxValue() { this.Test<TimeSpan, SInt16__>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From_MinValue() { this.Test<TimeSpan, UInt16__>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From_Zero____() { this.Test<TimeSpan, UInt16__>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, SysConvert.ToUInt16__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_UInt16___From_MaxValue() { this.Test<TimeSpan, UInt16__>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From_MinValue() { this.Test<TimeSpan, SInt32__>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From_Zero____() { this.Test<TimeSpan, SInt32__>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, SysConvert.ToSInt32__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_SInt32___From_MaxValue() { this.Test<TimeSpan, SInt32__>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From_MinValue() { this.Test<TimeSpan, UInt32__>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From_Zero____() { this.Test<TimeSpan, UInt32__>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, SysConvert.ToUInt32__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_UInt32___From_MaxValue() { this.Test<TimeSpan, UInt32__>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt64___From_MinValue() { this.Test<TimeSpan, SInt64__>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, SysConvert.ToSInt64__(TimeSpan.MinValue.Ticks)); }
        [TestCase] public void To_SInt64___From_Zero____() { this.Test<TimeSpan, SInt64__>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, SysConvert.ToSInt64__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_SInt64___From_MaxValue() { this.Test<TimeSpan, SInt64__>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, SysConvert.ToSInt64__(TimeSpan.MaxValue.Ticks)); }
        [TestCase] public void To_UInt64___From_MinValue() { this.Test<TimeSpan, UInt64__>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt64___From_Zero____() { this.Test<TimeSpan, UInt64__>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, SysConvert.ToUInt64__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_UInt64___From_MaxValue() { this.Test<TimeSpan, UInt64__>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, SysConvert.ToUInt64__(TimeSpan.MaxValue.Ticks)); }
        [TestCase] public void To_Single___From_MinValue() { this.Test<TimeSpan, Single__>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, SysConvert.ToSingle__(TimeSpan.MinValue.Ticks)); }
        [TestCase] public void To_Single___From_Zero____() { this.Test<TimeSpan, Single__>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, SysConvert.ToSingle__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_Single___From_MaxValue() { this.Test<TimeSpan, Single__>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, SysConvert.ToSingle__(TimeSpan.MaxValue.Ticks)); }
        [TestCase] public void To_Double___From_MinValue() { this.Test<TimeSpan, Double__>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, SysConvert.ToDouble__(TimeSpan.MinValue.Ticks)); }
        [TestCase] public void To_Double___From_Zero____() { this.Test<TimeSpan, Double__>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, SysConvert.ToDouble__(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_Double___From_MaxValue() { this.Test<TimeSpan, Double__>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, SysConvert.ToDouble__(TimeSpan.MaxValue.Ticks)); }
        [TestCase] public void To_Decimal__From_MinValue() { this.Test<TimeSpan, Decimal_>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, SysConvert.ToDecimal_(TimeSpan.MinValue.Ticks)); }
        [TestCase] public void To_Decimal__From_Zero____() { this.Test<TimeSpan, Decimal_>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, SysConvert.ToDecimal_(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_Decimal__From_MaxValue() { this.Test<TimeSpan, Decimal_>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, SysConvert.ToDecimal_(TimeSpan.MaxValue.Ticks)); }
        [TestCase] public void To_Boolean__From_MinValue() { this.Test<TimeSpan, Boolean_>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Boolean__From_Zero____() { this.Test<TimeSpan, Boolean_>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Boolean__From_MaxValue() { this.Test<TimeSpan, Boolean_>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_DateTime_From_MinValue() { this.Test<TimeSpan, DateTime>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_DateTime_From_Zero____() { this.Test<TimeSpan, DateTime>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, new DateTime(TimeSpan.Zero.Ticks)); }
        [TestCase] public void To_DateTime_From_MaxValue() { this.Test<TimeSpan, DateTime>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_TimeSpan_From_MinValue() { this.Test<TimeSpan, TimeSpan>(TimeSpan.MinValue /**/, TimeSpan.MinValue    /**/, TimeSpan.MinValue); }
        [TestCase] public void To_TimeSpan_From_Zero____() { this.Test<TimeSpan, TimeSpan>(TimeSpan.Zero     /**/, TimeSpan.Zero        /**/, TimeSpan.Zero); }
        [TestCase] public void To_TimeSpan_From_MaxValue() { this.Test<TimeSpan, TimeSpan>(TimeSpan.MaxValue /**/, TimeSpan.MaxValue    /**/, TimeSpan.MaxValue); }
        [TestCase] public void To_String___From_MinValue() { this.Test<TimeSpan, String__>(TimeSpan.MinValue /**/, Expected.ErrorRaised /**/, TimeSpan.MinValue.ToString()); }
        [TestCase] public void To_String___From_Zero____() { this.Test<TimeSpan, String__>(TimeSpan.Zero     /**/, Expected.ErrorRaised /**/, TimeSpan.Zero.ToString()); }
        [TestCase] public void To_String___From_MaxValue() { this.Test<TimeSpan, String__>(TimeSpan.MaxValue /**/, Expected.ErrorRaised /**/, TimeSpan.MaxValue.ToString()); }
    }
}
