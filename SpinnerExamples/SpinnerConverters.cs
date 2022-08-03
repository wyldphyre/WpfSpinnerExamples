using System;
using System.Windows.Data;

namespace SpinnerExamples
{
    /// <summary>
    /// This converter is used to produce a clipping rectangle for the "ProgressArc" ellipse.
    /// It's job is to a rectangle in the top right of the width and height it is given, which will
    /// be used to clip the ellipse.
    /// </summary>
    public class SpinnerClipRectangleConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var halfWidth = (double)values[0] / 2;
            var halfHeight = (double)values[1] / 2;

            return new System.Windows.Rect(halfWidth, 0, halfWidth, halfHeight);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
