using System;

namespace Func_Example
{
    class Swap
    {
        public void swap(int number1, int number2)
        {

            int temp;
            temp = number1;
            number1 = number2;
            number2 = temp;

        }

        public void swapRef(ref int number1, ref int number2)
        {

            int temp;
            temp = number1;
            number1 = number2;
            number2 = temp;

        }


        public void getValue(out int number)
        {
            int temp = 100;
            number = 999;
        }
        static void Main(string[] args)
        {

            // VALUE PARAM
            Swap n = new Swap();

            int a = 10;
            int b = 5;

            Console.WriteLine("Before Swap A: {0} , B: {1}", a,b);
            Console.WriteLine("Before Swap A: {0} , B: {1}", a,b);


            Console.WriteLine("\n\n\n");
            n.swap(a, b);

            Console.WriteLine("After Swap A: {0} , B: {1}", a, b);
            Console.WriteLine("After Swap A: {0} , B: {1}", a, b);



            // REF PARAM
            Console.WriteLine("\n\n\nRef Param");
            Swap m = new Swap();

            

            int c = 100;
            int d = 50;

            Console.WriteLine("Before Swap C: {0} , D: {1}",  c,  d);
            Console.WriteLine("Before Swap C: {0} , D: {1}",  c,  d);

            Console.WriteLine("\n\n\n");
            m.swapRef(ref c, ref d);

            Console.WriteLine("After Swap C: {0} , D: {1}", c, d);
            Console.WriteLine("After Swap C: {0} , D: {1}", c, d);


            Console.WriteLine("\n\n\n Out Param");


            Swap k = new Swap();



            int e = 100;

            Console.WriteLine("Before Out Process  E: {0} ",e);


            k.getValue(out e);

            Console.WriteLine("After Out Process E: {0} ",e);


        // While initialization is required in "REF", there is no need to initialize "OUT".
        // But at the end of the function, a value must be assigned to "OUT".

       



        }
    }
}