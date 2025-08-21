using System;
using System.Globalization;
using System.Windows.Data;

namespace OpenSilverHelper.Converters;

/// <summary>
/// boolの反転コンバータ
/// </summary>
public class InverseBooleanConverter : IValueConverter
{

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return !(bool)value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
}
