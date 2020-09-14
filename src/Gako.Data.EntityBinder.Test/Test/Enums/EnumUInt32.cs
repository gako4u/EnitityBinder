using SInt08 = System.SByte;
using UInt08 = System.Byte;
using SInt16 = System.Int16;
using UInt16 = System.UInt16;
using SInt32 = System.Int32;
using UInt32 = System.UInt32;

namespace Test.Anything.Test.Enums
{
    public enum EnumUInt32 : UInt32
    {
        Zero________ = (UInt32)0,
        SInt08__Max_ = (UInt32)SInt08.MaxValue,
        UInt08__Max_ = (UInt32)UInt08.MaxValue,
        SInt16__Max_ = (UInt32)SInt16.MaxValue,
        UInt16__Max_ = (UInt32)UInt16.MaxValue,
        SInt32__Max_ = (UInt32)SInt32.MaxValue,
        UInt32__Max_ = (UInt32)UInt32.MaxValue,
    }
}
