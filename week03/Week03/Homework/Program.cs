using System;
using System.Collections.Generic;
namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ex2 = EX2(new[] { 1, 5, 7, 8, 9, 2, 3, 6 }, 9);
        }

        static List<int> EX2(int[] array, int sum)
        {

            List<int> pairs = new List<int>();
            // Find all pairs of elements in an integer array, whose sum is equal to a given number?[x]
            //todo home: return the list of pairs as single return type
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
    }
}
