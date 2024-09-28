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
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void SwapElements_Click(object sender, RoutedEventArgs e)
        {
            string[] inputArray = InputArrayTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array;
            try
            {
                array = inputArray.Select(s => int.Parse(s)).ToArray();
            }
            catch (FormatException)
            {
                ResultTextBlock.Text = "Ошибка: Введите только целые числа, разделённые пробелами.";
                return;
            }

            int maxNegativeIndex = -1;
            int minPositiveIndex = -1;
            int maxNegative = int.MinValue;
            int minPositive = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    if (array[i] == int.MinValue)
                    {
                        maxNegative = array[i];
                        maxNegativeIndex = i;
                    }
                    else if (maxNegative == int.MinValue || Math.Abs(array[i]) > Math.Abs(maxNegative))
                    {
                        maxNegative = array[i];
                        maxNegativeIndex = i;
                    }
                }

                if (array[i] > 0 && array[i] < minPositive)
                {
                    minPositive = array[i];
                    minPositiveIndex = i;
                }
            }

            if (maxNegativeIndex != -1 && minPositiveIndex != -1)
            {
                int temp = array[maxNegativeIndex];
                array[maxNegativeIndex] = array[minPositiveIndex];
                array[minPositiveIndex] = temp;

                ResultTextBlock.Text = $"Результат перестановки: {string.Join(", ", array)}";
            }
            else
            {
                ResultTextBlock.Text = "Не найдены подходящие элементы для перестановки.";
            }
        }
    }
}
