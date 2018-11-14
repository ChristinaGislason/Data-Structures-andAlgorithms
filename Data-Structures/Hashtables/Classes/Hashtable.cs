using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashtables.Classes
{
    class Hashtable

    {
        private List<object> list;

        public Hashtable()
        {
            list = Enumerable.Repeat(0, 1024).ToList();
        }

        public void Add(string key, object value)
        {
            int sum = 0;
            for(int i = 0; i < key.Length; i++)
            {
                sum += (int)(key[i]);
            }
            int hash = sum * 599;
            int index = hash % list.Count;
            Console.WriteLine(index);
        }

    }
}
