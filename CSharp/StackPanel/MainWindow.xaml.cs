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

namespace StackPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void r1_Checked(object sender, RoutedEventArgs e)
        {
            if (r1.IsChecked == true)
            {
                statusRadio.Content = "Radio 1 Checked";
            }
        }
        private void r2_Checked(object sender, RoutedEventArgs e)
        {
            if (r2.IsChecked == true)
            {
                statusRadio.Content = "Radio 2 Checked";
            }
        }
        private void r3_Checked(object sender, RoutedEventArgs e)
        {
            if (r3.IsChecked == true)
            {
                statusRadio.Content = "Radio 3 Checked";
            }
        }
        private void r4_Checked(object sender, RoutedEventArgs e)
        {
            if (r4.IsChecked == true)
            {
                statusRadio.Content = "Radio 4 Checked";
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {

            Dictionary<CheckBox, string> keyValuePairs = new Dictionary<CheckBox, string>();

            if (chk1.IsChecked == true)
            {
                keyValuePairs.Add(chk1, chk1.Content.ToString());
            }
            else if (chk2.IsChecked == true)
            {
                keyValuePairs.Add(chk2, chk2.Content.ToString());
            }
            else
            {
                keyValuePairs.Add(chk3, chk3.Content.ToString());
            }

            if (chk1.IsChecked != true)
            {
                if(statusCheck.Content != null)
                {
                    statusCheck.Content = keyValuePairs.ToString();
                }
                keyValuePairs.Remove(chk1);
                
            }
            else if (chk2.IsChecked != true)
            {
                keyValuePairs.Remove(chk2);
            }
            else
            {
                keyValuePairs.Remove(chk3);
            }

            foreach (var item in keyValuePairs)
            {
                statusCheck.Content = item.Value;
            }

        }

    }
}
