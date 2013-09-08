using System;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;


namespace TextBlockHW
{
    class colorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(Brush))
            {
                return null;
            }
            //int age = int.Parse(value.ToString());
            string color = value.ToString();
            //int age = int.Parse(value.ToString());
            if (color=="#ff0000")
            {
                return Brushes.Red;
            }
            else if (color == "#00ff00")
            {
                return Brushes.Green;
            }
            else if (color == "#0000ff")
            {
                return Brushes.Blue;
            }
            else
            {
                return Brushes.Bisque;
            }
           
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
