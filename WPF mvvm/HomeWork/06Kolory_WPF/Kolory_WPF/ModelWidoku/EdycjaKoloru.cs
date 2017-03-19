//using System.Windows.Media;
using System.ComponentModel;
using System.Windows.Input;

#if WINDOWS_UWP
using Windows.UI;
#else
using System.Windows.Media;
#endif

namespace Kolory_WPF.ModelWidoku
{
    using DataAccessLayer;

    public class EdycjaKoloru : INotifyPropertyChanged
    {
        private Model.Kolor model = DAL.CzytajModel();

        private void zapiszStan()
        {
            DAL.ZapiszModel(model);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string nazwaWłasności)
        {
            if (PropertyChanged != null)
                PropertyChanged(
                    this,
                    new PropertyChangedEventArgs(nazwaWłasności));
        }

        public byte R
        {
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
                //onPropertyChanged(nameof(Pędzel));
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
                //onPropertyChanged(nameof(Pędzel));
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
                //onPropertyChanged(nameof(Pędzel));
            }
        }

        public Color Kolor
        {
            get
            {
                //return Color.FromRgb(model.R, model.G, model.B);
                return new Color() { R = model.R, G = model.G, B = model.B, A = 255 };
            }
        }

        /*
        public Brush Pędzel
        {
            get
            {
                return new SolidColorBrush(Kolor);
            }
        }
        */

        private ICommand resetuj = null;

        public ICommand Resetuj
        {
            get
            {
                if(resetuj == null)
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
