﻿using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace DemoXamarinEssentials.Converters
{
    public class NetworkAccessToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is NetworkAccess)
                return value.ToString();

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

