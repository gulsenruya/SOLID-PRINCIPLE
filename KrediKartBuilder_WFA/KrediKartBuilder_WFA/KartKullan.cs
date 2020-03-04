using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartBuilder_WFA
{
    public class KartKullan
    {
        public void KartiKullan(KrediKartiBuilder kart, string bankaAdi, string kartTipi, decimal kartLimit, bool taksit)
        {
            kart.BankaAdi(bankaAdi);
            kart.KartTipi(kartTipi);
            kart.KartLimit(kartLimit);
            kart.Taksit(taksit);
        }
    }
}
