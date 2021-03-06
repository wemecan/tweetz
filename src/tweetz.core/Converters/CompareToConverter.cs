﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace tweetz.core.Converters
{
    public class CompareToConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = value?.ToString();
            return val != null && val.Equals(parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return parameter;
        }
    }
}