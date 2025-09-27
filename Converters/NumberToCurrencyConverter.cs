using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace NhaHang.Converters
{
    public class NumberToCurrencyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int number)
                return number.ToString("N0", CultureInfo.InvariantCulture); // Có dấu ,
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
