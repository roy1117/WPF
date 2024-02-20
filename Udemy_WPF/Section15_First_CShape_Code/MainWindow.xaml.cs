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

namespace Section15_First_CShape_Code
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public delegate void Notify();
    public partial class MainWindow : Window
    {
        public event Notify OneIsEntered;
        public event Notify TwoIsEntered;
        public MainWindow()
        {
            InitializeComponent();
            OneIsEntered += OneEventHandler;
        }

        private void btnMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World", "Test");
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtCustomerRequest.Text == "1")
            {
                OneIsEntered?.Invoke();
            }
        }

        private void OneEventHandler()
        {
            MessageBox.Show("This is one Event Handler");
        }
    }
}
