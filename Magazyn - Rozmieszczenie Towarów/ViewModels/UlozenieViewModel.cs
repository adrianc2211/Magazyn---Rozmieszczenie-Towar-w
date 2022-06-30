using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazyn___Rozmieszczenie_Towarów.Models;

namespace Magazyn___Rozmieszczenie_Towarów.ViewModels
{
    public class UlozenieViewModel:ViewModelBase
    {
        private readonly ulozenie _ulozenie;
        public string IdPoz => _ulozenie?.IdPoz.ToString();
        public string IdTowaru => _ulozenie.IdTowaru.ToString();
        public int IloscT => _ulozenie.IloscT;

        public UlozenieViewModel(ulozenie ulozenie)
        {
            _ulozenie = ulozenie;
        }
    }
}
