using System;
using System.Diagnostics.Metrics;

namespace ArrayApplication
{
    class week4

    {
        static void Main(string[] args)
        {

            /*
                         ÖDEV 1: 10 elemanlı interger sayılardan oluşan bir dizi oluşturulacak. 
                                 Diziyi tersten, sıralıi string ifadeye çevrilmiş ve dizinin kullanıcının istediği
                                 elemanını ekrana yazdıran programı Array class methodları kullanarak yazınız. 
            */


            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Array.Reverse(array);
            Array.Sort(array);

            string[] strArray = new string[10];

            for (int i = 0; i < 10; i++)
            {
                strArray[i] = Convert.ToString(array[i]);
            }

            Console.WriteLine("1-10 Arasında Numara Tuşlayınız");
            int sayı = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tip: {0} , Eleman: {1}", strArray[sayı - 1].GetType(), strArray[sayı - 1]);


            //  ÖDEV : 2: Klavyeden kullanıcının girdiği 10 elemanlı dizideki her bir elemanın karesi alınacak ve bir fonksiyon yardımı ile ortalaması hesaplanacaktır.

            int[] squareArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + ". elemanı giriniz.");
                squareArray[i] = Convert.ToInt32(Console.ReadLine());

            }
            week4 week4 = new week4();

            Console.WriteLine(week4.getSquareArray(squareArray));




            /*  ÖDEV : 3:                   enum calısanlar : byte
                                           {
                                               İdareci,// 0 100 TL
                                               Öğretmen,// 1 200TL
                                               Memur, // 2 300TL
                                               Hizmetli// 3 400 TL
                                           }
                                    Şeklinde bir enum yapısı oluşturunuz.
                                     Kullanıcının klavyeden girdiği çalışan tipine göre 
                                    maaşını ekrana yazdıran programı switch-case kullanarak yazınız.
            */
            Console.WriteLine("\n\nÇalışan giriniz \n1-İdareci\n2-Öğretmen\n3-Memur\n4-Hizmetli");
            int tip  = Convert.ToInt32(Console.ReadLine());

            switch (tip)
            {
                case 1:
                    Console.WriteLine("\n\nSeçilen Tip: {0} Maaş: 100", (calisanlar)0);
                    break;
                case 2:
                    Console.WriteLine("\n\nSeçilen Tip: {0} Maaş: 200", (calisanlar)1);
                    break;
                case 3:
                    Console.WriteLine("\n\nSeçilen Tip: {0} Maaş: 300", (calisanlar)2);
                    break;
                case 4:
                    Console.WriteLine("\n\nSeçilen Tip: {0} Maaş: 400", (calisanlar)3);
                        break;
                    break;

            }

        }

        enum calisanlar
        {
            İdareci = 0,
            Öğretmen = 1,
            Memur = 2,
            hizmetli = 3
        }

        double getSquareArray(int[] array)
        {
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {

                toplam += array[i];

            }

            return (double)toplam / (double)array.Length;
        }


    }
}
