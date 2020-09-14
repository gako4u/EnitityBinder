using SInt08 = System.SByte;
using UInt08 = System.Byte;
using SInt16 = System.Int16;
using UInt16 = System.UInt16;
using SInt32 = System.Int32;

namespace Test.Anything.Test.Enums
{
    public enum EnumSInt32 : SInt32
    {
        SInt32__Min_ = (SInt32)SInt32.MinValue,
        SInt16__Min_ = (SInt32)SInt16.MinValue,
        SInt08__Min_ = (SInt32)SInt08.MinValue,
        Zero________ = (SInt32)0,
        SInt08__Max_ = (SInt32)SInt08.MaxValue,
        UInt08__Max_ = (SInt32)UInt08.MaxValue,
        SInt16__Max_ = (SInt32)SInt16.MaxValue,
        UInt16__Max_ = (SInt32)UInt16.MaxValue,
        SInt32__Max_ = (SInt32)SInt32.MaxValue,
    }
}
