
//////  wap  gcd 

/*using System;
namespace Tesla
{
    //////{ 
    //////{
    //////class Assignment
    //////  {
    //////        public static void Main(string[] args)
    //////      {
    //////        int a = 12, b = 18;
    //////      int gcd = 0;
    //////        for (int i = 1; i <= a; i++)
    //////       {
    //////          if (a % i == 0 && b % i == 0)
    //////         {
    //////            gcd = i;

    //////           }
    //////      }
    //////      Console.WriteLine("gcd" + gcd);
    //////      int lcm = a * b / gcd;
    //////      Console.WriteLine("lcm=" + lcm);
    //////  }
    //////  }
    //////*}




    //////// while loop





    //////    class h
    //////  {
    //////    static void Main(string[] args)
    //////  {
    //////int n = 534;
    //////int sum = 0;
    //////while (n != 0)
    //////{
    //////  sum += n % 10;
    //////n /= 10;
    //////}
    //////Console.WriteLine("sum of the digit accept no:" + sum);
    //////}
    //////}


    //////  }
    //////}



    //////            int sum = 0, even = 0, odd = 0;
    //////          int n = int.Parse(Console.ReadLine());
    //////        while (n > 0)
    //////      {
    //////        int last = n % 10;
    //////      sum = sum + last;
    //////    n = n / 10;

    //////                if (last % 2 == 0)
    //////              {
    //////                even++;
    //////          }
    //////        else
    //////   {
    //////          odd++;

    ////// }
    //////    Console.WriteLine(sum);
    //////     Console.WriteLine(+even);
    //////    Console.WriteLine(+odd);
    //////  }
    ///
    /// 
    //////        }
    //////  }
    //////}









    /////// neon Number
    ////using System;
    ////namespace tesla

    ////{
    ////    class f
    ////{
    ////    public static void Main(string[] args)

    ////    {


    ////            int num=0;
    ////            int sq=num* num;
    ////            int sum = 0;
    ////            while(sq>0)
    ////            {
    ////                sum += sq % 10;
    ////                sq=sq/10;
    ////            }
    ////            Console.WriteLine(number:"+num);
    ////                if (sum == num)
    ////            {
    ////                Console.WriteLine("yes");
    ////            }
    ////                else
    ////            {
    ////                Console.WriteLine("no");
    ////            }





    //    class palindrome
    //    {
    //        static void Main(string[] args)
    //        {
    //            Console.Write("Enter a Number To Check Palindrome : ");
    //            int number = int.Parse(Console.ReadLine());
    //            int remineder, sum = 0;
    //            int temp = number;
    //            while (number > 0)
    //            {

    //                remineder = number % 10;

    //                sum = (sum * 10) + remineder;

    //                number = number / 10;
    //            }
    //            if (temp == sum)
    //            {
    //                Console.WriteLine($"Number {temp} is Palindrome.");
    //            }
    //            else
    //            {
    //                Console.WriteLine($"Number {temp} is not Palindrome");
    //            }
    //            Console.ReadKey();
    //        }
    //    }
    //}



    /*
        using System;
        namespace program

        {
            class employee
            {
                float salary = 10000;

            }
            class programmer : employee
            {
                float bonus = 5000;

            }
            class inheritance
            {
                static void Main(string[] args)
                {
                    programmer p1 = new programmer();

                    Console.WriteLine("salary:" + p1);
                    Console.WriteLine("bonus:" + p1);

                }

            }
        }
    }


    /*class p2
    {


            string name = "tesala";
            int maxspeed = 500;
            string colour = "red";
            string model = "c2";

        {
        static void Main(string[] args)
        {
            p2.car = new.p2();

        }
        }
    }
    */



    /*class parent
    {
        string name;

        public void play()
        {
            Console.WriteLine("play on ground");
        }
        public override void()
            {
            Console.WriteLine( );






            class child : parent
        {
            public static void m1()
            {
                Console.WriteLine("in child m1");
            }
            public override void play()
            {
                Console.WriteLine("play videos game");

            }
        }
        */


    // SEALED 


    /*ass pavan
     {
         public virtual void m1()

         {

             Console.WriteLine("in parent m1");
         }
     }
     class cc1 : pavan
     {
         public sealed override void m1()
         {
             Console.WriteLine("in child m1");
         }
         class cc2 : cc1
         {
             public override void m1()
             {
                 Console.WriteLine("in child22222222 m1");
             }
             static void Main(string[] args)
             {
                 pavan ob = new cc2();
                 ob.m1();
             }
         }
     }
 }
    */



   /* class stud1
    {
        int sid;
        string name;
        int percent;

        public stud1(int sid, string name, int percent)
        {
            this.sid = sid;
            this.name = name;
            this.percent = percent;
        }
        public override string ToString()
        {
            return $"sid:{sid} name:{name} percentage:{percent}";

        }
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            stud1 s1 = new stud1(1, "pavan", 90);

            Console.WriteLine(s1);
        }
    }
}

/*abstract class teacher
{
    string name;
    int exper;
     
    public teacher(
}
    */


