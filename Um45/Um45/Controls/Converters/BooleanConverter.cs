using System;
using System.Globalization;
using Xamarin.Forms;

namespace Um45.Controls.Converters
{
    public class BooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = false;
            try
            {
                result = (bool) value;
            }
            catch
            {
                // ignored
            }
            return !result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}