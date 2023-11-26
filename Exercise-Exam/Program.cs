using System;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace ExamExercise
{
    class Exircese
    {


        static void Main(string[] args)
        {
            /*VISUAL PROGRAMMING LAB QUESTIONS
                1. Write a C# Sharp program to find out whether a given year is a leap year or not.*/
            Console.WriteLine("Please enter a year ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("This is a leap year.");
            }
            else
            {
                Console.WriteLine("This is not a leap year!");
            }
            /*
            2. Write a C# Sharp program to read the age of a candidate and determine
            whether it is eligible for casting his/her own vote.*/
            Console.WriteLine("Please enter a age ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 17)
            {
                Console.WriteLine("Not Eligible For Vote!");
            }
            else
            {
                Console.WriteLine("Eligible For Vote.");
            }

            /*
           3. Write a C# Sharp program to calculate the root of a quadratic equation.*/

            Console.WriteLine("Please enter A for a quadratic equation ax2 + bx + c = 0");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter  B for a quadratic equation ax2 + bx + c = 0");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter C for a quadratic equation ax2 + bx + c = 0");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            double firstRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double secondRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Root 1 :{0} , Root 2 :{1}", firstRoot, secondRoot);


            /*
         4. Write a C# Sharp program to read any day number as an integer and
         display the name of the day as a word. */
            Console.WriteLine("Please enter a number to display week of days between 1 and 7. ");
            int numberDay = Convert.ToInt32(Console.ReadLine());

            switch (numberDay)
            {

                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;

            }



            /*
            5. Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ... ]*/
            Console.WriteLine("Please enter the number of series that will be calculated. [ 9 + 99 + 999 + 9999 ... ] ");
            int seriesNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0, series = 9;

            for (int i = 0; i < seriesNumber; i++)
            {
                sum += series;
                series = (series * 10) + 9;

            }
            Console.WriteLine("Sum of Series: " + sum);

            /*

           6. Write a program in C# Sharp to find the sum of the series [ x - x^3+x^5- x^7 + x^9 -..... ]*/

            Console.WriteLine("Please enter the number of series that will be calculated. [ x - x^3+x^5- x^7 + x^9 -..... ]");
            int seriesNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter X.");
            double x = Convert.ToInt32(Console.ReadLine());
            double sum2 = 0;

            for (int i = 0; i < seriesNumber2; i++)
            {
                if (i % 2 == 0)
                    sum2 += Math.Pow(x, 2 * i + 1);
                else
                    sum2 -= Math.Pow(x, 2 * i + 1);


            }
            Console.WriteLine("Sum of Series: " + sum2);

             /*
                 7. Write a C# Sharp program to count duplicate elements in an array.
             */
            Console.WriteLine("Plese enter 10 length array to count duplicate elements in array");
            int[] mainArray = new int[10];
            int counter = 1;


            for (int i = 0; i < mainArray.Length; i++)
            {
                Console.WriteLine("Element: {0} -> ", i + 1);

                int element = Convert.ToInt32(Console.ReadLine());
                mainArray[i] = element;

            }

            for (int i = 0; i < mainArray.Length; i++)
            {
                for (int j = i + 1; j < mainArray.Length; j++)
                {
                    if (mainArray[i] == mainArray[j])
                        counter++;
                }
                if (counter == 2)
                    Console.WriteLine("Dublicated Element: {0}", mainArray[i]);
                counter = 1;
            }


            /*
            8. Write a C# Sharp program to count the frequency of each element in an array.
            */

            int[] frequancyArray = new int[10];
            Dictionary<int, int> frequancyDic = new Dictionary<int, int>();

            Console.WriteLine("Please enter 10-lenghth array to count the frequency.");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter {0}. element.", i + 1);
                frequancyArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (frequancyDic.ContainsKey(frequancyArray[i]))
                    continue;
                else
                {
                    int counterFrequancy = 1;
                    for (int j = i + 1; j < frequancyArray.Length; j++)
                    {
                        if (frequancyArray[i] == frequancyArray[j])
                            counterFrequancy++;
                    }
                    frequancyDic.Add(frequancyArray[i], counterFrequancy);
                }
            }
            foreach (var element in frequancyDic)
            {
                Console.WriteLine("Frequancy of {0} is: {1}", element.Key, element.Value);
            }

            /*

           9. Write a C# Sharp program to find the length of a string without using a library function. */
            Console.WriteLine("Please enter a string to find length of it.");
            string lengthOfString = Console.ReadLine();
            int length = 0;

            // Manually iterate through characters until null terminator is found
            foreach (var item in lengthOfString)
            {

                length++;
            }
            Console.WriteLine("Length of String: " + length);

            /*
           10. Write a C# Sharp program to remove duplicate characters from a given string.
           */


            Console.WriteLine("Please enter a string to remove dublicate characters.");
            string dublicateOfString = Console.ReadLine();
            string modifiedString = "";

            for (int i = 0; i < dublicateOfString.Length; i++)
            {
                for (int j = i + 1; j < dublicateOfString.Length; j++)
                {
                    if (dublicateOfString[j] == dublicateOfString[i])
                    {
                        try
                        {
                            modifiedString = dublicateOfString.Substring(0, j) + dublicateOfString.Substring(j + 1, dublicateOfString.Length);
                        }
                        catch (Exception ex)
                        {
                            modifiedString = dublicateOfString.Substring(0, j);
                        }

                        dublicateOfString = modifiedString;
                    }

                }
            }

            Console.WriteLine("Result: " + dublicateOfString);
            /*
            




            11. Write a program in C# Sharp to create a function to input a string and count the number of spaces within the string. Use out or ref
            */
            Console.WriteLine("Please enter a string to count number of spaces");
            string spacesString = Console.ReadLine();
            int counterSpaces;
            findSpaces(spacesString, out counterSpaces);

            Console.WriteLine("Number of Spaces in this string: {0}", counterSpaces);

            /*

            12. Write a C# Sharp program to display the date of the past and future
            fifteen years from a specified date.*/
            Console.WriteLine("Please enter a day.");
            int dayDate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a month.");
            int monthDate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a year.");
            int yearDate = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(yearDate, monthDate, dayDate);
            DateTime datePast = date.AddYears(-15);
            DateTime dateFuture = date.AddYears(15);

            Console.WriteLine("Past Fifteen Years:{0}/{1}/{2} Future Fifteen Years {3}/{4}/{5}.", datePast.Year, datePast.Month, datePast.Day, dateFuture.Year, dateFuture.Month, dateFuture.Day);

            /*
            
            13.Write a program in C# Sharp to get the number of days in a given
            month for a year. Test Data:Input the Month No. : 2 Input the Year : 2017
            Expected Output :The Number of days in the month February is: 28
            */

            Console.WriteLine("Please enter the Month.");
            int monthSpesific = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the Year.");
            int yearSpesific = Convert.ToInt32(Console.ReadLine());

            DateTime dateSpesific = new DateTime(yearSpesific, monthSpesific, 1);

            Console.WriteLine("The Number of days in the month " + dateSpesific.Month + " is: " + dateSpesific.DayOfWeek);

            /*
            14.Write a program that reads names and ages from the user until an empty line
            is entered. The name and age are separed by a comma. After reading the
            program prints the name of the oldest person. You can assume that the user
            enters at least one person and that one of the users is older than the others.
         
             */
            string name, agePersonStr;
            int agePerson = 0, oldest = -1;
            Dictionary<string, int> person = new Dictionary<string, int>();
            KeyValuePair<string, int> oldestPerson = new KeyValuePair<string, int>();
            List<Dictionary<string, int>> arrayList = new List<Dictionary<string, int>>();

            for (; ; )
            {
                Console.WriteLine("Please enter name.");
                name = Console.ReadLine();
                if (name == "")
                    break;
                Console.WriteLine("Please enter age.");
                agePersonStr = Console.ReadLine();
                if (agePersonStr == "")
                {
                    Console.WriteLine("You should enter a age!");
                    for (; ; )
                    {
                        agePersonStr = Console.ReadLine();
                        if (agePersonStr != "")
                        {
                            agePerson = Convert.ToInt32(agePersonStr);
                            break;
                        }


                    }
                }
                else
                    agePerson = Convert.ToInt32(agePersonStr);
                person.Add(name, agePerson);
                arrayList.Add(person);

            }

            foreach (Dictionary<string, int> item in arrayList)
            {
                foreach (KeyValuePair<string, int> item2 in item)
                {
                    if (oldest < item2.Value) 
                    {
                        oldestPerson = item2;
                        oldest = item2.Value;
                    }
                        
                }
            }

            Console.WriteLine("Oldest Person Name {0}, Age:{1}", oldestPerson.Key, oldestPerson.Value);





        }

        public static void findSpaces(string spacesString, out int counter)
        {
            counter = 0;
            for (int i = 0; i < spacesString.Length; i++)
            {
                if (spacesString[i] == ' ')
                    counter++;
            }

        }
    }
}