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
    public class Tester_FormatAttribute
    {
        [TestCase(nameof(Entity.Field_null__00), /**/  1,     /**/    "01")]
        [TestCase(nameof(Entity.Field_null__00), /**/ 10,     /**/    "10")]
        [TestCase(nameof(Entity.Field_null__00), /**/100,     /**/   "100")]
        [TestCase(nameof(Entity.Field____3__00), /**/  1,     /**/   " 01")]
        [TestCase(nameof(Entity.Field____3__00), /**/ 10,     /**/   " 10")]
        [TestCase(nameof(Entity.Field____3__00), /**/100,     /**/   "100")]
        [TestCase(nameof(Entity.Field_null_000), /**/1.2345d, /**/ "1.235")]
        public void Test(string propName, object value, string expected)
        {
            var ety = new Entity();
            EntityBinder<Entity>.Instance.SetValueTo(ety, propName, value);
            string actual = (string)typeof(Entity).GetProperty(propName).GetValue(ety);
            Assert.AreEqual(expected, actual);
        }

        public class Entity
        {
            [Format("00")] public string Field_null__00 { get; set; }

            [Format(3, "00")] public string Field____3__00 { get; set; }

            [Format("0.000")] public string Field_null_000 { get; set; }
        }
    }
}
