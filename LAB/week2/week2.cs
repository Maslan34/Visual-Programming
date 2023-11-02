

using System; 
 
namespace DatatypeConversion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int myInt = 20;
            double myDouble = myInt;       // Automatic casting: int to double 

            Console.WriteLine(myInt);      // Outputs 20 
            Console.WriteLine(myDouble);   // Outputs 20 

            double DoubleValue = 4.78;
            int intValue = (int)DoubleValue;    // Manual casting: double to int 

            Console.WriteLine(DoubleValue);   // Outputs 4.78 
            Console.WriteLine(intValue);      // Outputs 4 

            int myInt2 = 100;
            double myDouble2 = 2.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt2));    // Convert int to string
            Console.WriteLine(Convert.ToDouble(myInt2));    // Convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble2));  // Convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string



            var i = 10;
            Console.WriteLine("Type of i is {0}", i.GetType().ToString());

            var str = "Hello World";
            Console.WriteLine("Type of str is {0}", str.GetType().ToString());

            var d = 10.50d;
            Console.WriteLine("Type of d is {0}", d.GetType().ToString());
        }
    }
}