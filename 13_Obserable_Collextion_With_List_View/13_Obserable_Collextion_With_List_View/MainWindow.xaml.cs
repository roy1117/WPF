using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _13_Obserable_Collextion_With_List_View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            entries = new ObservableCollection<string>();
            InitializeComponent();
            DataContext = this;
            
        }

        private ObservableCollection<string> entries;

        public ObservableCollection<string> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(tbEntry.Text);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string selectedItem = tbEntry.Text;
            entries.Remove(selectedItem);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            entries.Clear();
        }
    }
}
