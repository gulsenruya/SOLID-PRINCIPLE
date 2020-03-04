using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartBuilder_WFA
{
    public abstract class KrediKartiBuilder
    {
        //miras verdiğimizde kullanılacak anlamında 
        protected KrediKarti kart;
        public KrediKarti Kart
        {
            get
            {
                return kart;
            }
        }
        public abstract void BankaAdi(string bankaAdi);
        public abstract void KartTipi(string kartTipi);
        public abstract void KartLimit(decimal kartLimit);
        public abstract void Taksit(bool taksit);
    }
}
