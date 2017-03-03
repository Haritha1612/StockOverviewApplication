﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace StockOverviewApplication.Converters
{
    /// <summary>
    /// Class that converts and converts back boolean value to its equivalent visibility option.
    /// </summary>
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && (bool)value == true)
            {
                return Visibility.Visible;
            }
            return Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return false;
        }
    }
}
