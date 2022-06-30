using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Magazyn___Rozmieszczenie_Towarów.ViewModels
{
    public class WyswietlProduktyViewModel:ViewModelBase
    {
        private readonly ObservableCollection<TowaryViewModel> _towary;
        public IEnumerable<TowaryViewModel> Towary => _towary;
        public ICommand DodajProduktCommand { get; }

        public WyswietlProduktyViewModel()
        {
            _towary = new ObservableCollection<TowaryViewModel>();

            _towary.Add(new TowaryViewModel(new Models.towary(2000,"Pergola z grotem",8)));
        }
    }
}
