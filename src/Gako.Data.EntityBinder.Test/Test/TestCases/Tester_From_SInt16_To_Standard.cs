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
    public class Tester_From_SInt16_To_Standard : Tester
    {
        private static readonly SInt16__ SInt16___Zero = 0;

        [TestCase] public void To_Object___From_Min___() { this.Test<SInt16__, Object__>(SInt16__.MinValue /**/, SInt16__.MinValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From__Zero_() { this.Test<SInt16__, Object__>(SInt16___Zero     /**/, SInt16___Zero        /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From___Max_() { this.Test<SInt16__, Object__>(SInt16__.MaxValue /**/, SInt16__.MaxValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From_Min___() { this.Test<SInt16__, SInt08__>(SInt16__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From__Zero_() { this.Test<SInt16__, SInt08__>(SInt16___Zero     /**/, Expected.ErrorRaised /**/, (SInt08__)SInt16___Zero); }
        [TestCase] public void To_SInt08___From___Max_() { this.Test<SInt16__, SInt08__>(SInt16__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From_Min___() { this.Test<SInt16__, UInt08__>(SInt16__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From__Zero_() { this.Test<SInt16__, UInt08__>(SInt16___Zero     /**/, Expected.ErrorRaised /**/, (UInt08__)SInt16___Zero); }
        [TestCase] public void To_UInt08___From___Max_() { this.Test<SInt16__, UInt08__>(SInt16__.MaxValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From_Min___() { this.Test<SInt16__, SInt16__>(SInt16__.MinValue /**/, SInt16__.MinValue    /**/, SInt16__.MinValue); }
        [TestCase] public void To_SInt16___From__Zero_() { this.Test<SInt16__, SInt16__>(SInt16___Zero     /**/, SInt16___Zero        /**/, SInt16___Zero); }
        [TestCase] public void To_SInt16___From___Max_() { this.Test<SInt16__, SInt16__>(SInt16__.MaxValue /**/, SInt16__.MaxValue    /**/, SInt16__.MaxValue); }
        [TestCase] public void To_UInt16___From_Min___() { this.Test<SInt16__, UInt16__>(SInt16__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From__Zero_() { this.Test<SInt16__, UInt16__>(SInt16___Zero     /**/, Expected.ErrorRaised /**/, (UInt16__)SInt16___Zero); }
        [TestCase] public void To_UInt16___From___Max_() { this.Test<SInt16__, UInt16__>(SInt16__.MaxValue /**/, Expected.ErrorRaised /**/, (UInt16__)SInt16__.MaxValue); }
        [TestCase] public void To_SInt32___From_Min___() { this.Test<SInt16__, SInt32__>(SInt16__.MinValue /**/, SInt16__.MinValue    /**/, SInt16__.MinValue); }
        [TestCase] public void To_SInt32___From__Zero_() { this.Test<SInt16__, SInt32__>(SInt16___Zero     /**/, SInt16___Zero        /**/, SInt16___Zero); }
        [TestCase] public void To_SInt32___From___Max_() { this.Test<SInt16__, SInt32__>(SInt16__.MaxValue /**/, SInt16__.MaxValue    /**/, SInt16__.MaxValue); }
        [TestCase] public void To_UInt32___From_Min___() { this.Test<SInt16__, UInt32__>(SInt16__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From__Zero_() { this.Test<SInt16__, UInt32__>(SInt16___Zero     /**/, Expected.ErrorRaised /**/, (UInt32__)SInt16___Zero); }
        [TestCase] public void To_UInt32___From___Max_() { this.Test<SInt16__, UInt32__>(SInt16__.MaxValue /**/, Expected.ErrorRaised /**/, (UInt32__)SInt16__.MaxValue); }
        [TestCase] public void To_SInt64___From_Min___() { this.Test<SInt16__, SInt64__>(SInt16__.MinValue /**/, SInt16__.MinValue    /**/, SInt16__.MinValue); }
        [TestCase] public void To_SInt64___From__Zero_() { this.Test<SInt16__, SInt64__>(SInt16___Zero     /**/, SInt16___Zero        /**/, SInt16___Zero); }
        [TestCase] public void To_SInt64___From___Max_() { this.Test<SInt16__, SInt64__>(SInt16__.MaxValue /**/, SInt16__.MaxValue    /**/, SInt16__.MaxValue); }
        [TestCase] public void To_UInt64___From_Min___() { this.Test<SInt16__, UInt64__>(SInt16__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt64___From__Zero_() { this.Test<SInt16__, UInt64__>(SInt16___Zero     /**/, Expected.ErrorRaised /**/, (UInt64__)SInt16___Zero); }
        [TestCase] public void To_UInt64___From___Max_() { this.Test<SInt16__, UInt64__>(SInt16__.MaxValue /**/, Expected.ErrorRaised /**/, (UInt64__)SInt16__.MaxValue); }
        [TestCase] public void To_Single___From_Min___() { this.Test<SInt16__, Single__>(SInt16__.MinValue /**/, SInt16__.MinValue    /**/, SInt16__.MinValue); }
        [TestCase] public void To_Single___From__Zero_() { this.Test<SInt16__, Single__>(SInt16___Zero     /**/, SInt16___Zero        /**/, SInt16___Zero); }
        [TestCase] public void To_Single___From___Max_() { this.Test<SInt16__, Single__>(SInt16__.MaxValue /**/, SInt16__.MaxValue    /**/, SInt16__.MaxValue); }
        [TestCase] public void To_Double___From_Min___() { this.Test<SInt16__, Double__>(SInt16__.MinValue /**/, SInt16__.MinValue    /**/, SInt16__.MinValue); }
        [TestCase] public void To_Double___From__Zero_() { this.Test<SInt16__, Double__>(SInt16___Zero     /**/, SInt16___Zero        /**/, SInt16___Zero); }
        [TestCase] public void To_Double___From___Max_() { this.Test<SInt16__, Double__>(SInt16__.MaxValue /**/, SInt16__.MaxValue    /**/, SInt16__.MaxValue); }
        [TestCase] public void To_Decimal__From_Min___() { this.Test<SInt16__, Decimal_>(SInt16__.MinValue /**/, SInt16__.MinValue    /**/, SInt16__.MinValue); }
        [TestCase] public void To_Decimal__From__Zero_() { this.Test<SInt16__, Decimal_>(SInt16___Zero     /**/, SInt16___Zero        /**/, SInt16___Zero); }
        [TestCase] public void To_Decimal__From___Max_() { this.Test<SInt16__, Decimal_>(SInt16__.MaxValue /**/, SInt16__.MaxValue    /**/, SInt16__.MaxValue); }
        [TestCase] public void To_Boolean__From_Min___() { this.Test<SInt16__, Boolean_>(SInt16__.MinValue /**/, Expected.ErrorRaised /**/, true); }
        [TestCase] public void To_Boolean__From__Zero_() { this.Test<SInt16__, Boolean_>(SInt16___Zero     /**/, Expected.ErrorRaised /**/, false); }
        [TestCase] public void To_Boolean__From___Max_() { this.Test<SInt16__, Boolean_>(SInt16__.MaxValue /**/, Expected.ErrorRaised /**/, true); }
        [TestCase] public void To_DateTime_From_Min___() { this.Test<SInt16__, DateTime>(SInt16__.MinValue /**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_DateTime_From__Zero_() { this.Test<SInt16__, DateTime>(SInt16___Zero     /**/, Expected.ErrorRaised /**/, new DateTime((SInt64__)SInt16___Zero)); }
        [TestCase] public void To_DateTime_From___Max_() { this.Test<SInt16__, DateTime>(SInt16__.MaxValue /**/, Expected.ErrorRaised /**/, new DateTime((SInt64__)SInt16__.MaxValue)); }
        [TestCase] public void To_TimeSpan_From_Min___() { this.Test<SInt16__, TimeSpan>(SInt16__.MinValue /**/, Expected.ErrorRaised /**/, new TimeSpan((SInt64__)SInt16__.MinValue)); }
        [TestCase] public void To_TimeSpan_From__Zero_() { this.Test<SInt16__, TimeSpan>(SInt16___Zero     /**/, Expected.ErrorRaised /**/, new TimeSpan((SInt64__)SInt16___Zero)); }
        [TestCase] public void To_TimeSpan_From___Max_() { this.Test<SInt16__, TimeSpan>(SInt16__.MaxValue /**/, Expected.ErrorRaised /**/, new TimeSpan((SInt64__)SInt16__.MaxValue)); }
        [TestCase] public void To_String___From_Min___() { this.Test<SInt16__, String__>(SInt16__.MinValue /**/, Expected.ErrorRaised /**/, SInt16__.MinValue.ToString()); }
        [TestCase] public void To_String___From__Zero_() { this.Test<SInt16__, String__>(SInt16___Zero     /**/, Expected.ErrorRaised /**/, SInt16___Zero.ToString()); }
        [TestCase] public void To_String___From___Max_() { this.Test<SInt16__, String__>(SInt16__.MaxValue /**/, Expected.ErrorRaised /**/, SInt16__.MaxValue.ToString()); }
    }
}
