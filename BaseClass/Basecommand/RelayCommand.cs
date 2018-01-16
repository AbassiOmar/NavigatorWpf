namespace BaseWPF.BaseClass.Basecommand
{
    using System;
    using System.Diagnostics;
    using System.Windows.Input;

    /// <summary>
    /// classe pour executer une commande
    /// </summary>
    public class RelayCommand<T> : ICommand
    {
        #region fileds
        readonly Action<object> _execute;
        readonly Predicate<object> _canexecute;
        #endregion

        #region constructeurs
        /// <summary>
        /// création d'une nouvelle instance de <see cref="Relaycommand"/>
        /// </summary>
        /// <param name="execute">l'action à executer</param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {

        }
        public RelayCommand(Action<object> execute, Predicate<object> canexecute)
        {
            if (execute == null)
                throw new ArgumentNullException("cammnd vide");
            this._canexecute = canexecute;
            this._execute = execute;
        }
        #endregion

        #region Icommand region
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canexecute == null ? true : _canexecute(parameter);
        }

        
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        #endregion
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RelayCommand : ICommand
    {
        #region fileds
        readonly Action<object> _execute;
        readonly Predicate<object> _canexecute;
        #endregion

        #region constructeurs
        /// <summary>
        /// création d'une nouvelle instance de <see cref="Relaycommand"/>
        /// </summary>
        /// <param name="execute">l'action à executer</param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {

        }
        public RelayCommand(Action<object> execute, Predicate<object> canexecute)
        {
            if (execute == null)
                throw new ArgumentNullException("cammnd vide");
            this._canexecute = canexecute;
            this._execute = execute;
        }
        #endregion

        #region Icommand region
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canexecute == null ? true : _canexecute(parameter);
        }


        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        #endregion
    }
}
