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
    public class ZajmijMiejsceViewModel:ViewModelBase
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

        private char IdPoz;
        public char _IdPoz
        {
            get { return _IdPoz; }
            set
            {
                _IdPoz = value;
                OnPropertyChange(nameof(IdPoz));
            }
        }

        private string _IloscT;
        public string IloscT
        {
            get { return _IloscT; }
            set
            {
                _IloscT = value;
                OnPropertyChange(nameof(IloscT));
            }
        }

        public ICommand DodajCommand { get; }
        public ICommand CancellCommand { get; }
        public ICommand GoToDodajProductViewCommand { get; }
        public ICommand GoToWyswietlProduktyViewCommand { get; }
        public ICommand GoToZajmijMiejsceViewCommand { get; }
        public ICommand GoToWsywietlRegalViewCommand { get; }

        public ZajmijMiejsceViewModel(NavigationStore navigationStore)
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
