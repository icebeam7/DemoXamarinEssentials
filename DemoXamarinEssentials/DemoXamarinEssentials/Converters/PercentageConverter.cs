using System;
using System.Globalization;
using Xamarin.Forms;

namespace DemoXamarinEssentials.Converters
{
    public class PercentageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var porcentaje = (int)(((double)value) * 100);
                return string.Format($"{porcentaje} %");
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

