using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace WpfApp2
{
    public class Converter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            int day = (int)values[0];
            int month = (int)values[1];
            int year = (int)values[2];

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day == 31)
                {
                    return new DateTime(year, month, day);
                }
            }
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day == 30)
                {
                    return new DateTime(year, month, day);
                }
            }
            if (month == 2)
            {
                if (year % 4 == 0 && day == 29)
                {
                    return new DateTime(year, month, day);
                }
            }
            return new DateTime(year, month, day);
        }


        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            object[] arr = new object[3];
            arr[0] = ((DateTime)value).Day;
            arr[1] = ((DateTime)value).Month;
            arr[2] = ((DateTime)value).Year;
            return arr;
        }
    }
}
