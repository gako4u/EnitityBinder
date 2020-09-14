using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder.Utilities
{
    internal class FixedSizeDictionaryBase<TSelf, TKey, TValue> : IEnumerable<DictionaryEntry<TKey, TValue>>
        where TSelf : FixedSizeDictionaryBase<TSelf, TKey, TValue>
    {
        protected FixedSizeDictionaryBase(float loadFactor, IEnumerable<DictionaryEntry<TKey, TValue>> entries)
        {
            var entryList = (entries as IList<DictionaryEntry<TKey, TValue>>) ?? entries.ToList();
            this.Count = entryList.Count;
            this.Capacity = 1 << this.CalcExponentOfTwoForCapacity(loadFactor, entryList.Count);
            this.mask = this.Capacity - 1;
            this.buckets = this.CreateBuckets(this.Capacity, this.mask, entryList);
        }

        protected FixedSizeDictionaryBase(int exponentOfTwoForCapacity, IEnumerable<DictionaryEntry<TKey, TValue>> entries)
        {
            var entryList = (entries as IList<DictionaryEntry<TKey, TValue>>) ?? entries.ToList();
            this.Count = entryList.Count;
            this.Capacity = 1 << exponentOfTwoForCapacity;
            this.mask = this.Capacity - 1;
            this.buckets = this.CreateBuckets(this.Capacity, this.mask, entryList);
        }

        private readonly DictionaryEntry<TKey, TValue>[][] buckets;

        private readonly int mask;

        public int Capacity { get; }

        public int Count { get; }

        public IEnumerable<TValue> Values => this.Select(entry => entry.value);

        public TValue this[TKey key]
        {
            get
            {
                var bucket = FixedSizeDictionaryBase<TSelf, TKey, TValue>.getBucket(this, key);
                return
                    bucket == null
                        ? throw new KeyNotFoundException()
                        : this.GetValue(bucket, key);
            }
        }

        private DictionaryEntry<TKey, TValue>[][] CreateBuckets(int capacity, int mask, IList<DictionaryEntry<TKey, TValue>> entries)
        {
            var tmpBuckets = new List<DictionaryEntry<TKey, TValue>>[capacity];

            foreach (var entry in entries)
            {
                var hashCode = entry.key.GetHashCode();
                int bucketIndex = hashCode & mask;
                ref var bucket = ref tmpBuckets[bucketIndex];
                if (bucket == null) { bucket = new List<DictionaryEntry<TKey, TValue>>(); }
                int idx = bucket.FindIndex(ety => ety.key.Equals(entry.key));
                if (idx == -1)
                {
                    bucket.Add(entry);
                }
                else
                {
                    bucket[idx] = entry;
                }
            }

#if DEBUG
            try
            {
                System.Diagnostics.Debug.WriteLine("Capacity: {0}", this.Capacity);
                int bucketIndex = -1;
                foreach (var bucket in tmpBuckets)
                {
                    System.Diagnostics.Debug.Write(string.Format("Buckets[{0}]:", ++bucketIndex));
                    if (bucket == null)
                    {
                        System.Diagnostics.Debug.Write(" Empty");
                    }
                    else
                    {
                        foreach (var entry in bucket)
                        {
                            System.Diagnostics.Debug.Write(string.Format(" [{0}]", entry.key));
                        }
                    }
                    System.Diagnostics.Debug.WriteLine(string.Empty);
                }

            }
            catch { }
#endif

            return
                tmpBuckets
                    .Select(bucket => bucket?.ToArray())
                    .ToArray();
        }

        private int CalcExponentOfTwoForCapacity(float loadFactor, int entryCount)
        {
            int required = (int)(entryCount / loadFactor);

            var capacity = 1;
            int exponentOfTwoForCapacity = 0;
            while (capacity < required)
            {
                capacity <<= 1;
                exponentOfTwoForCapacity++;
            }

            return exponentOfTwoForCapacity;
        }

        protected TSelf Add(float loadFactor, IEnumerable<DictionaryEntry<TKey, TValue>> entries, Func<float, IEnumerable<DictionaryEntry<TKey, TValue>>, TSelf> creator)
        {
            return creator(loadFactor, this.Concat(entries));
        }

        protected TSelf Add(int exponentOfTwoForCapacity, IEnumerable<DictionaryEntry<TKey, TValue>> entries, Func<int, IEnumerable<DictionaryEntry<TKey, TValue>>, TSelf> creator)
        {
            return creator(exponentOfTwoForCapacity, this.Concat(entries));
        }

        public bool TryGet(TKey key, out TValue value)
        {
            var bucket = FixedSizeDictionaryBase<TSelf, TKey, TValue>.getBucket(this, key);
            if (bucket == null)
            {
                value = default;
                return false;
            }
            else
            {
                value = this.GetValue(bucket, key);
                return true;
            }
        }

        public TValue GetOrDefault(TKey key, TValue defaultValue)
        {
            var bucket = FixedSizeDictionaryBase<TSelf, TKey, TValue>.getBucket(this, key);
            return
                bucket == null
                    ? defaultValue
                    : this.GetValue(bucket, key);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private TValue GetValue(DictionaryEntry<TKey, TValue>[] entries, TKey key)
        {
            // 最初の要素
            {
                ref var ety = ref entries[0];
                if (key.Equals(ety.key))
                {
                    return ety.value;
                }
            }

            // 二つ目以降の要素
            for (int i = 1; i < entries.Length; i++)
            {
                ref var ety = ref entries[i];
                if (key.Equals(ety.key))
                {
                    return ety.value;
                }
            }

            return default;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(this.GetType().Name);
            sb.Append('<');
            sb.Append(typeof(TKey).Name);
            sb.Append(", ");
            sb.Append(typeof(TValue).Name);
            sb.Append('>');

            return sb.ToString();
        }

        public IEnumerator<DictionaryEntry<TKey, TValue>> GetEnumerator()
        {
            return this.buckets.Where(bucket => bucket != null).SelectMany(entry => entry).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private static readonly Func<FixedSizeDictionaryBase<TSelf, TKey, TValue>, TKey, DictionaryEntry<TKey, TValue>[]> getBucket = FixedSizeDictionaryBase<TSelf, TKey, TValue>.CreateGetBucket();

        private static Func<FixedSizeDictionaryBase<TSelf, TKey, TValue>, TKey, DictionaryEntry<TKey, TValue>[]> CreateGetBucket()
        {
            // (obj, key) => obj.buckets[key.GetHashCode() & obj.mask]

            var fieldBuckets = typeof(FixedSizeDictionaryBase<TSelf, TKey, TValue>).GetField(nameof(FixedSizeDictionaryBase<TSelf, TKey, TValue>.buckets), BindingFlags.Instance | BindingFlags.NonPublic);
            var fieldMask = typeof(FixedSizeDictionaryBase<TSelf, TKey, TValue>).GetField(nameof(FixedSizeDictionaryBase<TSelf, TKey, TValue>.mask), BindingFlags.Instance | BindingFlags.NonPublic);

            var parameterObj = Expression.Parameter(typeof(FixedSizeDictionaryBase<TSelf, TKey, TValue>), "obj");
            var parameterKey = Expression.Parameter(typeof(TKey), "key");

            var buckets = Expression.Field(parameterObj, fieldBuckets);

            var hashCode = Expression.Call(parameterKey, FixedSizeDictionaryHelper.MethodGetHashCode);
            var mask = Expression.Field(parameterObj, fieldMask);

            var bucketsIndex = Expression.And(hashCode, mask);

            var body = Expression.ArrayIndex(buckets, bucketsIndex);

            var lambda = Expression.Lambda<Func<FixedSizeDictionaryBase<TSelf, TKey, TValue>, TKey, DictionaryEntry<TKey, TValue>[]>>(body, parameterObj, parameterKey);

            var func = lambda.Compile();
            return func;
        }
    }

    internal static class FixedSizeDictionaryHelper
    {
        public static readonly MethodInfo MethodGetHashCode = typeof(object).GetMethod(nameof(object.GetHashCode), Type.EmptyTypes);
    }
}
