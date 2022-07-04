using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla

{
    /*  class countname
     {
         static void Main(string[] args)
         {
             string[] name = { "pavan", "shiva", "sudhir", "kushal", "shuhas" };
             int count = 0;
             string nam;
             for(int i = 0; i < name.Length; i++)
             {
                 nam =name[i];
                 Console.WriteLine(nam);
                 Console.WriteLine(name.Length);
                 count=count+1;
             }
             Console.WriteLine("total names is array given are"+count);

         }
     }
 }
    */

    //   Today excersice
    // sum of elements of array
    //sum of array elements
    // find out minimum elements of char or int
    // reverse char type of array
    // alternate elements of array
    // search char of array
    //sum of prime number in array



    // sum of elemen8ts of array
    /* class sumarray
     {
         static void Main(string[] args)
         {
             int sum = 0;
             int[] arr = { 2, 8, 9, 4, 5, 6 };
             for(int i = 0; i < arr.Length; i++)
             {
                 sum+=arr[i];
             }
             Console.WriteLine(sum);

         }
     }
 }
    */

    //find out minimum elements of char or int


    class minimum
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 2, 8, 9, 4, 5, 6 };
            int i, min, n;
            n = 5;
            min = arr[0];

            for (i = 1; i < arr.Length; i++)
            {

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("minimun element={0}", min);

        }
    }
}