using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBoxToTestBlock.Model;

namespace TextBoxToTextBlock.ViewModel
{
    public class Model_VM: INotifyPropertyChanged
    {
        private Model model = new Model();
        public string txt
        {
            get
            {
                return model.Text;
            }
            set
            {
                model.Text = value;
                OnPropertyChanged(nameof(txt));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string PropertiesName)
        {
            if (PropertiesName != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertiesName));
        }
    }
}
