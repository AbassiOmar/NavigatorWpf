using BaseWPF.BaseClass.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseWPF.Model
{
    public class StudentModel : ViewModelBase
    {
        #region fileds
        private string firstname;
        private string lastname;
     

        public string Fullname
        {
            get { return firstname +" "+lastname; }
           
        }
        public string Lastname
        {
            get { return lastname; }
            set {
                lastname = value;
                OnPropertyChanged("Lastname");
                OnPropertyChanged("Fullname");
            }
        }

        public string Firstname
        {
            get { return firstname; }
            set {
                firstname = value;
                OnPropertyChanged("Firstname");
                OnPropertyChanged("Fullname");
            }
        }


        public StudentModel()
        {

        }
        public StudentModel(string firstname,string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        #endregion
    }
}
