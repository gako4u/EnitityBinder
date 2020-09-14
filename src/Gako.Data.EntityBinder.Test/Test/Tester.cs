using Gako.Data.EntityBinder;
using Gako.Data.EntityBinder.NHibernateUtilities;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.Anything.Test;

namespace NHibernateUtility.Test
{
    /// <summary>テストドライバー
    /// </summary>
    [TestFixture]
    public abstract class Tester
    {
        public Tester()
        {
            this.entityPropertyName = this.GetPropertyName<Cast___<object>>(ety => ety.FIELD);
        }

        private readonly string entityPropertyName;

        private string GetPropertyName<TObject>(Expression<Func<TObject, object>> expression)
        {
            return ((MemberExpression)(expression).Body).Member.Name;
        }

        protected void Test<TFrom, TTo>(
            TFrom value
            , Expected<TTo> expectedCastImplicitly
            , Expected<TTo> expectedConvert
        )
        {
            this.TestInternal<TFrom, TTo, Cast___<TTo>>(value, expectedCastImplicitly);
            this.TestInternal<TFrom, TTo, Convert<TTo>>(value, expectedConvert);
        }

        protected void TestInternal<TFrom, TTo, TEntity>(TFrom value, Expected<TTo> expected) where TEntity : Cast___<TTo>, new()
        {
            var formatter = new EntityTransformer<TEntity>();
            TEntity ety = null;

            try
            {
                ety = (TEntity)formatter.TransformTuple(new object[] { value }, new[] { this.entityPropertyName });
                if (expected.IsErrorRaised) { Assert.Fail("例外発生せず"); }
            }
            catch
            {
                if (!expected.IsErrorRaised) { throw; }
            }

            if (!expected.IsErrorRaised)
            {
                TTo actual = ety.FIELD;
                Assert.AreEqual(expected.Value?.GetType(), actual?.GetType());
                Assert.AreEqual(expected.Value, actual);
            }
        }

        private string MakeErrorMessage(Exception e, string firstMessage)
        {
            var list = new List<string>();
            list.Add(firstMessage);

            while (e != null)
            {
                list.Add("----");
                list.Add(e.Message);
                list.Add(e.GetType().Name);
                list.Add(e.StackTrace);
                e = e.InnerException;
            }

            return string.Join(Environment.NewLine, list);
        }

        protected class Cast___<T>
        {
            [Convert(ConvertBehavior.Cast)]
            public virtual T FIELD { get; set; }
        }

        protected class Convert<T> : Cast___<T>
        {
            [Convert(ConvertBehavior.Convert)]
            public override T FIELD { get; set; }
        }
    }
}
