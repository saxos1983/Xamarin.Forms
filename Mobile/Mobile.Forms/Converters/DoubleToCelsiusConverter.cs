using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Forms.Converters
{
    using System.Globalization;

    using Xamarin.Forms;

    class DoubleToCelsiusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            var doubleValue = value as double?;

            return doubleValue.HasValue ? Math.Round(doubleValue.Value, 1) + " °C" : "-- °C";
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}