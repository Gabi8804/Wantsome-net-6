using System;

namespace Generics
{
    // Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
    // Keep the elements of the list in an array with a fixed capacity which is given as a parameter in the class constructor.
    // Implement methods for:
    // Add element. If the capacity is exceeded, throw an exception [ex usage: list.Add(value)]
    // Get element by index. [ex usage: var data = list.Get(2)]. Element on position 2 will be returned. 
    // Removing element by index. [ex usage: var data = list.Remove(2)]. Element on position 2 will be removed. 
    // Inserting an element at a given position. [ex usage: list.Add(10, 2). 10 will be inserted on position 2. 
    // Elements from the position 2 will be moved with one position. If capacity is exceeded, the last element will be removed.
    class Program
    {
        static void Main(string[] args)
        {
            var listGeneric = new GenericList<int>(5);

            listGeneric.AddElement(2);
            listGeneric.AddElement(6);
            listGeneric.AddElement(111);
            listGeneric.AddElement(1232);
            listGeneric.AddElement(44);

            var obj = listGeneric.RetunElementAtT(2);
            Console.WriteLine(obj);

        }
    }  

    public class GenericList<T>
    {
        int capacity = 0;
        T[] array;
        int position = 0;

        public GenericList(int n)
        {
            this.capacity = n;
            this.array = new T[capacity];
        }

        public void AddElement(T obj)
        {
            try
            {
                if (position <= capacity - 1)
                {
                    this.array[position] = obj;
                    position++;
                }
                else
                {
                    throw new Exception("Capacity exceeded");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public T RetunElementAtT(int pos)
        {
            return this.array[pos];
        }

        public void RemoveElement(int pos)
        {
            for (int i = pos + 1; i <= position; i++)
            {
                this.array[i - 1] = this.array[i];
            }

            this.array[position] = default(T);
        }


    }
}
