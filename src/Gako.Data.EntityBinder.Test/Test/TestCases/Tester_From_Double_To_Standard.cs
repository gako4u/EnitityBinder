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
    public class Tester_From_Double_To_Standard : Tester
    {
        private static readonly Double__ Double___Zero = 0;

        [TestCase] public void To_Object___From_Min___() { this.Test<Double__, Object__>(Double__.MinValue /**/, Double__.MinValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From__Zero_() { this.Test<Double__, Object__>(Double___Zero     /**/, Double___Zero        /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From___Max_() { this.Test<Double__, Object__>(Double__.MaxValue /**/, Double__.MaxValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From_Min___() { this.Test<Double__, SInt08__>(Double__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From__Zero_() { this.Test<Double__, SInt08__>(Double___Zero     /**/, Expected.ErrorRaised /**/, (SInt08__)Double___Zero); }
        [TestCase] public void To_SInt08___From___Max_() { this.Test<Double__, SInt08__>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From_Min___() { this.Test<Double__, UInt08__>(Double__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From__Zero_() { this.Test<Double__, UInt08__>(Double___Zero     /**/, Expected.ErrorRaised /**/, (UInt08__)Double___Zero); }
        [TestCase] public void To_UInt08___From___Max_() { this.Test<Double__, UInt08__>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From_Min___() { this.Test<Double__, SInt16__>(Double__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From__Zero_() { this.Test<Double__, SInt16__>(Double___Zero     /**/, Expected.ErrorRaised /**/, (SInt16__)Double___Zero); }
        [TestCase] public void To_SInt16___From___Max_() { this.Test<Double__, SInt16__>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From_Min___() { this.Test<Double__, UInt16__>(Double__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From__Zero_() { this.Test<Double__, UInt16__>(Double___Zero     /**/, Expected.ErrorRaised /**/, (UInt16__)Double___Zero); }
        [TestCase] public void To_UInt16___From___Max_() { this.Test<Double__, UInt16__>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From_Min___() { this.Test<Double__, SInt32__>(Double__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From__Zero_() { this.Test<Double__, SInt32__>(Double___Zero     /**/, Expected.ErrorRaised /**/, (SInt32__)Double___Zero); }
        [TestCase] public void To_SInt32___From___Max_() { this.Test<Double__, SInt32__>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From_Min___() { this.Test<Double__, UInt32__>(Double__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From__Zero_() { this.Test<Double__, UInt32__>(Double___Zero     /**/, Expected.ErrorRaised /**/, (UInt32__)Double___Zero); }
        [TestCase] public void To_UInt32___From___Max_() { this.Test<Double__, UInt32__>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt64___From_Min___() { this.Test<Double__, SInt64__>(Double__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt64___From__Zero_() { this.Test<Double__, SInt64__>(Double___Zero     /**/, Expected.ErrorRaised /**/, (SInt64__)Double___Zero); }
        [TestCase] public void To_SInt64___From___Max_() { this.Test<Double__, SInt64__>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt64___From_Min___() { this.Test<Double__, UInt64__>(Double__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt64___From__Zero_() { this.Test<Double__, UInt64__>(Double___Zero     /**/, Expected.ErrorRaised /**/, (UInt64__)Double___Zero); }
        [TestCase] public void To_UInt64___From___Max_() { this.Test<Double__, UInt64__>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Single___From_Min___() { this.Test<Double__, Single__>(Double__.MinValue /**/, Expected.ErrorRaised /**/, (Single__)Double__.MinValue); }
        [TestCase] public void To_Single___From__Zero_() { this.Test<Double__, Single__>(Double___Zero     /**/, Expected.ErrorRaised /**/, (Single__)Double___Zero); }
        [TestCase] public void To_Single___From___Max_() { this.Test<Double__, Single__>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, (Single__)Double__.MaxValue); }
        [TestCase] public void To_Double___From_Min___() { this.Test<Double__, Double__>(Double__.MinValue /**/, Double__.MinValue    /**/, Double__.MinValue); }
        [TestCase] public void To_Double___From__Zero_() { this.Test<Double__, Double__>(Double___Zero     /**/, Double___Zero        /**/, Double___Zero); }
        [TestCase] public void To_Double___From___Max_() { this.Test<Double__, Double__>(Double__.MaxValue /**/, Double__.MaxValue    /**/, Double__.MaxValue); }
        [TestCase] public void To_Decimal__From_Min___() { this.Test<Double__, Decimal_>(Double__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Decimal__From__Zero_() { this.Test<Double__, Decimal_>(Double___Zero     /**/, Expected.ErrorRaised /**/, (Decimal_)Double___Zero); }
        [TestCase] public void To_Decimal__From___Max_() { this.Test<Double__, Decimal_>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Boolean__From_Min___() { this.Test<Double__, Boolean_>(Double__.MinValue /**/, Expected.ErrorRaised /**/, true); }
        [TestCase] public void To_Boolean__From__Zero_() { this.Test<Double__, Boolean_>(Double___Zero     /**/, Expected.ErrorRaised /**/, false); }
        [TestCase] public void To_Boolean__From___Max_() { this.Test<Double__, Boolean_>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, true); }
        [TestCase] public void To_DateTime_From_Min___() { this.Test<Double__, DateTime>(Double__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_DateTime_From__Zero_() { this.Test<Double__, DateTime>(Double___Zero     /**/, Expected.ErrorRaised /**/, new DateTime((SInt64__)Double___Zero)); }
        [TestCase] public void To_DateTime_From___Max_() { this.Test<Double__, DateTime>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_TimeSpan_From_Min___() { this.Test<Double__, TimeSpan>(Double__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_TimeSpan_From__Zero_() { this.Test<Double__, TimeSpan>(Double___Zero     /**/, Expected.ErrorRaised /**/, new TimeSpan((SInt64__)Double___Zero)); }
        [TestCase] public void To_TimeSpan_From___Max_() { this.Test<Double__, TimeSpan>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_String___From_Min___() { this.Test<Double__, String__>(Double__.MinValue /**/, Expected.ErrorRaised /**/, Double__.MinValue.ToString()); }
        [TestCase] public void To_String___From__Zero_() { this.Test<Double__, String__>(Double___Zero     /**/, Expected.ErrorRaised /**/, Double___Zero.ToString()); }
        [TestCase] public void To_String___From___Max_() { this.Test<Double__, String__>(Double__.MaxValue /**/, Expected.ErrorRaised /**/, Double__.MaxValue.ToString()); }
    }
}
