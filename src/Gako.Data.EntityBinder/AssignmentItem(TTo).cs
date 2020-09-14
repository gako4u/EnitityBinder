using Gako.Data.EntityBinder.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder
{
    internal class AssignmentItem<TTo>
    {
        public static TypeKeyDictionary<Convert<TTo>> cast___Dic = new TypeKeyDictionary<Convert<TTo>>(Assignment.loadFactor);

        public static TypeKeyDictionary<Convert<TTo>> convertDic = new TypeKeyDictionary<Convert<TTo>>(Assignment.loadFactor);

        public static void Add<TFrom>(Convert<TTo> cast, Convert<TTo> convert)
        {
            AssignmentItem<TTo>.cast___Dic = AssignmentItem<TTo>.cast___Dic.Add(typeof(TFrom), cast);
            AssignmentItem<TTo>.convertDic = AssignmentItem<TTo>.convertDic.Add(typeof(TFrom), convert);
        }
    }
}
