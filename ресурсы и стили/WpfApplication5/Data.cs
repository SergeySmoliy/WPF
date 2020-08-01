using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Globalization;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using WpfApp2;

namespace WpfApp5
{
    public class data : DependencyObject, INotifyPropertyChanged
    {
        public data()
        {
            DAY = 1;
            MONTH = 1;
            YEAR = 1990;
            MultiBinding binding = new MultiBinding();
            Binding bind1 = new Binding("DAY");
            bind1.Source = this;
            binding.Bindings.Add(bind1);

            Binding bind2 = new Binding("MONTH");
            bind2.Source = this;
            binding.Bindings.Add(bind2);

            Binding bind3 = new Binding("YEAR");
            bind3.Source = this;
            binding.Bindings.Add(bind3);

            binding.Converter = new Converter();
            binding.Mode = BindingMode.TwoWay;
            BindingOperations.SetBinding(this, DateProperty, binding);
        }

        public DateTime Date
        {
            get { return (DateTime)GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }
        public static readonly DependencyProperty DateProperty =
            DependencyProperty.Register("Date", typeof(DateTime), typeof(data));

        private int day;
        public int DAY
        {
            get { return day; }
            set
            {
                day = value; OnPropertyChanged("DAY");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private int month;
        public int MONTH
        {
            get { return month; }
            set
            {
                month = value; OnPropertyChanged("MONTH");
            }
        }
        private int year;



        public int YEAR
        {
            get { return year; }
            set
            {
                year = value; OnPropertyChanged("YEAR");
            }
        }


    }


    public class YearValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int year = Convert.ToInt32(value);
            if (year < 0)
                return new ValidationResult(false, "Error!");
            else
                return new ValidationResult(true, "Right!");
        }
    }

}



