using Gako.Data.EntityBinder;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Test.Anything.Test.TestCases.Attribute
{
    [TestFixture]
    public class Tester_DecodeAttribute
    {
        [TestCase]
        public void Test1()
        {
            Assert.Throws<EntityBinderException>(
                () =>
                {
                    var notBytes = new int[] { 1, 2 };
                    var ety = new Entity();
                    EntityBinder<Entity>.Instance.SetValueTo(ety, nameof(Entity.Enum), notBytes);
                }
            );
        }

        [TestCase(nameof(Entity.Enum), null)]
        [TestCase(nameof(Entity.Enum), "")]
        [TestCase(nameof(Entity.Enum), "Hello, World")]
        [TestCase(nameof(Entity.Int32), null)]
        [TestCase(nameof(Entity.Int32), "")]
        [TestCase(nameof(Entity.Int32), "Hello, World")]
        public void Test2(string propName, string source)
        {
            byte[] encoded =
                source == null
                    ? null
                    : Encoding.UTF8.GetBytes(source);

            var ety = new Entity();
            EntityBinder<Entity>.Instance.SetValueTo(ety, propName, encoded);
            string actual = (string)typeof(Entity).GetProperty(propName).GetValue(ety);
            Assert.AreEqual(source, actual);
        }

        public class Entity
        {
            [Decode(CodePage.CP65001_utf_8)] public string Enum { get; set; }

            [Decode(65001)] public string Int32 { get; set; }
        }
    }
}
