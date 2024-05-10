using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Koşullu_İfadeler__Karar_Yapıları_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region if el-se

            //if - else eğer - değilse
            //Kullanıcı tarafından girilen tam sayının tek vey çift olduğuna karar veren program çıktısı

            //try
            //{

            //    int sayi;
            //    basadon:
            //    Console.WriteLine("Lütfen Bir Sayı Giriniz");
            //    //sayi =Convert.ToInt32(Console.ReadLine());
            //    sayi = int.Parse(Console.ReadLine());


            //    if (sayi % 2 == 0)
            //    {
            //        Console.WriteLine($"{sayi} Çift Sayı Girdiniz");
            //        goto basadon;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{sayi} Tek Sayı Girdiniz");
            //        goto basadon;
            //    }


            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Girmiş olduğunuz karakterin dönüşümü yanlıştır! " + e);
            //}


            //Console.ReadLine();

            #endregion

            #region Soru
            //kullanıcı tarafından girilen sayının negatif veya pozitif olduğuna karar veren program çıktısı?

            //try
            //{

            //    int sayi;
            //    basadon:
            //    Console.WriteLine("Lütfen Bir Sayı Giriniz");
            //    sayi = int.Parse(Console.ReadLine());

            //    if (sayi > 0)
            //    {
            //        Console.WriteLine($"{sayi} Girilen Sayı Pozitiftir");
            //        goto basadon;
            //    }
            //    else if (sayi < 0)
            //    {

            //        Console.WriteLine($"{sayi} Girilen Sayı Negatifir");
            //        goto basadon;

            //    }
            //    else
            //    {
            //        Console.WriteLine($"{sayi} Girilen Sayı Nötr'dür");
            //        goto basadon;
            //    }
            //}
            //catch (Exception b)
            //{

            //    Console.WriteLine("Lütfen Tam Sayı Giriniz! " + b);
            //}

            //Console.ReadLine();

            //Kullanıcı tarafından girilen tam sayının tek veya çift ayrıca pozitif , negatif veya nötr olduğuna karar veren program çıktısı

            //try
            //{
            //    int sayi;
            //    Console.WriteLine("Lütfen Bir Sayı Gir");
            //    sayi=int.Parse(Console.ReadLine());
            //    if (sayi%2==0) 
            //    {
            //        if (sayi>0)
            //        {
            //            Console.WriteLine("Girilen sayı pozitif çift sayıdır");
            //        }
            //        else if (sayi<0) 
            //        {
            //            Console.WriteLine("Girilen sayı negatif çift sayıdır");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Girilen sayı nötr çift sayıdır");

            //        }



            //    }
            //    else
            //    {
            //        if(sayi>0)
            //        {
            //            Console.WriteLine("Girilen sayı pozitif tek sayıdır");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Girilen sayı negatif tek sayıdır");
            //        }
            //    }


            //}
            //catch (Exception b)
            //{

            //    Console.WriteLine("Lütfen tam sayı giriniz!" + b);
            //}

            //Soru Kullanıcı Tarafından Girilen Birbirinden Farklı 3 Sayının Büyükten Küçüğe Doğru Sıralaması

            //try
            //{

            //int sayı1, sayı2, sayı3;


            //Console.Write("Lütfen Birinci Sayıyı Giriniz = ");
            //sayı1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen İkinci Sayıyı Giriniz = ");
            //sayı2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen Üçüncü Sayıyı Giriniz = ");
            //sayı3 = Convert.ToInt32(Console.ReadLine());

            //    if (sayı1 > sayı2 && sayı1 > sayı3 && sayı2 > sayı3)
            //    {
            //        Console.WriteLine($"{sayı1}> {sayı2}> {sayı3}");

            //    }
            //    else if (sayı1 > sayı2 && sayı1 > sayı3 && sayı3 > sayı2)
            //    {
            //        Console.WriteLine($"{sayı1}> {sayı3}> {sayı2}");
            //    }


            //    else if (sayı2 > sayı1 && sayı2 > sayı3 && sayı1 > sayı3)
            //    {
            //        Console.WriteLine($"{sayı2}> {sayı1}> {sayı3}");

            //    }
            //    else if (sayı2 > sayı3 && sayı2 > sayı1 && sayı3 > sayı1)
            //    {
            //        Console.WriteLine($"{sayı2}> {sayı3}> {sayı1}");
            //    }
            //    else if (sayı3 > sayı1 && sayı3 > sayı2 && sayı1 > sayı2)
            //    {
            //        Console.WriteLine($"{sayı3}> {sayı1}> {sayı2}");

            //    }
            //    else if (sayı3 > sayı1 && sayı3 > sayı2 && sayı2 > sayı1)
            //    {
            //        Console.WriteLine($"{sayı3}> {sayı2}> {sayı1}");
            //    }

            //}
            //catch 
            //{

            //    Console.WriteLine("Girilmesi Gereken Değer Sayı Olmalıdır");
            //}


            //Soru Kullanıcı Tarafından Girilen Birbirinden Farklı 3 Sayının Küçükten Büyüğe ve büyükten küçüğe Doğru Sıralaması

            //int sayi1,sayi2,sayi3;
            //Console.WriteLine("Lütfen Birinci Sayı Giriniz = ");
            //sayi1 =Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen İkinci Sayıyı Giriniz = ");
            //sayi2=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen Üçüncü Sayıyı Giriniz = ");
            //sayi3= Convert.ToInt32(Console.ReadLine());

            //if (true)
            //{

            //} 


            //kullanıcının sayısıyla dört işlem yap


            //    double s1, s2, sonuç;
            //    sonuç = 0;
            //    string opt = "";
            //b:

            //    try
            //    {

            //        Console.Write("Lütfen Birinci Sayıyı Giriniz = ");
            //        s1 = Convert.ToDouble(Console.ReadLine());

            //    basadon:
            //        Console.WriteLine("Lütfen Bir Operatör Giriniz (+,-,*,/,C) = ");
            //        opt = Console.ReadLine();

            //        Console.Write("Lütfen İkinci Sayıyı Giriniz = ");
            //        s2 = Convert.ToDouble(Console.ReadLine());



            //    if (opt == "+")
            //    {
            //        sonuç = s1 + s2;
            //        Console.WriteLine($"{s1}+{s2}={sonuç}");
            //        goto basadon;
            //    }


            //    else if (opt == "-")
            //    {
            //        sonuç = s1 - s2;
            //        Console.WriteLine($"{s1}-{s2}={sonuç}");
            //        goto basadon;

            //    }

            //    else if (opt == "*")
            //    {
            //        sonuç = s1 * s2;
            //        Console.WriteLine($"{s1}*{s2}={sonuç}");
            //        goto basadon;

            //    }

            //    else if (opt == "/")
            //    {
            //        sonuç = s1 / s2;
            //        Console.WriteLine($"{s1}/{s2}={sonuç}");
            //        goto basadon;

            //    }
            //    else if
            //    {
            //        Console.WriteLine("Lütfen İstenen Operatörlerden Birini Seçiniz");
            //        goto basadon;

            //    }
            //    else
            //    {
            //        Console.Clear();
            //    }

            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Sistemin Hata Mesajı..." + e);
            //    goto b;
            //}

            //Bir  komisyoncu aldığı  3 Ürünün fiyatlarının toplamı 500ün üzerindeyse yüzde 2 komisyon alıyor 500 ün altındaysa yüzde 3 komisyon alıyor 1000in üzerindeyse yüzde 1.5 komisyon alıyor bu komisyoncunun almış olduğu üç üründe toplam ne kadar kazanç olur?

            //double ü1, ü2, ü3,toplam,kazanç;

            //Console.WriteLine("İlk Ürün Fiyatını Giriniz = ");
            //ü1=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("İkinci Ürün Fiyatını Giriniz = ");
            //ü2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Üçüncü Ürün Fiyatını Giriniz = ");
            //ü3 = Convert.ToDouble(Console.ReadLine());
            //toplam = (ü1 + ü2 + ü3);
            //if (toplam > 0 && toplam==500)
            //{
            //    kazanç= toplam * 2 / 100;
            //    Console.WriteLine("Kazancınız = "+kazanç);

            //}
            //else if (toplam >500 && toplam <= 999)
            //{
            //    kazanç = toplam * 3 / 100;
            //    Console.WriteLine("Kazancınız = " + kazanç);
            //}
            //else if (toplam>1000&&toplam<=1500)
            //{
            //    kazanç = toplam * 1.5 / 100;
            //    Console.WriteLine("Kazancınız = " + kazanç);
            //}

            //else
            //{
            //    Console.WriteLine("Lütfen Uygun Bir Değer Giriniz");

            //}

            //double u1, u2, u3;
            //double toplam = 0;
            //double k = 0;

            //try
            //{

            //    Console.WriteLine("Lütfen Birinci Ürünü Giriniz");
            //    u1 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Lütfen İkinci Ürünü Giriniz");
            //    u2 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Lütfen Üçüncü Ürünü Giriniz");
            //    u3 = double.Parse(Console.ReadLine());
            //    toplam = u1 + u2 + u3;

            //    if (u1>0&&u2>0&&u3>00)
            //    {
            //        if (toplam <= 500)
            //        {
            //            k = (toplam * 3) / 100;
            //            Console.WriteLine($"toplam : {toplam} kazanç : {k}");
            //        }
            //        else if (toplam > 500 && toplam < 1000)
            //        {
            //            k = (toplam * 2) / 100;
            //            Console.WriteLine($"toplam : {toplam} kazanç : {k}");
            //        }

            //        else
            //        {
            //            k = (toplam * 1.5) / 100;
            //            Console.WriteLine($"toplam : {toplam} kazanç : {k}");
            //        }
            //    }

            //    else
            //    {
            //        Console.WriteLine("Lütfen Uygun Değer Giriniz");
            //    }


            //}
            //catch 
            //{
            //    Console.WriteLine("Lütfen Uygun Değer Giriniz");

            //}

            // Kullanıcı tarafından girilen sayının hem 3e hem hem 5e bölündüğünü kontrol eden program çıktısı

            //int sayi1;
            //Console.Write("Lütfen Bir Sayı Giriniz = ");
            //sayi1=Convert.ToInt32(Console.ReadLine());

            //if (sayi1%3==0 && sayi1%5==0 )
            //{
            //    Console.WriteLine($"Girdiğiniz Sayı Hem Üçe Hem Beşe Bölünebilmektedir : {sayi1}");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz Sayı Uygun Değildir");
            //}

            //Soru Kullanıcı Tarafından Girilen Birbirinden Farklı 3 Sayının Büyükten Küçüğe Ve Küçükten Büyüğe Doğru Sıralaması


            //int sayi1, sayi2, sayi3;
            //b:

            //Console.Write("Lütfen Birinci Tam Sayıyı Giriniz = ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen İkinci Tam Sayıyı Giriniz = ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen Üçüncü Tam Sayıyı Giriniz = ");
            //sayi3 = Convert.ToInt32(Console.ReadLine());

            //try
            //{

            //    if (sayi1 > sayi2 && sayi1 > sayi3)
            //    {
            //        if (sayi2 > sayi3)
            //        {
            //            Console.WriteLine($"{sayi1} > {sayi2} > {sayi3}");
            //            Console.WriteLine($"{sayi3} <  {sayi2} < {sayi1}");
            //            goto b;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{sayi1} > {sayi3} > {sayi2}");
            //            Console.WriteLine($"{sayi2} <  {sayi3} < {sayi1}");
            //            goto b;
            //        }



            //    }


            //    else if (sayi2 > sayi1 && sayi2 > sayi3)
            //    {
            //        if (sayi1 > sayi3)
            //        {
            //            Console.WriteLine($"{sayi2} > {sayi1} > {sayi3}");
            //            Console.WriteLine($"{sayi3} <  {sayi1} < {sayi2}");
            //            goto b;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{sayi2} > {sayi3} > {sayi1}");
            //            Console.WriteLine($"{sayi1} <  {sayi3} < {sayi2}");
            //            goto b;
            //        }


            //    }


            //    else if (sayi3 > sayi1 && sayi3 > sayi2)
            //    {
            //        if (sayi1 > sayi2)
            //        {
            //            Console.WriteLine($"{sayi3} > {sayi1} > {sayi2}");
            //            Console.WriteLine($"{sayi2} <  {sayi1} < {sayi3}");
            //            goto b;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{sayi3} > {sayi2} > {sayi1}");
            //            Console.WriteLine($"{sayi1} <  {sayi2} < {sayi3}");
            //            goto b;
            //        }



            //    }
            //    else
            //    {
            //        Console.WriteLine("Lütfen Uygun Değer Giriniz");
            //        goto b;
            //    }

            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Lütfen Uygun Değer Giriniz " + e);
            //    goto b;
            //}


            #endregion

            #region Soru

            //Bir otoparkta ilk saat için 40 Tl bir sonraki saat için ilk saatin yüzde altmış beşi kadar ekleniyor daha sonraki her saat için yüzde on ekleniyor.Beş saat kalan biri toplam ne kadar ödeme yapar?
            //KalınanDakika = KalınanSure * 60;
            //double sayi = 40;
            //double sonuc;
            //double saat;

            //Console.Write("Lütfen Kaç Saat Kaldığınızı Belirtiniz = ");
            //saat = Convert.ToDouble(Console.ReadLine());


            //if (saat == 1)
            //{
            //    Console.WriteLine($"Kalınan Süre = {saat} Ödenecek Ücret = {sayi}");
            //}
            //else if (saat == 2)
            //{
            //    sonuc = (sayi * 25) / 100 + sayi;
            //    Console.WriteLine($"Kalınan Süre = {saat} Ödenecek Ücret = {sonuc}");
            //}
            //else if (sayi > 2 && sayi <= 5)
            //{
            //    if (sayi > 2 && sayi <= 3)
            //    {
            //        sonuc = (sayi * 30) / 100 + sayi;
            //        Console.WriteLine($"Kalınan Süre = {saat} Ödenecek Ücret = {sonuc}");
            //    }

            //    else if (sayi > 3 && sayi <= 4)
            //    {
            //        sonuc = (sayi * 40) / 100 + sayi;
            //        Console.WriteLine($"Kalınan Süre = {saat} Ödenecek Ücret = {sonuc}");
            //    }


            //    else
            //    {
            //        sonuc = (sayi * 50) / 100 + sayi;
            //        Console.WriteLine($"Kalınan Süre = {saat} Ödenecek Ücret = {sonuc}");
            //    }


            //}


            #endregion

            #region switch-Case

            // Eğer kontrol yapısında çok fazla dallanma varsa switch-case kullanılır
            //string sayi = "";
            //Console.Write("Bugün Haftanın Kaçıncı Günü ? = ");
            //sayi=Console.ReadLine();


            //if (sayi=="1")
            //{
            //    Console.WriteLine("Bugün Pazartesi");
            //}

            //else  if (sayi == "2")
            //{
            //    Console.WriteLine("Bugün Salı");
            //}
            //else if (sayi == "3")
            //{
            //    Console.WriteLine("Bugün Çarşamba");
            //}
            //else if (sayi == "4")
            //{
            //    Console.WriteLine("Bugün Perşembe");
            //}
            //else if (sayi == "5")
            //{
            //    Console.WriteLine("Bugün Cuma");
            //}
            //else if (sayi == "6")
            //{
            //    Console.WriteLine("Bugün Cumartesi");
            //}
            //else if (sayi == "7")
            //{
            //    Console.WriteLine("Bugün Pazar");
            //}
            //else
            //{
            //    Console.WriteLine("Bir Hafta 7 Gündür");
            //}

            // 4 İşlem switch-case 

            //b:
            //try

            //{

            //    double sayi1, sayi2, sonuc;
            //    string opt;

            //    Console.Write("Lütfen Birinci Sayıyı Giriniz = ");
            //    sayi1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Lütfen Yapmak İstediğiniz İşlem Operatörünü Seçiniz (+,-,/,*)=  ");
            //    opt = Console.ReadLine();

            //    Console.Write("Lütfen İkinci Sayıyı Giriniz = ");
            //    sayi2 = Convert.ToDouble(Console.ReadLine());


            //    switch (opt)
            //    {
            //        case "+":
            //            sonuc = sayi1 + sayi2;
            //            Console.Clear();
            //            Console.WriteLine($"{sayi1}+{sayi2}={sonuc}");
            //            sayi1 = sonuc;
            //            goto b;
            //            break;
            //        case "-":
            //            sonuc = sayi1 - sayi2;
            //            Console.Clear();
            //            Console.WriteLine($"{sayi1}-{sayi2}={sonuc}");
            //            sayi1 = sonuc;
            //            goto b;
            //            break;
            //        case "/":
            //            sonuc = sayi1 / sayi2;
            //            Console.Clear();
            //            Console.WriteLine($"{sayi1}/{sayi2}={sonuc}");
            //            sayi1 = sonuc;
            //            goto b;
            //            break;

            //        case "*":
            //            sonuc = sayi1 * sayi2;
            //            Console.Clear();
            //            Console.WriteLine($"{sayi1}*{sayi2}={sonuc}");
            //            sayi1 = sonuc;
            //            goto b;
            //            break;


            //        default:
            //            Console.WriteLine("Lütfen Uygun Değer Giriniz Tekrar Operatör Girin");
            //            goto b;
            //            break;



            //    }

            //}
            //catch 
            //{

            //    Console.WriteLine("Lütfen Uygun Değer Giriniz ");
            //    goto b;

            //}


            #endregion

            #region Switch case 1

            //int sayi;

            //Console.Write("lÜTFEN BİR SAYİ GİRİN");
            //   sayi = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= sayi; i++)
            //{
            //    switch (i % 2)
            //    {
            //        case 0:
            //            Console.WriteLine($" {i} Çifttir");
            //            break;
            //        case 1:
            //            Console.WriteLine($" {i} Tektir ");
            //            break;

            //    }
            //}

            //Console.ReadLine();

            #endregion

            #region  switch case 2

            //Kullanıcı tarafından girilen sayma sayısına kadar çift veya tek sayıları ayrı ayrı yazdırın.


            //int sayi;

            //Console.Write("Lütfen bir sayı giriniz: ");
            //sayi = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= sayi; i++)
            //{ 
            //    switch (i % 2)
            //    {
            //        case 0:
            //            Console.WriteLine($" {i} Çifttir");
            //            break;
            //        case 1:
            //            Console.WriteLine($"{i} Tektir ");
            //                break;
            //        }

            //}

            #endregion

            #region switch case 3

            //Kullanıcı tarafından girilen sayıdan 3er 3er azaltarak yazdıran program çıktısı.

            //int sayi;

            //Console.Write("lütfen bir sayi girin ");
            //sayi = int.Parse(Console.ReadLine());

            //int baslangic = sayi;

            //switch (sayi % 3)
            //{
            //    case 0:
            //        for (int i = sayi - 3; i > 0;i -= 3)
            //        {
            //            Console.WriteLine(i);
            //        } 
            //        break;
            //        case 1:
            //        baslangic += 2;
            //        for (int i = baslangic; i > 0; i -= 3) 
            //        { 
            //            Console.WriteLine(i);

            //        }
            //        break;
            //        case 2:
            //        baslangic += 1;
            //        for (int i = baslangic; i > 0; i -= 3)
            //        {
            //            Console.WriteLine(i);
            //        }
            //        break ;

            //}

            #endregion

            #region switch case 4


            // 1 den 1 tane 2den 2 tane 3 ten 3 tane 5 ten 5 tane istiyorum


            //for (int i = 1; i <= 5; i++)
            //{
            //    switch (i)
            //    {
            //        case 1:
            //            Console.WriteLine("1");
            //            break;
            //        case 2:
            //            Console.WriteLine("22");
            //            break;
            //        case 3:
            //            Console.WriteLine("333");
            //            break;
            //        case 4:
            //            Console.WriteLine("4444");
            //            break;
            //        case 5:
            //            Console.WriteLine("55555");
            //            break;
            //    }
            //}


            #endregion

            #region switch case 5

            // 5ten 5 tane 4 ten 4tane 1e kadar program çıktısı.

            //for (int i = 5; i >= 1; i--)
            //{
            //    switch (i)
            //    {
            //        case 5:
            //            Console.WriteLine("55555");
            //            break;
            //        case 4:
            //            Console.WriteLine("4444");
            //            break;
            //        case 3:
            //            Console.WriteLine("333");
            //            break;
            //        case 2:
            //            Console.WriteLine("22");
            //            break;
            //        case 1:
            //            Console.WriteLine("1");
            //            break;
            //    }
            //}

            //Console.ReadLine();


            #endregion

            #region switch case 6

            //5443332222211111

            //for (int i = 5; i >= 1; i--)
            //{
            //    switch (i)
            //    {
            //        case 5:
            //            Console.Write("55555");
            //            break;
            //        case 4:
            //            Console.Write("44444");
            //            break;
            //        case 3:
            //            Console.Write("333");
            //            break;
            //        case 2:
            //            Console.Write("22");
            //            break;
            //        case 1:
            //            Console.Write("1");
            //            break;
            //    }
            //}

            //Console.ReadLine();


            #endregion

            #region switch case 7
            // if else kullanmadan kullanıcının girdiği sayıya kadar çift sayının toplamını girin

            //int sayi;
            //int ciftToplam = 0;

            //Console.Write("Lütfen Bir Sayı Giriniz = ");
            //sayi = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= sayi; i += 2)
            //{
            //    switch (i % 2)
            //    {
            //        case 0:
            //            ciftToplam +=i;
            //            break;
            //    }
            //}

            //Console.ReadLine();

            #endregion

            #region switch case 9

            //Kullanıcıdan girilen sayıya kadar fibonacci sayısını yazdırın.

            //int a = 1;
            //int b = 1;
            //int c = 0;

            //Console.WriteLine("Lütfen Bir Sayı Giriniz");
            //int ks = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //for (int i = 1; i <= ks; i++)
            //{
            //    switch (i % 3)
            //    {
            //        case 0:
            //            c = a + b;
            //            a = b;
            //            b = c;
            //            Console.WriteLine(c);
            //            break;

            //    }
            //}

            //Console.ReadLine();
            #endregion

            #region switch case 10

            // Kullanıcı tarafından girilen sayının asal olup olmadığını kontrol eden program

            //Console.Write("Lütfen Bir Sayı Giriniz = ");
            //int sayi = int.Parse(Console.ReadLine());
            //int sayac = 0;

            //for (int i = 2; i <= sayi / 2; i++)
            //{
            //    switch (sayi % i)
            //    {
            //        case 0:
            //            sayac++;
            //            break;

            //    }
            //}

            //switch (sayac)
            //{
            //    case 0:
            //        Console.WriteLine($"{sayi} Asaldır");
            //        break;
            //    default:
            //        Console.WriteLine($"{sayi} Asal Değil");
            //        break;
            //}
            //Console.ReadLine();

            #endregion

        }
    }
}
