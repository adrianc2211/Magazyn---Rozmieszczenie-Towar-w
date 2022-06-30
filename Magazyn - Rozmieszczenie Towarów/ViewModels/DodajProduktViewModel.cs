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
    public class DodajProduktViewModel : ViewModelBase
    {
        private int _IdTowaru;
        public int IdTowaru
        {
            get { return _IdTowaru; }
            set
            {
                _IdTowaru = value;
                OnPropertyChange(nameof(IdTowaru));
            }
        }

        private string _NazwaTowaru;
        public string NazwaTowaru
        {
            get { return _NazwaTowaru; }
            set
            {
                _NazwaTowaru = value;
                OnPropertyChange(nameof(NazwaTowaru));
            }
        }

        private string _WagaTowaru;
        public string WagaTowaru
        {
            get { return _WagaTowaru; }
            set
            {
                _WagaTowaru = value;
                OnPropertyChange(nameof(WagaTowaru));
            }
        }

        public ICommand DodajCommand { get; }
        public ICommand CancellCommand { get; }
        public ICommand GoToDodajProductViewCommand { get; }
        public ICommand GoToWyswietlProduktyViewCommand { get; }
        public ICommand GoToZajmijMiejsceViewCommand { get; }
        public ICommand GoToWsywietlRegalViewCommand { get; }

        public DodajProduktViewModel(NavigationStore navigationStore)
        {
            DodajCommand = new DodajCommand();
            CancellCommand = new CancellCommand();
            GoToWyswietlProduktyViewCommand = new GoToWyswietlProduktyViewCommand(navigationStore);
            GoToDodajProductViewCommand = new GoToDodajProductViewCommand(navigationStore);
            GoToZajmijMiejsceViewCommand = new GoToZajmijMiejsceViewCommand(navigationStore);
            GoToWsywietlRegalViewCommand = new GoToWsywietlRegalViewCommand(navigationStore);
        }
}
}
