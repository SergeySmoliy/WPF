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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        decimal num1;
        decimal num2;
        string operation;

        string num3;
        string num4;





        public MainWindow()
        {
            InitializeComponent();
        }


        public void input(string a)
        {
            if (screen.Text == "0")
            {
                screen.Text = a;
            }
            else
                screen.Text += a;
        }

        public void inputs(string b)
        {
            if (srit.Text == "0")
            {
                srit.Text = b;
            }
            else
                srit.Text += b;
        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            srit.Text = "";
            screen.Text = "";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            input("7");
            srit.Text = srit.Text + "7";

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            input("4");
            srit.Text = srit.Text + "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            input("1");
            srit.Text = srit.Text + "1";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            screen.Text = "";
            srit.Text = "";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            input("8");
            srit.Text = srit.Text + "8";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            input("5");
            srit.Text = srit.Text + "5";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            input("2");
            srit.Text = srit.Text + "2";
        }


        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            num1 = decimal.Parse(screen.Text);
            operation = "v";
            screen.Text = "0";

            srit.Text = srit.Text + "v";

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            input("9");
            srit.Text = srit.Text + "9";
        }


        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            input("/");
            srit.Text = srit.Text + "/";
        }



        private void Button_Click_20(object sender, EventArgs e)
        {


            num2 = decimal.Parse(screen.Text);
          
            switch (operation)
            {
                case "+":
                    {
                        screen.Text = (num1 + num2).ToString();

                        break;
                    }
                case "-":
                    {
                        screen.Text = (num1 - num2).ToString();
                        break;
                    }
                case "*":
                    {
                        screen.Text = (num1 * num2).ToString();
                        break;
                    }
                case "/":
                    {
                        screen.Text = (num1 / num2).ToString();
                        break;
                    }
                case "v":
                    {
                        screen.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                        break;
                    }
                case ".":
                    {

                        {

                            screen.Text =float.Parse (num3 + num4).ToString();
                        }

                        break;
                    }

            }



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            input("0");
            srit.Text = srit.Text + "0";
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            input("6");
            srit.Text = srit.Text + "6";
        }


        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            input("3");
            srit.Text = srit.Text + "3";
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {

            input(".");
            srit.Text = srit.Text + ".";
            screen.Text = "0";



        }

        private void operator_plus(object sender, RoutedEventArgs e)
        {



            input("+");
            srit.Text = srit.Text + "+";




            num1 = decimal.Parse(screen.Text);
            operation = "+";
            screen.Text = "0";
          
        }
    
        private void operator_minys(object sender, RoutedEventArgs e)
        {
          
          
            srit.Text = srit.Text + "-";




            num1 = decimal.Parse(screen.Text);
            operation = "-";
            screen.Text = "0";
        }

        private void operator_ymnoshit(object sender, RoutedEventArgs e)
        {
            

           
            srit.Text = srit.Text + "*";




            num1 = decimal.Parse(screen.Text);
            operation = "*";
            screen.Text = "0";

        }

        private void operator_podelit(object sender, RoutedEventArgs e)
        {
            
            srit.Text = srit.Text + "/";




            num1 = decimal.Parse(screen.Text);
            operation = "/";
            screen.Text = "0";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            srit.Text = "";
            screen.Text = "0";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ResourceDictionary newDictionary = new ResourceDictionary();

            newDictionary.Source = new Uri("Skin2.xaml", UriKind.Relative);
            this.Resources.MergedDictionaries[0] = newDictionary;




        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ResourceDictionary newDictionary = new ResourceDictionary();

            newDictionary.Source = new Uri("Skin1.xaml", UriKind.Relative);
            this.Resources.MergedDictionaries.Clear();
            this.Resources.MergedDictionaries.Add(newDictionary);
           

          

        }
    }
}
