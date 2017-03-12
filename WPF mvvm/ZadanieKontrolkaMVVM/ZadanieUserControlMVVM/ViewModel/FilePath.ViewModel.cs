using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieUserControlMVVM;
using ZadanieUserControlMVVM.Model;

namespace ZadanieUserControlMVVM.ViewModel
{
    using DataAccessLayer;
    using PSPiZK;
    using System.ComponentModel;
    using System.Windows.Input;

    public class FilePathVM : INotifyPropertyChanged
    {
        private FilePathModel model = DAL.LoadModel();

        private void saveApp()
        {
            DAL.SaveModel(model);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(
                    this,
                    new PropertyChangedEventArgs(propertyName));
        }

        public string FilePathString
        {
            get
            {
                return model.FilePathString;
            }
            set
            {
                model.FilePathString = value;
                saveApp();
                onPropertyChanged(nameof(FilePathString));
            }
        }
    }
}
