using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SInt08 = System.SByte;
using UInt08 = System.Byte;
using SInt16 = System.Int16;
using UInt16 = System.UInt16;
using SInt32 = System.Int32;
using UInt32 = System.UInt32;
using SInt64 = System.Int64;
using UInt64 = System.UInt64;

namespace Test.Anything.Test.Enums
{
    public enum EnumUInt64 : UInt64
    {
        Zero________ = (UInt64)0,
        SInt08__Max_ = (UInt64)SInt08.MaxValue,
        UInt08__Max_ = (UInt64)UInt08.MaxValue,
        SInt16__Max_ = (UInt64)SInt16.MaxValue,
        UInt16__Max_ = (UInt64)UInt16.MaxValue,
        SInt32__Max_ = (UInt64)SInt32.MaxValue,
        UInt32__Max_ = (UInt64)UInt32.MaxValue,
        SInt64__Max_ = (UInt64)SInt64.MaxValue,
        UInt64__Max_ = (UInt64)UInt64.MaxValue,
    }
}
