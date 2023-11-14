using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using week6_Exercise;

namespace learningClass
{
    class driver
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Muharrem";
            student.Surname = "Aslan";
            student.SchoolName = "Karabük";
            student.Visa1 = 100;
            student.Visa2 = 100;
            student.Final = 90;
            bool exit = false;

            while (!exit) {

                Console.WriteLine("Select an Operation\n1-Get Name and Surname \n2-Get School Name\n3-Calculate Notes\n4-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Name: {0} Surname: {1}", student.Name, student.Surname);
                        break;
                    case 2:
                        Console.WriteLine("School: {0} ", student.SchoolName);
                        break;
                    case 3:
                        int not = student.Calculate;
                        Console.WriteLine("Note: {0} ", not);
                        break;
                    case 4:
                        exit = true; 
                        break;
                    default: Console.WriteLine("Wrong Dialing!");
                            
                            break;
                }
     
            }        
                    

        }
    }
}

