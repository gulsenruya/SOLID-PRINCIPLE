﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactory
{
    public class IphoneOS : MobileApplication
    {
        public override void Platform()
        {
           Console.WriteLine("Bu uygulama IPhoneIOs için çalışmaktadır.");
        }
    }
}
