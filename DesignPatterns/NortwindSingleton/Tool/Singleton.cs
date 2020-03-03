using NortwindSingleton.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindSingleton.Tool
{
    public class Singleton
    { 
        private Singleton()
        {

        }
        private static NORTHWNDEntities _db;
        public static NORTHWNDEntities db
        {
            get
            {
                if (_db == null)
                {
                    _db = new NORTHWNDEntities();
                }
                return _db;
            }
        }
    }
}
