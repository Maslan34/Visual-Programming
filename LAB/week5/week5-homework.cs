using System;
using System.Collections;
using System.Collections.Generic;


/*
 *  ENG
 *  Prepare a list structure with 10 elements consisting of username, surname and date of birth. 
 *  Write a program that calculates the ages of the people here according to their birth dates and sorts the list from largest to smallest.
 *
 *  TR
 *  Kullanıcı adı soyadı ve doğum tarihlerinden oluşan  10 elemanlı bir list yapısı hazırlayınız. 
 *  Buradaki kişilerin doğum tarihlerine göre yaşlarını hesaplayıp,
 *   listeyi büyükten küçüğe sıralayan programı yazınız.
 *
 */


List<object[]> containerList = new List<object[]>();

// Kullanıcı bilgilerini al
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Kullanıcı {i + 1} bilgilerini girin:");
    Console.Write("Ad: ");
    string ad = Console.ReadLine();
    Console.Write("Soyad: ");
    string soyad = Console.ReadLine();
    Console.Write("Doğum Tarihi (örn. YYYY-MM-DD): ");
    DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());

    object[] tempArray = { ad, soyad, dogumTarihi };
    containerList.Add(tempArray);
}

Console.WriteLine(containerList.Count);
// Doğum tarihlerini sıralama
containerList.Sort((x, y) => ((DateTime)x[2]).CompareTo((DateTime)y[2]));

// Sıralanmış doğum tarihlerini yazdırma
foreach (object[] item in containerList)
{
    
        DateTime dogumTarihi = (DateTime)item[2];
        TimeSpan yas = DateTime.Now - dogumTarihi;
        int gun = (int)Math.Floor(yas.Days / 365.25);
        Console.WriteLine($"Ad: {item[0]}, Soyad: {item[1]}, Yaş: {gun}");
    

}

