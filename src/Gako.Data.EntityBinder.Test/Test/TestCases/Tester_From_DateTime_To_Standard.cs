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
    public class Tester_From_DateTime_To_Standard : Tester
    {
        [TestCase] public void To_Object___From_MinValue() { this.Test<DateTime, Object__>(DateTime.MinValue, DateTime.MinValue   /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From_MaxValue() { this.Test<DateTime, Object__>(DateTime.MaxValue, DateTime.MaxValue   /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From_MinValue() { this.Test<DateTime, SInt08__>(DateTime.MinValue, Expected.ErrorRaised/**/, (SInt08__)DateTime.MinValue.Ticks); }
        [TestCase] public void To_SInt08___From_MaxValue() { this.Test<DateTime, SInt08__>(DateTime.MaxValue, Expected.ErrorRaised/**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From_MinValue() { this.Test<DateTime, UInt08__>(DateTime.MinValue, Expected.ErrorRaised/**/, (UInt08__)DateTime.MinValue.Ticks); }
        [TestCase] public void To_UInt08___From_MaxValue() { this.Test<DateTime, UInt08__>(DateTime.MaxValue, Expected.ErrorRaised/**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From_MinValue() { this.Test<DateTime, SInt16__>(DateTime.MinValue, Expected.ErrorRaised/**/, (SInt16__)DateTime.MinValue.Ticks); }
        [TestCase] public void To_SInt16___From_MaxValue() { this.Test<DateTime, SInt16__>(DateTime.MaxValue, Expected.ErrorRaised/**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From_MinValue() { this.Test<DateTime, UInt16__>(DateTime.MinValue, Expected.ErrorRaised/**/, (UInt16__)DateTime.MinValue.Ticks); }
        [TestCase] public void To_UInt16___From_MaxValue() { this.Test<DateTime, UInt16__>(DateTime.MaxValue, Expected.ErrorRaised/**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From_MinValue() { this.Test<DateTime, SInt32__>(DateTime.MinValue, Expected.ErrorRaised/**/, (SInt32__)DateTime.MinValue.Ticks); }
        [TestCase] public void To_SInt32___From_MaxValue() { this.Test<DateTime, SInt32__>(DateTime.MaxValue, Expected.ErrorRaised/**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From_MinValue() { this.Test<DateTime, UInt32__>(DateTime.MinValue, Expected.ErrorRaised/**/, (UInt32__)DateTime.MinValue.Ticks); }
        [TestCase] public void To_UInt32___From_MaxValue() { this.Test<DateTime, UInt32__>(DateTime.MaxValue, Expected.ErrorRaised/**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt64___From_MinValue() { this.Test<DateTime, SInt64__>(DateTime.MinValue, Expected.ErrorRaised/**/, (SInt64__)DateTime.MinValue.Ticks); }
        [TestCase] public void To_SInt64___From_MaxValue() { this.Test<DateTime, SInt64__>(DateTime.MaxValue, Expected.ErrorRaised/**/, (SInt64__)DateTime.MaxValue.Ticks); }
        [TestCase] public void To_UInt64___From_MinValue() { this.Test<DateTime, UInt64__>(DateTime.MinValue, Expected.ErrorRaised/**/, (UInt64__)DateTime.MinValue.Ticks); }
        [TestCase] public void To_UInt64___From_MaxValue() { this.Test<DateTime, UInt64__>(DateTime.MaxValue, Expected.ErrorRaised/**/, (UInt64__)DateTime.MaxValue.Ticks); }
        [TestCase] public void To_Single___From_MinValue() { this.Test<DateTime, Single__>(DateTime.MinValue, Expected.ErrorRaised/**/, (Single__)DateTime.MinValue.Ticks); }
        [TestCase] public void To_Single___From_MaxValue() { this.Test<DateTime, Single__>(DateTime.MaxValue, Expected.ErrorRaised/**/, (Single__)DateTime.MaxValue.Ticks); }
        [TestCase] public void To_Double___From_MinValue() { this.Test<DateTime, Double__>(DateTime.MinValue, Expected.ErrorRaised/**/, (Double__)DateTime.MinValue.Ticks); }
        [TestCase] public void To_Double___From_MaxValue() { this.Test<DateTime, Double__>(DateTime.MaxValue, Expected.ErrorRaised/**/, (Double__)DateTime.MaxValue.Ticks); }
        [TestCase] public void To_Decimal__From_MinValue() { this.Test<DateTime, Decimal_>(DateTime.MinValue, Expected.ErrorRaised/**/, (Decimal_)DateTime.MinValue.Ticks); }
        [TestCase] public void To_Decimal__From_MaxValue() { this.Test<DateTime, Decimal_>(DateTime.MaxValue, Expected.ErrorRaised/**/, (Decimal_)DateTime.MaxValue.Ticks); }
        [TestCase] public void To_Boolean__From_MinValue() { this.Test<DateTime, Boolean_>(DateTime.MinValue, Expected.ErrorRaised/**/, Expected.ErrorRaised); }
        [TestCase] public void To_Boolean__From_MaxValue() { this.Test<DateTime, Boolean_>(DateTime.MaxValue, Expected.ErrorRaised/**/, Expected.ErrorRaised); }
        [TestCase] public void To_DateTime_From_MinValue() { this.Test<DateTime, DateTime>(DateTime.MinValue, DateTime.MinValue   /**/, DateTime.MinValue); }
        [TestCase] public void To_DateTime_From_MaxValue() { this.Test<DateTime, DateTime>(DateTime.MaxValue, DateTime.MaxValue   /**/, DateTime.MaxValue); }
        [TestCase] public void To_TimeSpan_From_MinValue() { this.Test<DateTime, TimeSpan>(DateTime.MinValue, Expected.ErrorRaised/**/, new TimeSpan(DateTime.MinValue.Ticks)); }
        [TestCase] public void To_TimeSpan_From_MaxValue() { this.Test<DateTime, TimeSpan>(DateTime.MaxValue, Expected.ErrorRaised/**/, new TimeSpan(DateTime.MaxValue.Ticks)); }
        [TestCase] public void To_String___From_MinValue() { this.Test<DateTime, String__>(DateTime.MinValue, Expected.ErrorRaised/**/, DateTime.MinValue.ToString()); }
        [TestCase] public void To_String___From_MaxValue() { this.Test<DateTime, String__>(DateTime.MaxValue, Expected.ErrorRaised/**/, DateTime.MaxValue.ToString()); }
    }
}
