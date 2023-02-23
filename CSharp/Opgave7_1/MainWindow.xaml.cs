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

namespace Opgave7_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person person;
        private ObservableCollection<Person> persons = new ObservableCollection<Person>();
        public MainWindow()
        {
            InitializeComponent();

            person = new Person("Lasse", 70, 23, 69420, true);

           

            persons.Add(person);
            persons.Add(new Person("Kristina", 56, 23, 55, false));

            
            listConsol.ItemsSource = persons;
            mainGrid.DataContext = persons;



        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (listConsol.SelectedItem != null)
            {
               ((Person)listConsol.SelectedItem).Name =((TextBox)sender).Text;
            }
        }
        private void txtAge_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (listConsol.SelectedItem != null)
            {
                ((Person)listConsol.SelectedItem).Age = Int32.Parse(((TextBox)sender).Text);
            }
        }
        private void txtWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (listConsol.SelectedItem != null)
            {
                ((Person)listConsol.SelectedItem).Weight = Int32.Parse(((TextBox)sender).Text);
            }
        }
        private void txtScore_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (listConsol.SelectedItem != null)
            {
                ((Person)listConsol.SelectedItem).Score = Int32.Parse(((TextBox)sender).Text);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person.Name = "Morten";
            person.Age = 23;
            person.Weight = 59;
            person.Score = 1337;
        }

        private void btnTilføj_Click(object sender, RoutedEventArgs e)
        {
            String name = txtName.Text;
            int age = Int32.Parse(txtAge.Text);
            int weight = Int32.Parse(txtWeight.Text);
            int score = Int32.Parse(txtScore.Text);
            Boolean accepted = chkAcc.IsChecked  == true;

            persons.Add(new Person(name, weight, age, score, accepted));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listConsol.ItemsSource = null;
            listConsol.ItemsSource = persons;
        }
    }
}
