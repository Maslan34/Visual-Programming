using System;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



            for (int i = 0; i < 10; i++)
            {
                myArray[i] = myArray[i] + 100;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Iter: {0} , Element: {1}", i, myArray[i]);
            }

            int[,] array2d = new int[3, 3]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            Console.WriteLine(array2d);

            
            ArrayAverageCalculator calculator = new ArrayAverageCalculator();

            double average;
            average = calculator.getAverage(myArray, 10);
            Console.WriteLine("Ortalama:"+average);
        }

            class ArrayAverageCalculator
        {

            /// !!! public yazılması gerekiyor. çünkü class aşağıda yazılmış eğer class yukarıda yazılsaydı public yazılmaya gerek kalmazdı !!!
             public double getAverage(int[] array, int size)

            {

                double average = 0;
                for(int i = 0; i < size; i++)
                {
                    average += array[i];
                }

                return average / size;
            }
        }


        }
    }
