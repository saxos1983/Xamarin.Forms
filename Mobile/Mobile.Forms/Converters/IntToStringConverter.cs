namespace Mobile.Forms.Converters
{
    using System;
    using System.Globalization;

    using Xamarin.Forms;

    public class IntToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                             object parameter, CultureInfo culture)
        {
            var intValue = value as int?;

            return intValue.HasValue ? intValue.Value.ToString() : "unknown";
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            int number = 0;
            int.TryParse((string)value, out number);
            return number;
        }
    }
}