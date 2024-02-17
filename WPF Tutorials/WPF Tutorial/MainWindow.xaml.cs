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

namespace WPF_Tutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool bRunning = false;

        public MainWindow()
        {
            InitializeComponent();

            tbStatus.Text = "Hello World 2";
            btnToggleButton.Content = "Stop";
        }


        private void btnToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (bRunning)
            {
                bRunning = false;
                tbStatus.Text = "Stopped";
                btnToggleButton.Content = "Run";
            }
            else
            {
                bRunning = true;
                tbStatus.Text = "Running";
                btnToggleButton.Content = "Stop";
            }
        }
    }
}
