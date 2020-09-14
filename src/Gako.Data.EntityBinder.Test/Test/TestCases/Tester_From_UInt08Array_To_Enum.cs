using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Anything.Test;
using Test.Anything.Test.Enums;

namespace NHibernateUtility.Test
{
    public class Tester_From_UInt08Array_To_Enum : Tester
    {
        private static readonly byte[] Empty = new byte[0];

        [TestCase] public void To_EnumSInt08_From_EmptyArray() { this.Test<byte[], EnumSInt08>(Empty /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt08_From_EmptyArray() { this.Test<byte[], EnumUInt08>(Empty /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt16_From_EmptyArray() { this.Test<byte[], EnumSInt16>(Empty /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt16_From_EmptyArray() { this.Test<byte[], EnumUInt16>(Empty /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt32_From_EmptyArray() { this.Test<byte[], EnumSInt32>(Empty /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt32_From_EmptyArray() { this.Test<byte[], EnumUInt32>(Empty /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumSInt64_From_EmptyArray() { this.Test<byte[], EnumSInt64>(Empty /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
        [TestCase] public void To_EnumUInt64_From_EmptyArray() { this.Test<byte[], EnumUInt64>(Empty /**/, Expected.ErrorRaised, Expected.ErrorRaised); }
    }
}
