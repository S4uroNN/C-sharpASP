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

namespace Opgave1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn1.Visibility = Visibility.Hidden;
        }

        private void CheckBox_Onclick(object sender, RoutedEventArgs e)
        {
            if(checkBox1.IsChecked == true)
            {
                btn1.Visibility = Visibility.Visible;
            }
            else
            {
                btn1.Visibility = Visibility.Hidden;
            }

            if(checkBox1.IsChecked == false)
            {
                btn1.Visibility = Visibility.Hidden;
            }
            else
            {
                btn1.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = "RED BUTTON!";
        }
    }
}
