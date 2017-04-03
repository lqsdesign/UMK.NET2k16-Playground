using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PasekPostępuSuwak.Model;
using System.ComponentModel;
using PSPiZK;
using System.Windows.Input;

namespace PasekPostępuSuwak.ModelWidoku
{
    public class EdycjaWartości : INotifyPropertyChanged
    {
        private WartośćModel model = new WartośćModel() { Wartość = 50 };

        public double Wartość
        {
            get
            {
                return model.Wartość;
            }
            set
            {
                model.Wartość = value;
                OnPropertyChanged(nameof(Wartość));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string nazwaWłasności)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nazwaWłasności));
        }

        private ICommand resetujCommand;

        public ICommand Resetuj
        {
            get
            {
                if (resetujCommand == null)
                    resetujCommand = new MvvmCommand(
                        (object parameter) =>
                        {
                            Wartość = 0;
                        },
                        (object parameter) =>
                        {
                            return Wartość > 0;
                        });
                return resetujCommand;
            }
        }
    }
}
