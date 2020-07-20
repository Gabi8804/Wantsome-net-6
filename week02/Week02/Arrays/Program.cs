using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the exercise number you wish to run");
            int Ex = int.Parse(Console.ReadLine());
            SelectExercise(Ex);   
        }

        //1. Find the index of an element in an array.

        public static void Ex01()
        {
            
            int indexfound = -1;
            List<int> array1 = new List<int> { 12, 7, 67, 69, 5 };
            string arrayVal = "";

            foreach(int x in array1)
            {
                arrayVal += x + ", ";
            }
            
            Console.WriteLine("Enter the element's value you wish to find it's index from the following array: " + arrayVal);
            int value = int.Parse(Console.ReadLine());

            while (!array1.Contains(value))
            {
                Console.WriteLine("Enter only numbers that exist in the above array");
                value = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array1.Count; i++)
            {
                if (array1[i] == value)
                {
                    indexfound = i;
                    break;
                }
            }
            Console.WriteLine($"Indexfound={indexfound}");
        }

        //2. Insert an element into an array at a specified position

        public static void Ex02()
        {


            int[] array = new int[] { 1,2,3,4,5};
            Console.WriteLine("Specify the position you wish to add the element in the array between 0 and 4");
            int pos = int.Parse(Console.ReadLine());

            while (pos>4)
            {
                Console.WriteLine("Enter a value between 0 and 4");
                pos = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the value you want to add");
            int val = int.Parse(Console.ReadLine());
            for (int i = 0; i <= array.Length-1; i++)
            {
                if (i == pos)
                {
                    array[i] = val;
                    break;
                }
            }
            Console.WriteLine("Here is the array: ");
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
        }

        //For all numbers from 1 to 1000, print the following:
        //- If number is divisible by 3, print Fizz
        //- If number is divisible by 5, print Buzz
        //- If number is divisible by 3 and 5, print FizzBuzz
        //- Otherwise, print the number

        public static void Ex03()
        {

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }else if(i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        //02. Write a program to count the frequency of each element in an array e.g. [1, 4, 5, 2, 1, 4, 3, 1, 2]
        //should output: 1 - 3 times 4 - 2 times 5 - one time 2 - 2 times 3 - one time

        public static void Ex04()
        {
            
            int[] array = new int[10] { 1, 3, 6, 4, 3, 2, 1, 3, 3, 1 };

            bool[] checkComparedNumber = new bool[array.Length];

            for (int i= 0; i < array.Length;i++)
            {

                if (checkComparedNumber[i] == true)
                {
                    continue;
                }
                int count = 1;
                for (int j = i + 1; j < array.Length; j++)
                {

                    if (array[i] == array[j])
                    {
                        count++;
                        checkComparedNumber[j] = true;
                    }
                    
                }
                Console.WriteLine(array[i] + " - " + count+" times");
            }
        }

        //03. Read an array from the console and separate odd and even values into 2 arrays.
        //E.g.Number of elements in array: 3
        //- element 1: 4
        //- element 2: 3
        //- element 3: 2
        //Result: Odd array: [3] Even array: [4, 2]

        public static void Ex05()
        {
            Console.WriteLine("Enter the number of elements you want for your array, no more than 10");
            int arrLength = int.Parse(Console.ReadLine());
            while (arrLength > 10)
            {
                Console.WriteLine("Enter a value < 10");
                arrLength = int.Parse(Console.ReadLine());
            }
            List<int> array = new List<int>(arrLength);
            var arrayOdd = new List<int>();
            var arrayEven = new List<int>();
            Console.WriteLine("Add " + arrLength+" values to array");
            for (int i = 0; i < arrLength; i++)
            {
                array.Add(int.Parse(Console.ReadLine()));

            }

            foreach (int value in array)
            {
                if (value % 2 == 0)
                {
                    arrayEven.Add(value);
                }
                else
                {
                    arrayOdd.Add(value);
                }
            }
            Console.WriteLine("Even array:");
            
            foreach(int value in arrayEven)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("Odd array: ");

            foreach (int value in arrayOdd)
            {
                Console.WriteLine(value);
            }

        }

        //04. Homework 4

        //1. Find common elements between two arrays of integers.



        public static void Ex06()
        {

            Console.WriteLine("Enter the number of elements you want for your first array, no more than 10");
            int arr1Length = int.Parse(Console.ReadLine());
            while (arr1Length > 10)
            {
                Console.WriteLine("Enter a value < 10");
                arr1Length = int.Parse(Console.ReadLine());
            }
            List<int> array1 = new List<int>(arr1Length);
            Console.WriteLine("Add " + arr1Length + " values to the first array");
            for (int i = 0; i < arr1Length; i++)
            {
                array1.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Enter the number of elements you want for your second array, no more than 10");
            int arr2Length = int.Parse(Console.ReadLine());
            while (arr2Length > 10)
            {
                Console.WriteLine("Enter a value < 10");
                arr2Length = int.Parse(Console.ReadLine());
            }
            List<int> array2 = new List<int>(arr2Length);
            Console.WriteLine("Add " + arr2Length + " values to the second array");
            for (int i = 0; i < arr2Length; i++)
            {
                array2.Add(int.Parse(Console.ReadLine()));
            }


            List<int> common = new List<int>();
            
            for (int i = 0; i < arr1Length; i++)
            {
                for (int j = 0; j < arr2Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        common.Add(array1[i]);
                        break;
                    }
                }
            }
            Console.WriteLine("The common elements are ");
            foreach (int value in common)
            {
                Console.WriteLine(value);
            }
        }

        //2. Implement an algorithm to determine if a string has all unique characters.

        public static void Ex07()
        {
            Console.WriteLine("Enter your string");
            string myString = Console.ReadLine();
            bool unique = true;

            for (int i = 0; i < myString.Length; i++)
            {
                for (int j = i + 1; j < myString.Length; j++)
                {
                    if (myString[i] == myString[j])
                    {
                        Console.WriteLine("Your string is not unique");
                        unique = false;
                        break;
                    }
                }
            }
            if (unique==true)
            {
                Console.WriteLine("Your string is unique");
            }

        }

       // 3. Write code to remove duplicates from an unsorted linked list.



        public static void Ex08()
        {
            Console.WriteLine("Enter the number of elements you want for your array, no more than 10");
            int arrLength = int.Parse(Console.ReadLine());
            while (arrLength > 10)
            {
                Console.WriteLine("Enter a value < 10");
                arrLength = int.Parse(Console.ReadLine());
            }
            List<int> array = new List<int>(arrLength);
            Console.WriteLine("Add " + arrLength + " values to the first array");

            for(int i = 0; i < arrLength; i++)
            {
                array.Add(int.Parse(Console.ReadLine()));
            }

            var indexArray = new List<int>();

            for (int i = 0; i <= array.Count-1; i++)
            {
                for (int j = i + 1; j <= array.Count-1; j++)
                {
                    if (array[i] == array[j])
                    {
                        indexArray.Add(i);
                    }
                }
            }

            for (int i = 0; i <= indexArray.Count-1; i++)
            {
                array.RemoveAt(indexArray[i]);
                array.Insert(indexArray[i], 0);
            }
            while (array.Contains(0))
            {
                array.Remove(0);
            }
            
            Console.WriteLine("Your array without duplicates is ");
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
        }

        public static void Ex09()
        {
            Console.WriteLine("Enter your number");
            int number = int.Parse(Console.ReadLine());

            bool prime = true;

            for(int i = 2; i <= number / 2; i++)
                {
                if (number % i == 0)
                {
                    prime = false;
                }
            }

            if (prime)
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("The number is not prime");
            }
        }
        


        //Check if a word is a palindrome


        public static void Ex10()
        {
            Console.WriteLine("Enter your string");
            string myString = Console.ReadLine();
            string reverseString = "";

            for (int i = myString.Length - 1; i >= 0; i--)
            {
                reverseString = reverseString + myString[i];
            }

            if (myString == reverseString)
            {
                Console.WriteLine("The word is palindrome");
            }
            else
            {
                Console.WriteLine("The word is not palindrome");
            }

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
                case 8:
                    Ex08();
                    break;
                case 9:
                    Ex09();
                    break;
                case 10:
                    Ex10();
                    break;
                  

            }
        }
    }
}
