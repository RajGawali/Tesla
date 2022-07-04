/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla
{
    ////////    class pattern
    ////////    {
    ////////        static void Main(string[] args)
    ////////        {
    ////////            for (int r = 1; r <= 10; r++)
    ////////            {
    ////////
    ////////                for (int c = 1; c <= 10; c++)
    ////////                {
    ////////                    if(c ==1  || r == 10)
    ////////                        Console.Write("*");
    ////////                    else
    ////////                        Console.Write(" ");

    ////////                }
    ////////                Console.WriteLine(  );
    ////////            }
    //        }
    //    }
    //}

    //    class T
    //    {
    //        static void Main(string[] args)
    //        {
    //            for (int r = 1; r <= 10; r++)
    //            {
    //                for (int c = 1; c <= 10; c++)
    //                {
    //                    if (r == 1 || c == 5)
    //                        Console.Write("*");
    //                    else
    //                        Console.Write(" ");
    //                }
    //                Console.WriteLine();
    //            }
    //        }
    //    }
    //}


    //class E
    //{
    //    static void Main(string[] args)
    //    {
    //        for (int r = 1; r <= 10; r++)
    //        {
    //            for (int c = 1; c <= 10; c++)
    //            {
    //                if (c == 1 || r==1 ||r == 5 || r == 10)
    //                    Console.Write("*");
    //                else
    //                    Console.Write(" ");
    //            }
    //            Console.WriteLine();

    //        }
    //    }
    //    }
    //}


    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////   ///////// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




    //*****
    //*****
    //*****
    //*****
    //*****

    //    class starpattern
    //    {
    //        static void Main(string[] args)
    //        {
    //            for (int i = 1; i <= 5; i++)
    //            {
    //                for (int j = 1; j <= 5; j++)
    //                {
    //                    Console.Write("*");

    //                }
    //                Console.WriteLine();
    //            }
    //            Console.ReadLine();
    //        }
    //    }
    //}



    /*
     *****
     ****
     ***
     **
     *
     */


    //   / class triangle
    //    {
    //        static void Main(string[] args)
    //        {
    //            for (int i = 1; i <= 5; i++)
    //            {
    //                for (int j = i; j <= 5; j++)
    //                {
    //                    Console.Write("*");
    //                }
    //                Console.WriteLine();
    //            }
    //        }
    //    }
    //}







    //    class p1
    //    {
    //        static void Main(string[] args)
    //        {
    //            int i, j;
    //            for (i = 1; i <= 5; i++)
    //            {
    //                for (j = 5; j >= i; j--)
    //                {
    //                    Console.Write(j);
    //                }
    //                Console.WriteLine();
    //            }
    //        }
    //    }
    //}



    //    class p2
    //    {
    //        static void Main(string[] args)
    //        {

    //            for (int i = 6; i<=9; i++)
    //            {
    //                for (int j = 9; j <= i; j++)
    //                {
    //                    Console.Write(j);
    //                }
    //                Console.WriteLine();

    //            }
    //        }
    //    }
    //}


    ////
    // 54321
    // 4321
    // 321
    // 21
    // 1



    /*class p3
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 5; i <= 1; i--)
            {
            for (j = i; j >= 1; j--)

            {

                Console.Write(j);
            }


                Console.WriteLine();

            }
        }
    }
    }



    /*
    12345
    2345
    345
    45
    5
    */



    /*class p4
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = i; j <= 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    }
    */


    /*
     1
     10
     101
     10102
     10101
    */

    /* class p5
     {
         static void Main(string[] args)
         {
             int r, c;

             for (r = 1; r <= 5; r++)

             {
 6
    for (c = 1; c <= r; c++)
                     Console.Write(c % 2);
                 Console.WriteLine();
             }
         }
     }
 }
    */




    /*class p6
    {
        static void Main(string[] args)
        {
            int k = 0;
            for (int r = 1; r <= 5; r++)
            {
                for (int space = 4; space >= 5; space--)

                {
                    Console.Write(" ");
                }

                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                k--;
            }
        }
    }
}
      */


    /* class p7
     {
         static void Main(string[] args)
         {
             Console.WriteLine("enter number of lines");
             int line = int.Parse(Console.ReadLine());

             for (int i = 1; i <= line; i++)
             {
                 for (int sp = 1; sp < line - i; sp++)
                 {
                     Console.Write("*");
                 }
                 for (int j = 1; j < 2 * i; j++)
                 {
                     Console.WriteLine();
                 }
             }
         }
     }
 }
    */


    /*class p8
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)

            {
                for (int space = r; space <= 4; space++)
                {
                    Console.Write(" ");
                }

                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                for (int k = r - 1; k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }

}
  


    /*class p9
    {
        static void Main(string[] args)
        {

        }
    }
    */
