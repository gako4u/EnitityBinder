
using SInt08 = System.SByte;
using UInt08 = System.Byte;
using SInt16 = System.Int16;
using UInt16 = System.UInt16;

namespace Test.Anything.Test.Enums
{
    public enum EnumUInt16 : UInt16
    {
        Zero________ = (UInt16)0,
        SInt08__Max_ = (UInt16)SInt08.MaxValue,
        UInt08__Max_ = (UInt16)UInt08.MaxValue,
        SInt16__Max_ = (UInt16)SInt16.MaxValue,
        UInt16__Max_ = (UInt16)UInt16.MaxValue,
    }
}
