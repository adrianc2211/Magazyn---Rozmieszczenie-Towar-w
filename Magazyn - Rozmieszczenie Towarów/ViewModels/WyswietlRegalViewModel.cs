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
    public class WyswietlRegalViewModel:ViewModelBase
    {
        private readonly ObservableCollection<UlozenieViewModel> _ulozenie;
        public IEnumerable<UlozenieViewModel> Ulozenie => _ulozenie;

        public ICommand GoToDodajProductViewCommand { get; }
        public ICommand GoToWyswietlProduktyViewCommand { get; }
        public ICommand GoToZajmijMiejsceViewCommand { get; }
        public ICommand GoToWsywietlRegalViewCommand { get; }


        public WyswietlRegalViewModel(NavigationStore navigationStore)
        {
            _ulozenie = new ObservableCollection<UlozenieViewModel>();

            _ulozenie.Add(new UlozenieViewModel(new Models.ulozenie(new Models.regal("A001",""), new Models.towary(2000, "Pergola z grotem", 8), 12)));

            GoToDodajProductViewCommand = new GoToDodajProductViewCommand(navigationStore);
            GoToWyswietlProduktyViewCommand = new GoToWyswietlProduktyViewCommand(navigationStore);
            GoToZajmijMiejsceViewCommand = new GoToZajmijMiejsceViewCommand(navigationStore);
            GoToWsywietlRegalViewCommand = new GoToWsywietlRegalViewCommand(navigationStore);
        }
    }
}
