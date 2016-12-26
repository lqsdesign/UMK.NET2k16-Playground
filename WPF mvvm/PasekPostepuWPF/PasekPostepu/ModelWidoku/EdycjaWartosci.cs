using PasekPostepu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasekPostepu.ModelWidoku
{
    public class EdycjaWartosci : INotifyPropertyChanged
    {
        private WartoscModel model = new WartoscModel() { Wartosc = 50 };
        public double Wartosc
        {
            get
            {
                return model.Wartosc;
            }
            set
            {
                model.Wartosc = value;
                OnPropertyChanged(nameof(Wartosc));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string nazwaWlasnosci)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nazwaWlasnosci));
        }
    }
}
