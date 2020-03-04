using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartBuilder_WFA
{
    public class KrediKarti
    {
        public string BankaAdi { get; set; }
        public string KartTipi { get; set; }
        public decimal Limit { get; set; }
        public bool Taksit { get; set; }
        public override string ToString()
        {
            return $"{BankaAdi} bankasına ait müşteri {KartTipi} ni kullanmakta {Limit} TL limiti bulunmakta ve taksit imkanı {Taksit}";
        }
    }
}
