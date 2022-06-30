using Magazyn___Rozmieszczenie_Towarów.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn___Rozmieszczenie_Towarów.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;


        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
    }
}
