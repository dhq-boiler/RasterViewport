using RasterViewport.Core;
using System;
using System.Windows.Data;

namespace RasterViewport.Converters
{
    public class PathToWriteableBitmap : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string path = value as string;
            return Decorder.LoadBitmap(path);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
