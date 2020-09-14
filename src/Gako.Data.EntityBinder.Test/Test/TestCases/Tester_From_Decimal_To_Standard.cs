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
    public class Tester_From_Decimal_To_Standard : Tester
    {
        [TestCase] public void To_Object___From_Min___() { this.Test<Decimal_, Object__>(Decimal_.MinValue/**/, Decimal_.MinValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From__Zero_() { this.Test<Decimal_, Object__>(Decimal_.Zero    /**/, Decimal_.Zero        /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Object___From___Max_() { this.Test<Decimal_, Object__>(Decimal_.MaxValue/**/, Decimal_.MaxValue    /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From_Min___() { this.Test<Decimal_, SInt08__>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt08___From__Zero_() { this.Test<Decimal_, SInt08__>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, (SInt08__)Decimal_.Zero); }
        [TestCase] public void To_SInt08___From___Max_() { this.Test<Decimal_, SInt08__>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From_Min___() { this.Test<Decimal_, UInt08__>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt08___From__Zero_() { this.Test<Decimal_, UInt08__>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, (UInt08__)Decimal_.Zero); }
        [TestCase] public void To_UInt08___From___Max_() { this.Test<Decimal_, UInt08__>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From_Min___() { this.Test<Decimal_, SInt16__>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt16___From__Zero_() { this.Test<Decimal_, SInt16__>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, (SInt16__)Decimal_.Zero); }
        [TestCase] public void To_SInt16___From___Max_() { this.Test<Decimal_, SInt16__>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From_Min___() { this.Test<Decimal_, UInt16__>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt16___From__Zero_() { this.Test<Decimal_, UInt16__>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, (UInt16__)Decimal_.Zero); }
        [TestCase] public void To_UInt16___From___Max_() { this.Test<Decimal_, UInt16__>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From_Min___() { this.Test<Decimal_, SInt32__>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt32___From__Zero_() { this.Test<Decimal_, SInt32__>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, (SInt32__)Decimal_.Zero); }
        [TestCase] public void To_SInt32___From___Max_() { this.Test<Decimal_, SInt32__>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From_Min___() { this.Test<Decimal_, UInt32__>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt32___From__Zero_() { this.Test<Decimal_, UInt32__>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, (UInt32__)Decimal_.Zero); }
        [TestCase] public void To_UInt32___From___Max_() { this.Test<Decimal_, UInt32__>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt64___From_Min___() { this.Test<Decimal_, SInt64__>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_SInt64___From__Zero_() { this.Test<Decimal_, SInt64__>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, (SInt64__)Decimal_.Zero); }
        [TestCase] public void To_SInt64___From___Max_() { this.Test<Decimal_, SInt64__>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt64___From_Min___() { this.Test<Decimal_, UInt64__>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_UInt64___From__Zero_() { this.Test<Decimal_, UInt64__>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, (UInt64__)Decimal_.Zero); }
        [TestCase] public void To_UInt64___From___Max_() { this.Test<Decimal_, UInt64__>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_Single___From_Min___() { this.Test<Decimal_, Single__>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, (Single__)Decimal_.MinValue); }
        [TestCase] public void To_Single___From__Zero_() { this.Test<Decimal_, Single__>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, (Single__)Decimal_.Zero); }
        [TestCase] public void To_Single___From___Max_() { this.Test<Decimal_, Single__>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, (Single__)Decimal_.MaxValue); }
        [TestCase] public void To_Double___From_Min___() { this.Test<Decimal_, Double__>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, (Double__)Decimal_.MinValue); }
        [TestCase] public void To_Double___From__Zero_() { this.Test<Decimal_, Double__>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, (Double__)Decimal_.Zero); }
        [TestCase] public void To_Double___From___Max_() { this.Test<Decimal_, Double__>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, (Double__)Decimal_.MaxValue); }
        [TestCase] public void To_Decimal__From_Min___() { this.Test<Decimal_, Decimal_>(Decimal_.MinValue/**/, Decimal_.MinValue    /**/, Decimal_.MinValue); }
        [TestCase] public void To_Decimal__From__Zero_() { this.Test<Decimal_, Decimal_>(Decimal_.Zero    /**/, Decimal_.Zero        /**/, Decimal_.Zero); }
        [TestCase] public void To_Decimal__From___Max_() { this.Test<Decimal_, Decimal_>(Decimal_.MaxValue/**/, Decimal_.MaxValue    /**/, Decimal_.MaxValue); }
        [TestCase] public void To_Boolean__From_Min___() { this.Test<Decimal_, Boolean_>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, true); }
        [TestCase] public void To_Boolean__From__Zero_() { this.Test<Decimal_, Boolean_>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, false); }
        [TestCase] public void To_Boolean__From___Max_() { this.Test<Decimal_, Boolean_>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, true); }
        [TestCase] public void To_DateTime_From_Min___() { this.Test<Decimal_, DateTime>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_DateTime_From__Zero_() { this.Test<Decimal_, DateTime>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, new DateTime((SInt64__)Decimal_.Zero)); }
        [TestCase] public void To_DateTime_From___Max_() { this.Test<Decimal_, DateTime>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_TimeSpan_From_Min___() { this.Test<Decimal_, TimeSpan>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_TimeSpan_From__Zero_() { this.Test<Decimal_, TimeSpan>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, new TimeSpan((SInt64__)Decimal_.Zero)); }
        [TestCase] public void To_TimeSpan_From___Max_() { this.Test<Decimal_, TimeSpan>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, Expected.ErrorRaised); }
        [TestCase] public void To_String___From_Min___() { this.Test<Decimal_, String__>(Decimal_.MinValue/**/, Expected.ErrorRaised /**/, Decimal_.MinValue.ToString()); }
        [TestCase] public void To_String___From__Zero_() { this.Test<Decimal_, String__>(Decimal_.Zero    /**/, Expected.ErrorRaised /**/, Decimal_.Zero.ToString()); }
        [TestCase] public void To_String___From___Max_() { this.Test<Decimal_, String__>(Decimal_.MaxValue/**/, Expected.ErrorRaised /**/, Decimal_.MaxValue.ToString()); }
    }
}
