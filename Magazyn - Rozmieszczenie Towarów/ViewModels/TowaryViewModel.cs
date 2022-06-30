using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazyn___Rozmieszczenie_Towarów.Models;

namespace Magazyn___Rozmieszczenie_Towarów.ViewModels
{
    public class TowaryViewModel:ViewModelBase
    {
        private readonly towary _towary;
        public int IdTowaru => _towary.IdTowaru;
        public string NazwaTowaru => _towary?.NazwaTowaru;
        public float WagaTowaru => _towary.waga;

        public TowaryViewModel(towary towary)
        {
            _towary = towary;
        }
    }
}
