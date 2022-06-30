using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn___Rozmieszczenie_Towarów.Models
{
    public class regal
    {
        public string IdPoz { get; }
        public string Opis { get; }

        public regal(string idPoz, string opis)
        {
            IdPoz = idPoz;
            Opis = opis;
        }
        public regal(string idPoz)
        {
            IdPoz = idPoz;
        }
    }
}
