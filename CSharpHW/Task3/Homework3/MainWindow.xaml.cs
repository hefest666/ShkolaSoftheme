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

namespace Homework3
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

        public bool CheckNum(string str)
        {           
            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsNumber(str[i]))
                {                    
                    return true;
                }                               
            }
            return false;
        }

        public bool CheckPhone(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsNumber(str[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckLenght(string str, int lenght)
        {
            if(str.Length > lenght)
            {
                return false;
            }
            else
            {
                return true;
            }            
        }

        public bool CheckBday(string str1, string str2, string str3)
        {
            try { 
                if ((str1.Length > 2 || str1 == "") || (str2.Length > 2 || str2 == "") || (str3.Length > 2 || str3 == ""))
                {
                    return false;
                }

                if (!CheckNum(str1) || !CheckNum(str2) || !CheckNum(str3))
                {
                    return false;
                }

                if ((int.Parse(str1) > 31 || int.Parse(str1) < 1) || (int.Parse(str2) > 12 || int.Parse(str2) < 1) || (int.Parse(str3) < 0))
                {
                    return false;
                }

            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }

        public bool CheckEmail(string str)
        {
            if (str == "")
            {
                return false;
            }
            
            return true;
        }

        private void fName_TextChanged(object sender, TextChangedEventArgs e)
        {           
        }        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //-------------Проверяем 1 поле на валидность
            if (!CheckNum(fName.Text) && fName.Text.Length < 255 && fName.Text != "")
            {
                 lbl1.Content = "+";
            }
            else
            {
                  lbl1.Content = "-";               
            }
            //-------------Проверяем 2 поле на валидность
            if (!CheckNum(lName.Text) && lName.Text.Length < 255 && lName.Text != "")
            {
                lbl2.Content = "+";
            }
            else
            {
                lbl2.Content = "-";
            }
            //-------------Проверяем 3 поле на валидность
            if (CheckBday(bDay.Text, bMounth.Text, bYear.Text))
            {
                lbl3.Content = "+";
            }
            else
            {
                lbl3.Content = "-";
            }
            //-------------Проверяем 4 поле на валидность
            if (rMale.IsChecked == true || rFemale.IsChecked == true)
            {
                lbl4.Content = "+";
            }
            else
            {
                lbl4.Content = "-";
            }
            //-------------Проверяем 5 поле на валидность
            if (CheckEmail(email.Text) )
            {
                lbl5.Content = "+";
            }
            else
            {
                lbl5.Content = "-";
            }
            //-------------Проверяем 6 поле на валидность
            if (phone.Text.Length < 1 || !CheckPhone(phone.Text))
            {
                lbl6.Content = "-";
            }
            else
            {
                lbl6.Content = "+";
            }
            //-------------Проверяем 7 поле на валидность
            if (textArea.Text.Length > 2000)
            {
                lbl7.Content = "-";
            }
            else
            {
                lbl7.Content = "+";
            }
            //lbl1.Content = checkNum(fName.Text) ? lbl1.Content = "-" : lbl1.Content = "+";
            //lbl2.Content = checkNum(lName.Text) ? lbl2.Content = "-" : lbl2.Content = "+";

            if(lbl1.Content == "+" && 
                lbl2.Content == "+" && 
                lbl3.Content == "+" &&
                lbl4.Content == "+" &&
                lbl5.Content == "+" &&
                lbl6.Content == "+" &&
                lbl7.Content == "+")
            {
                registr.Content = "Registration is succsessful!";
            }
            else
            {
                registr.Content = "Registration is NOT succsessful!!";
            }

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void bDay_TextChanged(object sender, TextChangedEventArgs e)
        {                      
        }

        private void textArea_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
