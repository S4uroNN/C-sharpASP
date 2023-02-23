using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave7_1
{
    internal class Person : INotifyPropertyChanged
    {
        private string _name;
        private int _weight;
        private int _age;
        private int _score;
        private Boolean _accepted;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }
        public int Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                _weight = value;
                NotifyPropertyChanged("Weight");
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
                NotifyPropertyChanged("Age");
            }
        }
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                NotifyPropertyChanged("Score");
            }
        }

        public Boolean Accepted 
        {
            get
            {
                return _accepted;
            }

            set
            {
                _accepted = value;
                NotifyPropertyChanged("Accepted");
            }
        }

        public Person(String name, int weight, int age, int score, Boolean accepted)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Score = score;
            Accepted = accepted;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override string ToString()
        {
            return "Navn: " +Name +  " Alder: " + Age + " Score: " + Score;
        }
    }
}
