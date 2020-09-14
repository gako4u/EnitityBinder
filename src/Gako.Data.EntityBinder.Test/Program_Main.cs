using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Routing;
namespace Test.Anything
{
    partial class Program
    {
        /// <summary>エントリーポイント
        /// </summary>
        /// <param name="args"></param>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Main(string[] args)
        {
            try
            {
                Action001();
            }
            catch (Exception e)
            {
                Program.WriteExceptions(e);
            }

            Console.WriteLine("終了");
            //Console.ReadKey();
        }

        private static void WriteExceptions(Exception e)
        {
            while (e != null)
            {
                Console.WriteLine("----");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.StackTrace);
                e = e.InnerException;
            }
        }

        private static void WriteLine(this object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
