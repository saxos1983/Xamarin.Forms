namespace Mobile.Forms.Converters
{
    using System;
    using System.Globalization;

    using Xamarin.Forms;

    public class IntToHumidityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                             object parameter, CultureInfo culture)
        {
            var intValue = value as int?;

            return intValue.HasValue ? intValue.Value + "  %" : "-- %";
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}