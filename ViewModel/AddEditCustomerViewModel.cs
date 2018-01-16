using BaseWPF.BaseClass.Basecommand;
using BaseWPF.BaseClass.BaseViewModel;
using BaseWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseWPF.ViewModel
{
    public class AddEditCustomerViewModel : ViewModelBase
    {
        #region command

        RelayCommand _saveCommand;
        RelayCommand _cancelCommand;

        public RelayCommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                    _saveCommand = new RelayCommand(param => OnSave(), param => CanSave());
                return _saveCommand;
            }
        }

        private bool CanSave()
        {
            return false;
        }

        private object OnSave()
        {
            throw new NotImplementedException();
        }
      

        public RelayCommand CancelCommand
        {
            get { return _cancelCommand; }
            set { _cancelCommand = value; }
        }
        #endregion

        public AddEditCustomerViewModel()
        {

        }

    }
}
