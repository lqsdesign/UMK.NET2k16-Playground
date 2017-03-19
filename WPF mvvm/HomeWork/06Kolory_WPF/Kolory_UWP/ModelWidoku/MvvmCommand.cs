using System;
using System.Windows.Input;

namespace PSPiZK
{
    public class MvvmCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged;

        public MvvmCommand(Action<object> execute, Func<object,bool> canExecute = null)
        {
            if (execute == null) throw new ArgumentNullException(nameof(execute));
            else this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute == null) return true;
            else return canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
