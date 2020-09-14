using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder
{
    internal class AssignmentItem<TFrom, TTo>
    {
        public static Convert<TTo> cast = null;

        public static Convert<TTo> convert = null;

        public static void Set(Convert<TTo> cast, Convert<TTo> convert)
        {
            AssignmentItem<TFrom, TTo>.cast = cast;
            AssignmentItem<TFrom, TTo>.convert = convert;
        }
    }
}
