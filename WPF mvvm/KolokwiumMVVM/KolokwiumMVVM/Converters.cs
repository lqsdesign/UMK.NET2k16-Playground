using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace KolokwiumMVVM
{
    public class String2ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int length = 1;
            if (value != null) length = (value as string).Length;

            if (length < 6) return new SolidColorBrush(Colors.Red);
            if (length < 11) return new SolidColorBrush(Colors.Orange);
            if (length < 16) return new SolidColorBrush(Colors.Yellow);

            return new SolidColorBrush(Colors.LightGreen);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
