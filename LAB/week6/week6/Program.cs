using System;

namespace learningClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car(24);
            Console.WriteLine("Color:"+myObj.color);
            Console.WriteLine("Age:"+myObj.age);
            myObj.Price = 500;
            Console.WriteLine("Price:"+myObj.Price);
            myObj.Brand = "Merc";
            Console.WriteLine("Brand:" + myObj.Brand);




        }
    }
}

