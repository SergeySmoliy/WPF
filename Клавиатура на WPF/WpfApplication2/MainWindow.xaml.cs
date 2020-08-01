using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

     

        private void buton_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftShift||e.Key==Key.RightShift)
            {
                a0.Content = "~";
                a1.Content = "!";
                a2.Content = "@";
                a3.Content = "#";
                a4.Content = "$";
                a5.Content = "%";
                a6.Content = "^";
                a7.Content = "&";
                a8.Content = "*";
                a9.Content = "(";
                a10.Content = ")";
                a11.Content = "_";
                a12.Content = "+";



                s0.Content = "Q";
                s1.Content = "W";
                s2.Content = "E";
                s3.Content = "R";
                s4.Content = "T";
                s5.Content = "Y";
                s6.Content = "U";
                s7.Content = "I";
                s8.Content = "O";
                s9.Content = "P";




                f0.Content = "A";
                f1.Content = "S";
                f2.Content = "D";
                f3.Content = "F";
                f4.Content = "G";
                f5.Content = "H";
                f6.Content = "J";
                f7.Content = "K";
                f8.Content = "L";


                x0.Content = "Z";
                x1.Content = "X";
                x2.Content = "C";
                x3.Content = "V";
                x4.Content = "B";
                x5.Content = "N";
                x6.Content = "M";

                x7.Content = "<";
                x8.Content = ">";
                x9.Content = "?";


                f10.Content = "''";



              


                s10.Content = "{";
                s11.Content = "}";
                s12.Content = "|";

            }






            //if (e.Key == Key.LeftShift)
            //{
            //    a0.Content = "`";
            //    a1.Content = "1";
            //    a2.Content = "2";
            //    a3.Content = "3";
            //    a4.Content = "4";
            //    a5.Content = "5";
            //    a6.Content = "6";
            //    a7.Content = "7";
            //    a8.Content = "8";
            //    a9.Content = "9";
            //    a10.Content = "0";
            //    a11.Content = "-";
            //    a12.Content = "=";


            //}


        }

        private void buton_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftShift||e.Key==Key.RightShift)
            {
                a0.Content = "`";
                a1.Content = "1";
                a2.Content = "2";
                a3.Content = "3";
                a4.Content = "4";
                a5.Content = "5";
                a6.Content = "6";
                a7.Content = "7";
                a8.Content = "8";
                a9.Content = "9";
                a10.Content = "0";
                a11.Content = "-";
                a12.Content = "=";


                f9.Content = ";";











                s0.Content = "q";
                s1.Content = "w";
                s2.Content = "e";
                s3.Content = "r";
                s4.Content = "T";
                s5.Content = "y";
                s6.Content = "u";
                s7.Content = "i";
                s8.Content = "o";
                s9.Content = "p";




                f0.Content = "a";
                f1.Content = "s";
                f2.Content = "d";
                f3.Content = "f";
                f4.Content = "g";
                f5.Content = "h";
                f6.Content = "j";
                f7.Content = "k";
                f8.Content = "l";


                x0.Content = "z";
                x1.Content = "x";
                x2.Content = "c";
                x3.Content = "v";
                x4.Content = "b";
                x5.Content = "n";
                x6.Content = "m";






                x7.Content = ",";
                x8.Content = ".";
                x9.Content = "/";


                f9.Content = ":";



                f10.Content = "'";



                s10.Content = "[";
                s11.Content = "]";
                s12.Content = "/";



            }
        }

        private void buton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
