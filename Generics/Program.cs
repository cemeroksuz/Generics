using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("İzmir");
            sehirler.Add("Antalya");
            sehirler.Add("Adana");
            Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İzmir");
            sehirler2.Add("Antalya");
            sehirler2.Add("Adana");
            sehirler2.Add("Mersin");
            Console.WriteLine(sehirler2.Count);


        }
    }
    //T = type
    class MyList<T> //Generic Class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }
}
