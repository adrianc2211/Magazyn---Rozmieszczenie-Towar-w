using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn___Rozmieszczenie_Towarów.Models
{
    public class ulozenie
    {
        public ulozenie(regal idPoz, towary idTowaru, int iloscT)
        {
            IdPoz = idPoz;
            IdTowaru = idTowaru;
            IloscT = iloscT;
            DataUmieszczenia = DateTime.Now;
        }

        public regal IdPoz { get; set; }
        public towary IdTowaru { get; set; }
        public int IloscT { get; set; }
        public DateTime DataUmieszczenia { get; set; }
        public DateTime DataSciagniecia { get; set; }

        
    }
}
