namespace BaseWPF.BaseClass.BaseViewModel
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        protected virtual bool ThrowOnInvalidPropertyName { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyname)
        {
            this.VerifyPropertyName(propertyname); PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null) { var e = new PropertyChangedEventArgs(propertyname); handler(this, e); }
        }

        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public void VerifyPropertyName(string propertyname)
        {
            if (TypeDescriptor.GetProperties(this)[propertyname] == null)
            {
                string message = "Invalid property name:" + propertyname;
                if (ThrowOnInvalidPropertyName)
                    throw new Exception(message);
                else
                    Debug.Fail(message);
            }
        }

        protected virtual void SetProperty<T>(ref T member, T val, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(member, val)) return;
            member = val;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
