using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartBuilder_WFA
{
    public class AmericanExpressConcreteBuilder : KrediKartiBuilder
    {
        public AmericanExpressConcreteBuilder()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi(string bankaAdi)
        {
            kart.BankaAdi = bankaAdi;
        }

        public override void KartLimit(decimal kartLimit)
        {
            kart.Limit = kartLimit;
        }

        public override void KartTipi(string kartTipi)
        {
            kart.KartTipi = kartTipi;
        }

        public override void Taksit(bool taksit)
        {
            kart.Taksit = taksit;
        }
    }
}
