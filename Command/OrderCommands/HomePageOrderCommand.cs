using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseWPF.Command.OrderCommands
{
    public class HomePageOrderCommand
    {
        private MainWindowViewModel _mainwindowviewmodel;
        
        public HomePageOrderCommand(MainWindowViewModel mainwindowviewmodel)
        {
            _mainwindowviewmodel = mainwindowviewmodel;
        }
    }
}
