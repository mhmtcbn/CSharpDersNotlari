using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan değer alıp ekrana yazdırma

            Console.WriteLine("Lütfen isminizi girin.");

            string isim = Console.ReadLine();

            Console.WriteLine("Lütfen soyisminizi girin.");

            string soyisim = Console.ReadLine();

            Console.WriteLine("Kullanıcının ismi ve soyismi: " + isim + " " + soyisim);
            Console.ReadLine();

        }
    }
}
