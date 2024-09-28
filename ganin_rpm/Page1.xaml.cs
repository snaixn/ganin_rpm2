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

namespace ganin_rpm
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void CheckSum_Click(object sender, RoutedEventArgs e)
        {
            string input = InputNumberTextBox.Text;
            if (input.Length == 6 && int.TryParse(input, out int number))
            {
                int firstThreeSum = input.Take(3).Sum(c => c - '0');
                int lastThreeSum = input.Skip(3).Sum(c => c - '0');

                if (firstThreeSum == lastThreeSum)
                {
                    ResultTextBlock.Text = "Суммы первых трех и последних трех цифр равны!";
                }
                else
                {
                    ResultTextBlock.Text = "Суммы не равны.";
                }
            }
            else
            {
                ResultTextBlock.Text = "Введите корректное шестизначное число.";
            }
        }
    }
}
