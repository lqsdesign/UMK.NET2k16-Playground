using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace KoloryWPF2.ViewModel
{
    public class EdycjaKoloru : INotifyPropertyChanged
    {
        private Model.Kolor model = new Model.Kolor()
        {
            R = Properties.Settings.Default.R,
            G = Properties.Settings.Default.G,
            B = Properties.Settings.Default.B
        };

        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string nazwaWlasnosci)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nazwaWlasnosci));
        }

        private void zapiszStan()
        {
            Properties.Settings.Default.R = R;
            Properties.Settings.Default.G = G;
            Properties.Settings.Default.B = B;
            Properties.Settings.Default.Save(); //mało optymalne rozwiązanie
        }
        public byte R {
            get
            {
                return model.R;
            }
            set
            {
                model.R = value;
                zapiszStan();
                onPropertyChanged(nameof(R));
                onPropertyChanged(nameof(Kolor));
                onPropertyChanged(nameof(Pedzel));
            }
        }

        public byte G
        {
            get
            {
                return model.G;
            }
            set
            {
                model.G = value;
                zapiszStan();
                onPropertyChanged(nameof(G));
                onPropertyChanged(nameof(Kolor));
                onPropertyChanged(nameof(Pedzel));
            }
        }

        public byte B
        {
            get
            {
                return model.B;
            }
            set
            {
                model.B = value;
                zapiszStan();
                onPropertyChanged(nameof(B));
                onPropertyChanged(nameof(Kolor));
                onPropertyChanged(nameof(Pedzel));
            }
        }

        public Color Kolor
        {
            get
            {
                return Color.FromRgb(model.R, model.G, model.B);
            }
        }

        public Brush Pedzel
        {
            get
            {
                return new SolidColorBrush(Kolor);
            }
        }

        private ICommand resetuj = null;

        public ICommand Resetuj
        {
            get
            {
                if (resetuj == null)
                {
                    resetuj = new PSPiZK.MvvmCommand(
                        (object o) =>
                        {
                            R = 0;
                            G = 0;
                            B = 0;
                        },
                        (object o) =>
                        {
                            return R != 0 || G != 0 || B != 0;
                        });
                }
                return resetuj;
            }
        }
    }
}
