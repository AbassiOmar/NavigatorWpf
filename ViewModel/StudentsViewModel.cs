﻿using BaseWPF.BaseClass.Basecommand;
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
    public class StudentsViewModel : ViewModelBase
    {
        private StudentModel _selectedStudent;
        public StudentModel SelectedStudent
        { 
            get { return _selectedStudent; }
            set { _selectedStudent = value; OnPropertyChanged("SelectedStudent"); }
        }


        public StudentsViewModel()
        {
            LoadStudentList();
           // DeleteCommand = new RelayCommand(param=>OnDelete(),param=>CanDelete());
        }
        public ObservableCollection<StudentModel> Listestudent
        {
            get;
            set;
        }

        public void LoadStudentList()
        {
            ObservableCollection<StudentModel> students = new ObservableCollection<StudentModel>();
            students.Add(new StudentModel("abassi", "omar"));
            students.Add(new StudentModel("abassi1", "omar1"));
            students.Add(new StudentModel("abassi2", "omar2"));
            Listestudent = students;
        }

        private RelayCommand<object> _deleteCommand;
        public RelayCommand<object> DeleteCommand
        {
          get
            {

                if (_deleteCommand == null)
                    _deleteCommand = new RelayCommand<object>(param => OnDelete(), param => CanDelete());
                return _deleteCommand;
            }

          
        }

        public bool CanDelete()
        {
            return (SelectedStudent == null) ? false : true;
        }
        public void OnDelete()
        {
            Listestudent.Remove(SelectedStudent);
        }
    }
}
