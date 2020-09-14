using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder.Utilities
{
    internal class FixedSizeDictionary<TKey, TValue> : FixedSizeDictionaryBase<FixedSizeDictionary<TKey, TValue>, TKey, TValue>
    {
        public FixedSizeDictionary(float loadFactor, IEnumerable<TValue> values, Func<TValue, TKey> keySelector)
            : base(loadFactor, DictionaryEntry.CreateEntries(values, keySelector))
        {
        }
    }
}
