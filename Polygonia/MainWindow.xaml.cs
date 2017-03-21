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

namespace Polygonia
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

      

        private void button_Click2(object sender, RoutedEventArgs e) //triangle
        {
            myFrame.Visibility = System.Windows.Visibility.Visible;
            Page2 p2 = new Page2();
            myFrame.NavigationService.Navigate(p2);
        }

        private void button_Click1(object sender, RoutedEventArgs e) //square
        {
            myFrame.Visibility = System.Windows.Visibility.Visible;
            Page1 p1 = new Page1();
            myFrame.NavigationService.Navigate(p1);
        }

        private void button_Click3(object sender, RoutedEventArgs e)//exit
        {
            Application.Current.Shutdown();
      
        }
    }
}
