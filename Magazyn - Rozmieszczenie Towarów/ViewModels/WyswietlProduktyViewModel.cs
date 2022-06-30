using Magazyn___Rozmieszczenie_Towarów.Commands;
using Magazyn___Rozmieszczenie_Towarów.Stores;
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

        public ICommand GoToDodajProductViewCommand { get; }
        public ICommand GoToWyswietlProduktyViewCommand { get; }
        public ICommand GoToZajmijMiejsceViewCommand { get; }
        public ICommand GoToWsywietlRegalViewCommand { get; }
        
            
        public WyswietlProduktyViewModel(NavigationStore navigationStore)
        {
            _towary = new ObservableCollection<TowaryViewModel>();

            _towary.Add(new TowaryViewModel(new Models.towary(2000,"Pergola z grotem",8)));

            GoToDodajProductViewCommand = new GoToDodajProductViewCommand(navigationStore);
            GoToWyswietlProduktyViewCommand = new GoToWyswietlProduktyViewCommand(navigationStore);
            GoToZajmijMiejsceViewCommand = new GoToZajmijMiejsceViewCommand(navigationStore);
            GoToWsywietlRegalViewCommand = new GoToWsywietlRegalViewCommand(navigationStore);
        }
    }
}
