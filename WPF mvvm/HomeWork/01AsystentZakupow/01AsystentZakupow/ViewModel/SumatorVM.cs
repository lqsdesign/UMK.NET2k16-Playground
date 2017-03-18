using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01AsystentZakupow.Model;
using System.Windows.Input;
using PSPiZK;

namespace _01AsystentZakupow.ViewModel
{
    public class SumatorVM : INotifyPropertyChanged
    {
        Sumator model = new Sumator(0, 200);

        public decimal Suma
        {
            get
            {
                return model.Suma;
            }
            private set
            {
                model.Suma = value;
            }
        }

        private void dodajKwote(decimal kwota)
        {
            if (!czyKwotaPoprawna(kwota))
                throw new ArgumentOutOfRangeException(nameof(kwota));
            Suma += kwota;
        }

        private bool czyKwotaPoprawna(decimal kwota)
        {
            return kwota > 0 && !(Suma + kwota > model.Limit);
        }

        #region CommandHandler
        private ICommand dodajKwoteCommand = null;

        public ICommand DodajKwote
        {
            get
            {
                if (dodajKwoteCommand == null)
                    dodajKwoteCommand = new MvvmCommand(
                        (object parameter) =>
                        {
                            decimal kwota = (decimal)parameter;
                            dodajKwote(kwota);
                            OnPropertyChanged(nameof(Suma));
                        },
                        (object parameter) =>
                        {
                            if (parameter == null) return false;
                            decimal kwota = (decimal)parameter;
                            return czyKwotaPoprawna(kwota);
                        });
                return dodajKwoteCommand;
            }
        }
        #endregion

        #region EventHandler
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion 
    }
}
