using BaseWPF.BaseClass.Basecommand;
using BaseWPF.BaseClass.BaseViewModel;
using BaseWPF.Navigation;
using BaseWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseWPF
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _currentViewModel;
        private CustomerViewModel custListViewModel = new CustomerViewModel();
        private OrderViewModel orderViewModelModel = new OrderViewModel();

        private List<MenuItemModel> _menuGenerale;



        public List<MenuItemModel> MenuGenerale
        {
            get { return _menuGenerale; }
            set { _menuGenerale = value; OnPropertyChanged("MenuGenerale"); }
        }
        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { SetProperty(ref _currentViewModel, value); }
        }

        public MainWindowViewModel()
        {
            //NavCommand = new RelayCommand<string>(param => OnNavigate(param), null);
            HeaderContent = new HeaderPageViewModel(this);
            MainContent = _currentViewModel;
            
           // LoadMenu();
        }

    
       // public RelayCommand<string> NavCommand { get; private set; }

     

        private object _headerContent;

        public object HeaderContent
        {
            get
            {
                return _headerContent;
            }

            set
            {
                _headerContent = value;
                OnPropertyChanged("HeaderContent");
            }
        }

        private ViewModelBase _mainContent;


        public ViewModelBase MainContent
        {
            get
            {
                return _mainContent;
            }

            set
            {
                _mainContent = value;
                OnPropertyChanged("MainContent");
            }
        }
    }
}
