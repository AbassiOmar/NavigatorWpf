using BaseWPF.BaseClass.BaseViewModel;
using BaseWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseWPF.ViewModel
{
    public class OrderViewModel : ViewModelBase
    {
        public OrderViewModel()
        {
            LoadStudentList();
        }
        public void LoadStudentList()
        {
            ObservableCollection<Order> orders = new ObservableCollection<Order>();
            orders.Add(new Order() { Refrence = "0001", Datedebut = DateTime.Now, Qte = "10" });
            orders.Add(new Order() { Refrence = "0002", Datedebut = DateTime.Now, Qte = "20" });
            orders.Add(new Order() { Refrence = "0003", Datedebut = DateTime.Now, Qte = "30" });
            ListOrders = orders;
        }

        private ObservableCollection<Order> _listOrders;
        public ObservableCollection<Order> ListOrders
        {
            get
            {
                return _listOrders;
            }
            set
            {
                _listOrders = value;
                OnPropertyChanged("ListOrders");
            }
        }
    }
}
