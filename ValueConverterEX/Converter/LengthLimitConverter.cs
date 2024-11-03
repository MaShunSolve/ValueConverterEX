using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ValueConverterEX.Converter
{
    /// <summary>
    /// 字串長度Converter
    /// </summary>
    public class LengthLimitConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SolidColorBrush brush = Brushes.Azure;
            if (value is not null && value.ToString().Length > 5)
            {
                brush = Brushes.Chocolate;
            }
            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
