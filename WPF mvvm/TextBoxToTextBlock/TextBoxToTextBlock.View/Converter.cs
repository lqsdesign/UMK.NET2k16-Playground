using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace TextBoxToTextBlock.View
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int tmp = (value as string).Length;

            byte _r = (byte)tmp;
            byte _g = (byte)(tmp + 255);
            byte _b = (byte)(0 - tmp * 2);
            return new SolidColorBrush(Color.FromRgb(_r, _g, _b));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
