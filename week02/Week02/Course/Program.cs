using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {




            //static void Main(string[] args)
            //{

            ////ex1
            //var array = new int[5] {1,32,3,4,5 };
            //var newArray = new int[5];
            //for (int i = array.Length - 1; i >= 0; i--)
            //{
            //    int newPos = array.Length - 1 - i;
            //    newArray[newPos] = array[i];

            //}
            //foreach (int value in newArray)
            //{
            //    Console.WriteLine(value);
            //}

            ////ex2
            //int startNumber = 1;
            //int endNumber = 10;
            //int counter = 0;
            //var array1 = new int[endNumber / 2 + startNumber];
            //for (int i = startNumber; i <= endNumber; i++)
            //{
            //    Console.WriteLine($"i: {i}");
            //    if (i % 2 == 0)
            //    {
            //        array1[counter] = i;
            //        Console.WriteLine($"Counter: {counter}, i: {i}, Array1: {array1[counter]}");
            //        counter += 1;
            //    }
            //}
            //foreach (int value in array1)
            //{
            //    Console.WriteLine(value);
            //}

            //ex3


            //var array = new int[] { 13, 1, 15, 7, 19 };
            //foreach (int v in array)
            //{
            //    if (v == 1 || v == 10)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(v);
            //}



            //////average of elements in array
            ////    var array = new int[5];
            ////    Console.WriteLine("please provide 5 numbers separated by comma");
            ////    string input1 = Console.ReadLine();
            ////    string[] separatedNumbers = input1.Split(',');
            ////    for (var input = 0; input <= 4; input++)
            ////    {
            ////        array[input] = int.Parse(separatedNumbers[input]);
            ////    }
            ////    var sum = 0;
            ////    foreach (var nr in array)
            ////    {
            ////        sum = sum + nr;
            ////    }
            ////    double av = (double)sum / array.Length;
            ////    Console.WriteLine($"the average is: {av}");



            // min an max
            /*        int[] array = new int[] { 20, 11, 45, 2, 55, 62, 1 };
                    int max = -1, min = int.MaxValue;
                    foreach(int val in array)
                    {
                        if(val < min)
                        {
                            min = val;
                        }
                        if(val > max)
                        {
                            max = val;
                        }
                    }
                    Console.WriteLine("max is: "+ max);
                    Console.WriteLine("min is: " + min);
                } */


            // delete element from array
            //int[] array = new int[] { 20, 11, 45, 2, 55, 62, 1 };
            //int pos = 2;
            //for (int i = pos + 1; i <= array.Length - 1; i++)
            //{
            //    array[i - 1] = array[i];
            //}
            //array[array.Length - 1] = 0;
            //foreach (int val in array)
            //{
            //    Console.WriteLine(val);
            //}

            //last ex

            //            using System;
            //namespace ConsoleApp1
            //    {
            //        class Program
            //        {
            //            static void Main(string[] args)
            //            {
            //                int indexfound = -1;
            //                int[] array = new int[] { 12, 7, 67, 69, 5 };
            //                int value = 69;
            //                for (int i = 0; i < array.Length; i++)
            //                {
            //                    if (array[i] == value)
            //                    {
            //                        indexfound = i;
            //                        break;
            //                    }
            //                }
            //                Console.WriteLine($"Indexfound={indexfound}");
            //            }
            //        }
            //    }
            //    New

            //    Antoneta Bejan  8:53 PM
            //using System;
            //namespace ConsoleApp1
            //    {
            //        class Program
            //        {
            //            static void Main(string[] args)
            //            {
            //                int[] array = new int[] { 12, 7, 67, 69, 5 };
            //                int[] array1 = new int[array.Length];
            //                for (int i = 0; i < array.Length; i++)
            //                {
            //                    array1[i] = array[i];
            //                }
            //                foreach (int v in array1)
            //                {
            //                    Console.WriteLine(v);
            //                }

            //                Vlad Holbura  9:05 PM
            //    int[] array1 = new int[] { 123, 5, 423, 6, 42, 444, 2, 3 };
            //                int[] array2 = new int[] { 5, 23, 7878, 333, 42, 1, 0, 444 };
            //                int nrInteratii = 0;
            //                foreach (int valueFromFirstArray in array1)
            //                {
            //                    foreach (int valueFromSecondArray in array2)
            //                    {
            //                        if (valueFromFirstArray == valueFromSecondArray)
            //                        {
            //                            Console.WriteLine(valueFromSecondArray);
            //                            break;
            //                        }
            //                        nrInteratii++;
            //                    }
            //                }
            //                Console.WriteLine($"nr iteratii: {nrInteratii}");
            //int startNumber = 1;
            //int endNumber = 10;
            //List<int> list1 = new List<int>();
            //List<int> list2 = new List<int> { 4, 7 };
            //string listToPrint = "";
            //for (int i = startNumber; i <= endNumber; i++)
            //{
            //    if (!list2.Contains(i))
            //    {
            //        list1.Add(i);
            //    }
            //}
            //foreach (int x in list1)
            //{
            //    listToPrint += $"{x} ";
            //}
            //Console.WriteLine(listToPrint);


        }
    }
}
