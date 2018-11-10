using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Collections.Generic;

namespace DemoXamarinEssentials.Converters
{
    public class ConnectionProfileToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is List<ConnectionProfile>)
            {
                var perfiles = (List<ConnectionProfile>)value;
                return String.Join(", ", perfiles);
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

