using System;
using System.Collections.Generic;
namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Ex2 = EX2(new[] { 1, 5, 7, 8, 9, 2, 3, 6 }, 9);
            //var Ex3 = EX3(int.Parse(Console.ReadLine()));
            EX5(int.Parse(Console.ReadLine()));

            Ex6(new[] { 6, 6, 6, 8, 9, 6, 3, 6 });
            EX8(int.Parse(Console.ReadLine()));
            EX9(int.Parse(Console.ReadLine()));
            var ex10 = EX10(int.Parse((Console.ReadLine())));
            int[] x = new int[]  { 1, 5, 7, 8, 9, 2, 3, 6 };
             x = EX11(x, 0, 2 - 1);
            x = EX11(x, 2, x.Length - 1);
            x = EX11(x, 0, x.Length - 1);

            EX12(new[] { 6, 6, 6, 8, 9, 6, 3, 6 });

        }


        // Find all pairs of elements in an integer array, whose sum is equal to a given number?[x]
        //todo home: return the list of pairs as single return type
        static List<int> EX2(int[] array, int sum)
        {
            List<int> pairs = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sum)
                    {
                        Console.WriteLine(array[i] + "+" + array[j] + "=" + sum);
                        pairs.Add(array[i]);
                        pairs.Add(array[j]);
                    }
                }
            }
            return pairs;
        }

        //How to calculate factorial using recursion in C# + iterative + time difference.


        static double EX3(int number)
        {
            if (number == 1)
                return 1;
            else
            {
                return number * EX3(number - 1);
            }
        }

        // How to find sum of digits of a number using Recursion?
        static int EX5(int number)
        {
            if (number != 0)
            {
                return (number % 10 + EX5(number / 10));
            }
            else return 0;

        }

        //Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?
        static int Ex6(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (count > array.Length / 2)
                    return i;
            }
            return -1;
        }

        //Write a function to print the nth number in Fibonacci series?
        static int EX8(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return EX8(n - 1) + EX8(n - 2);
            }
        }

        //Write a function to count a total number of set bits in a 32-bit Integer?

        static int EX9(int number)
        {
            int count = 0;
            while (number > 0)
            {
                count += number & 1;
                number = number >> 1;
            }
            return count;
        }

        //Write a function to remove duplicate characters from String?
        static string EX9(string aString)
        {
            
            string newstring = "";
            List<char> duplicates = new List<char>();

            foreach (char value in aString)
            {
                if (duplicates.Contains(value))
                {
                    continue;
                }

                newstring += value.ToString();
                duplicates.Add(value);
            }
            return newstring;
        }

        //C# program to check if a number is Armstrong number or not?
        static bool EX10(int number)
        {
            int temp = number;
            int sum = 0,r=-1;

                while (temp != 0)
                {
                    r = temp % 10;
                    temp = temp / 10;
                    sum = sum + (r * r * r);
                }
                if (sum == number)
            {
                return true;
            }return false;
                    
            }
        //How to rotate an array by a given pivot?
        private static int[] EX11(int[] x, int start, int end)
        {
            while (start < end)
            {
                int temp = x[start];
                x[start] = x[end];
                x[end] = temp;
                start++;
                end--;
            }
            return x;
        }

        //Sorting an Array using Selection Sort

        static void EX12(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first 
                // element 
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            foreach(int val in arr)
            {
                Console.WriteLine(val);
            }
        }

    }
}

