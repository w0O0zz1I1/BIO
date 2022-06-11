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

namespace BIO.Part16
{
    /// <summary>
    /// Логика взаимодействия для Part16Page8.xaml
    /// </summary>
    public partial class Part16Page8 : Page
    {
        public Part16Page8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = 0, b = 0, c = 1, d = 0, h = 0;
            if (answer1.IsChecked == true)
            {
                a = 1;
            }
            if (answer2.IsChecked == true)
            {
                b = 1;
            }
            if (answer4.IsChecked == true)
            {
                d = 1;
            }
            if (answer5.IsChecked == true)
            {
                h = 1;
            }

            resultTestTextBox.Text = "Оценка: " + (a + b + c + d + h).ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new MainPage());
        }
    }
}
