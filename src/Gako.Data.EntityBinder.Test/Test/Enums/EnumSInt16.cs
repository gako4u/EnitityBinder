using SInt08 = System.SByte;
using UInt08 = System.Byte;
using SInt16 = System.Int16;

namespace Test.Anything.Test.Enums
{
    public enum EnumSInt16 : SInt16
    {
        SInt16__Min_ = (SInt16)SInt16.MinValue,
        SInt08__Min_ = (SInt16)SInt08.MinValue,
        Zero________ = (SInt16)0,
        SInt08__Max_ = (SInt16)SInt08.MaxValue,
        UInt08__Max_ = (SInt16)UInt08.MaxValue,
        SInt16__Max_ = (SInt16)SInt16.MaxValue,
    }
}
