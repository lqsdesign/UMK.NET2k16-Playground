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

    public class ByteToStringParseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string text = (string)value;
            byte result;
            if (byte.TryParse(text, out result)) return result;

            return 0;
        }
    }
}
