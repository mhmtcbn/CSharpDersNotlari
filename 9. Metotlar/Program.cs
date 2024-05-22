using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            /*
            Bir yöntem oluşturmak demektir.
            Belirli bir işlemi yerine getirmek için yazılan ve istenilen yerde çağırılan kod bloklarıdır.
            Bir işlem birçok basamaktan oluışabilir ve bu basamakların istenildiğinde çalışması gerekebilir.
            Yada bir basamak birden fazla yerde çalışması gerekebilir. Bu yüzden onu bir metotta tanımlayıp birden fazla yerde çağırıp çalıştırabiliriz.
            2 Tür metot vardır
            1- Mimari tarafından hazırlanmıştır. Örnek :  "static void Main(string[] args)"
            2- Kendi hazırladığımız metotlar. Önce tanımlanır. Sonra oluşturulur ve daha sonra kullanılır.
            Oluşturulurken dikkat edilmesi gereken: Erişim Belirteci - Niteleyici (varsa) - Dönüşüm Tipi - Metot Adı (parametre(varsa))
            Metotlar Classların içine tanımlanır, Metot aynı sınıfta ise farklı, farklı sınıftaysa erişim yöntemi farklılık gösterir.
            Static metotlar içerisinde Static metotlar kullanılır.
            
            
            Erişim  Belirteçleri : 
            public: (Halka açık anlamına gelir.) İstediğin yerde çapır kullan.
            private: (Özel anlamına gelir.) Sadece bulunduğu class'ın içinde çağırılabilir.
            Not: static bir metotun içerisinde static bir metot çağırılır.
            Not: Eğer bir metota erişmek istenirse bulunduğu class'ın ismiyle yeni bir nesne oluşturarak erişebilirsiniz. 
            Yeni bir nesnede 'new' keywordu ile oluşturulabilir. 
            Eğer bir metot geriye değer göndermiyorsa void keyword ü kullanılır
            Geriye değer döndürecek bir metotsa o tipte bir değeri göndermek zorundadır, yani değer tipi aynı olmalıdır.
            Değer döndürme varsa return kullanılır.
             */

            Ekle();
            #endregion

            Console.ReadLine();
        }

        public static void Ekle()
        {
            Console.WriteLine("Bu Bir Metottur.");
        }

    }
}
