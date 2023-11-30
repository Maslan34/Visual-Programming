using System;
using week7;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
              Car myCar = new Car();

            myCar.honk();

            Console.WriteLine(myCar.brand + " " + myCar.modelName);
            Personel P = new Personel(123, "Nesrin", "Aydın");
                
                Personel.salary = 1500;
                Console.WriteLine(" ID: {0} Name:{1} Surname:{2} Salary: {3}",P.P_id , P.name,  P.s_name, Personel.salary);

                Console.WriteLine("New salary is:"+Personel.Calculate_salary(Personel.salary))
;

                Console.ReadLine();
            }
        }
    }




 

 