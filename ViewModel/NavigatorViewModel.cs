using BaseWPF.BaseClass.Basecommand;
using BaseWPF.BaseClass.BaseViewModel;
using BaseWPF.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace BaseWPF.ViewModel
{
    public class NavigatorViewModel:ViewModelBase,IDisposable
    {
        private ViewModelBase _currentViewModel;
        private CustomerViewModel custListViewModel = new CustomerViewModel();
        private OrderViewModel orderViewModelModel = new OrderViewModel();
        private MainWindowViewModel _mainwindowviewmodel;
        
        public NavigatorViewModel(MainWindowViewModel mainwindowviewmodel)
        {
            _mainwindowviewmodel = mainwindowviewmodel;
            NavCommand = new RelayCommand<string>(param => OnNavigate(param), null);
            LoadMenu();
        }
        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { SetProperty(ref _currentViewModel, value); }
        }
        private List<MenuItemModel> _menuGenerale;



        public List<MenuItemModel> MenuGenerale
        {
            get { return _menuGenerale; }
            set { _menuGenerale = value; OnPropertyChanged("MenuGenerale"); }
        }

        private void LoadMenu()
        {

            var menu = new List<MenuItemModel>();
            var orders = new MenuItemModel("Orders")
            {
                Text = "Orders",
                Command = new RelayCommand(param => OnNavigate(param), null)
            };
            var customers = new MenuItemModel("Customers")
            {
                Text = "Customers",
                Command = new RelayCommand(param => OnNavigate(param), null)
            };

            var accueil = new MenuItemModel("Accueil")
            {
                Text = "Accueil",
                Command = new RelayCommand(param => OnNavigate(param), null)
            };

            var company = new MenuItemModel("company")
            {
                Text = "company",

            };

            company.Children.Add(orders);
            company.Children.Add(customers);
            menu.Add(accueil);
            menu.Add(company);
            MenuGenerale = menu; ;
        }

        private void OnNavigate(object destination)
        {
             if (destination == null)
            {
                return;
            }
            string dest = destination.ToString().ToLower();
            switch (dest)
            {
                case "orders":
                    CurrentViewModel = orderViewModelModel;
                           break;
                case "customers":
                    CurrentViewModel = custListViewModel;
                    break;
                case "accueil":
                    CurrentViewModel = _mainwindowviewmodel;
                    break;
            }
            _mainwindowviewmodel.MainContent = CurrentViewModel;

        }

        public RelayCommand<string> NavCommand { get; private set; }

        #region disposable
        public void Dispose()
        {
           GC.SuppressFinalize(this);
        }
      
        #endregion
    }
}
