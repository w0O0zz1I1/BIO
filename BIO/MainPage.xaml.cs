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

namespace BIO
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part1.Part1Page1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part2.Part2Page1());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part3.Part3Page1());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part4.Part4Page1());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part5.Part5Page1());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part6.Part6Page1());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part7.Part7Page1());
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part10.Part10Page1());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part8.Part8Page1());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part9.Part9Page1());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part11.Part11Page1());
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part12.Part12Page1());
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part13.Part13Page1());
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part16.Part16Page1());
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part17.Part17Page1());
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part18.Part18Page1());
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part19.Part19Page1());
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part21.Part21Page1());
        }
    }
}
