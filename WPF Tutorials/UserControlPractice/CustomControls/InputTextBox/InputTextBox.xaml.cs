using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace UserControlPractice.CustomControls.InputTextBox
{
    /// <summary>
    /// Interaction logic for InputTextBox.xaml
    /// </summary>
    public partial class InputTextBox : UserControl, INotifyPropertyChanged
    {
        public InputTextBox()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;


        private string stPlaceHolder;

        public string PlaceHolder
        {
            get { return stPlaceHolder; }
            set 
            { 
                stPlaceHolder = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PlaceHolder"));
            }
        }
    }


}
