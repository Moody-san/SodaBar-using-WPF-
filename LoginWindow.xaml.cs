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
using System.Windows.Shapes;
using System.Configuration;

namespace SodaBarProject
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        MyDataClassDataContext dataContext;
        public LoginWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            string connectionString = ConfigurationManager.ConnectionStrings["SodaBarProject.Properties.Settings.OOPPROJECTDBConnectionString"].ConnectionString;
            dataContext = new MyDataClassDataContext(connectionString);
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool flag = false;
                foreach (var user in dataContext.UserPasses)
                {
                    if (user.UserName.ToString()==txtbox.Text && user.Password.ToString()==passwordbox.Password)
                    {
                        flag = true;
                        App.UserName = user.UserName.ToString();
                    }
                }
                if (flag == true)
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username/Password is incorrect","You are not registered in SodaBar database!",MessageBoxButton.OK,MessageBoxImage.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Login Error");
            }
            
        }
    }
}
