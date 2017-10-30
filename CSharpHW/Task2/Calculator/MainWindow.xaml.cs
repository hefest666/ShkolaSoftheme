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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char symb = ' ';
        double lh = 0, rh = 0;
        double result = 0;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            symb = '-';
            label2.Content = symb;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            symb = '*';
            label2.Content = symb;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            symb = '/';
            label2.Content = symb;
        }  

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            symb = '+';
            label2.Content = symb;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            try
            {
                if (lhs.Text != "" || rhs.Text != "")
                {
                    lh = Double.Parse(lhs.Text);
                    rh = Double.Parse(rhs.Text);
                    switch (symb)
                    {
                        case '+':
                            result = lh + rh;
                            break;
                        case '-':
                            result = lh - rh;
                            break;
                        case '*':
                            result = lh * rh;
                            break;
                        case '/':
                            if (rhs.Text == "0")
                            {
                                label1.Content = "ERROR!";
                            }
                            else
                            {
                                result = lh / rh;
                            }
                            break;
                    }
                }                

                label1.Content = Math.Round(result, 2);
            }
            catch (System.FormatException)
            {
                label1.Content = "ERROR!";
            }
        }
    }
}
