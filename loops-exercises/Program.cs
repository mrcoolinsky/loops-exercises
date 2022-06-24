using System;

namespace loops_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            Ex7();
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
        public static void Ex4()
        {
            Console.WriteLine("Exercise 4");
            Console.WriteLine("***");
            Console.WriteLine("Please enter a number:");
            string number = Console.ReadLine();
            int numberInt;
            int digit = 1;
            Int32.TryParse(number, out numberInt);

            for (int i=0; i<numberInt; i++)
            {
                for (int j=0; j<i; j++)
                {
                    Console.Write(digit);
                    digit++;
                }
                Console.WriteLine("");
            }
            
        }
        public static void Ex5()
        {
            Console.WriteLine("Exercise 5");
            Console.WriteLine("***");
            double number = 1;
            for(int i=0; i<20; i++)
            {
                Console.WriteLine($"{Math.Pow(number, 3)}");
                number++;
            }

        }
        public static void Ex6()
        {
            Console.WriteLine("Exercise 6");
            Console.WriteLine("***");
            int number =1;
            for (int i=1; i<=20; i++)
            {
                number += 1 / i;
                
            }
            Console.WriteLine(number);
        }
        public static void Ex7()
        {
            Console.WriteLine("Exercise 7");
            Console.WriteLine("***");
            Console.WriteLine("Please enter a number:");
            string number = Console.ReadLine();
            int numberInt;
            Int32.TryParse(number, out numberInt);
            Console.WriteLine("Please enter length of the shorter diagonal:");
            string diagonal = Console.ReadLine();
            int diagonalInt;
            Int32.TryParse(diagonal, out diagonalInt);

            for (int i=0; i<numberInt;i++)
            {
                for (int j=0; j<i;j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine("");
            }

        }

    }
}
