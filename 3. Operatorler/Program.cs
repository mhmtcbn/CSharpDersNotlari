using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region toplama ve cikarma

            // toplama operatoru: +
            // çıkarma operatoru: -

            //int sayi1 = 5;
            //int sayi2 = 45;
            //int sayi3 = 32;

            //int toplama = sayi1 + sayi2;
            //int cikarma = sayi2 - sayi3;

            //int sonuc = (sayi1 + sayi2 + sayi3) - sayi2;

            //Console.WriteLine(toplama);
            //Console.WriteLine(cikarma);
            //Console.WriteLine(sonuc);
            //Console.ReadLine();

            #endregion

            #region carpma ve bolme

            // çarpma operatoru: *
            // bölme operatörü: /

            //int sayi1 = 5;
            //int sayi2 = 45;
            //int sayi3 = 32;
            //int sayi4 = 64;

            //int carpma = sayi1 * sayi2;
            //int bolme = sayi4 / sayi1;

            //Console.WriteLine(carpma);
            //Console.WriteLine(bolme);
            //Console.ReadLine();

            #endregion

            #region mod alma

            // mod alma operatoru: %
            // mod almak bir sayının bir sayıya bölümünden kalan değeri verir

            //int sayi1 = 3;
            //int sayi2 = 10;
            //int sayi3 = 32;
            //int sayi4 = 64;

            //Console.WriteLine(sayi4%sayi1);
            //Console.ReadLine();

            #endregion

            #region arttirma ve azaltma

            // arttirma operatoru ++
            // eksiltme operatoru --

            //int sayi = 20;

            //sayi++; // sayı değerimizi 1 arttırdık
            //sayi--; // sayı değerimizi 1 eksilttik

            //Console.WriteLine(sayi);
            //Console.ReadLine();

            #endregion

            #region atama

            // atama operatoru: =

            // int yas = 21;

            #endregion

            #region esittir

            // eşittir operatoru: ==

            //int sayi1 = 5;
            //int sayi2 = 5;
            //int sayi3 = 3;

            //bool kontrolEt = sayi1 == sayi2;
            //bool kontrolEt2 = sayi1 == sayi3;

            //Console.WriteLine(kontrolEt);
            //Console.WriteLine(kontrolEt2);
            //Console.ReadLine();

            #endregion

            #region esitDegildir

            // eşit değildir !=

            //int sayi1 = 5;
            //int sayi2 = 5;
            //int sayi3 = 3;

            //bool kontrolEt = sayi1 != sayi2;
            //bool kontrolEt2 = sayi1 != sayi3;

            //Console.WriteLine(kontrolEt);
            //Console.WriteLine(kontrolEt2);
            //Console.ReadLine();

            #endregion

            #region BuyukturveBuyukEsittir

            // büyüktür operatörü: >
            // Büyük veya Eşittir Operatörü: >=

            //int yas = 18;

            //bool kontrolEt = yas > 18;
            //bool kontrolEt2 = yas >= 18;


            //Console.WriteLine(kontrolEt);
            //Console.WriteLine(kontrolEt2);
            //Console.ReadLine();

            #endregion

            #region kucukturvekucukesittir

            // küçüktür operatörü: <
            // küçük veya eşittir operatörü: <=

            //int yas = 18;

            //bool kontrolEt = yas < 18;
            //bool kontrolEt2 = yas <= 18;

            //Console.WriteLine(kontrolEt);
            //Console.WriteLine(kontrolEt2);
            //Console.ReadLine();

            #endregion

            #region ve

            // ve operatörü &&

            //int sayi1 = 5;
            //int sayi2 = 5;
            //int sayi3 = 20;

            //bool kontrolEt = sayi1 == sayi2 && sayi2 < sayi3;
            //bool kontrolE2 = sayi1 == sayi2 && sayi2 > sayi3;

            //Console.WriteLine(kontrolEt);
            //Console.WriteLine(kontrolE2);
            //Console.ReadLine();

            #endregion

            #region veya

            // veya operatörü: ||

            //int sayi1 = 3;
            //int sayi2 = 3;
            //int sayi3 = 6;

            //bool kontrolEt = sayi1 == sayi2 || sayi2 > sayi3;
            //bool kontrolE2 = sayi1 != sayi2 || sayi2 > sayi3;

            //Console.WriteLine(kontrolEt);
            //Console.WriteLine(kontrolE2);
            //Console.ReadLine();

            #endregion

            #region degil

            // değil operatörü: !
            // var olan birşeyi tersine çevirir

            //bool a = true; // normalde ekrana yazdırdığımda true olması lazım ama ! kullandığımda tam tersi çıkıyor.

            //Console.WriteLine(!a);
            //Console.ReadLine();

            #endregion

            #region ek operatorler

            // +=
            // -=
            // /=
            // *=
            // işlemlerin kısaltılmış halleridir.

            int a = 6;

            // a = a + 4;
            // a += 4;
            // a = a - 3;
            // a -= 3;
            // a = a * 3;
            // a *= 3;
            // a = a / 2;
            a /= 2;


            Console.WriteLine(a);
            Console.ReadLine();

            #endregion

        }
    }
}
