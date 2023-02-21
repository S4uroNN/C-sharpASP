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

namespace Status
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

        //private void file_Click(object sender, RoutedEventArgs e)
        //{
        //    lastClicked.Text = "File";
        //}

        private void help_Click(object sender, RoutedEventArgs e)
        {
            lastClicked.Text = "Help";
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            lastClicked.Text = "Open";
            //e.Handled = true;
        }
        private void save_Click(object sender, RoutedEventArgs e)
        {
            lastClicked.Text = "Save as..";
        }
        private void quit_Click(object sender, RoutedEventArgs e)
        {
            lastClicked.Text = "Quit";
        }
        private void about_Click(object sender, RoutedEventArgs e)
        {
            lastClicked.Text = "About";
        }


    }
}
