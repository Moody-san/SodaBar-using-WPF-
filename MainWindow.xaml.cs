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

namespace SodaBarProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Menu_Button_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(MainMenu);
        }

        private void Stocks_Button_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Stocks);
        }

        private void Settings_Button_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Settings);
        }
        
        public void SetActiveUserControl(UserControl control)
        {
            MainMenu.Visibility = Visibility.Collapsed;
            Stocks.Visibility = Visibility.Collapsed;
            Settings.Visibility = Visibility.Collapsed;
            control.Visibility = Visibility.Visible;
        }

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Close();
        }
    }
}
