using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gako.Data.EntityBinder.Utilities
{
    internal class TypeKeyDictionary<TValue> : FixedSizeDictionaryBase<TypeKeyDictionary<TValue>, Type, TValue>
    {
        public TypeKeyDictionary(float loadFactor) : base(loadFactor, ArrayUtility<DictionaryEntry<Type, TValue>>.Empty)
        {
            this.loadFactor = loadFactor;
        }

        private TypeKeyDictionary(float loadFactor, IEnumerable<DictionaryEntry<Type, TValue>> entries) : base(loadFactor, entries)
        {
            this.loadFactor = loadFactor;
        }

        private readonly float loadFactor;

        public TypeKeyDictionary<TValue> Add(Type key, TValue value)
        {
            return
                base.Add(
                    this.loadFactor
                    , new[] { DictionaryEntry.Create(key, value) }
                    , (_l, _e) => new TypeKeyDictionary<TValue>(_l, _e)
                );
        }
    }
}
