using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Task2._8_1
{
    internal class NameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if((string)value == "Яблоко")
                return "img/Apple.png";
            if ((string)value == "Банан")
                return "img/Banana.png";
            if ((string)value == "Холодильник")
                return "img/Fridge.png";
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
