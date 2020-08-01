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

namespace WpfApplication4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool flag = true;
        
        public MainWindow()
        {
            InitializeComponent();
            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (button6.Content.ToString() == "")
            {
                if (flag == true)
                {
                    button6.Content = "X";
                    flag = false;
                }
                else
                {
                    button6.Content = "0";
                    flag = true;
                }
                proverka(button6);
            }

        }


     
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (button8.Content.ToString() == "")
            {
                if (flag == true)
                {
                    button8.Content = "X";
                    flag = false;
                }
                else
                {
                    button8.Content = "0";
                    flag = true;
                }
                proverka(button8);
            }

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (button9.Content.ToString() == "")
            {
                if (flag == true)
                {
                    button9.Content = "X";
                    flag = false;
                }
                else
                {
                    button9.Content = "0";
                    flag = true;
                }
                proverka(button9);
            }

        }

      
      
        public void proverka(Button b1)
        {
            if (button1.Content.ToString() == "X" && button2.Content.ToString() == "X" && button3.Content.ToString() == "X" || button4.Content.ToString() == "X" && button5.Content.ToString() == "X" && button6.Content.ToString() == "X" || button7.Content.ToString() == "X" && button8.Content.ToString() == "X" && button9.Content.ToString() == "X")
            {
                MessageBox.Show($"{b1.Content} has won");
                button1.Content = "";
                button2.Content = "";
                button3.Content = "";
                button4.Content = "";
                button5.Content = "";
                button6.Content = "";
                button7.Content = "";
                button8.Content = "";
                button9.Content = "";
            }
            else if (button1.Content.ToString() == "X" && button4.Content.ToString() == "X" && button7.Content.ToString() == "X" || button2.Content.ToString() == "X" && button5.Content.ToString() == "X" && button8.Content.ToString() == "X" || button3.Content.ToString() == "X" && button6.Content.ToString() == "X" && button9.Content.ToString() == "X")
            {
                MessageBox.Show($"{b1.Content} has won");
                button1.Content = "";
                button2.Content = "";
                button3.Content = "";
                button4.Content = "";
                button5.Content = "";
                button6.Content = "";
                button7.Content = "";
                button8.Content = "";
                button9.Content = "";
            }
            else if (button1.Content.ToString() == "X" && button5.Content.ToString() == "X" && button9.Content.ToString() == "X" || button3.Content.ToString() == "X" && button5.Content.ToString() == "X" && button7.Content.ToString() == "X")
            {
                MessageBox.Show($"{b1.Content} has won");
                button1.Content = "";
                button2.Content = "";
                button3.Content = "";
                button4.Content = "";
                button5.Content = "";
                button6.Content = "";
                button7.Content = "";
                button8.Content = "";
                button9.Content = "";
            }




            else if (button1.Content.ToString() == "0" && button2.Content.ToString() == "0" && button3.Content.ToString() == "0" || button4.Content.ToString() == "0" && button5.Content.ToString() == "0" && button6.Content.ToString() == "0" || button7.Content.ToString() == "0" && button8.Content.ToString() == "0" && button9.Content.ToString() == "0")
            {
                MessageBox.Show($"{b1.Content} has won");
                button1.Content = "";
                button2.Content = "";
                button3.Content = "";
                button4.Content = "";
                button5.Content = "";
                button6.Content = "";
                button7.Content = "";
                button8.Content = "";
                button9.Content = "";
            }
            else if (button1.Content.ToString() == "0" && button4.Content.ToString() == "0" && button7.Content.ToString() == "0" || button2.Content.ToString() == "0" && button5.Content.ToString() == "0" && button8.Content.ToString() == "0" || button3.Content.ToString() == "0" && button6.Content.ToString() == "0" && button9.Content.ToString() == "0")
            {
                MessageBox.Show($"{b1.Content} has won");
                button1.Content = "";
                button2.Content = "";
                button3.Content = "";
                button4.Content = "";
                button5.Content = "";
                button6.Content = "";
                button7.Content = "";
                button8.Content = "";
                button9.Content = "";
            }
            else if (button1.Content.ToString() == "0" && button5.Content.ToString() == "0" && button9.Content.ToString() == "0" || button3.Content.ToString() == "0" && button5.Content.ToString() == "0" && button7.Content.ToString() == "0")
            {
                MessageBox.Show($"{b1.Content} has won");
                button1.Content = "";
                button2.Content = "";
                button3.Content = "";
                button4.Content = "";
                button5.Content = "";
                button6.Content = "";
                button7.Content = "";
                button8.Content = "";
                button9.Content = "";
            }






            else if (button1.Content.ToString() != "" && button2.Content.ToString() != "" && button3.Content.ToString() != "" && button4.Content.ToString() != "" && button5.Content.ToString() != "" && button6.Content.ToString() != "" && button7.Content.ToString() != "" && button8.Content.ToString() != "" && button9.Content.ToString() != "")
            {
                MessageBox.Show($"TIE!");
                button1.Content = "";
                button2.Content = "";
                button3.Content = "";
                button4.Content = "";
                button5.Content = "";
                button6.Content = "";
                button7.Content = "";
                button8.Content = "";
                button9.Content = "";
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (button1.Content.ToString() == "")
            {
                if (flag == true)
                {
                    button1.Content = "X";
                    flag = false;
                }
                else
                {
                    button1.Content = "0";
                    flag = true;
                }
                proverka(button1);
            }
        }

       

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (button3.Content.ToString() == "")
            {
                if (flag == true)
                {
                    button3.Content = "X";
                    flag = false;
                }
                else
                {
                    button3.Content = "0";
                    flag = true;
                }
                proverka(button3);
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (button4.Content.ToString() == "")
            {
                if (flag == true)
                {
                    button4.Content = "X";
                    flag = false;
                }
                else
                {
                    button4.Content = "0";
                    flag = true;
                }
                proverka(button4);
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (button5.Content.ToString() == "")
            {
                if (flag == true)
                {
                    button5.Content = "X";
                    flag = false;
                }
                else
                {
                    button5.Content = "0";
                    flag = true;
                }
                proverka(button5);
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (button7.Content.ToString() == "")
            {
                if (flag == true)
                {
                    button7.Content = "X";
                    flag = false;
                }
                else
                {
                    button7.Content = "0";
                    flag = true;
                }
                proverka(button7);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (button2.Content.ToString() == "")
            {
                if (flag == true)
                {
                    button2.Content = "X";
                    flag = false;
                }
                else
                {
                    button2.Content = "0";
                    flag = true;
                }
                proverka(button2);
            }
        }
    }
}










