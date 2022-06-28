using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn___Rozmieszczenie_Towarów.Models
{
    internal class historia
    {
        public int IdAkcja { get; set; }
        public regal IdPoz { get; set; }
        public towary IdTowaru { get; set; }
        public int Ilosc { get; set; }
        public DateTime DataUmieszczenia { get; set; }
        public DateTime DataSciagniecia { get; set; }
    }
}
