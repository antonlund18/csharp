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

namespace PersonWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Person> GetPeople(string filename)
        {
            return Person.ReadCSVFile(filename);
        }
        public MainWindow()
        {
            InitializeComponent();

            string fileData1 = @"../../../data1.csv";

            List<Person> peopleList = GetPeople(fileData1);
            ObservableCollection<Person> people = new ObservableCollection<Person>();
            foreach(var p in peopleList)
            {
                people.Add(p);
            }
            myListBox.ItemsSource = people;
            myListBox.SelectionChanged += (s, e) =>
            {
                Person p = (Person)((ListBox)s).SelectedItem;
                txbName.Text = p.Name;
                txbScore.Text = p.Score.ToString();
                txbAge.Text = p.Age.ToString();
                txbWeight.Text = p.Weight.ToString();
                txbAccepted.Text = p.Accepted.ToString();

                Binding binding = new Binding();
                binding.Source = myListBox.SelectedItem;
                binding.Path = new PropertyPath("Age");
                binding.Mode = BindingMode.TwoWay;
                txbAge.SetBinding(TextBox.TextProperty, binding);
            };
            btnSave.Click += (s, e) =>
            {
                Person p = (Person)myListBox.SelectedItem;
                p.Name = txbName.Text;
                p.Score = int.Parse(txbScore.Text);
                p.Weight = int.Parse(txbWeight.Text);
                p.Accepted = bool.Parse(txbAccepted.Text);
                myListBox.Items.Refresh();
            };
        }
    }
}
