using BaseWPF.BaseClass.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseWPF.ViewModel
{
    public class HeaderPageViewModel : ViewModelBase
    {
        private object _navContent;
        private MainWindowViewModel _mainviewmodel;

        public HeaderPageViewModel(MainWindowViewModel mainviewmodel)
        {
            _mainviewmodel = mainviewmodel;
        }
        /// <summary>
        /// Obtient le composant de navigation
        /// </summary>
        public object NavContent
        {
            get
            {
                if (_navContent == null)
                {
                    _navContent = new NavigatorViewModel(_mainviewmodel);
                }

                return _navContent;
            }
        }
    }
}
