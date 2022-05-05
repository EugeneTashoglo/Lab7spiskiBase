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

namespace lab7_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new ObservableCollection<string>();
            Spisok.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (InputText.Text.Length != 0)
            {
                list.Add(InputText.Text);
                InputText.Clear();

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (list.Count >= 2)
            {
                list.RemoveAt(0);
                list.RemoveAt(list.Count - 1);

                return;
            }
            if (list.Count == 1)
            {
                list.Clear();
            }
        }
    }
}