using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace PasekPostępuSuwak
{
    public class Konwerter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double parametr = (double)value;
            byte r = (byte)(2.55 * parametr);
            byte g = (byte)(255 - r);
            Brush pędzel = new SolidColorBrush(Color.FromRgb(r, g, 0));
            return pędzel;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
