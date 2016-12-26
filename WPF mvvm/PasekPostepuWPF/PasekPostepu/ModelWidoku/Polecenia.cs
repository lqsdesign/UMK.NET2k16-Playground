using AsystentZakupow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AsystentZakupow
{
    class DodajKwote : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public Sumator model;
        public DodajKwote(Sumator model)
        {
            this.model = model;
        }

        public bool CanExecute(object parameter)
        {
            if (parameter == null) return false;
            decimal kwota = (decimal)parameter;
            return model.CzyKwotaPoprawna(kwota);
        }

        public void Execute(object parameter)
        {
            decimal kwota = (decimal)parameter;
            model.DodajKwote(kwota);
        }
    }
}
