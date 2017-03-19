using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04TextBoxBlock.Model;
using System.ComponentModel;

namespace _04TextBoxBlock.ViewModel
{
    public class textVM : INotifyPropertyChanged
    {
        textModel model = new textModel();

        public string Tekst
        {
            get
            {
                return model.Tekst;
            }
            set
            {
                model.Tekst = value;
                OnPropertyChanged(nameof(Tekst));
            }
        }

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
