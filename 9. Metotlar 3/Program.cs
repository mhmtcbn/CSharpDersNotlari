using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _9.Metotlar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();

            p.Metot1();
            p.Metot2(1, true);
            var sonuc = 10 + p.Metot3();
            Console.WriteLine(sonuc);
            int c = 50;

            //Kullanıcı tarafından girilen iki sayının çıktısını veren metot

            Console.WriteLine("Lütfen bir Sayı Girin");
            int s1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı girin");
            int s2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(p.toplam(s1, s2));

            //SORU: Kullanıcı tarafından girilen sayıya kadar, sayıların toplamını veren program çıktısı

            //SORU: Kullanıcı tarafından girilen sayıya kadar, tek ve çift sayıları ayrı ayrı tek ve çift olarak veren metot

        }

        #region Geriye Değer Göndermeyen, Değer Almayan Metot

        public void Metot1()
        {
            Console.WriteLine("Geriye Değer Göndermeyen, Değer Almayan Metot");
            Console.ReadLine();
        }

        #endregion

        #region Geriye Değer Göndermeyen, Değer Alan Metot

        public void Metot2(int a, bool y)
        {
            Console.WriteLine(a + " " + y);
            Console.ReadLine();
        }

        #endregion

        #region Geriye Değer Döndüren, Değer Almayan Metot

        public int Metot3()
        {
            int a = 0;
            return a;
        }

        #endregion

        #region Geriye Değer Döndüren, Değer Alan Metot

        public int Metot4(int a, int b)
        {
            var sonuc = a + b;
            return sonuc;
        }

        #endregion

        #region Soru1

        public int toplam(int x, int y)


        { return x + y; }

        #endregion

        #region Soru2

        //Kullanıcı Tarafından Girilen sayıya kadar, sayıların toplamını veren program çıktısı.

        public int GirilenToplam(int a)
        {
            int toplam = 0;
            for (int i = 0; i < a; i++)
            {
                toplam = toplam + i;
            }
            return toplam;
        }

        #endregion

        #region Soru3

        //Kullanıcı tarafından girilen sayıya kadar, tek ve çift sayıları ayrı ayrı toplamını veren program çıktısını istediğiniz metotla yapın.
        public void TekCiftToplam(int a)
        {

            int tektoplam = 0;
            int cifttoplam = 0;

            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 1)
                {
                    tektoplam = tektoplam + i;
                }
                else if (i % 2 == 0)
                {
                    cifttoplam = cifttoplam + i;
                }

            }

            Console.WriteLine("Tek Sayıların Toplamı   : " + tektoplam);
            Console.WriteLine("Çift Sayıların Toplamı  : " + cifttoplam);
        }

        #endregion

        #region Soru4

        //Kullanıcı tarafından girilen sayıya kadar olan asal sayıları bulan program çıktısı.

        public void AsalSayi(int sayi)
        {

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i != 0)
                {

                    Console.WriteLine(i + "sayısı asaldır");
                }

            }

        }

        #endregion

    }
}
