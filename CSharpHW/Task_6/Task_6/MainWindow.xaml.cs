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

namespace Task_6
{   
    public partial class MainWindow : Window
    {
        private int numb;
        private int attempts = 3;
        Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (attempts < 1)
            {               
                numb = rand.Next(1, 11);
                attempts = 3;
                lbl.Content = "You have " + attempts + " attempts";
                MessageBox.Show("New game begin!");
            }
            else
            {
                MessageBox.Show("You can still guess!");
            }                        
        }

        private void BTry_Click(object sender, RoutedEventArgs e)
        {
            string result = "";
            
            try
            {
                if (attempts < 1)
                {
                    attempts = 0;
                    MessageBox.Show("You Lose!! Ganerate a new number.");                    
                }
                else
                {                                       
                    if (int.Parse(text.Text) > 10 || int.Parse(text.Text) < 1)
                    {
                        throw new OverflowException();
                    }

                    if (int.Parse(text.Text) == numb)
                    {
                        MessageBox.Show("You guessed! New number will generate.");
                        numb = rand.Next(1, 11);
                        attempts = 3;
                    }
                    else if (int.Parse(text.Text) != numb && attempts > 0)
                    {
                        attempts--;
                        MessageBox.Show("Try more!");
                    }
                    else
                    {
                        MessageBox.Show("You Lose!! Ganerate a new number.");
                    }
                }  
            }
            catch (FormatException ex)
            {   
                result = ex.Message;
                MessageBox.Show(result);
            }
            catch (OverflowException ex)
            {
                result = ex.Message;                
                MessageBox.Show(result);
            }

            lbl.Content = "You have " + attempts + " attempts";
        }
    }
}
