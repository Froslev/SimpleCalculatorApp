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

namespace SimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int firstnumber = 0;
        int secondnumber = 0;
        int total;
        

        public MainWindow()
        {
            InitializeComponent();

            /*
            bool quit = false;
            bool calculation = true;
            double num1, num2, result;
            string answer;
            */

        }

        private void num1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(num1.Text, out firstnumber))
            {
                
            }
            else
            {

            }

            
            
        }

        private void num2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(num2.Text, out secondnumber))
            {

            }
            else
            {

            }

        }

        private void result_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            total = firstnumber + secondnumber;
            result_textbox.Text = total.ToString();
        }

        private void btnSubtraction_Click(object sender, RoutedEventArgs e)
        {
            total = firstnumber - secondnumber;
            result_textbox.Text = total.ToString();
        }

        private void btnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            total = firstnumber * secondnumber;
            result_textbox.Text = total.ToString();
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            
            if (secondnumber == 0)
            {
                result_textbox.Text = "Cannot divide by 0";
            }
            else
            {
                total = firstnumber / secondnumber;

                result_textbox.Text = total.ToString();

                
            }
        }

        private void btnModulus_Click(object sender, RoutedEventArgs e)
        {
                
                total = firstnumber % secondnumber;
                result_textbox.Text = total.ToString();
        }

        private void btnQuitProgram_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void num1_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Text == "00") 
            {
                textBox.Clear();
            }

        }

        private void num2_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Text == "00")
            {
                textBox.Clear();
            }

        }

    }
}
