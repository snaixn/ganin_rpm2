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
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void ShowSeriesLengths_Click(object sender, RoutedEventArgs e)
        {
            string[] inputArray = InputArrayTextBox.Text.Split(' ');
            int[] array = inputArray.Select(int.Parse).ToArray();
            List<int> seriesLengths = new List<int>();

            int count = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    count++;
                }
                else
                {
                    seriesLengths.Add(count);
                    count = 1;
                }
            }
            seriesLengths.Add(count);

            ResultTextBlock.Text = string.Join(", ", seriesLengths);
        }
    }
}
