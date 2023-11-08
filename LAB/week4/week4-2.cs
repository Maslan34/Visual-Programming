using System;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] array = new int[7] { 1, 3, 2, 6, 5, 7, 4 };
            int[] temp = array;

            Console.WriteLine("Original Array");
            foreach(int i in array)
            {
                Console.WriteLine(i+" ");
            }
            Console.WriteLine();

            // Reversing Array

            Array.Reverse(array);
            Console.WriteLine("Reversed Array");

            foreach(int i in array)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();


            // Sorting  Array

            Array.Sort(array);
            Console.WriteLine("Sorted Array");

            foreach(int i in array)
            {
                Console.WriteLine(i + " ");
            }

        }
    }
}