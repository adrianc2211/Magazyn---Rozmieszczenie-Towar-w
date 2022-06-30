using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Magazyn___Rozmieszczenie_Towarów.ViewModels
{
    internal class WyswietlProduktyViewModel:ViewModelBase
    {
        private readonly ObservableCollection<> _towary;
        public ICommand DodajProduktCommand { get; }

        public WyswietlProduktyViewModel()
        {

        }
    }
}
