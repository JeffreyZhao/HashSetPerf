using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System.Collections.Generic
{
    public static class NonRandomizedStringEqualityComparer
    {
        public static IEqualityComparer<string> Default
        {
            get{ return EqualityComparer<string>.Default; }
        }
    }

    public interface ICollectionDebugView<T> { }

    public class DictionaryKeyCollectionDebugView<TKey, TValue> { }

    public class DictionaryValueCollectionDebugView<TKey, TValue> { }

    public class IDictionaryDebugView<TKey, TValue> { }

    public class HashSetEqualityComparer<T> : IEqualityComparer<FastHashSet<T>>
    {
        public bool Equals([AllowNull] FastHashSet<T> x, [AllowNull] FastHashSet<T> y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode([DisallowNull] FastHashSet<T> obj)
        {
            throw new NotImplementedException();
        }
    }
}

namespace System.Diagnostics
{
    public class SR
    {
       public static readonly string InvalidOperation_EnumFailedVersion = "";
       public static readonly string InvalidOperation_ConcurrentOperationsNotSupported = "";
       public static readonly string Arg_ArrayPlusOffTooSmall = "";
       public static readonly string Arg_HTCapacityOverflow = "";
       public static readonly string Serialization_MissingKeys = "";
       public static readonly string ArgumentOutOfRange_NeedNonNegNum = "";
       public static readonly string Arg_HSCapacityOverflow = "";
       public static readonly string InvalidOperation_EnumOpCantHappen = "";
    }

    public static class ThrowHelper
    {
        public static void ThrowArgumentNullException(string argName)
        {
            throw new ArgumentNullException(argName);
        }

        public static void ThrowKeyNotFoundException(object key)
        {
            throw new KeyNotFoundException("key");
        }

        public static void ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
        {
            throw new IndexOutOfRangeException();
        }

        public static void ThrowArgumentException(string msg)
        {
            throw new ArgumentException(msg);
        }

        public static void ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
        {
            throw new InvalidOperationException();
        }

        public static void ThrowAddingDuplicateWithKeyArgumentException(object key)
        {
            throw new ArgumentException();
        }

        public static void ThrowSerializationException(string msg)
        {
            throw new Exception(msg);
        }

        public static void ThrowArgumentException_Argument_InvalidArrayType()
        {
            throw new ArgumentException();
        }    

        public static void ThrowArgumentOutOfRangeException(string argName)
        {
            throw new ArgumentOutOfRangeException(argName);
        }

        public static void IfNullAndNullsAreIllegalThenThrow<TValue>(object value = null, object arg2 = null)
        {
            throw new Exception();
        }

        public static void ThrowWrongValueTypeArgumentException(object arg1, object arg)
        {
            throw new Exception();
        }

        public static void ThrowWrongKeyTypeArgumentException(object arg1, object arg)
        {
            throw new Exception();
        }

        public static void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
        {
            throw new Exception();
        }

        public static void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen()
        {
            throw new Exception();
        }

        public static void ThrowNotSupportedException(string message)
        {
            throw new NotSupportedException();
        }
    }

    public static class ExceptionArgument
    {
        public const string dictionary = "dictionary";
        public const string collection = "collection";
        public const string array = "array";
        public const string capacity = "capacity";
        public const string key = "key";
        public const string info = "info";
        public const string value = "value";
    }

    public static class ExceptionResource
    {
        public const string Arg_ArrayPlusOffTooSmall = "";
        public const string Serialization_MissingKeys = "";
        public const string Serialization_NullKey = "";
        public const string NotSupported_KeyCollectionSet = "";
        public const string Arg_NonZeroLowerBound = "";
        public const string Arg_RankMultiDimNotSupported = "";
        public const string NotSupported_ValueCollectionSet = "";
    }
}

namespace Internal.Runtime.CompilerServices
{
    public static class Unsafe1
    {
        public static bool IsNullRef<T>(ref T value)
        {
            return true;
        }

        public static ref T NullRef<T>()
        {
            throw new NotSupportedException();
        }
    }
}