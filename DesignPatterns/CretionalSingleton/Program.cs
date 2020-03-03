using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CretionalSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             tasarım desenleri arasında creational grubuna ait en popüler yapılardandır. Uluslar arası standartlarda kullanım oranı %80 dir.
             Esas amaç; her daim nesnenin kullanım süresi boyunca bir nesnenin bir kez oluşturulup defelarca farklı konumlarda kullanılmasını sağlamaktır.(tekrar tekrar instance almadan)
             */
            //Singleton singleton = new Singleton();
            //var sonuc = singleton.Add(5, 3);
            //var sonuc2 = singleton.Add(3, 5);
            //var sonuc3 = singleton.Add(10, 3);
            //var sonuc4 = singleton.Add(25, 3);
            //Console.WriteLine(sonuc);
            //Console.Read();

            //int toplam1 = Singleton.Obje.Add(3, 5);
            //int toplam2 = Singleton.Obje.Add(5, 3);
            //int toplam3 = Singleton.Obje.Add(8, 16);

            Singleton2 singleton2 = Singleton2.Sinif;
            Console.WriteLine(singleton2.Get());
            Console.WriteLine(singleton2.Get());
            Console.Read();
        }
    }
}
