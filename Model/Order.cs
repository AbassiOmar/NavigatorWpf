using BaseWPF.BaseClass.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseWPF.Model
{
    public class Order : ViewModelBase
    {
        private string refrence;

        public string Refrence
        {
            get { return refrence; }
            set { refrence = value;
            OnPropertyChanged("Refrence");
            }
        }
        private DateTime datedebut;

        public DateTime Datedebut
        {
            get { return datedebut; }
            set { datedebut = value;
            OnPropertyChanged("Datedebut");
            }
        }
        private string qte;

        public string Qte
        {
            get { return qte; }
            set { qte = value;
            OnPropertyChanged("Qte");
            }
        }
    }
}
