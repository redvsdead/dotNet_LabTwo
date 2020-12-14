using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace dotNet_LabTwo
{
    public class LEConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null || parameter == null)
                return false;
            double dValue;
            double dParameter;
            if (!Double.TryParse(value.ToString(), out dValue) || !Double.TryParse(parameter.ToString(), out dParameter))
                return false;
            return (dValue < dParameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
