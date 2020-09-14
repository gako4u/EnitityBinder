using SInt08 = System.SByte;
using UInt08 = System.Byte;
using SInt16 = System.Int16;
using UInt16 = System.UInt16;
using SInt32 = System.Int32;
using UInt32 = System.UInt32;
using SInt64 = System.Int64;
using System;

namespace Test.Anything.Test.Enums
{
    public enum EnumSInt64 : SInt64
    {
        SInt64__Min_ = (SInt64)SInt64.MinValue,
        SInt32__Min_ = (SInt64)SInt32.MinValue,
        SInt16__Min_ = (SInt64)SInt16.MinValue,
        SInt08__Min_ = (SInt64)SInt08.MinValue,
        Zero________ = (SInt64)0,
        SInt08__Max_ = (SInt64)SInt08.MaxValue,
        UInt08__Max_ = (SInt64)UInt08.MaxValue,
        SInt16__Max_ = (SInt64)SInt16.MaxValue,
        UInt16__Max_ = (SInt64)UInt16.MaxValue,
        SInt32__Max_ = (SInt64)SInt32.MaxValue,
        UInt32__Max_ = (SInt64)UInt32.MaxValue,
        SInt64__Max_ = (SInt64)SInt64.MaxValue,
    }
}
