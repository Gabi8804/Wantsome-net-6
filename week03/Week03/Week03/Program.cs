using System;

namespace Week03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1,6,4,5,2,0,-1};
            //Ex4(array);

            //var result = Anagram("TRIANGLE", "INTEGRAL");

            for (int i = array.Length-1; i >=0; i--)
            {
                for (int j = array.Length-2; j >=0; j--)
                {
                    
                    if (array[i] > array[j])
                    {
                        var aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
                Console.WriteLine();
            }
            foreach(int v in array)
            {
                Console.WriteLine(array[v]);
            }
        }

        static void Ex4(int[] a)
        {
            int[] array = new int[] { 2, 12, 16, 3, 15, 17, 3 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine("The array contains duplicates!");
                        return;
                    }
                }
            }
            Console.WriteLine("The array does not contain duplicates!");
        }


        //LISTEN-SILENT
        //TRIANGLE-INTEGRAL
        static bool Anagram(string a, string b)
        {


            if (a.Length == b.Length)
            {
                char[] aCharArray = a.ToCharArray();
                char[] bCharArray = b.ToCharArray();
                Array.Sort(aCharArray);
                Array.Sort(bCharArray);

                for (int i = 0; i > a.Length; i++)
                {
                    if (aCharArray[i] != bCharArray[i])
                    {
                         return false;
                    }
                }
                return true;
            }
            else return false;
        }

            

    }
}
