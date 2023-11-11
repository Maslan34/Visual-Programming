using System;

namespace Func_Example
{
    class Program
    {
        static int findMax(int number1 , int number2)
        {

              return   number1 < number2 ? number2: number1;

        }
        static void Main(string[] args)
        {
            Program n = new Program();

            Console.WriteLine("Result: {0}", Program.findMax(3500, 213123));
            
        }
    }
}