using PetAdoptionApp.Helpers;
using System.Globalization;
using Color = Microsoft.Maui.Graphics.Color;

namespace PetAdoptionApp.Converters
{
    internal class HexStringToColourConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ColorUtilities.HexToColor((string)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return default;
        }
    }
}