using BaseWPF.BaseClass.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseWPF.BaseClass.Basecommand
{
    public class NavigationCommandBase : ViewModelBase
    {
        private MainWindowViewModel _mainwindowviewmodel;
        public NavigationCommandBase(MainWindowViewModel mainwindowviewmodel)
        {
            _mainwindowviewmodel = mainwindowviewmodel;

        }
    }
}
