using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] sayilar = { 1, 3, 6, 5, 88, 44 };
            //string[] isimler = { "Mehmet", "Çoban", "Ayşegül" };

            //Console.WriteLine(sayilar[4]);

            //for (int i = 0; i < sayilar.Length; i++) // .Length uzunluğu kadar anlamında
            //{
            //    Console.WriteLine(sayilar[i]);
            //    Console.ReadLine();
            //}

            //Console.WriteLine(isimler[2]);
            //Console.ReadLine();

            // var aslında veri tipi değildir gelen veriye göre tip alır.


            // foreach bir dizi veya koleksiyon içerisinde bütün verilere erişmek için kullanılan dögülerden biridir.

            //foreach (var x in isimler)
            //{
            //    Console.WriteLine(isimler[x]);
            //    Console.ReadLine();
            //}

            #region Ornek

            // sınıf mevcuduna göre veri alıp yazdırmak

            //string[] sinifMevcudu = new string[5];

            //for (int i = 0; i < sinifMevcudu.Length; i++)
            //{
            //    Console.Write(i + 1 + " Elemanı Gir: ");
            //    sinifMevcudu[i] = Console.ReadLine();
            //}

            //Console.WriteLine("*******");

            //foreach (var x in sinifMevcudu)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.ReadLine();

            #endregion

            #region Ornek

            // sınıf mevcudu sorup veri alıp yazdıracağız.

            //string[] sinifmevcudu;

            //Console.WriteLine("Sınıf mevcudu nedir ?");

            //int deger = int.Parse(Console.ReadLine());

            //sinifmevcudu = new string[deger];

            //for(int i = 0; i < sinifmevcudu.Length; i++)
            //{
            //    Console.Write(i+1 + ". öğrenciyi girin : ");
            //    sinifmevcudu[i] = Console.ReadLine(); 
            //}

            //Console.WriteLine("---Sınıf Mevcudu");

            //Console.Clear();
            //foreach (var x in sinifmevcudu)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.ReadLine();

            #endregion

            #region Ornek

            // kullanıcıdan dizi ile veri al tek ve çiftleri yazdır

            //int[] sayilar;

            //Console.WriteLine("kaç elemanlı olsun");
            //int deger = int.Parse(Console.ReadLine());
            //sayilar = new int[deger];

            //for (int i = 0; i < deger; i++)
            //{
            //    Console.Write(i+1 + "degeri gir: ");
            //    sayilar[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine();
            //Console.Clear();
            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //int ttoplam = 0;
            //int ctoplam = 0;

            //foreach (int item in sayilar)
            //{
            //    if (item % 2 == 0)
            //    {
            //        ctoplam += item;
            //    }
            //    else
            //    {
            //        ttoplam += item;
            //    }
            //}

            //Console.WriteLine($"çift sayıların toplamı {ctoplam}\ntek sayıların toplamı {ttoplam}");
            //Console.ReadLine();


            #endregion

        }
    }
}
