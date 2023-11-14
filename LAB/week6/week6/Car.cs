using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace learningClass
{
    class Car
    {
        public string color = "red";
        private const int password = 123;
        
        public int age;

        private string brand;
        private int price;
        //CONST
        public Car(int age)
        {
            this.age = age;
        }
        // GETTER SETTER

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        // Conditional Setter
        public string Brand
        {
            get { return brand; }
            set {
                Console.WriteLine("Enter Password for Brand Assignment");
                int pass = Convert.ToInt32(Console.ReadLine());
                   if (pass == password)
                    brand = value;
                   else
                    Console.WriteLine("Assignment Failed!");
            }
        }
    }
}