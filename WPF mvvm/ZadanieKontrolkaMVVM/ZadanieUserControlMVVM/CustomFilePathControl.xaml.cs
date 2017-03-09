using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZadanieUserControlMVVM
{
    /// <summary>
    /// Interaction logic for CustomFilePathControl.xaml
    /// </summary>
    public partial class CustomFilePathControl : UserControl
    {
        #region DependencyProperties

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(CustomFilePathControl));

        #endregion

        #region Commands

        public ICommand ButtonCommand
        {
            get { return (ICommand)GetValue(ButtonCommandProperty); }
            set { SetValue(ButtonCommandProperty, value); }
        }

        public static readonly DependencyProperty ButtonCommandProperty =
        DependencyProperty.Register(
            "ButtonCommand",
            typeof(ICommand),
            typeof(CustomFilePathControl));

        #endregion

        public CustomFilePathControl()
        {
            InitializeComponent();
        }
    }
}
