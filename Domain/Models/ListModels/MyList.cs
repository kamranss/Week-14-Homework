using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.ListModels
{
    public class MyList<T>:IEnumerable
    {
       public   T[] arr;

        public int Count { get { return arr.Length; } }
        


        public MyList()
        {
            arr = new T[0];
           
            
        }

        public MyList( int arrlenght)
        {
            arr = new T[arrlenght];
        }

        public  void Add(T a)
        {
            T[] temparr = new T[arr.Length +1];
            for (int i = 0; i < arr.Length; i++)
            {
                temparr[i] = arr[i];
            }
            temparr[arr.Length] = a;

            arr = temparr;
            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write(arr[i]);
            }

        }

        public T this[int productindex]
        {
            get { return arr[productindex]; }
            set { arr[productindex] = value; }
        }

        public T Find (Predicate<T> function)
        {
            foreach (var item in arr)
            {
                if (function(item))
                {
                    return item;
                }              
            }
            return default(T);
        }
        public void Clear()
        {
            arr = new T[0];
        }

        public void AddRange(IEnumerable<T> m)
        {
            T[] temp = new T[arr.Length + m.Count()];
            for (int i = 0; i < temp.Length; i++)
            {
                if (i< arr.Length)
                {
                    temp[i] = arr[i];
                }
                else
                {
                    temp[i] = m.ElementAt(i - arr.Length);
                }
            }
        }


        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }

      
    }
}
