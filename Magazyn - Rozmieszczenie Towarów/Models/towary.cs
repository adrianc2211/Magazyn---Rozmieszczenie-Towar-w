using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn___Rozmieszczenie_Towarów.Models
{
    public class towary
    {
        public int IdTowaru { get; set; } 
        public string NazwaTowaru { get; set; }
        public float waga { get; set; }

        public towary(int idTowaru, string nazwaTowaru, float Waga)
        {
            IdTowaru = idTowaru;
            NazwaTowaru = nazwaTowaru;
            waga = Waga;
        }

        public towary()
        {
        }
    }
}
