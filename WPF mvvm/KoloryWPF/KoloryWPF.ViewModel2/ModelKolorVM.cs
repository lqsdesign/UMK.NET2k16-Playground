using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoloryWPF.Model;

namespace KoloryWPF.ViewModel
{
    public class ModelKolorVM : INotifyPropertyChanged
    {
        private ModelKolor model = new ModelKolor(100, 0, 0);

        public byte color_R
        {
            get
            {
                return model.R;
            }
            set
            {
                model.SetColor('R', value);
                OnPropertyChanged(nameof(color_R));
            }
        }
        public byte color_G
        {
            get
            {
                return model.G;
            }
            set
            {
                model.SetColor('G', value);
                OnPropertyChanged(nameof(color_G));
            }
        }
        public byte color_B
        {
            get
            {
                return model.B;
            }
            set
            {
                model.SetColor('B', value);
                OnPropertyChanged(nameof(color_B));
            }
        }

        public byte[] color_RGB
        {
            get
            {
                return model.RGB;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string nazwaWlasnosci)
        {
            if (nazwaWlasnosci != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nazwaWlasnosci));
        }
    }
}