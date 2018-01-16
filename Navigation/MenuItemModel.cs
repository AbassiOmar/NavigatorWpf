using BaseWPF.BaseClass.Basecommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseWPF.Navigation
{
    public class MenuItemModel
    {
        public string Text { get; set; }
        public List<MenuItemModel> Children { get; private set; }
        public RelayCommand Command { get; set; }
        public MenuItemModel(string item)
        {
            Text = item;
            Children = new List<MenuItemModel>();
        }
    }
}
