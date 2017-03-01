using System;
using System.Globalization;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Kolory_UWP
{
    public class ColorToBrushConverter : IValueConverter
    {
        private SolidColorBrush brush = new SolidColorBrush();

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            /*
            Color kolor = (Color)value;
            return new SolidColorBrush(kolor);
            */

            Color kolor = (Color)value;
            brush.Color = kolor;
            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            SolidColorBrush brush = (SolidColorBrush)value;
            return brush.Color;
        }
    }

    public class ByteToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            byte bvalue = (byte)value;
            return (double)bvalue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            double dvalue = (double)value;
            return (byte)dvalue;
        }
    }
}
