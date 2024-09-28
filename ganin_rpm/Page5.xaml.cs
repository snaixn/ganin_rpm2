using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ganin_rpm
{
    public partial class Page5 : Page
    {
        private MainWindow mainWindow;
        private int[,] array;

        public Page5(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void GenerateArray_Click(object sender, RoutedEventArgs e)
        {
            this.Height = 800;
            mainWindow.Height = 800;

            if (!int.TryParse(RowsTextBox.Text, out int rows) || !int.TryParse(ColumnsTextBox.Text, out int cols))
            {
                MessageBox.Show("Введите корректные значения для строк и столбцов!");
                return;
            }
            if (rows <= 5)
            {
                this.Height = 800;
                mainWindow.Height = 800;
            }
            else if (rows > 5 && rows < 8)
            {
                this.Height = 900;
                mainWindow.Height = 900;
            }
            else
            {
                this.Height = 1050;
                mainWindow.Height = 1050;
            }

            Random rand = new Random();
            array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next(-10, 11);
                }
            }

            OriginalArrayTextBlock.Text = ArrayToString(array, rows, cols);

            int[] flatArray = array.Cast<int>().ToArray();

            int[] sortedAsc = (int[])flatArray.Clone();
            Array.Sort(sortedAsc);
            SortedAscTextBlock.Text = ArrayToString(sortedAsc, rows, cols);

            int[] sortedDesc = (int[])flatArray.Clone();
            Array.Sort(sortedDesc);
            Array.Reverse(sortedDesc);
            SortedDescTextBlock.Text = ArrayToString(sortedDesc, rows, cols);

            int max = sortedAsc.Max();
            int min = sortedAsc.Min();
            MinMaxTextBlock.Text = $"Максимальный элемент: {max}, Минимальный элемент: {min}";
        }

        private string ArrayToString(int[,] array, int rows, int cols)
        {
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += array[i, j].ToString().PadRight(4);
                }
                result += "\n";
            }
            return result;
        }

        private string ArrayToString(int[] array, int rows, int cols)
        {
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int index = i * cols + j;
                    if (index < array.Length)
                    {
                        result += array[index].ToString().PadRight(4);
                    }
                }
                result += "\n";
            }
            return result;
        }
    }
}
