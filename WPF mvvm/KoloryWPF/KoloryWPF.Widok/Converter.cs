using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace KoloryWPF.Widok
{
    public class ModelToColorConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var tmp = (value as byte[]);
            byte _r = tmp[0];
            byte _g = tmp[1];
            byte _b = tmp[2];

            return new SolidColorBrush(Color.FromRgb(_r, _g, _b));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
