using System;
using System.Globalization;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DemoXamarinEssentials.Converters
{
    public class BatteryPowerSourceToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is BatteryPowerSource)
                return value.ToString();

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

