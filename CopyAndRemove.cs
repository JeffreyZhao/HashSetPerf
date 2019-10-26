using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace HashSetPerf
{
    public abstract class CopyAndRemove<T>
    {
        private FastHashSet<T> _hashSet;
        private T[] _found;

        protected abstract T[] GetItems();

        [Params(512)]
        public int Size;

        [GlobalSetup]
        public void SetUp()
        {
            _found = GetItems();
            _hashSet = new FastHashSet<T>(_found);
        }

        [Benchmark]
        public bool Remove()
        {
            var res = false;
            var found = _found;
            var copy = new FastHashSet<T>(_hashSet);

            for (var i = 0; i < found.Length; i++)
            {
                res ^= copy.Remove(found[i]);
            }

            return res;
        }
    }
}