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
    public class Tester_From_SInt64_To_Standard : Tester
    {
        private static readonly SInt64__ SInt64___Zero = 0;

        [TestCase] public void To_Object___From_Min___() { this.Test<SInt64__, Object__>(SInt64__.MinValue /**/, SInt64__.MinValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From__Zero_() { this.Test<SInt64__, Object__>(SInt64___Zero     /**/, SInt64___Zero        /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From___Max_() { this.Test<SInt64__, Object__>(SInt64__.MaxValue /**/, SInt64__.MaxValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From_Min___() { this.Test<SInt64__, SInt08__>(SInt64__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From__Zero_() { this.Test<SInt64__, SInt08__>(SInt64___Zero     /**/, Expected.ErrorRaised /**/, (SInt08__)SInt64___Zero); }
        [TestCase] public void To_SInt08___From___Max_() { this.Test<SInt64__, SInt08__>(SInt64__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From_Min___() { this.Test<SInt64__, UInt08__>(SInt64__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From__Zero_() { this.Test<SInt64__, UInt08__>(SInt64___Zero     /**/, Expected.ErrorRaised /**/, (UInt08__)SInt64___Zero); }
        [TestCase] public void To_UInt08___From___Max_() { this.Test<SInt64__, UInt08__>(SInt64__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From_Min___() { this.Test<SInt64__, SInt16__>(SInt64__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From__Zero_() { this.Test<SInt64__, SInt16__>(SInt64___Zero     /**/, Expected.ErrorRaised /**/, (SInt16__)SInt64___Zero); }
        [TestCase] public void To_SInt16___From___Max_() { this.Test<SInt64__, SInt16__>(SInt64__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From_Min___() { this.Test<SInt64__, UInt16__>(SInt64__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From__Zero_() { this.Test<SInt64__, UInt16__>(SInt64___Zero     /**/, Expected.ErrorRaised /**/, (UInt16__)SInt64___Zero); }
        [TestCase] public void To_UInt16___From___Max_() { this.Test<SInt64__, UInt16__>(SInt64__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From_Min___() { this.Test<SInt64__, SInt32__>(SInt64__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From__Zero_() { this.Test<SInt64__, SInt32__>(SInt64___Zero     /**/, Expected.ErrorRaised /**/, (SInt32__)SInt64___Zero); }
        [TestCase] public void To_SInt32___From___Max_() { this.Test<SInt64__, SInt32__>(SInt64__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From_Min___() { this.Test<SInt64__, UInt32__>(SInt64__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From__Zero_() { this.Test<SInt64__, UInt32__>(SInt64___Zero     /**/, Expected.ErrorRaised /**/, (UInt32__)SInt64___Zero); }
        [TestCase] public void To_UInt32___From___Max_() { this.Test<SInt64__, UInt32__>(SInt64__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt64___From_Min___() { this.Test<SInt64__, SInt64__>(SInt64__.MinValue /**/, SInt64__.MinValue    /**/, SInt64__.MinValue); }
        [TestCase] public void To_SInt64___From__Zero_() { this.Test<SInt64__, SInt64__>(SInt64___Zero     /**/, SInt64___Zero        /**/, SInt64___Zero); }
        [TestCase] public void To_SInt64___From___Max_() { this.Test<SInt64__, SInt64__>(SInt64__.MaxValue /**/, SInt64__.MaxValue    /**/, SInt64__.MaxValue); }
        [TestCase] public void To_UInt64___From_Min___() { this.Test<SInt64__, UInt64__>(SInt64__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt64___From__Zero_() { this.Test<SInt64__, UInt64__>(SInt64___Zero     /**/, Expected.ErrorRaised /**/, (UInt64__)SInt64___Zero); }
        [TestCase] public void To_UInt64___From___Max_() { this.Test<SInt64__, UInt64__>(SInt64__.MaxValue /**/, Expected.ErrorRaised /**/, SInt64__.MaxValue); }
        [TestCase] public void To_Single___From_Min___() { this.Test<SInt64__, Single__>(SInt64__.MinValue /**/, SInt64__.MinValue    /**/, SInt64__.MinValue); }
        [TestCase] public void To_Single___From__Zero_() { this.Test<SInt64__, Single__>(SInt64___Zero     /**/, SInt64___Zero        /**/, SInt64___Zero); }
        [TestCase] public void To_Single___From___Max_() { this.Test<SInt64__, Single__>(SInt64__.MaxValue /**/, SInt64__.MaxValue    /**/, SInt64__.MaxValue); }
        [TestCase] public void To_Double___From_Min___() { this.Test<SInt64__, Double__>(SInt64__.MinValue /**/, SInt64__.MinValue    /**/, SInt64__.MinValue); }
        [TestCase] public void To_Double___From__Zero_() { this.Test<SInt64__, Double__>(SInt64___Zero     /**/, SInt64___Zero        /**/, SInt64___Zero); }
        [TestCase] public void To_Double___From___Max_() { this.Test<SInt64__, Double__>(SInt64__.MaxValue /**/, SInt64__.MaxValue    /**/, SInt64__.MaxValue); }
        [TestCase] public void To_Decimal__From_Min___() { this.Test<SInt64__, Decimal_>(SInt64__.MinValue /**/, SInt64__.MinValue    /**/, SInt64__.MinValue); }
        [TestCase] public void To_Decimal__From__Zero_() { this.Test<SInt64__, Decimal_>(SInt64___Zero     /**/, SInt64___Zero        /**/, SInt64___Zero); }
        [TestCase] public void To_Decimal__From___Max_() { this.Test<SInt64__, Decimal_>(SInt64__.MaxValue /**/, SInt64__.MaxValue    /**/, SInt64__.MaxValue); }
        [TestCase] public void To_Boolean__From_Min___() { this.Test<SInt64__, Boolean_>(SInt64__.MinValue /**/, Expected.ErrorRaised /**/, true); }
        [TestCase] public void To_Boolean__From__Zero_() { this.Test<SInt64__, Boolean_>(SInt64___Zero     /**/, Expected.ErrorRaised /**/, false); }
        [TestCase] public void To_Boolean__From___Max_() { this.Test<SInt64__, Boolean_>(SInt64__.MaxValue /**/, Expected.ErrorRaised /**/, true); }
        [TestCase] public void To_DateTime_From_Min___() { this.Test<SInt64__, DateTime>(SInt64__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_DateTime_From__Zero_() { this.Test<SInt64__, DateTime>(SInt64___Zero     /**/, Expected.ErrorRaised /**/, new DateTime((SInt64__)SInt64___Zero)); }
        [TestCase] public void To_DateTime_From___Max_() { this.Test<SInt64__, DateTime>(SInt64__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_TimeSpan_From_Min___() { this.Test<SInt64__, TimeSpan>(SInt64__.MinValue /**/, Expected.ErrorRaised /**/, new TimeSpan((SInt64__)SInt64__.MinValue)); }
        [TestCase] public void To_TimeSpan_From__Zero_() { this.Test<SInt64__, TimeSpan>(SInt64___Zero     /**/, Expected.ErrorRaised /**/, new TimeSpan((SInt64__)SInt64___Zero)); }
        [TestCase] public void To_TimeSpan_From___Max_() { this.Test<SInt64__, TimeSpan>(SInt64__.MaxValue /**/, Expected.ErrorRaised /**/, new TimeSpan((SInt64__)SInt64__.MaxValue)); }
        [TestCase] public void To_String___From_Min___() { this.Test<SInt64__, String__>(SInt64__.MinValue /**/, Expected.ErrorRaised /**/, SInt64__.MinValue.ToString()); }
        [TestCase] public void To_String___From__Zero_() { this.Test<SInt64__, String__>(SInt64___Zero     /**/, Expected.ErrorRaised /**/, SInt64___Zero.ToString()); }
        [TestCase] public void To_String___From___Max_() { this.Test<SInt64__, String__>(SInt64__.MaxValue /**/, Expected.ErrorRaised /**/, SInt64__.MaxValue.ToString()); }
    }
}
