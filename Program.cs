using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace Dict
{
    public abstract class HashSetPerf
    {
        protected readonly Dictionary<string, string> _stringDict = new Dictionary<string, string>();
        protected readonly HashSet<string> _stringSet = new HashSet<string>();
        protected readonly FastHashSet<string> _stringFastSet = new FastHashSet<string>();
        
        protected readonly Dictionary<int, int> _intDict = new Dictionary<int, int>();
        protected readonly HashSet<int> _intSet = new HashSet<int>();
        protected readonly FastHashSet<int> _intFastSet = new FastHashSet<int>();
        
        protected readonly Dictionary<Key, Key> _objDict = new Dictionary<Key, Key>();
        protected readonly HashSet<Key> _objSet = new HashSet<Key>();
        protected readonly FastHashSet<Key> _objFastSet = new FastHashSet<Key>();
        
        protected readonly Dictionary<Key, Key> _customDict = new Dictionary<Key, Key>(KeyEqualityComparer.Instance);
        protected readonly HashSet<Key> _customSet = new HashSet<Key>(KeyEqualityComparer.Instance);
        protected readonly FastHashSet<Key> _customFastSet = new FastHashSet<Key>(KeyEqualityComparer.Instance);
        
        protected readonly Key _key1 = new Key(1);
        protected readonly Key _key2 = new Key(2);
        protected readonly Key _key3 = new Key(3);
        protected readonly Key _key4 = new Key(4);
        protected readonly Key _key5 = new Key(5);
        protected readonly Key _key6 = new Key(6);
        protected readonly Key _key7 = new Key(7);
        protected readonly Key _key8 = new Key(8);
        protected readonly Key _key9 = new Key(9);
        protected readonly Key _key10 = new Key(10);
        protected readonly Key _key11 = new Key(11);
        protected readonly Key _key12 = new Key(12);
        protected readonly Key _key13 = new Key(13);
        protected readonly Key _key14 = new Key(14);
        protected readonly Key _key15 = new Key(15);
        protected readonly Key _key16 = new Key(16);
        protected readonly Key _key17 = new Key(17);
        protected readonly Key _key18 = new Key(18);
        protected readonly Key _key19 = new Key(19);
        protected readonly Key _key20 = new Key(20);
        protected readonly Key _key21 = new Key(21);
        protected readonly Key _key22 = new Key(22);
        protected readonly Key _key23 = new Key(23);
        protected readonly Key _key24 = new Key(24);
        protected readonly Key _key25 = new Key(25);
        protected readonly Key _key26 = new Key(26);

        public HashSetPerf()
        {
            var allKeys = new Key[]
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

    }
    
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    [CategoriesColumn]
    public class HashSetPerf_Get : HashSetPerf
    {
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
    
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    [CategoriesColumn]
    public class HashSetPerf_Set : HashSetPerf
    {
        [BenchmarkCategory("String")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void StringDict()
        {
            _stringDict["A"] = "A";
            _stringDict["B"] = "B";
            _stringDict["C"] = "C";
            _stringDict["D"] = "D";
            _stringDict["E"] = "E";
            _stringDict["F"] = "F";
            _stringDict["G"] = "G";
            _stringDict["H"] = "H";
            _stringDict["I"] = "I";
            _stringDict["J"] = "J";
            _stringDict["K"] = "K";
            _stringDict["L"] = "L";
            _stringDict["M"] = "M";
            _stringDict["N"] = "N";
            _stringDict["O"] = "O";
            _stringDict["P"] = "P";
            _stringDict["Q"] = "Q";
            _stringDict["R"] = "R";
            _stringDict["S"] = "S";
            _stringDict["T"] = "T";
            _stringDict["U"] = "U";
            _stringDict["V"] = "V";
            _stringDict["W"] = "W";
            _stringDict["X"] = "X";
            _stringDict["Y"] = "Y";
            _stringDict["Z"] = "Z";
        }
        
        [BenchmarkCategory("String")]
        [Benchmark(OperationsPerInvoke = 26, Baseline = true)]
        public void StringSet()
        {
            _stringSet.Add("A");
            _stringSet.Add("B");
            _stringSet.Add("C");
            _stringSet.Add("D");
            _stringSet.Add("E");
            _stringSet.Add("F");
            _stringSet.Add("G");
            _stringSet.Add("H");
            _stringSet.Add("I");
            _stringSet.Add("J");
            _stringSet.Add("K");
            _stringSet.Add("L");
            _stringSet.Add("M");
            _stringSet.Add("N");
            _stringSet.Add("O");
            _stringSet.Add("P");
            _stringSet.Add("Q");
            _stringSet.Add("R");
            _stringSet.Add("S");
            _stringSet.Add("T");
            _stringSet.Add("U");
            _stringSet.Add("V");
            _stringSet.Add("W");
            _stringSet.Add("X");
            _stringSet.Add("Y");
            _stringSet.Add("Z");
        }
        
        [BenchmarkCategory("String")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void StringFastSet()
        {
            _stringFastSet.Add("A");
            _stringFastSet.Add("B");
            _stringFastSet.Add("C");
            _stringFastSet.Add("D");
            _stringFastSet.Add("E");
            _stringFastSet.Add("F");
            _stringFastSet.Add("G");
            _stringFastSet.Add("H");
            _stringFastSet.Add("I");
            _stringFastSet.Add("J");
            _stringFastSet.Add("K");
            _stringFastSet.Add("L");
            _stringFastSet.Add("M");
            _stringFastSet.Add("N");
            _stringFastSet.Add("O");
            _stringFastSet.Add("P");
            _stringFastSet.Add("Q");
            _stringFastSet.Add("R");
            _stringFastSet.Add("S");
            _stringFastSet.Add("T");
            _stringFastSet.Add("U");
            _stringFastSet.Add("V");
            _stringFastSet.Add("W");
            _stringFastSet.Add("X");
            _stringFastSet.Add("Y");
            _stringFastSet.Add("Z");
        }
        
        [BenchmarkCategory("Int32")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void IntDict()
        {
            _intDict[1] = 1;
            _intDict[2] = 2;
            _intDict[3] = 3;
            _intDict[4] = 4;
            _intDict[5] = 5;
            _intDict[6] = 6;
            _intDict[7] = 7;
            _intDict[8] = 8;
            _intDict[9] = 9;
            _intDict[10] = 10;
            _intDict[11] = 11;
            _intDict[12] = 12;
            _intDict[13] = 13;
            _intDict[14] = 14;
            _intDict[15] = 15;
            _intDict[16] = 16;
            _intDict[17] = 17;
            _intDict[18] = 18;
            _intDict[19] = 19;
            _intDict[20] = 20;
            _intDict[21] = 21;
            _intDict[22] = 22;
            _intDict[23] = 23;
            _intDict[24] = 24;
            _intDict[25] = 25;
            _intDict[26] = 26;
        }

        [BenchmarkCategory("Int32")]
        [Benchmark(OperationsPerInvoke = 26, Baseline = true)]
        public void IntSet()
        {
            _intSet.Add(1);
            _intSet.Add(2);
            _intSet.Add(3);
            _intSet.Add(4);
            _intSet.Add(5);
            _intSet.Add(6);
            _intSet.Add(7);
            _intSet.Add(8);
            _intSet.Add(9);
            _intSet.Add(10);
            _intSet.Add(11);
            _intSet.Add(12);
            _intSet.Add(13);
            _intSet.Add(14);
            _intSet.Add(15);
            _intSet.Add(16);
            _intSet.Add(17);
            _intSet.Add(18);
            _intSet.Add(19);
            _intSet.Add(20);
            _intSet.Add(21);
            _intSet.Add(22);
            _intSet.Add(23);
            _intSet.Add(24);
            _intSet.Add(25);
            _intSet.Add(26);
        }
        
        [BenchmarkCategory("Int32")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void IntFastSet()
        {
            _intFastSet.Add(1);
            _intFastSet.Add(2);
            _intFastSet.Add(3);
            _intFastSet.Add(4);
            _intFastSet.Add(5);
            _intFastSet.Add(6);
            _intFastSet.Add(7);
            _intFastSet.Add(8);
            _intFastSet.Add(9);
            _intFastSet.Add(10);
            _intFastSet.Add(11);
            _intFastSet.Add(12);
            _intFastSet.Add(13);
            _intFastSet.Add(14);
            _intFastSet.Add(15);
            _intFastSet.Add(16);
            _intFastSet.Add(17);
            _intFastSet.Add(18);
            _intFastSet.Add(19);
            _intFastSet.Add(20);
            _intFastSet.Add(21);
            _intFastSet.Add(22);
            _intFastSet.Add(23);
            _intFastSet.Add(24);
            _intFastSet.Add(25);
            _intFastSet.Add(26);
        }
        
        [BenchmarkCategory("Object")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void ObjDict()
        {
            _objDict[_key1] = _key1;
            _objDict[_key2] = _key2;
            _objDict[_key3] = _key3;
            _objDict[_key4] = _key4;
            _objDict[_key5] = _key5;
            _objDict[_key6] = _key6;
            _objDict[_key7] = _key7;
            _objDict[_key8] = _key8;
            _objDict[_key9] = _key9;
            _objDict[_key10] = _key10;
            _objDict[_key11] = _key11;
            _objDict[_key12] = _key12;
            _objDict[_key13] = _key13;
            _objDict[_key14] = _key14;
            _objDict[_key15] = _key15;
            _objDict[_key16] = _key16;
            _objDict[_key17] = _key17;
            _objDict[_key18] = _key18;
            _objDict[_key19] = _key19;
            _objDict[_key20] = _key20;
            _objDict[_key21] = _key21;
            _objDict[_key22] = _key22;
            _objDict[_key23] = _key23;
            _objDict[_key24] = _key24;
            _objDict[_key25] = _key25;
            _objDict[_key26] = _key26;
        }
        
        [BenchmarkCategory("Object")]
        [Benchmark(OperationsPerInvoke = 26, Baseline = true)]
        public void ObjSet()
        {
            _objSet.Add(_key1);
            _objSet.Add(_key2);
            _objSet.Add(_key3);
            _objSet.Add(_key4);
            _objSet.Add(_key5);
            _objSet.Add(_key6);
            _objSet.Add(_key7);
            _objSet.Add(_key8);
            _objSet.Add(_key9);
            _objSet.Add(_key10);
            _objSet.Add(_key11);
            _objSet.Add(_key12);
            _objSet.Add(_key13);
            _objSet.Add(_key14);
            _objSet.Add(_key15);
            _objSet.Add(_key16);
            _objSet.Add(_key17);
            _objSet.Add(_key18);
            _objSet.Add(_key19);
            _objSet.Add(_key20);
            _objSet.Add(_key21);
            _objSet.Add(_key22);
            _objSet.Add(_key23);
            _objSet.Add(_key24);
            _objSet.Add(_key25);
            _objSet.Add(_key26);
        }
        
        [BenchmarkCategory("Object")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void ObjFastSet()
        {
            _objFastSet.Add(_key1);
            _objFastSet.Add(_key2);
            _objFastSet.Add(_key3);
            _objFastSet.Add(_key4);
            _objFastSet.Add(_key5);
            _objFastSet.Add(_key6);
            _objFastSet.Add(_key7);
            _objFastSet.Add(_key8);
            _objFastSet.Add(_key9);
            _objFastSet.Add(_key10);
            _objFastSet.Add(_key11);
            _objFastSet.Add(_key12);
            _objFastSet.Add(_key13);
            _objFastSet.Add(_key14);
            _objFastSet.Add(_key15);
            _objFastSet.Add(_key16);
            _objFastSet.Add(_key17);
            _objFastSet.Add(_key18);
            _objFastSet.Add(_key19);
            _objFastSet.Add(_key20);
            _objFastSet.Add(_key21);
            _objFastSet.Add(_key22);
            _objFastSet.Add(_key23);
            _objFastSet.Add(_key24);
            _objFastSet.Add(_key25);
            _objFastSet.Add(_key26);
        }
        
        [BenchmarkCategory("Custom")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void CustomDict()
        {
            _customDict[_key1] = _key1;
            _customDict[_key2] = _key2;
            _customDict[_key3] = _key3;
            _customDict[_key4] = _key4;
            _customDict[_key5] = _key5;
            _customDict[_key6] = _key6;
            _customDict[_key7] = _key7;
            _customDict[_key8] = _key8;
            _customDict[_key9] = _key9;
            _customDict[_key10] = _key10;
            _customDict[_key11] = _key11;
            _customDict[_key12] = _key12;
            _customDict[_key13] = _key13;
            _customDict[_key14] = _key14;
            _customDict[_key15] = _key15;
            _customDict[_key16] = _key16;
            _customDict[_key17] = _key17;
            _customDict[_key18] = _key18;
            _customDict[_key19] = _key19;
            _customDict[_key20] = _key20;
            _customDict[_key21] = _key21;
            _customDict[_key22] = _key22;
            _customDict[_key23] = _key23;
            _customDict[_key24] = _key24;
            _customDict[_key25] = _key25;
            _customDict[_key26] = _key26;
        }
        
        [BenchmarkCategory("Custom")]
        [Benchmark(OperationsPerInvoke = 26, Baseline = true)]
        public void CustomSet()
        {
            _customSet.Add(_key1);
            _customSet.Add(_key2);
            _customSet.Add(_key3);
            _customSet.Add(_key4);
            _customSet.Add(_key5);
            _customSet.Add(_key6);
            _customSet.Add(_key7);
            _customSet.Add(_key8);
            _customSet.Add(_key9);
            _customSet.Add(_key10);
            _customSet.Add(_key11);
            _customSet.Add(_key12);
            _customSet.Add(_key13);
            _customSet.Add(_key14);
            _customSet.Add(_key15);
            _customSet.Add(_key16);
            _customSet.Add(_key17);
            _customSet.Add(_key18);
            _customSet.Add(_key19);
            _customSet.Add(_key20);
            _customSet.Add(_key21);
            _customSet.Add(_key22);
            _customSet.Add(_key23);
            _customSet.Add(_key24);
            _customSet.Add(_key25);
            _customSet.Add(_key26);
        }
        
        [BenchmarkCategory("Custom")]
        [Benchmark(OperationsPerInvoke = 26)]
        public void CustomFastSet()
        {
            _customFastSet.Add(_key1);
            _customFastSet.Add(_key2);
            _customFastSet.Add(_key3);
            _customFastSet.Add(_key4);
            _customFastSet.Add(_key5);
            _customFastSet.Add(_key6);
            _customFastSet.Add(_key7);
            _customFastSet.Add(_key8);
            _customFastSet.Add(_key9);
            _customFastSet.Add(_key10);
            _customFastSet.Add(_key11);
            _customFastSet.Add(_key12);
            _customFastSet.Add(_key13);
            _customFastSet.Add(_key14);
            _customFastSet.Add(_key15);
            _customFastSet.Add(_key16);
            _customFastSet.Add(_key17);
            _customFastSet.Add(_key18);
            _customFastSet.Add(_key19);
            _customFastSet.Add(_key20);
            _customFastSet.Add(_key21);
            _customFastSet.Add(_key22);
            _customFastSet.Add(_key23);
            _customFastSet.Add(_key24);
            _customFastSet.Add(_key25);
            _customFastSet.Add(_key26);
        }
    }
    
    public class KeyEqualityComparer : EqualityComparer<Key>
    {
        public static readonly KeyEqualityComparer Instance = new KeyEqualityComparer();

        public override bool Equals(Key x, Key y)
        {
            return x == y;
        }

        public override int GetHashCode(Key x)
        {
            return x.HashCode;
        }
    }
    
    public class Key
    {
        public readonly int HashCode;
        
        public Key(int hashCode)
        {
            HashCode = hashCode;
        }
        
        public override int GetHashCode()
        {
            return HashCode;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
