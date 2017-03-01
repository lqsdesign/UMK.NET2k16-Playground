using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Kolory_WPF
{
    public class ColorToBrushConverter : IValueConverter
    {
        private SolidColorBrush brush = new SolidColorBrush();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            /*
            Color kolor = (Color)value;
            return new SolidColorBrush(kolor);
            */

            Color kolor = (Color)value;
            brush.Color = kolor;
            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SolidColorBrush brush = (SolidColorBrush)value;
            return brush.Color;
        }
    }
}
