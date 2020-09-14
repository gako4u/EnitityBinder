using Gako.Data.EntityBinder;
using NHibernate.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SInt08__ = System.SByte;
using UInt08__ = System.Byte;
using SInt16__ = System.Int16;
using UInt16__ = System.UInt16;
using SInt32__ = System.Int32;
using UInt32__ = System.UInt32;
using SInt64__ = System.Int64;
using UInt64__ = System.UInt64;
using Single__ = System.Single;
using Double__ = System.Double;
using Decimal_ = System.Decimal;
using Boolean_ = System.Boolean;
using String__ = System.String;
using Gako.Data.EntityBinder.NHibernateUtilities;

namespace Test.Anything
{
    /// <summary>エントリーポイントクラス
    /// </summary>
    internal static partial class Program
    {
        /// <summary>主処理
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void Action001()
        {
            var b = EntityBinder<Entity>.Instance;
            var s = new Source();
            var e = new Entity();
            b.SetValueTo(e, nameof(s.SInt64_SInt64), s.SInt64_SInt64);

            InstanceCreator<Entity>.Create();

            int rowCount = 10000;
            int times = 100;

            int count = 0;
            var results =
                Stopwatch.Start(
                    times
                    , true
                    , () => count = Action(rowCount, () => new AliasToBeanResultTransformer(typeof(Entity))).Count
                    , () => count = Action(rowCount, () => new EntityTransformer<Entity>()).Count
                    , () => count = Action(rowCount, () => new EntityTransformer<Entity>(() => new Entity())).Count
                    , () => count = Action(rowCount, () => new AliasToBeanResultTransformer(typeof(Entity))).Count
                    , () => count = Action(rowCount, () => new EntityTransformer<Entity>()).Count
                    , () => count = Action(rowCount, () => new EntityTransformer<Entity>(() => new Entity())).Count
                );

            Console.WriteLine(count);

            long a = 0;

            results.ForEach(r =>
            {
                if (r.Index == 0 || r.Index == 3)
                {
                    a = r.TimeSpan.Ticks;
                }
                Console.WriteLine("{0}\t{1}", r, (double)r.TimeSpan.Ticks / a);
            });
        }

        private static List<Entity> Action(int rowCount, Func<IResultTransformer> createTransformer)
        {
            var entities = new List<Entity>();

            var t = createTransformer();
            var names = SourceHelper.GetNames();
            foreach (var source in SourceHelper.Sources(rowCount))
            {
                var values = source.GetValues();
                var entity = (Entity)t.TransformTuple(values, names);
                entities.Add(entity);
            }

            return entities;
        }
    }

    internal static class SourceHelper
    {
        public static object[] GetValues(this Source source)
        {
            return SourceHelper.properties.Select(prop => prop.GetValue(source)).ToArray();
        }

        private static readonly PropertyInfo[] properties = typeof(Source).GetProperties();

        public static string[] GetNames()
        {
            return SourceHelper.properties.Select(prop => prop.Name).ToArray();
        }

        public static IEnumerable<Source> Sources(int rowCount)
        {
            for (int i = 0; i < rowCount; i++)
            {
                yield return new Source();
            }
        }
    }

    internal class Source
    {
        public SInt32__ SInt32_SInt32 { get; set; }
        public SInt32__ SInt32_SInt64 { get; set; }
        public SInt64__ SInt64_SInt64 { get; set; }
        public string String_String { get; set; } = "Hello";

        public int Int32Enum { get; set; }
    }

    internal class Entity : Source
    {
        public new SInt64__ SInt32_SInt64 { get; set; }
        public new Int32Enum Int32Enum { get; set; }
    }

    internal enum Int32Enum { }
}
