using System;

namespace Week01HomeWork
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the exercise number you wish to run");
            int Ex = int.Parse(Console.ReadLine());
            SelectExercise(Ex);

            
            // 1. Display even numbers between 0, 100            




            // 2.

            /* * Read 2 number from the keyboard and create mathematical operations for
                -division
                -multiplication
                -on division if the number is 0 display a message that it is not possible
                -calculate the minimum and maximum
             */



            //3
            /*
             * Read a number from the keyboard and
                -it is the temperature in C, convert it to F
                -it is the temperature in F, convert it to C
                -it is a number of days, convert it to years, months, weeks and days
                Conventions - year: 365 days, month: 30 days, week: 7 days, use only numbers
                bigger than 1000
            */


            //4. Print to console all even numbers between 15 and 97.            



            //5. Print all numbers divisible by 3 between 20 and 65.            


            //6. Count all numbers divisible by 7 and multiple of 5, from 1400 to 2300 and print the result to console.            

            //7. Write a program to guess a number between 1 and 10. To generate a random number, use Random class from .NET Framework.            

            //9. Read a text from console and print it reversed.            

            //10. Print numbers from 1 to 10 except 4 and 7.            

            //11. Print the Fibonacci sequence from 0 to 50. (i.e. Exery next number is found by adding up those two before it: 0, 1, 1, 2, 3, 5, 8, 13, ..

        }
        public static void SelectExercise(int val)
        {
            switch (val)
            {
                case 1:
                    Ex01();
                    break;
                case 2:
                    Ex02();
                    break;
                case 3:
                    Ex03();
                    break;
                case 4:
                    Ex04();
                    break;
                case 5:
                    Ex05();
                    break;
                case 6:
                    Ex06();
                    break;
                case 7:
                    Ex07();
                    break;
                case 9:
                    Ex09();
                    break;
                case 10:
                    Ex10();
                    break;
                case 11:
                    Ex11();
                    break;
                case 12:
                    Ex12();
                    break;
                case 13:
                    Ex13();
                    break;
                case 14:
                    Ex14();
                    break;
                case 15:
                    Ex15();
                    break;
                case 16:
                    Ex16();
                    break;

            }
        }

        public static void Ex01()
        {
            for (int i = 0; i <= 100; i += 1)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("the number is even: " + i);
                }

            }
        }

        public static void Ex02()
        {
            Console.WriteLine("First number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 != 0 && number2 != 0)
            {
                float number3 = (float)number1 / (float)number2;
                Console.WriteLine("Division= " + number3);
            }

            int numberMultiplied = number1 * number2;
            Console.WriteLine("Multiplication= " + numberMultiplied);
            if (number1 > number2)
            {
                Console.WriteLine("The greatest number is: " + number1 + " and the lowest number is " + number2);
            }
            else
            {
                Console.WriteLine("The greatest number is: " + number2 + " and the lowest number= " + number1);
            }
        }

        public static void Ex03()
        {
            Console.WriteLine("Enter your number");
            int tempNumber = int.Parse(Console.ReadLine());

            float F = tempNumber * 1.8f + 32;
            float C = (tempNumber - 32) / 1.8f;
            Console.WriteLine("Fahrenheit temp is: " + F);
            Console.WriteLine("Celsius temp is: " + C);

            Console.WriteLine("Enter number of days");

            int days = int.Parse(Console.ReadLine());
            while (days < 1000)
            {
                Console.WriteLine("Enter a number bigger than 1000");
                days = int.Parse(Console.ReadLine());


            }

            if (days > 1000)
            {
                int years = days / 365;
                int months = days / 30;
                int weeks = days / 7;

                Console.WriteLine("You have entered " + years + " years, " + months + " months, " + weeks + " weeks.");
            }



        }
        public static void Ex04()
        {
            for (int i = 15; i <= 97; i += 1)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("the number is even: " + i);
                }

            }
        }

        public static void Ex05()
        {
            for (int i = 20; i <= 65; i += 1)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("the number" + i + " is divisible by 3");
                }

            }
        }

        public static void Ex06()
        {
            int a = 0;
            for (int i = 1400; i <= 2300; i++)
            {
                if (i % 7 == 0 && i % 5 == 0)
                {
                    a = a + 1;
                }
            }
            Console.WriteLine("There are " + a + " numbers divisible by 7 and multiple of 5 between 1400 and 2300");
        }

        public static void Ex07()
        {
            int x = new Random().Next(1, 10);
            Console.WriteLine("Guess the random number");
            int y = Convert.ToInt32(Console.ReadLine());
            while (y != x)
            {
                Console.WriteLine("Wrong guess, random number is " + x);
                y = Convert.ToInt32(Console.ReadLine());
            }




        }

        public static void Ex09()
        {
            Console.WriteLine("Enter your string");
            string y = Console.ReadLine();
            string reverseY = "";

            for (int i = y.Length - 1; i > -1; i--)
            {
                reverseY = reverseY + y[i];
            }

            Console.WriteLine("Your reverse string is: " + reverseY);
        }

        public static void Ex10()
        {
            Console.WriteLine("Numbers from 1 to 10 except 4 and 7 are");
            for (int i = 1; i <= 10; i++)
            {
                if (i != 4 && i != 7)
                {
                    Console.WriteLine(i);

                }
            }
        }

        public static void Ex11()
        {
            long a = 0;
            long b = 1;
            long c = 0;
            int length = 50;
            Console.WriteLine("Fibonacci sequence from 0 to 50");
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i <= length; i++)
            {
                 c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
        public static void Ex12()
        {
            Console.WriteLine("Input the first number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number");
            int number2 = int.Parse(Console.ReadLine());

            int sum = number1 + number2;
            int div = number1 - number2;
            int mult = number1 * number2;
            int sub = number1 / number2;
            int mod = number1 % number2;

            Console.WriteLine(number1 + " + " + number2 + " = " + sum);
            Console.WriteLine(number1 + " - " + number2 + " = " + div);
            Console.WriteLine(number1 + " * " + number2 + " = " + mult);
            Console.WriteLine(number1 + " / " + number2 + " = " + sub);
            Console.WriteLine(number1 + " mod " + number2 + " = " + mod);
        }

        public static void Ex13()
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int multi = number * i;
                Console.WriteLine(number + " * " + i + " = " + multi);
            }
        }

        public static void Ex14()
        {
            Console.WriteLine("Input the first number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the fourth number");
            int number4 = int.Parse(Console.ReadLine());

            int average = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of "+ number1 + ", " + number2  +", " + number3  +", " + number4  +", is:"  + average);
            
        }

        public static void Ex15()
        {
            
            Console.WriteLine("Input a string :");
            string myString = Console.ReadLine();

            char firstChar = myString[0];

            string newString = firstChar + myString + firstChar;
            Console.WriteLine("The new string is: " + newString);

        }

        public static void Ex16()
        {
            int sum = 0;
            int number = 2;
            int count = 0;
           
            
               while (count <= 500)
            {
                count = 0;
                for (int j = 2; j <= number / 2; j++)
                {
                    if (number % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                        sum = sum + number;
                        count++;  
                }
                number++;
            }
               
               
            Console.WriteLine("Sum of the first 500 prime numbers: "+ sum);
        }

    }
}
