using Arma3Queue.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma3Queue.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AnotherViewCommand { get; set; }

        private object _currentView;
        public HomeViewModel HomeVM { get; set; }
        public AnotherViewModel AnotherVM { get; set; }

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView= value;
                OnPropertyChanged();
                
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            AnotherVM = new AnotherViewModel();
           CurrentView= HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView= HomeVM;
            });
            
            AnotherViewCommand = new RelayCommand(o =>
            {
                CurrentView= AnotherVM;
            });

        }


     
    }
}
