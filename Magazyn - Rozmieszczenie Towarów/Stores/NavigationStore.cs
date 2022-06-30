using Magazyn___Rozmieszczenie_Towarów.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn___Rozmieszczenie_Towarów.Stores
{
    public class NavigationStore
    {
        //w tej klasie przechowywany jest aktualnie wyświetlany viewmodel w oknie
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set 
            { 
                _currentViewModel = value; 
            }
        }
    }
}
