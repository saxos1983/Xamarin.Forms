namespace Mobile.Forms.Converters
{
    using System;
    using System.Globalization;

    using Xamarin.Forms;

    public class DoubleToPressureConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                             object parameter, CultureInfo culture)
        {
            var doubleValue = value as double?;

            return doubleValue.HasValue ? Math.Round(doubleValue.Value, 1) + "  hPa" : "-- hPa";
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}