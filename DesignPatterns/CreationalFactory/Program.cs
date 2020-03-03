using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator cr = new Creator();
            MobileApplication MobileAndroid = cr.FactoryMethod(AllMobileOs.AndroidOs);
            MobileApplication MobileIphone = cr.FactoryMethod(AllMobileOs.IphoneOs);
            MobileApplication MobileWindows = cr.FactoryMethod(AllMobileOs.WindowsOs);

            MobileIphone.Platform();
            MobileWindows.Platform();
            MobileAndroid.Platform();

            Console.ReadKey();

        }
    }
}
