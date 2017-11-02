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

namespace Task4_2
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

        public bool CheckDateRange(int d, int m, int y)
        {
            if ((d > 31 || d < 1) || (m > 12 || m < 1) || (y > 2017 || y < 1900))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ExtractNum(string d, int start, int finish)
        {
            string t = "";
            for (int i = start; i < finish; i++)
            {
                if (char.IsNumber(d[i]))
                {
                    t += d[i];
                }
            }

            return t;
        }

        public void CheckZodiak(int d, int m, int y)
        {
            //error.Content = "";
            if ((m == 3 && d >= 21) || (m == 4 && d <= 20))
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/2.png"));
            }
            else if ((m == 4 && d >= 21) || (m == 5 && d <= 21))
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/3.png"));
            }
            else if ((m == 5 && d >= 22) || (m == 6 && d <= 21))
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/4.png"));
            }
            else if ((m == 6 && d >= 22) || (m == 7 && d <= 23))
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/5.png"));
            }
            else if ((m == 7 && d >= 24) || (m == 8 && d <= 23))
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/6.png"));
            }
            else if ((m == 8 && d >= 24) || (m == 9 && d <= 23))
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/7.png"));
            }
            else if ((m == 9 && d >= 24) || (m == 10 && d <= 23))
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/8.png"));
            }
            else if ((m == 10 && d >= 24) || (m == 11 && d <= 22))
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/9.png"));
            }
            else if ((m == 11 && d >= 23) || (m == 12 && d <= 21))
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/10.png"));
            }
            else if ((m == 12 && d >= 22) || (m == 1 && d <= 20))
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/11.png"));
            }
            else if ((m == 1 && d >= 21) || (m == 2 && d <= 19))
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/12.png"));
            }
            else if ((m == 2 && d >= 20) || (m == 3 && d <= 20))
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/1.png"));
            }
            else
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/Error.png"));
                error.Content = "ОШИБКА!";
            }
        }

        private void bShow_Click(object sender, RoutedEventArgs e)
        {
            error.Content = "";
            int dd = 0, mm = 0, yy = 0;
            string temp = "";
            try
            {
                if (birthDay.Text[2].CompareTo('/') == 0 && birthDay.Text[5].CompareTo('/') == 0)
                {
                    temp += ExtractNum(birthDay.Text, 0, 2);

                    dd = int.Parse(temp);
                    temp = "";

                    temp += ExtractNum(birthDay.Text, 3, 5);
                    mm = int.Parse(temp);
                    temp = "";

                    temp += ExtractNum(birthDay.Text, 5, birthDay.Text.Length);
                    yy = int.Parse(temp);
                    temp = "";                    
                }
                else
                {
                    img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/Error.png"));
                    error.Content = "ОШИБКА!";
                }
            }
            catch (FormatException)
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/Error.png"));
                error.Content = "ОШИБКА!";
            }
            catch (IndexOutOfRangeException)
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/Error.png"));
                error.Content = "ОШИБКА!";
            }

            if (!CheckDateRange(dd, mm, yy))
            {
                CheckZodiak(dd, mm, yy);
            }
            else
            {
                img.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/Error.png"));
                error.Content = "ОШИБКА!";
            }

        }
    }
}
