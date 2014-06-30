using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Forms.Converters
{
    using System.Globalization;

    using Xamarin.Forms;

    class LongToDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                             object parameter, CultureInfo culture)
        {
            var longValue = value as long?;

            if (longValue.HasValue)
            {
                DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds((double)longValue).ToLocalTime();
                return dtDateTime.ToString("dd.MM.yyyy HH:mm:ss");
            }
            else
            {
                return "Time unknown";
            }
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}