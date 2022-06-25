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
            //Ex7();
            //Ex8();
            //Ex9();
            Ex10();
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
           
            for (int i=0; i<numberInt;i++)
            {
                for (int j=0;j<numberInt-i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=0;k<2*i-1;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = numberInt-1; i >= 1; i--)
            {
                for (int j = 0; j < numberInt - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Ex8()
        {
            Console.WriteLine("Exercise 8");
            Console.WriteLine("***");
            Console.WriteLine("Please enter a text:");
            string text = Console.ReadLine();
            string textReverse = "";
            int counter = text.Length - 1;
            while (counter >= 0)
            {
                textReverse += text[counter];
                counter--;                
            }
            Console.WriteLine(textReverse);
        }
        public static void Ex9()
        {
            Console.WriteLine("Exercise 9");
            Console.WriteLine("***");
            Console.WriteLine("Please enter a number:");
            string number = Console.ReadLine();
            int numberInt;
            int modulo=0;
            string text="";
            string textReverse="";            
          
            Int32.TryParse(number, out numberInt);

            while (numberInt > 0)
            {
                modulo = numberInt%2;
                text += modulo.ToString();
                numberInt /= 2;                
            }
            int counter = text.Length - 1;
            while (counter >= 0)
            {
                textReverse += text[counter];
                counter--;
            }
            Console.WriteLine(textReverse);
        }
        public static void Ex10()
        {
            Console.WriteLine("Please enter first number:");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Please enter second number:");
            string secondNumber = Console.ReadLine();
            int firstNumberInt;
            int secondNumberInt;
            int numberMultiply=0;
            
            Int32.TryParse(firstNumber, out firstNumberInt);
            Int32.TryParse(secondNumber, out secondNumberInt);

            numberMultiply = firstNumberInt * secondNumberInt;
            while (firstNumberInt !=  secondNumberInt)
            {
                if(firstNumberInt>secondNumberInt)
                {
                    firstNumberInt -= secondNumberInt;
                }
                else
                {
                    secondNumberInt -= firstNumberInt;
                }
            }
            int result = numberMultiply/firstNumberInt;
            Console.WriteLine(result);

        }


    }
}
