using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region byte

            //byte birinci = 5;
            //byte ikinci = 25;
            //byte ucuncu = 255; // byte veri tipi 0 ve 255 arasındaki sayıları tutabilir.

            //byte maxDeger = byte.MaxValue;
            //byte minDeger = byte.MinValue;

            //Console.WriteLine(birinci);
            //Console.WriteLine(ikinci);
            //Console.WriteLine(ucuncu);
            //Console.WriteLine(maxDeger);
            //Console.WriteLine(minDeger);
            //Console.ReadLine();

            #endregion

            #region short

            // short değişkeni -32768 ile 32767 arasındaki değerleri depolayabilir.

            //short sayi1 = 31444;
            //short sayi2 = -50;
            //short sayi3 = 13555;
            //// short sayi4 = 44999; sayı sınırların dışında olduğu için hata veriyor.

            //short maxDeger = short.MaxValue;
            //short minDeger = short.MinValue;

            //Console.WriteLine(maxDeger);
            //Console.ReadLine();

            #endregion

            #region int

            // int veri tipi -2.147.483.648 ile 2.147.483.647 arasında değer depolayabilir.
            // ram bellekte 4 byte yer kaplar.

            //int degisken1 = 15000;
            //int degisken2 = 2000000;
            //int degisken3 = -145000;

            //int maxDeger = int.MaxValue;
            //int minDeger = int.MinValue;

            //Console.WriteLine(degisken3);
            //Console.WriteLine(maxDeger);
            //Console.WriteLine(minDeger);
            //Console.ReadLine();

            #endregion

            #region long

            // long veri tipi -9,223,372,036,854,775,808 ile -9,223,372,036,854,775,807 arasında değer depolayabilir.
            // bellekte 8 byte yer kaplar

            //long degisken1 = 150555444443300;
            //long degisken2 = 20044664646000;
            //long degisken3 = -145434355446000;

            //long maxDeger = long.MaxValue;
            //long minDeger = long.MinValue;

            //Console.WriteLine(degisken3);
            //Console.WriteLine(maxDeger);
            //Console.WriteLine(minDeger);
            //Console.ReadLine();

            #endregion

            #region float

            // float ondalıklı sayıları girebildiğimiz veri tipi

            //float ondaliklisayi1 = 7.34F;
            //float ondaliklisayi2 = 45.44F;
            //float ondaliklisayi3 = 145.74F;
            //float ondaliklisayi4 = 15000.66F;

            //Console.WriteLine(ondaliklisayi4);

            //float maxDeger = float.MaxValue;
            //float minDeger = float.MinValue;

            //Console.WriteLine(maxDeger);
            //Console.WriteLine(minDeger);
            //Console.ReadLine();

            #endregion

            #region double

            // double ın float dan farkı dafa fazla basamak depolayabilmesi, 15 basamaklı ondalıklı sayı tutabilir

            //double ondaliklisayi1 = 103.55;
            //double ondaliklisayi2 = -250.6;

            //Console.WriteLine(ondaliklisayi2);
            //Console.ReadLine();

            #endregion

            #region char

            // tek karakter tutmak için char veri tipi kullanılabilir.
            // tek tırnak içerisinde tek değer olacak şekilde kullanılır.

            //char karakterE = 'E';
            //char karakterA = 'A';
            //char karakterM = 'M';

            //Console.WriteLine(karakterM);
            //Console.ReadLine();

            #endregion

            #region string

            // string veri tipinde metinleri tutmak için kullanırız

            //string isim1 = "Mehmet";
            //string isim2 = "Ayşegül";

            //string karsilama = "Hoşgeldiniz.";

            //Console.WriteLine(isim1 + " ve " + isim2);
            //Console.WriteLine(karsilama);
            //Console.ReadLine();

            #endregion

            #region bool

            // iki ihtimalin olduğu yerlerde true veya false olarak kullanılır.

            //bool kontrol1 = true; // dogru
            //bool kontrol2 = false; // yanlış

            //bool sonuc = 10 > 5; // bu şekilde bir kullanım ile cevabı da atayabilir.

            //Console.WriteLine(sonuc);
            //Console.ReadLine();

            #endregion

            #region object

            // tüm veri tiplerini kabul eder

            //object a = 5;
            //object b = "Ayşegül";
            //object c = 2.44;
            //object d = true;

            //Console.WriteLine(b);
            //Console.ReadLine();

            #endregion

        }
    }
}
