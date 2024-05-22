using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Metotlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ekle();

            Program p = new Program();
            p.ekle2();
            p.ekle3();

            ekle4();
            ekle5();

            Console.ReadLine();
        }

        public static void Ekle()
        {
            Console.WriteLine("Bu Bir Metottur.");
        }

        private void ekle3()
        {
            Console.WriteLine("fjsdfhsofh");
        }

        public void ekle2()
        {
            Console.WriteLine("dasdasdasd");
        }
        public static void ekle4()
        {
            Console.WriteLine("ajdaskjdbakdbas");
        }
        private static void ekle5()
        {
            Console.WriteLine("daksdjhaksjdbak");
        }

    }
}
