using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn___Rozmieszczenie_Towarów.Models
{
    public class regal
    {
        public char IdPoz { get; }
        public string Opis { get; }

        public regal(char idPoz, string opis)
        {
            IdPoz = idPoz;
            Opis = opis;
        }
        public regal(char idPoz)
        {
            IdPoz = idPoz;
        }
    }
}
