using System;
using System.Collections;
using System.Collections.Generic;

namespace Реализация_листа
{

    class MyList<T> : IEnumerable<T>
    {
        T[] array = new T[100];
        int count = 0;
        public void Add(T el)
        {
            if (count == array.Length - 1)
                CreatArray();

            array[count] = el;
            count++;
        }

        public void CreatArray()
        {
            array = new T[array.Length * 2];
        }

        public IEnumerator<T> GetEnumerator() // то как мы ходим
        {
            for (int i = 0; i < count; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> nums = new MyList<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
