using System;
using System.Globalization;
using System.Windows.Data;
using Task3._10._1.Models;

namespace Task3._10._1.ViewModels
{
    public class FurnitureTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is TreeType type)
            {
                switch (type)
                {
                    case TreeType.BirchTree:
                        return "Береза";
                    case TreeType.AppleTree:
                        return "Дикая яблоня";
                    case TreeType.HawthornTree:
                        return "Боярышник";
                    default:
                        return value != null ? value.ToString() : string.Empty;
                }
            }

            return value != null ? value.ToString() : string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string str)
            {
                switch (str)
                {
                    case "Береза":
                        return TreeType.BirchTree;
                    case "Дикая яблоня":
                        return TreeType.AppleTree;
                    case "Боярышник":
                        return TreeType.HawthornTree;
                    default:
                        throw new ArgumentException(string.Format("Неизвестный тип дерева: {0}", str));
                }
            }

            throw new ArgumentException("Некорректное значение для конвертации");
        }
    }
}

