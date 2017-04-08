using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KolokwiumMVVM.Model;
using System.Windows.Input;

namespace KolokwiumMVVM.ViewModel
{
    public class textVM : INotifyPropertyChanged
    {
        TextModel model = new TextModel();

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

        #region ActionResetuj
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
                            Tekst = "";
                        },
                        (object o) =>
                        {
                            if (Tekst.Length > 0) return true;
                            return false;
                        });
                }
                return resetuj;
            }
        }
        #endregion
    }
}
