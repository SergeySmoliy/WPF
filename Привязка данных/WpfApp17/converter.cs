using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp17
{
   public class BoolToStyleConverter :  IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
                         
        {
          //  return ((bool)value) ? FontWeights.Bold : FontWeights.Normal;

			if((bool)value==true)
			{
				return FontStyles.Italic;
			}
			else
			{
				return FontStyles.Normal;
			}

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
                                 
        {
            return FontStyles.Normal;
        }

    }
}
