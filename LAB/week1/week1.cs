using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    internal class Program
    {


        class Bread
        {

            public int counter;

        }


        class Butter
        {

            public static int counter;

        }
        static void Main(string[] args)
        {
            /*
             Console.WriteLine("Muharrem");
             var reading = Console.ReadLine();
             Console.WriteLine(reading);
            */


            /*
             * 
             *       { 
                         int a; 
                         a = 100; 
                   // local variable 
                      Console.WriteLine("Value:" + a);  //prints 100
                    }
                    
                     Console.WriteLine("Value:" + a);  // Error 
             * 
             * 
             */

            const double pi = 3.14159;
            double r;
            Console.WriteLine("Enter Radius");
            r = Convert.ToDouble(Console.ReadLine());

            double areaCircle = pi * r * r;
            Console.WriteLine("Radiuus {0},Area {1}", r, areaCircle);



            Bread br = new Bread();
            br.counter = 5;
            Console.WriteLine("Bread Counter: "+br.counter);
            Butter.counter = 10;
            Console.WriteLine("Butter Counter: " + Butter.counter);


        }

    }
}

    

