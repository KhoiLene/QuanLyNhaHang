using System.ComponentModel;
using System.Collections.ObjectModel;
using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace NhaHang.Con;
public class SoLuongNhoHonBangChinConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int soLuong)
            return soLuong <= 9;
        return false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
