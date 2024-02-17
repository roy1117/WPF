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

namespace CustomEventPractice.UserControls
{
    /// <summary>
    /// Interaction logic for CustomUserControl.xaml
    /// </summary>
    public partial class CustomUserControl : UserControl
    {
        public CustomUserControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event EventHandler<EventArgs> CustomUserChanged;

        private bool bPasswordSafe;

        public bool PasswordSafe
        {
            get { return bPasswordSafe; }
            set 
            { 
                bPasswordSafe = value;
                if (bPasswordSafe)
                {
                    tbSafeCheck.Text = "Safe";
                    tbSafeCheck.Foreground = Brushes.LightGreen;
                    brdOutline.BorderBrush = Brushes.LightGreen;
                }
                else
                {
                    tbSafeCheck.Text = "UnSafe";
                    tbSafeCheck.Foreground = Brushes.Red;
                    brdOutline.BorderBrush = Brushes.Red;
                }
                
            }
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string currentPassword = "";
            int textLength = 0;
            bool hasLower = false;
            bool hasUpper = false;
            bool hasNumber = false;
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                currentPassword = textBox.Text;
                textLength = currentPassword.Length;
            }
            for (int i = 0; i < textLength; i++)
            {
                if(Char.IsNumber(currentPassword[i]))
                {
                    hasNumber = true;
                }
                else if (Char.IsLower(currentPassword[i]))
                {
                    hasLower = true;
                }
                else if (Char.IsUpper(currentPassword[i]))
                {
                    hasUpper = true;
                }
                if (hasNumber & hasLower & hasUpper)
                {
                    PasswordSafe = true;
                    break;
                }
                else
                {
                    PasswordSafe = false;
                }
            }
        }
    }

}
