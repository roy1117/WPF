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

namespace UserControlPractice.CustomControls.SignUpScreen
{
    /// <summary>
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : UserControl
    {
        public Signup()
        {
            InitializeComponent();
            DataContext = this;
        }

        private string stPasswordCheck = "안전";

        public string PasswordCheck
        {
            get { return stPasswordCheck; }
            set
            {
                stPasswordCheck = value;
            }
        }

        private void ipPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (stPasswordCheck == "안전")
            {
                stPasswordCheck = "불안전";
                ipPassword.PlaceHolder = "불안전";
            }
            else
            {
                stPasswordCheck = "안전";
                ipPassword.PlaceHolder = "안전";
            }
        }

    }
}
