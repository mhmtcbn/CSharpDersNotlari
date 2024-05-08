using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region soru9

            // kullanıcıdan girilen sayıya kadar fibonaci sayısını yazdırın.

            //Console.WriteLine("bir sayı girin");

            //int sayi = int.Parse(Console.ReadLine());

            //int a = 1;
            //int b = 1;
            //int c = 0;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    c = a + b;
            //    a = b;
            //    b = c;

            //    Console.WriteLine(c);
            //    Console.ReadLine();
            //}

            #endregion

            #region soru10

            // kullanıcı tarafından girilen sayının asal olup olmadığını kontrol eden program çıktısı
            // kendisi ve 1 dışında böleni olmayan sayı

            //Console.WriteLine("bir sayı girin");

            //int sayi = int.Parse(Console.ReadLine());

            //int sayac = 0;

            //for (int i = 2; i <= sayi / 2; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //    }
            //}

            //if (sayac != 0)
            //{
            //    Console.WriteLine($"{sayi} asal değildir.");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine($"{sayi} asaldır.");
            //    Console.ReadLine();
            //}

            #endregion

            #region soru11

            /*
             
             * 
             **
             ***
             ****
             *****
             
            */

            //for (int i = 0; i < 5; i++ ) {

            //    Console.WriteLine();

            //    for (int j = 0; j <= i; j++ )
            //    {

            //        Console.Write("*");
            //    }

            //} 


            #endregion

            #region soru12

            /*
                *
               **
              ***
             ****
            *****
            */

            //string x = " ";

            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine();

            //    for(int j = 5-i; j > 0; j--)
            //    {
            //        Console.Write(x);
            //    }
            //    for (int k = 0;  k < i; k++)
            //    {
            //        Console.Write("*");
            //    }

            //}


            #endregion

            #region soru13

            /*
             
                *
               ***
              *****
             *******
            *********
               ***
               ***
               ***
           
             */

            //string x = " ";

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine();

            //    for (int j = 4 - i; j > 0; j--)
            //    {
            //        Console.Write(x);
            //    }
            //    for (int k = 0; k < 2*i+1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //}
            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("*");
            //    }
            //}

            // gencay yıldız

            #endregion

            #region soru14

            // kullanıcdan sıfır girilene kadar sayı isteyen sıfır girildiğinde ise sayıların çarpımını veren program çıktısı

            //Console.WriteLine("sayı girin;");
            //int sayi = int.Parse(Console.ReadLine());

            //if (sayi != 0)

            //{

            //    Console.WriteLine("sayı girin;");
            //    int sayi = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < sayi; i++)
            //    {


            //    }

            //}
            //else
            //{
            //    Console.WriteLine();

            //}

            //Console.WriteLine("sayı girin;");
            //int sayi = int.Parse(Console.ReadLine());



            #endregion

            #region continue
            // kullanıcıdan 10 a kadar olan sayıları yazdırırken 5 i yazdırma

            //for (int i = 0; i < 10; i++) { 

            //    if (i == 8)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);

            //}

            #endregion

            #region soru

            // Sorun var

            // kullanıcıdan 0 girilene kadar sayı ise 0 girildiğinde ise tek ve çiftlerin ayrı ayrı toplamını göster

            //Console.WriteLine("sayı girin");

            //int ctoplam = 0;
            //int ttoplam = 0;
            //int sayi = int.Parse(Console.ReadLine());
            //if (sayi == 0)
            //{
            //    Console.WriteLine("ilk sayı sıfır olamaz");
            //}
            //else
            //{
            //    while (sayi != 0)
            //    {
            //        if (sayi % 2 == 0)
            //        {
            //            ctoplam = ctoplam + sayi;
            //        }
            //        else
            //        {
            //            ttoplam = ttoplam + sayi;
            //        }

            //        Console.WriteLine("sayı girin");
            //        int sayi = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine($"çift sayıların toplamı {ctoplam}\n Tek sayıların toplamı {ttoplam}");
            //}

            #endregion

            Console.ReadLine();
        }
    }
}