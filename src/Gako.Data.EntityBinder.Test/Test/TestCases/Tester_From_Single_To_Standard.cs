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
    public class Tester_From_Single_To_Standard : Tester
    {
        private static readonly Single__ Single___Zero = 0;

        [TestCase] public void To_Object___From_Min___() { this.Test<Single__, Object__>(Single__.MinValue /**/, Single__.MinValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From__Zero_() { this.Test<Single__, Object__>(Single___Zero     /**/, Single___Zero        /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From___Max_() { this.Test<Single__, Object__>(Single__.MaxValue /**/, Single__.MaxValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From_Min___() { this.Test<Single__, SInt08__>(Single__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From__Zero_() { this.Test<Single__, SInt08__>(Single___Zero     /**/, Expected.ErrorRaised /**/, (SInt08__)Single___Zero); }
        [TestCase] public void To_SInt08___From___Max_() { this.Test<Single__, SInt08__>(Single__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From_Min___() { this.Test<Single__, UInt08__>(Single__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From__Zero_() { this.Test<Single__, UInt08__>(Single___Zero     /**/, Expected.ErrorRaised /**/, (UInt08__)Single___Zero); }
        [TestCase] public void To_UInt08___From___Max_() { this.Test<Single__, UInt08__>(Single__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From_Min___() { this.Test<Single__, SInt16__>(Single__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From__Zero_() { this.Test<Single__, SInt16__>(Single___Zero     /**/, Expected.ErrorRaised /**/, (SInt16__)Single___Zero); }
        [TestCase] public void To_SInt16___From___Max_() { this.Test<Single__, SInt16__>(Single__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From_Min___() { this.Test<Single__, UInt16__>(Single__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From__Zero_() { this.Test<Single__, UInt16__>(Single___Zero     /**/, Expected.ErrorRaised /**/, (UInt16__)Single___Zero); }
        [TestCase] public void To_UInt16___From___Max_() { this.Test<Single__, UInt16__>(Single__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From_Min___() { this.Test<Single__, SInt32__>(Single__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From__Zero_() { this.Test<Single__, SInt32__>(Single___Zero     /**/, Expected.ErrorRaised /**/, (SInt32__)Single___Zero); }
        [TestCase] public void To_SInt32___From___Max_() { this.Test<Single__, SInt32__>(Single__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From_Min___() { this.Test<Single__, UInt32__>(Single__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From__Zero_() { this.Test<Single__, UInt32__>(Single___Zero     /**/, Expected.ErrorRaised /**/, (UInt32__)Single___Zero); }
        [TestCase] public void To_UInt32___From___Max_() { this.Test<Single__, UInt32__>(Single__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt64___From_Min___() { this.Test<Single__, SInt64__>(Single__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt64___From__Zero_() { this.Test<Single__, SInt64__>(Single___Zero     /**/, Expected.ErrorRaised /**/, (SInt64__)Single___Zero); }
        [TestCase] public void To_SInt64___From___Max_() { this.Test<Single__, SInt64__>(Single__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt64___From_Min___() { this.Test<Single__, UInt64__>(Single__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt64___From__Zero_() { this.Test<Single__, UInt64__>(Single___Zero     /**/, Expected.ErrorRaised /**/, (UInt64__)Single___Zero); }
        [TestCase] public void To_UInt64___From___Max_() { this.Test<Single__, UInt64__>(Single__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Single___From_Min___() { this.Test<Single__, Single__>(Single__.MinValue /**/, Single__.MinValue    /**/, Single__.MinValue); }
        [TestCase] public void To_Single___From__Zero_() { this.Test<Single__, Single__>(Single___Zero     /**/, Single___Zero        /**/, Single___Zero); }
        [TestCase] public void To_Single___From___Max_() { this.Test<Single__, Single__>(Single__.MaxValue /**/, Single__.MaxValue    /**/, Single__.MaxValue); }
        [TestCase] public void To_Double___From_Min___() { this.Test<Single__, Double__>(Single__.MinValue /**/, Single__.MinValue    /**/, Single__.MinValue); }
        [TestCase] public void To_Double___From__Zero_() { this.Test<Single__, Double__>(Single___Zero     /**/, Single___Zero        /**/, Single___Zero); }
        [TestCase] public void To_Double___From___Max_() { this.Test<Single__, Double__>(Single__.MaxValue /**/, Single__.MaxValue    /**/, Single__.MaxValue); }
        [TestCase] public void To_Decimal__From_Min___() { this.Test<Single__, Decimal_>(Single__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Decimal__From__Zero_() { this.Test<Single__, Decimal_>(Single___Zero     /**/, Expected.ErrorRaised /**/, (Decimal_)Single___Zero); }
        [TestCase] public void To_Decimal__From___Max_() { this.Test<Single__, Decimal_>(Single__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Boolean__From_Min___() { this.Test<Single__, Boolean_>(Single__.MinValue /**/, Expected.ErrorRaised /**/, true); }
        [TestCase] public void To_Boolean__From__Zero_() { this.Test<Single__, Boolean_>(Single___Zero     /**/, Expected.ErrorRaised /**/, false); }
        [TestCase] public void To_Boolean__From___Max_() { this.Test<Single__, Boolean_>(Single__.MaxValue /**/, Expected.ErrorRaised /**/, true); }
        [TestCase] public void To_DateTime_From_Min___() { this.Test<Single__, DateTime>(Single__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_DateTime_From__Zero_() { this.Test<Single__, DateTime>(Single___Zero     /**/, Expected.ErrorRaised /**/, new DateTime((SInt64__)Single___Zero)); }
        [TestCase] public void To_DateTime_From___Max_() { this.Test<Single__, DateTime>(Single__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_TimeSpan_From_Min___() { this.Test<Single__, TimeSpan>(Single__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_TimeSpan_From__Zero_() { this.Test<Single__, TimeSpan>(Single___Zero     /**/, Expected.ErrorRaised /**/, new TimeSpan((SInt64__)Single___Zero)); }
        [TestCase] public void To_TimeSpan_From___Max_() { this.Test<Single__, TimeSpan>(Single__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_String___From_Min___() { this.Test<Single__, String__>(Single__.MinValue /**/, Expected.ErrorRaised /**/, Single__.MinValue.ToString()); }
        [TestCase] public void To_String___From__Zero_() { this.Test<Single__, String__>(Single___Zero     /**/, Expected.ErrorRaised /**/, Single___Zero.ToString()); }
        [TestCase] public void To_String___From___Max_() { this.Test<Single__, String__>(Single__.MaxValue /**/, Expected.ErrorRaised /**/, Single__.MaxValue.ToString()); }
    }
}
