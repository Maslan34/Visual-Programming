using System;
using week6_Exercise2;

namespace learningClass
{
    class driver
    {

        /*
         * If there is a non-digit value in the entered ID, it prints an error message. 
         * Otherwise, write a program that accepts the first 5 values ​​of entered sID as the ID and prints it on the screen.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ID:");
            Person person = new Person();
            string id = (Console.ReadLine());
    
            person.Id = id;

            Console.WriteLine("ID:"+ person.Id);


        }
    }
}

