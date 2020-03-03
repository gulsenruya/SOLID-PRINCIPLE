using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CretionalSingleton
{
    public class Singleton
    {
        //constructor private yapılarak dışarıdan instance alınmasını engelliyoruz.
        private Singleton()
        {

        }
        /*oluşturulan static nesnenin dışarıdan erişilmesini sağlamak için property tanımlıyoruz(dışarıdaki bağlantıyı sağladık) Encapsulation*/
        private static Singleton obje = new Singleton();
        public static Singleton Obje
        {
            get
            {
                return obje;
            }
        }
        public int Add(int s1,int s2)
        {
            return s1 + s2;
        }
    }
}
