using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For

            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");

            //for (int x = 1; x <= 5; x++)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion

            #region Soru1

            //int sayi;

            //Console.Write("Lütfen Bir Sayı Giriniz = ");
            //sayi=int.Parse(Console.ReadLine());

            //for (int i=1; i<=sayi; i++)


            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($" {i} Çifttir");
            //    }
            //    else
            //    {
            //        Console.WriteLine($" {i} Tektir");
            //    }    


            //}

            #endregion

            #region Soru2

            //Kullanıcı tarafından girilen sayma sayısına kadar çift veya tek sayıları ayrı ayrı yazdırın.

            //int sayi;
            //int ciftToplam = 0;
            //int tekToplam = 0;
            //Console.WriteLine("Lütfen Bir Sayı Giriniz = ");
            //sayi = int.Parse(Console.ReadLine());

            //for(int i = 0;i <= sayi; i++)
            //{


            //if (i % 2 == 0)
            //{
            //    ciftToplam = ciftToplam + i;

            //}
            //else
            //{
            //    tekToplam = tekToplam + i; //tekToplam+=i;

            //           }    

            //}

            //Console.WriteLine($"Çift Sayıların Toplamı = {ciftToplam}\nTek Sayıların Toplamı = {tekToplam}");

            #endregion

            #region Soru3
            //Kullanıcı tarafından girilen sayıdan 3er 3er azaltarak yazdıran program çıktısı.

            //int sayi;

            //Console.Write("Lütfen Bir Sayı Giriniz = ");
            //sayi=int.Parse(Console.ReadLine());

            //for(int i = sayi-3; i >0;  i-=3)
            //{


            //    Console.WriteLine(i);

            //}

            #endregion

            #region Soru4

            // 1 den 1 tane 2den 2 tane 3 ten 3 tane 5 ten 5 tane istiyorum
            //for (int i = 1;i <=5;  i++)
            //{
            //    if ( i==1)
            //    {
            //        Console.WriteLine("1");
            //    }
            //    else if (i==2)
            //    {
            //        Console.WriteLine("22");
            //    }
            //    else if (i == 3)
            //    {
            //        Console.WriteLine("333");
            //    }
            //    else if (i == 4)
            //    {
            //        Console.WriteLine("4444");
            //    }
            //    else { Console.WriteLine("55555"); }

            //}

            //for (int i = 1; i <=5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.WriteLine(i);

            //    }
            //}

            #endregion

            #region Soru5

            // 5ten 5 tane 4 ten 4tane 1e kadar program çıktısı.

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)

            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            #endregion

            #region Soru6

            //5443332222211111

            //for (int i = 5;i >=1; i--) 
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.WriteLine(i);
            //    }



            //}

            #endregion

            #region Soru7

            // if else kullanmadan kullanıcının girdiği sayıya kadar çift sayının toplamını girin
            //int sayi;
            //int ciftToplam = 0;
            //Console.Write("Lütfen Bir Sayı Giriniz = ");
            //sayi = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= sayi; i += 2)//birden başlatırsan tek sayı toplamı verir.
            //{

            //    ciftToplam += i;

            //}

            //Console.WriteLine(ciftToplam);

            #endregion

            #region Soru8

            /*

            ***
            ***
            ***

            */

            //for (int i = 0; i <3; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j <3; j++)
            //    {
            //        Console.Write("*");
            //    }
            //}

            #endregion

            #region Soru9

            //Kullanıcıdan girilen sayıya kadar fibonacci sayısını yazdırın.

            //int a = 1;
            //int b = 1;
            //int c=0;
            //Console.WriteLine("Lütfen Bir Sayı Giriniz");
            //int ks=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //for (int i = 1; i <=ks ; i++)
            //{
            //    c = a + b;
            //    a = b;
            //    b = c;

            //  Console.WriteLine(c);
            //}

            #endregion

            #region Soru10

            // Kullanıcı tarafından girilen sayının asal olup olmadığını kontrol eden program

            //Console.Write("Lütfen Bir Sayı Giriniz = ");
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
            //    Console.WriteLine($"{sayi} Asal Değil");
            //}
            //else
            //{
            //    Console.WriteLine($"{sayi} Asaldır");
            //}

            #endregion

            #region Soru11

            /*
             * 
             * *
             * * *
             * * * *
             * * * * *

            */
            //string a = "*";

            //for (int i = 0;i <=5; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(a);
            //    }


            //}


            #endregion

            #region Soru12

            /*
              *
             ** 
            ***  
           ****   
          *****    

             */

            //string a = " ";

            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine();

            //    for (int j = 5 - i; j > 0; j--)
            //    {
            //        Console.Write(a);

            //    }
            //    for (int k = 0; k < i; k++)
            //    {
            //        Console.Write("*");
            //    }

            //}








            #endregion

            #region Soru13

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

            //string a = " ";


            //for (int i = 0; i < 5; i ++)
            //{
            //    Console.WriteLine();

            //    for (int j = 4 - i; j > 0; j--)


            //    {
            //        Console.Write(a);


            //    }
            //    for (int k = 0; k < 2*i+1; k++)

            //    {
            //        Console.Write("*");
            //    }


            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(" ");

            //    }
            //    for (int j = 0; j < 3; i++)
            //    {
            //        Console.Write("*");
            //    }
            //}

            #endregion

            #region While

            //Console.Write("Lütfen Bir Sayı Girin =");
            //int sayi = int.Parse(Console.ReadLine());
            //int k = 0;
            //int toplam = 0;
            //while (k<=sayi)
            //{
            //    toplam = toplam + k;
            //    k++;


            //}
            //Console.WriteLine(toplam);

            #endregion

            #region Soru14

            //Kullanıcıdan 0 girilene kadar sayı isteyen 0 girildiğinde ise sayıların çarpımını veren program çıktısı.

            //Console.Write("Lütfen Bir Sayı Giriniz =  ");
            //int sayi = int.Parse(Console.ReadLine());
            //int carpi = 1;
            //if (sayi == 0)
            //{
            //    carpi = 0;
            //}
            //else
            //{
            //    while (sayi != 0)
            //    {
            //        carpi = carpi * sayi;
            //        Console.Write("Lütfen Bir Sayı Giriniz =  ");
            //        sayi = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine(carpi);

            #endregion

            #region Soru15

            // 10 a kadar olan sayıları 5i yazdırmadan yazdırın.

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Soru16

            //Kullanıcıdan 0 girilene kadar sayı istesin ve girdiği anda çift ve tek ayrı toplamı.


            //Console.Write("Lütfen Bir Sayı Giriniz =  ");
            //int sayi = int.Parse(Console.ReadLine());
            //int tekToplam = 0;
            //int ciftToplam = 0;

            //if (sayi == 0)
            //{
            //    Console.WriteLine("İlk Girilen Sayı 0dan Farklı Olmalı");
            //}
            //else
            //{

            //    while (sayi != 0)
            //    {

            //        if (sayi % 2 == 0)
            //        {
            //            ciftToplam = ciftToplam + sayi;
            //        }
            //        else
            //        {
            //            tekToplam = tekToplam + sayi;
            //        }
            //        Console.WriteLine("Lütfen Bir Sayı Giriniz");
            //        sayi = int.Parse(Console.ReadLine());


            //    }
            //    Console.WriteLine($"Çift Sayıların Toplamı = {ciftToplam} \n Tek Sayıların Toplamı = {tekToplam}");

            //}

            #endregion

            #region while soru 1

            // Console.Write("Lütfen Bir Sayı Giriniz = ");
            // int sayi = Convert.ToInt32(Console.ReadLine());

            //int e = 0;
            // while (e <=sayi)
            // {

            //     if (e % 2 == 0)
            //     {
            //         Console.WriteLine($"Sayı Çifttir = {e}");


            //     }
            //     else
            //     {
            //         Console.WriteLine($"Sayı Tektir = {e}");
            //     }

            //     e++;

            // }

            //Console.ReadLine();

            #endregion

            #region while soru2 


            //    int sayi;
            //    int ciftToplam = 0;
            //    int tekToplam = 0;
            //    int b = 0;
            //    Console.WriteLine("Lütfen Bir Sayı Giriniz = ");
            //    sayi = int.Parse(Console.ReadLine());

            //while (b <= sayi)
            //{

            //    if (b % 2 == 0)
            //    {
            //        ciftToplam = ciftToplam + b;

            //    }
            //    else
            //    {
            //        tekToplam = tekToplam + b; 
            //    }
            //    b++;

            //}
            //Console.WriteLine($"Çift Sayıların Toplamı = {ciftToplam}\nTek Sayıların Toplamı = {tekToplam}");

            //Console.ReadLine();

            #endregion

            #region while soru3
            //Console.Write("Lütfen Bir Sayı Giriniz = ");
            //int sayi = int.Parse(Console.ReadLine());
            //while (sayi >= 0)
            //{
            //    Console.WriteLine(sayi);
            //    sayi -= 3;
            //}

            #endregion

            #region while soru4
            //int sayi = 0;
            //while (sayi <= 5)
            //{
            //    //switch (sayi)
            //    //{
            //    //    case 1:
            //    //        Console.WriteLine("1");
            //    //        break;
            //    //    case 2:
            //    //        Console.WriteLine("22"); break;
            //    //    case 3:
            //    //        Console.WriteLine("333"); break;
            //    //    case 4:
            //    //        Console.WriteLine("4444"); break;
            //    //    case 5:
            //    //        Console.WriteLine("55555"); break;

            //    //}

            //    sayi++;
            //}

            #endregion

            #region while soru5

            //int sayi = 5;
            //while (sayi >= 1)

            //{
            //    switch (sayi)
            //    {
            //        case 5:
            //            Console.WriteLine("55555");
            //            break;
            //        case 4:
            //            Console.WriteLine("4444"); break;
            //        case 3:
            //            Console.WriteLine("333"); break;
            //        case 2:
            //            Console.WriteLine("22"); break;
            //        case 1:
            //            Console.WriteLine("1"); break;

            //    }


            //    sayi--;

            //}

            #endregion

            #region while soru6
            //int sayi=5;
            //while (sayi>=1) 

            //{
            //    switch (sayi)
            //    {
            //        case 5:
            //            Console.WriteLine("5");
            //            break;
            //        case 4:
            //            Console.WriteLine("44"); break;
            //        case 3:
            //            Console.WriteLine("333"); break;
            //        case 2:
            //            Console.WriteLine("2222"); break;
            //        case 1:
            //            Console.WriteLine("11111"); break;

            //    }


            //    sayi--;

            //}

            #endregion

            #region while soru7

            //int k = 0;
            //int ciftToplam = 0;
            //Console.Write("Lütfen Bir Sayı Giriniz = ");
            //int sayi = int.Parse(Console.ReadLine());

            //while (k<=sayi)
            //{

            //    ciftToplam += k;



            //    k += 2;
            //}

            //Console.WriteLine(ciftToplam);

            #endregion

            #region while soru8

            //int i = 1;
            //int a = 1;
            //int b = 1;
            //int c = 0;

            //Console.Write("Lütfen Bir Sayı Giriniz = ");
            //int ks=int.Parse(Console.ReadLine());

            //while (i<=ks)
            //{
            //    a = b;
            //    b= c; 
            //    c= a+b;

            //    Console.WriteLine(c);
            //    i++;
            //}

            #endregion

            #region while soru9

            //int sayi = 2;
            //int sayac = 0;
            //Console.Write("Lütfen Bir Sayı Giriniz = ");
            //int ks = int.Parse(Console.ReadLine());

            //while (sayi <= ks/2 )
            //{
            //    if (ks % sayi == 0)
            //    {
            //        sayac++;
            //    }

            //    sayi++;

            //}

            //if (sayac != 0)
            //{
            //    Console.WriteLine($"{ks} Asal Sayı Değildir");
            //}

            //else 
            //{


            //    Console.WriteLine($"{ks} Asal Sayıdır");

            //}

            #endregion

            #region while soru10

            //int sayi = 0;

            //while (sayi<10)
            //{
            //    sayi++;
            //    if (sayi==5)
            //    {
            //        continue;

            //    }
            //    Console.WriteLine(sayi);


            //}

            #endregion


            Console.ReadLine();

        }
    }
}
