using System;
using System.Collections;
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

namespace DockPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     

        public MainWindow()
        {
            InitializeComponent();

            List<Button> listButtons = new List<Button>();
            GetLogicalChildCollection(this, listButtons);

            foreach (var item in listButtons)
            {
                item.Click += AnyButton_Click;
            }
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
                txtBox1.Text += btnUp.Content.ToString() + "\n";
       
        }
        
        private void AnyButton_Click(object sender, RoutedEventArgs e)
        {
            txtBox1.Text += ((Button)sender).Content.ToString() + "\n";
        }

        private static void GetLogicalChildCollection<T>(DependencyObject parent, List<T> logicalCollection) where T : DependencyObject
        {
            IEnumerable children = LogicalTreeHelper.GetChildren(parent);
            foreach (object child in children)
            {
                if (child is DependencyObject)
                {
                    DependencyObject depChild = child as DependencyObject;
                    if (child is T)
                    {
                        logicalCollection.Add(child as T);
                    }
                    GetLogicalChildCollection(depChild, logicalCollection);
                }
            }
        }
    }
}
