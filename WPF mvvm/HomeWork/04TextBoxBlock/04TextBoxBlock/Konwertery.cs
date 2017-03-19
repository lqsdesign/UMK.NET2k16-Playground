using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace _04TextBoxBlock
{
    public class String2ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int length = 1;
            if (value != null) length = (value as string).Length;

            byte _r = (byte)(length*2);
            byte _g = (byte)(-length*2);
            byte _b = (byte)(length * 4);

            return new SolidColorBrush(Color.FromRgb(_r, _g, _b));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
