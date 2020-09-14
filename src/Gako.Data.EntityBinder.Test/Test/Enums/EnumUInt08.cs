using SInt08 = System.SByte;
using UInt08 = System.Byte;

namespace Test.Anything.Test.Enums
{
    public enum EnumUInt08 : UInt08
    {
        Zero________ = (UInt08)0,
        SInt08__Max_ = (UInt08)SInt08.MaxValue,
        UInt08__Max_ = (UInt08)UInt08.MaxValue,
    }
}
