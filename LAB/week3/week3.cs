

using System;

namespace DatatypeConversion
{
    public class ControlStatements
    {
        public static void Main(string[] args)
        {
            int a = 10;
            //if condition 
            if (a > 20)
            {
                //code to be executed if condition is met true 
                Console.WriteLine("a is greater than 20");
            }
            else
            {
                //this will be printed, as a is less than 20 
                Console.WriteLine("a is less than 20");
            }

            int i = 20, j = 20;

            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
            else if (i < j)
            {
                Console.WriteLine("i is less than j");
            }
            else
            {
                Console.WriteLine("i is equal to j");
            }

            // NESTED IF COND.

            int k = 10, l = 20;



            if (k != l)
            {
                if (k < l)
                {
                    Console.WriteLine("k is less than l");
                }
                else if (k > l)
                {
                    Console.WriteLine("k is greater than l");
                }
            }
            else
                Console.WriteLine("k is equal to l");

            int x = 20, y = 10;
            var result = x > y ? "x is greater than y" : "x is less than y";
            Console.WriteLine(result);



            int t = 10;
            // var t = "hi";


                switch (t)
                {
                    case 5:
                        Console.WriteLine("Value of x is 5");
                        break;
                    case 10:
                        Console.WriteLine("Value of x is 10");
                        break;
                    case 15:
                        Console.WriteLine("Value of x is 15");
                        break;
                    default:
                        Console.WriteLine("Unknown value");
                        break;
                }

                for (int m= 0; m < 10; m++)
                {
                    Console.WriteLine("Value of i: {0}", m);
                }

            /*
         for (; ; )
         {
             Console.Write(1);
         }
            */


            for (int z = 0; z < 10; z++)
            {
                if (z == 5)
                    break;
                Console.WriteLine("Value of i: {0}", z); // stop at 4 
            }


            for (int c = 1; c <= 5; c++)
            {
                if (c == 4)
                {
                    //value of i =4 is not printed, and next loop is executed 
                    continue;
                }
                Console.WriteLine("End of loop number " + c + " for i");
            }


            int p = 0;



            do
            {
                Console.WriteLine("i = {0}", p);
                p++;

            } while (p < 5);




            // LAB ÖDEV



            // Ödev 1: Klavyeden okunan sayının 45'ten büyük,küçük,eşit olduğunu karşılaştıran programı yazınız.
            Console.WriteLine("Sayı Giriniz");
            int value = int.Parse(Console.ReadLine());

            if(value > 45)
            {
                Console.WriteLine("Sayı 45'den büyüktür.");
            }
            else if(value == 45)
            {
                Console.WriteLine("Sayı 45'e eşittir.");
            }
            else
            {
                Console.WriteLine("Sayı 45'den küçüktür.");
            }


            // Ödev 2: Üç kenarı klavyeden girilen üçgenin ikiz kenar,eş kenar ve çeşit kenar üçgen olupl olmadığını kontrol eden programı yazınız.

            Console.WriteLine("1.kenarı giriniz.");
            int kenar1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2.kenarı giriniz.");
            int kenar2 = int.Parse(Console.ReadLine());

            Console.WriteLine("3.kenarı giriniz.");
            int kenar3 = int.Parse(Console.ReadLine());


            if(kenar1 ==  kenar2 && kenar1 == kenar3)
            {
                Console.WriteLine("Eşit Kenar Üçgen.");
            }
            else if( (kenar1 == kenar2 && kenar1!=kenar3) || (kenar1 == kenar3 && kenar1 !=kenar2) )
            {
                Console.WriteLine("İkiz Kenar Üçgen");
            }
            else
            {
                Console.WriteLine("Çeşitkenar Üçgen");
            }

            // Ödev 3:0-100 arasındaki çift sayıları yazdırırken sayı=60 olduğunda döngünden çıkan programı yazınız.

            

            for (int iter = 0; iter < 100; iter++)
            {
                if (iter == 60)
                {
                    Console.WriteLine("İter 60 Döngüden Çıkıldı!");
                    break;
                }
                if (iter % 2 == 0)
                {
                    Console.WriteLine("Şunaki Çift Sayı: "+iter);
                }
                
            }

            // Ödev 4:0-100 arasındaki çift sayıları yazdırırken sayı=60 olduğunda 60 yı yazdırmadan devam eden programı yazınız.


            for (int iter = 0; iter < 100; iter++)
            {
                if (iter == 60)
                {
                    Console.WriteLine("İter 60 Döngüye Devam Ediliyor!");
                    continue;
                }
                if (iter % 2 == 0)
                {
                    Console.WriteLine("Şunaki Çift Sayı: "+iter);
                }
               
            }





        }
    }
}
