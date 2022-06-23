using System;

namespace loops_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            Ex3();
        }
        public static void Ex1()
        {
            Console.WriteLine("Exercise 1");
            Console.WriteLine("***");

            int counter = 0;

            for (int i=0; i<100; i++ )
            {
                for(int n =2; n <= i; n++)
                {
                    if (i == n)
                    {
                        counter++;
                        Console.WriteLine(n);
                    }
                    else if (i%n == 0)
                    {
                        break;
                    }
                }
            }
                                   
        }
        public static void Ex2()
        {
            Console.WriteLine("Exercise 2");
            Console.WriteLine("***");
            int i= 0;
            
            do
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i < 1000);                                    
        }
        public static void Ex3()
        {
            Console.WriteLine("Exercise 3");
            Console.WriteLine("***");
            Console.WriteLine("1");
            Console.WriteLine("1");
            int a = 1;
            int b = 1;
            int c;
            int n = 20;
            for (int i=0; i<n;i++)
            {
                c = a + b;
                a = b;
                b = c;

                Console.WriteLine(c);
            }
            

        }
    }
}
