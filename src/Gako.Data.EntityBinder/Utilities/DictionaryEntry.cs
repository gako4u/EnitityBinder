using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder.Utilities
{
    internal static class DictionaryEntry
    {
        public static DictionaryEntry<TKey, TValue> Create<TKey, TValue>(TKey key, TValue value)
        {
            return new DictionaryEntry<TKey, TValue>(key, value);
        }

        public static DictionaryEntry<TKey, TValue> Create<TKey, TValue>(TValue value, Func<TValue, TKey> keySelector)
        {
            return new DictionaryEntry<TKey, TValue>(keySelector(value), value);
        }

        public static IEnumerable<DictionaryEntry<TKey, TValue>> CreateEntries<TKey, TValue>(IEnumerable<TValue> values, Func<TValue, TKey> keySelector)
        {
            return values.Select(value => DictionaryEntry.Create(value, keySelector));
        }
    }

    internal readonly struct DictionaryEntry<TKey, TValue>
    {
        public DictionaryEntry(TKey key, TValue value) : this()
        {
            this.key = key;
            this.value = value;
        }

        public readonly TKey key;

        public readonly TValue value;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append('[');
            if (this.key != null) { sb.Append(this.key.ToString()); }
            sb.Append(", ");
            if (this.value != null) { sb.Append(this.value.ToString()); }
            sb.Append(']');

            return sb.ToString();
        }
    }
}
