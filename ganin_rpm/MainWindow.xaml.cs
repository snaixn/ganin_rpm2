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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FrmMain_ContentRendered(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page1 page1 = new Page1();
            FrmMain.Navigate(page1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page2 page2 = new Page2();
            FrmMain.Navigate(page2);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Page3 page3 = new Page3();
            FrmMain.Navigate(page3);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Page4 page4 = new Page4();
            FrmMain.Navigate(page4);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Page5(this));

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Page6 page6 = new Page6();
            FrmMain.Navigate(page6);
            this.Height = 680;
        }
    }
}
