using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace Dict
{
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    [CategoriesColumn]
    public class HashPerf
    {
        private readonly Dictionary<string, string> _stringDict = new Dictionary<string, string>();
        private readonly HashSet<string> _stringSet = new HashSet<string>();
        private readonly FastHashSet<string> _stringFastSet = new FastHashSet<string>();
        
        private readonly Dictionary<int, int> _intDict = new Dictionary<int, int>();
        private readonly HashSet<int> _intSet = new HashSet<int>();
        private readonly FastHashSet<int> _intFastSet = new FastHashSet<int>();
        
        private readonly Dictionary<object, object> _objDict = new Dictionary<object, object>();
        private readonly HashSet<object> _objSet = new HashSet<object>();
        private readonly FastHashSet<object> _objFastSet = new FastHashSet<object>();
        
        private readonly Dictionary<object, object> _customDict = new Dictionary<object, object>(CustomEqualityComparer.Instance);
        private readonly HashSet<object> _customSet = new HashSet<object>(CustomEqualityComparer.Instance);
        private readonly FastHashSet<object> _customFastSet = new FastHashSet<object>(CustomEqualityComparer.Instance);
        
        private readonly object _key1 = new object();
        private readonly object _key2 = new object();
        private readonly object _key3 = new object();
        private readonly object _key4 = new object();
        private readonly object _key5 = new object();
        private readonly object _key6 = new object();
        private readonly object _key7 = new object();
        private readonly object _key8 = new object();
        private readonly object _key9 = new object();
        private readonly object _key10 = new object();
        private readonly object _key11 = new object();
        private readonly object _key12 = new object();
        private readonly object _key13 = new object();
        private readonly object _key14 = new object();
        private readonly object _key15 = new object();
        private readonly object _key16 = new object();
        private readonly object _key17 = new object();
        private readonly object _key18 = new object();
        private readonly object _key19 = new object();
        private readonly object _key20 = new object();
        private readonly object _key21 = new object();
        private readonly object _key22 = new object();
        private readonly object _key23 = new object();
        private readonly object _key24 = new object();
        private readonly object _key25 = new object();
        private readonly object _key26 = new object();

        public HashPerf()
        {
            var allKeys = new object[]
            {
                _key1, _key2, _key3, _key4, _key5, _key6, _key7,
                _key8, _key9, _key10, _key11, _key12, _key13, _key14,
                _key15, _key16, _key17, _key18, _key19, _key20, _key21,
                _key22, _key23, _key24, _key25, _key26
            };
            
            for (var i = 0; i < 26; i++)
            {
                var str = ((char)('A' + i)).ToString();
                
                _stringDict.Add(str, str);
                _stringSet.Add(str);
                _stringFastSet.Add(str);
                
                _intDict.Add(i, i);
                _intSet.Add(i);
                _intFastSet.Add(i);
                
                var key = allKeys[i];
                
                _objDict.Add(key, key);
                _objSet.Add(key);
                _objFastSet.Add(key);
                
                _customDict.Add(key, key);
                _customSet.Add(key);
                _customFastSet.Add(key);
            }
        }

        [BenchmarkCategory("String")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void StringDict()
        {
            _stringDict.ContainsKey("A");
            _stringDict.ContainsKey("B");
            _stringDict.ContainsKey("C");
            _stringDict.ContainsKey("D");
            _stringDict.ContainsKey("E");
            _stringDict.ContainsKey("F");
            _stringDict.ContainsKey("G");
            _stringDict.ContainsKey("H");
            _stringDict.ContainsKey("I");
            _stringDict.ContainsKey("J");
            _stringDict.ContainsKey("K");
            _stringDict.ContainsKey("L");
            _stringDict.ContainsKey("M");
            _stringDict.ContainsKey("N");
            _stringDict.ContainsKey("O");
            _stringDict.ContainsKey("P");
            _stringDict.ContainsKey("Q");
            _stringDict.ContainsKey("R");
            _stringDict.ContainsKey("S");
            _stringDict.ContainsKey("T");
            _stringDict.ContainsKey("U");
            _stringDict.ContainsKey("V");
            _stringDict.ContainsKey("W");
            _stringDict.ContainsKey("X");
            _stringDict.ContainsKey("Y");
            _stringDict.ContainsKey("Z");
        }
        
        [BenchmarkCategory("String")]
        [Benchmark(OperationsPerInvoke = 26, Baseline = true)]
        public void StringSet()
        {
            _stringSet.Contains("A");
            _stringSet.Contains("B");
            _stringSet.Contains("C");
            _stringSet.Contains("D");
            _stringSet.Contains("E");
            _stringSet.Contains("F");
            _stringSet.Contains("G");
            _stringSet.Contains("H");
            _stringSet.Contains("I");
            _stringSet.Contains("J");
            _stringSet.Contains("K");
            _stringSet.Contains("L");
            _stringSet.Contains("M");
            _stringSet.Contains("N");
            _stringSet.Contains("O");
            _stringSet.Contains("P");
            _stringSet.Contains("Q");
            _stringSet.Contains("R");
            _stringSet.Contains("S");
            _stringSet.Contains("T");
            _stringSet.Contains("U");
            _stringSet.Contains("V");
            _stringSet.Contains("W");
            _stringSet.Contains("X");
            _stringSet.Contains("Y");
            _stringSet.Contains("Z");
        }
        
        [BenchmarkCategory("String")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void StringFastSet()
        {
            _stringFastSet.Contains("A");
            _stringFastSet.Contains("B");
            _stringFastSet.Contains("C");
            _stringFastSet.Contains("D");
            _stringFastSet.Contains("E");
            _stringFastSet.Contains("F");
            _stringFastSet.Contains("G");
            _stringFastSet.Contains("H");
            _stringFastSet.Contains("I");
            _stringFastSet.Contains("J");
            _stringFastSet.Contains("K");
            _stringFastSet.Contains("L");
            _stringFastSet.Contains("M");
            _stringFastSet.Contains("N");
            _stringFastSet.Contains("O");
            _stringFastSet.Contains("P");
            _stringFastSet.Contains("Q");
            _stringFastSet.Contains("R");
            _stringFastSet.Contains("S");
            _stringFastSet.Contains("T");
            _stringFastSet.Contains("U");
            _stringFastSet.Contains("V");
            _stringFastSet.Contains("W");
            _stringFastSet.Contains("X");
            _stringFastSet.Contains("Y");
            _stringFastSet.Contains("Z");
        }
        
        [BenchmarkCategory("Int32")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void IntDict()
        {
            _intDict.ContainsKey(1);
            _intDict.ContainsKey(2);
            _intDict.ContainsKey(3);
            _intDict.ContainsKey(4);
            _intDict.ContainsKey(5);
            _intDict.ContainsKey(6);
            _intDict.ContainsKey(7);
            _intDict.ContainsKey(8);
            _intDict.ContainsKey(9);
            _intDict.ContainsKey(10);
            _intDict.ContainsKey(11);
            _intDict.ContainsKey(12);
            _intDict.ContainsKey(13);
            _intDict.ContainsKey(14);
            _intDict.ContainsKey(15);
            _intDict.ContainsKey(16);
            _intDict.ContainsKey(17);
            _intDict.ContainsKey(18);
            _intDict.ContainsKey(19);
            _intDict.ContainsKey(20);
            _intDict.ContainsKey(21);
            _intDict.ContainsKey(22);
            _intDict.ContainsKey(23);
            _intDict.ContainsKey(24);
            _intDict.ContainsKey(25);
            _intDict.ContainsKey(26);
        }

        [BenchmarkCategory("Int32")]
        [Benchmark(OperationsPerInvoke = 26, Baseline = true)]
        public void IntSet()
        {
            _intSet.Contains(1);
            _intSet.Contains(2);
            _intSet.Contains(3);
            _intSet.Contains(4);
            _intSet.Contains(5);
            _intSet.Contains(6);
            _intSet.Contains(7);
            _intSet.Contains(8);
            _intSet.Contains(9);
            _intSet.Contains(10);
            _intSet.Contains(11);
            _intSet.Contains(12);
            _intSet.Contains(13);
            _intSet.Contains(14);
            _intSet.Contains(15);
            _intSet.Contains(16);
            _intSet.Contains(17);
            _intSet.Contains(18);
            _intSet.Contains(19);
            _intSet.Contains(20);
            _intSet.Contains(21);
            _intSet.Contains(22);
            _intSet.Contains(23);
            _intSet.Contains(24);
            _intSet.Contains(25);
            _intSet.Contains(26);
        }
        
        [BenchmarkCategory("Int32")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void IntFastSet()
        {
            _intFastSet.Contains(1);
            _intFastSet.Contains(2);
            _intFastSet.Contains(3);
            _intFastSet.Contains(4);
            _intFastSet.Contains(5);
            _intFastSet.Contains(6);
            _intFastSet.Contains(7);
            _intFastSet.Contains(8);
            _intFastSet.Contains(9);
            _intFastSet.Contains(10);
            _intFastSet.Contains(11);
            _intFastSet.Contains(12);
            _intFastSet.Contains(13);
            _intFastSet.Contains(14);
            _intFastSet.Contains(15);
            _intFastSet.Contains(16);
            _intFastSet.Contains(17);
            _intFastSet.Contains(18);
            _intFastSet.Contains(19);
            _intFastSet.Contains(20);
            _intFastSet.Contains(21);
            _intFastSet.Contains(22);
            _intFastSet.Contains(23);
            _intFastSet.Contains(24);
            _intFastSet.Contains(25);
            _intFastSet.Contains(26);
        }
        
        [BenchmarkCategory("Object")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void ObjDict()
        {
            _objDict.ContainsKey(_key1);
            _objDict.ContainsKey(_key2);
            _objDict.ContainsKey(_key3);
            _objDict.ContainsKey(_key4);
            _objDict.ContainsKey(_key5);
            _objDict.ContainsKey(_key6);
            _objDict.ContainsKey(_key7);
            _objDict.ContainsKey(_key8);
            _objDict.ContainsKey(_key9);
            _objDict.ContainsKey(_key10);
            _objDict.ContainsKey(_key11);
            _objDict.ContainsKey(_key12);
            _objDict.ContainsKey(_key13);
            _objDict.ContainsKey(_key14);
            _objDict.ContainsKey(_key15);
            _objDict.ContainsKey(_key16);
            _objDict.ContainsKey(_key17);
            _objDict.ContainsKey(_key18);
            _objDict.ContainsKey(_key19);
            _objDict.ContainsKey(_key20);
            _objDict.ContainsKey(_key21);
            _objDict.ContainsKey(_key22);
            _objDict.ContainsKey(_key23);
            _objDict.ContainsKey(_key24);
            _objDict.ContainsKey(_key25);
            _objDict.ContainsKey(_key26);
        }
        
        [BenchmarkCategory("Object")]
        [Benchmark(OperationsPerInvoke = 26, Baseline = true)]
        public void ObjSet()
        {
            _objSet.Contains(_key1);
            _objSet.Contains(_key2);
            _objSet.Contains(_key3);
            _objSet.Contains(_key4);
            _objSet.Contains(_key5);
            _objSet.Contains(_key6);
            _objSet.Contains(_key7);
            _objSet.Contains(_key8);
            _objSet.Contains(_key9);
            _objSet.Contains(_key10);
            _objSet.Contains(_key11);
            _objSet.Contains(_key12);
            _objSet.Contains(_key13);
            _objSet.Contains(_key14);
            _objSet.Contains(_key15);
            _objSet.Contains(_key16);
            _objSet.Contains(_key17);
            _objSet.Contains(_key18);
            _objSet.Contains(_key19);
            _objSet.Contains(_key20);
            _objSet.Contains(_key21);
            _objSet.Contains(_key22);
            _objSet.Contains(_key23);
            _objSet.Contains(_key24);
            _objSet.Contains(_key25);
            _objSet.Contains(_key26);
        }
        
        [BenchmarkCategory("Object")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void ObjFastSet()
        {
            _objFastSet.Contains(_key1);
            _objFastSet.Contains(_key2);
            _objFastSet.Contains(_key3);
            _objFastSet.Contains(_key4);
            _objFastSet.Contains(_key5);
            _objFastSet.Contains(_key6);
            _objFastSet.Contains(_key7);
            _objFastSet.Contains(_key8);
            _objFastSet.Contains(_key9);
            _objFastSet.Contains(_key10);
            _objFastSet.Contains(_key11);
            _objFastSet.Contains(_key12);
            _objFastSet.Contains(_key13);
            _objFastSet.Contains(_key14);
            _objFastSet.Contains(_key15);
            _objFastSet.Contains(_key16);
            _objFastSet.Contains(_key17);
            _objFastSet.Contains(_key18);
            _objFastSet.Contains(_key19);
            _objFastSet.Contains(_key20);
            _objFastSet.Contains(_key21);
            _objFastSet.Contains(_key22);
            _objFastSet.Contains(_key23);
            _objFastSet.Contains(_key24);
            _objFastSet.Contains(_key25);
            _objFastSet.Contains(_key26);
        }
        
        [BenchmarkCategory("Custom")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void CustomDict()
        {
            _customDict.ContainsKey(_key1);
            _customDict.ContainsKey(_key2);
            _customDict.ContainsKey(_key3);
            _customDict.ContainsKey(_key4);
            _customDict.ContainsKey(_key5);
            _customDict.ContainsKey(_key6);
            _customDict.ContainsKey(_key7);
            _customDict.ContainsKey(_key8);
            _customDict.ContainsKey(_key9);
            _customDict.ContainsKey(_key10);
            _customDict.ContainsKey(_key11);
            _customDict.ContainsKey(_key12);
            _customDict.ContainsKey(_key13);
            _customDict.ContainsKey(_key14);
            _customDict.ContainsKey(_key15);
            _customDict.ContainsKey(_key16);
            _customDict.ContainsKey(_key17);
            _customDict.ContainsKey(_key18);
            _customDict.ContainsKey(_key19);
            _customDict.ContainsKey(_key20);
            _customDict.ContainsKey(_key21);
            _customDict.ContainsKey(_key22);
            _customDict.ContainsKey(_key23);
            _customDict.ContainsKey(_key24);
            _customDict.ContainsKey(_key25);
            _customDict.ContainsKey(_key26);
        }
        
        [BenchmarkCategory("Custom")]
        [Benchmark(OperationsPerInvoke = 26, Baseline = true)]
        public void CustomSet()
        {
            _customSet.Contains(_key1);
            _customSet.Contains(_key2);
            _customSet.Contains(_key3);
            _customSet.Contains(_key4);
            _customSet.Contains(_key5);
            _customSet.Contains(_key6);
            _customSet.Contains(_key7);
            _customSet.Contains(_key8);
            _customSet.Contains(_key9);
            _customSet.Contains(_key10);
            _customSet.Contains(_key11);
            _customSet.Contains(_key12);
            _customSet.Contains(_key13);
            _customSet.Contains(_key14);
            _customSet.Contains(_key15);
            _customSet.Contains(_key16);
            _customSet.Contains(_key17);
            _customSet.Contains(_key18);
            _customSet.Contains(_key19);
            _customSet.Contains(_key20);
            _customSet.Contains(_key21);
            _customSet.Contains(_key22);
            _customSet.Contains(_key23);
            _customSet.Contains(_key24);
            _customSet.Contains(_key25);
            _customSet.Contains(_key26);
        }
        
        [BenchmarkCategory("Custom")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void CustomFastSet()
        {
            _customFastSet.Contains(_key1);
            _customFastSet.Contains(_key2);
            _customFastSet.Contains(_key3);
            _customFastSet.Contains(_key4);
            _customFastSet.Contains(_key5);
            _customFastSet.Contains(_key6);
            _customFastSet.Contains(_key7);
            _customFastSet.Contains(_key8);
            _customFastSet.Contains(_key9);
            _customFastSet.Contains(_key10);
            _customFastSet.Contains(_key11);
            _customFastSet.Contains(_key12);
            _customFastSet.Contains(_key13);
            _customFastSet.Contains(_key14);
            _customFastSet.Contains(_key15);
            _customFastSet.Contains(_key16);
            _customFastSet.Contains(_key17);
            _customFastSet.Contains(_key18);
            _customFastSet.Contains(_key19);
            _customFastSet.Contains(_key20);
            _customFastSet.Contains(_key21);
            _customFastSet.Contains(_key22);
            _customFastSet.Contains(_key23);
            _customFastSet.Contains(_key24);
            _customFastSet.Contains(_key25);
            _customFastSet.Contains(_key26);
        }
    }
    
    public class CustomEqualityComparer : EqualityComparer<object>
    {
        public static readonly CustomEqualityComparer Instance = new CustomEqualityComparer();

        public override bool Equals(object x, object y)
        {
            return x == y;
        }

        public override int GetHashCode(object x)
        {
            return x.GetHashCode();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<HashPerf>();
        }
    }
}
