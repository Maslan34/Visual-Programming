using System;

namespace Func_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // To find E constant values  
            double e = Math.E;

            // Print result  
            Console.WriteLine("Math.E = " + e);

            // To find PI constant values  
            double pi_value = Math.PI;

            // Print result  
            Console.WriteLine("Math.PI = " + pi_value);


            // using Floor() Method  
            Console.WriteLine("Floor value of 123.123: "
                                 + Math.Floor(123.123));
            // using Asin() Method  
            Console.WriteLine("Asin value of 0.35: "
                                 + Math.Asin(0.35));
            // using Sqrt() Method  
            Console.WriteLine("Square Root of 81: "
                                  + Math.Sqrt(81));
            // using Round() Method  
            Console.WriteLine("Round value of 14.6534: "
                                 + Math.Round(14.6534));
        }
    }
}