using System;
using System.Collections.Generic;

namespace PlaygroundProject
{
    public class Stack<T>
    {
        int position;
        T[] data = new T[100];

        public void Push(T obj) => data[position++] = obj;

        public T Pop() => data[--position];
    }

    public class MyDiscionary<TKey, TVal> //could be also more TParams
    {
        Dictionary<TKey, TVal> myDict = new Dictionary<TKey, TVal>();

        public void AddDictItem(TKey key, TVal val)
        {
            myDict.Add(key, val);
        }

        public TVal GetDictionaryItemByKey(TKey key)
        {
            return myDict.TryGetValue(key, out TVal val) ? val : default(TVal);
        }
    }

    public class MyDummyArrayCollection<S>
    {
        int position = 0;
        S[] dataArray = new S[20];

        public void AddToArray(S item)
        {
            dataArray[position++] = item;
            Console.WriteLine($"Element {item} added to array to position {position}");
        }

        public S GetItemFromTop()
        {
            return dataArray[--position];
        }

        //Generic method (becomes generic by introducing <T>)
        public void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

    }
}
