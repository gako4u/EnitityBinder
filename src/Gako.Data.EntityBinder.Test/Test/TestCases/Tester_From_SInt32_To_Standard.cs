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
    public class Tester_From_SInt32_To_Standard : Tester
    {
        private static readonly SInt32__ SInt32___Zero = 0;

        [TestCase] public void To_Object___From_Min___() { this.Test<SInt32__, Object__>(SInt32__.MinValue /**/, SInt32__.MinValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From__Zero_() { this.Test<SInt32__, Object__>(SInt32___Zero     /**/, SInt32___Zero        /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From___Max_() { this.Test<SInt32__, Object__>(SInt32__.MaxValue /**/, SInt32__.MaxValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From_Min___() { this.Test<SInt32__, SInt08__>(SInt32__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From__Zero_() { this.Test<SInt32__, SInt08__>(SInt32___Zero     /**/, Expected.ErrorRaised /**/, (SInt08__)SInt32___Zero); }
        [TestCase] public void To_SInt08___From___Max_() { this.Test<SInt32__, SInt08__>(SInt32__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From_Min___() { this.Test<SInt32__, UInt08__>(SInt32__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From__Zero_() { this.Test<SInt32__, UInt08__>(SInt32___Zero     /**/, Expected.ErrorRaised /**/, (UInt08__)SInt32___Zero); }
        [TestCase] public void To_UInt08___From___Max_() { this.Test<SInt32__, UInt08__>(SInt32__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From_Min___() { this.Test<SInt32__, SInt16__>(SInt32__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From__Zero_() { this.Test<SInt32__, SInt16__>(SInt32___Zero     /**/, Expected.ErrorRaised /**/, (SInt16__)SInt32___Zero); }
        [TestCase] public void To_SInt16___From___Max_() { this.Test<SInt32__, SInt16__>(SInt32__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From_Min___() { this.Test<SInt32__, UInt16__>(SInt32__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From__Zero_() { this.Test<SInt32__, UInt16__>(SInt32___Zero     /**/, Expected.ErrorRaised /**/, (UInt16__)SInt32___Zero); }
        [TestCase] public void To_UInt16___From___Max_() { this.Test<SInt32__, UInt16__>(SInt32__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From_Min___() { this.Test<SInt32__, SInt32__>(SInt32__.MinValue /**/, SInt32__.MinValue    /**/, SInt32__.MinValue); }
        [TestCase] public void To_SInt32___From__Zero_() { this.Test<SInt32__, SInt32__>(SInt32___Zero     /**/, SInt32___Zero        /**/, SInt32___Zero); }
        [TestCase] public void To_SInt32___From___Max_() { this.Test<SInt32__, SInt32__>(SInt32__.MaxValue /**/, SInt32__.MaxValue    /**/, SInt32__.MaxValue); }
        [TestCase] public void To_UInt32___From_Min___() { this.Test<SInt32__, UInt32__>(SInt32__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From__Zero_() { this.Test<SInt32__, UInt32__>(SInt32___Zero     /**/, Expected.ErrorRaised /**/, (UInt32__)SInt32___Zero); }
        [TestCase] public void To_UInt32___From___Max_() { this.Test<SInt32__, UInt32__>(SInt32__.MaxValue /**/, Expected.ErrorRaised /**/, SInt32__.MaxValue); }
        [TestCase] public void To_SInt64___From_Min___() { this.Test<SInt32__, SInt64__>(SInt32__.MinValue /**/, SInt32__.MinValue    /**/, SInt32__.MinValue); }
        [TestCase] public void To_SInt64___From__Zero_() { this.Test<SInt32__, SInt64__>(SInt32___Zero     /**/, SInt32___Zero        /**/, SInt32___Zero); }
        [TestCase] public void To_SInt64___From___Max_() { this.Test<SInt32__, SInt64__>(SInt32__.MaxValue /**/, SInt32__.MaxValue    /**/, SInt32__.MaxValue); }
        [TestCase] public void To_UInt64___From_Min___() { this.Test<SInt32__, UInt64__>(SInt32__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt64___From__Zero_() { this.Test<SInt32__, UInt64__>(SInt32___Zero     /**/, Expected.ErrorRaised /**/, (UInt64__)SInt32___Zero); }
        [TestCase] public void To_UInt64___From___Max_() { this.Test<SInt32__, UInt64__>(SInt32__.MaxValue /**/, Expected.ErrorRaised /**/, SInt32__.MaxValue); }
        [TestCase] public void To_Single___From_Min___() { this.Test<SInt32__, Single__>(SInt32__.MinValue /**/, SInt32__.MinValue    /**/, SInt32__.MinValue); }
        [TestCase] public void To_Single___From__Zero_() { this.Test<SInt32__, Single__>(SInt32___Zero     /**/, SInt32___Zero        /**/, SInt32___Zero); }
        [TestCase] public void To_Single___From___Max_() { this.Test<SInt32__, Single__>(SInt32__.MaxValue /**/, SInt32__.MaxValue    /**/, SInt32__.MaxValue); }
        [TestCase] public void To_Double___From_Min___() { this.Test<SInt32__, Double__>(SInt32__.MinValue /**/, SInt32__.MinValue    /**/, SInt32__.MinValue); }
        [TestCase] public void To_Double___From__Zero_() { this.Test<SInt32__, Double__>(SInt32___Zero     /**/, SInt32___Zero        /**/, SInt32___Zero); }
        [TestCase] public void To_Double___From___Max_() { this.Test<SInt32__, Double__>(SInt32__.MaxValue /**/, SInt32__.MaxValue    /**/, SInt32__.MaxValue); }
        [TestCase] public void To_Decimal__From_Min___() { this.Test<SInt32__, Decimal_>(SInt32__.MinValue /**/, SInt32__.MinValue    /**/, SInt32__.MinValue); }
        [TestCase] public void To_Decimal__From__Zero_() { this.Test<SInt32__, Decimal_>(SInt32___Zero     /**/, SInt32___Zero        /**/, SInt32___Zero); }
        [TestCase] public void To_Decimal__From___Max_() { this.Test<SInt32__, Decimal_>(SInt32__.MaxValue /**/, SInt32__.MaxValue    /**/, SInt32__.MaxValue); }
        [TestCase] public void To_Boolean__From_Min___() { this.Test<SInt32__, Boolean_>(SInt32__.MinValue /**/, Expected.ErrorRaised /**/, true); }
        [TestCase] public void To_Boolean__From__Zero_() { this.Test<SInt32__, Boolean_>(SInt32___Zero     /**/, Expected.ErrorRaised /**/, false); }
        [TestCase] public void To_Boolean__From___Max_() { this.Test<SInt32__, Boolean_>(SInt32__.MaxValue /**/, Expected.ErrorRaised /**/, true); }
        [TestCase] public void To_DateTime_From_Min___() { this.Test<SInt32__, DateTime>(SInt32__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_DateTime_From__Zero_() { this.Test<SInt32__, DateTime>(SInt32___Zero     /**/, Expected.ErrorRaised /**/, new DateTime((SInt64__)SInt32___Zero)); }
        [TestCase] public void To_DateTime_From___Max_() { this.Test<SInt32__, DateTime>(SInt32__.MaxValue /**/, Expected.ErrorRaised /**/, new DateTime((SInt64__)SInt32__.MaxValue)); }
        [TestCase] public void To_TimeSpan_From_Min___() { this.Test<SInt32__, TimeSpan>(SInt32__.MinValue /**/, Expected.ErrorRaised /**/, new TimeSpan((SInt64__)SInt32__.MinValue)); }
        [TestCase] public void To_TimeSpan_From__Zero_() { this.Test<SInt32__, TimeSpan>(SInt32___Zero     /**/, Expected.ErrorRaised /**/, new TimeSpan((SInt64__)SInt32___Zero)); }
        [TestCase] public void To_TimeSpan_From___Max_() { this.Test<SInt32__, TimeSpan>(SInt32__.MaxValue /**/, Expected.ErrorRaised /**/, new TimeSpan((SInt64__)SInt32__.MaxValue)); }
        [TestCase] public void To_String___From_Min___() { this.Test<SInt32__, String__>(SInt32__.MinValue /**/, Expected.ErrorRaised /**/, SInt32__.MinValue.ToString()); }
        [TestCase] public void To_String___From__Zero_() { this.Test<SInt32__, String__>(SInt32___Zero     /**/, Expected.ErrorRaised /**/, SInt32___Zero.ToString()); }
        [TestCase] public void To_String___From___Max_() { this.Test<SInt32__, String__>(SInt32__.MaxValue /**/, Expected.ErrorRaised /**/, SInt32__.MaxValue.ToString()); }
    }
}
