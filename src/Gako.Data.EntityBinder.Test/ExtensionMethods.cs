using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Anything
{
    /// <summary>
    /// </summary>
    internal static class ExtensionMethods
    {
        /// <summary>
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        public static void WriteLineAll<TSource>(this IEnumerable<TSource> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static IEnumerable<Exception> Enumerate(this Exception e)
        {
            while (e != null)
            {
                yield return e;
                e = e.InnerException;
            }
        }
    }

    /// <summary>
    /// </summary>
    internal static class StringUtility
    {
        /// <summary>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SingQuote(this string str)
        {
            return "'" + str + "'";
        }

        /// <summary>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string DoubleQuote(this string str)
        {
            return "\"" + str + "\"";
        }
    }

    /// <summary>
    /// </summary>
    internal static class IOUtility
    {
        /// <summary>
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static IEnumerable<string> EnumerateLines(this StreamReader reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                yield return line;
            }
        }
    }

    /// <summary>
    /// </summary>
    public static class EnumerableUtility
    {
        /// <summary>
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> source, params TSource[] second)
        {
            return source.Concat((IEnumerable<TSource>)second);
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="action"></param>
        public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            foreach (var item in source)
            {
                action(item);
            }
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="action"></param>
        public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource, int> action)
        {
            int idx = -1;
            foreach (var item in source)
            {
                action(item, ++idx);
            }
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> ToEnumerable<TSource>(this TSource source)
        {
            yield return source;
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string ToString<TSource>(this IEnumerable<TSource> source, string separator)
        {
            return string.Join(separator, source);
        }
    }
}
