using Magazyn___Rozmieszczenie_Towarów.Stores;
using Magazyn___Rozmieszczenie_Towarów.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn___Rozmieszczenie_Towarów.Commands
{
    public class GoToDodajProductViewCommand : CommandBase
    {

        private readonly NavigationStore _navigationStore;

        public GoToDodajProductViewCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new DodajProduktViewModel( _navigationStore);
        }
    }
}
