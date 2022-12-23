using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.ListModels
{
    public class MyList<T>
    {
       public static  T[] arr;

       public MyList()
        {
            arr = new T[0];
            
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
    }
}
