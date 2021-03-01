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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button1.Click += SwapText1;
            button2.Click += SwapText2;
        }

        public void SwapText1(object sender, RoutedEventArgs e)
        {
            object temp = text1.Content;
            text1.Content = text2.Content;
            text2.Content = temp;
        }

        public void SwapText2(object sender, RoutedEventArgs e)
        {
            object temp = text3.Content;
            text3.Content = text4.Content;
            text4.Content = temp;
        }
    }
}
