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
using System.Configuration;
namespace SodaBarProject
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
        MyDataClassDataContext dataContext;
        public SettingsView()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["SodaBarProject.Properties.Settings.OOPPROJECTDBConnectionString"].ConnectionString;
            dataContext = new MyDataClassDataContext(connectionString);
        }

        private void ChangeUserButn_Click(object sender, RoutedEventArgs e)
        {
            bool symbolCheck = ChangeUser.Text.Any(u => !char.IsLetterOrDigit(u));
            if (symbolCheck)
            {
                MessageBox.Show("Symbols not allowed!", "Special Character Present Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(ChangeUser.Text))
                {
                    MessageBox.Show("Please Fill The Required Field!", "Null Input", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else
                {
                    var User = dataContext.UserPasses.First(up => up.UserName.Equals(App.UserName));
                    User.UserName = ChangeUser.Text;
                    dataContext.SubmitChanges();
                    Window window = Window.GetWindow(this);
                    LoginWindow login = new LoginWindow();
                    login.Show();
                    window.Close();
                }
            }
        }

        private void ChangePassbtn_Click(object sender, RoutedEventArgs e)
        {
            bool symbolCheck = ChangePassword.Password.Any(p => !char.IsLetterOrDigit(p));
            if (symbolCheck)
            {
                MessageBox.Show("Symbols not allowed!", "Special Character Present Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(ChangePassword.Password))
                {
                    MessageBox.Show("Please Fill The Required Field!", "Null Input", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else
                {
                    var User = dataContext.UserPasses.First(up => up.UserName.Equals(App.UserName));
                    User.Password = ChangePassword.Password;
                    dataContext.SubmitChanges();
                    Window window = Window.GetWindow(this);
                    LoginWindow login = new LoginWindow();
                    login.Show();
                    window.Close();
                }
            }
        }

        private void NewUserbtn_Click(object sender, RoutedEventArgs e)
        {
            bool symbolCheck = NewUserPassword.Password.Any(p => !char.IsLetterOrDigit(p));
            if (symbolCheck)
            {
                MessageBox.Show("Symbols not allowed!", "Special Character Present Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if(symbolCheck = NewUserName.Text.Any(u => !char.IsLetterOrDigit(u)))
            {
                MessageBox.Show("Symbols not allowed!", "Special Character Present Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (string.IsNullOrEmpty(NewUserPassword.Password))
            {
                MessageBox.Show("Please Fill The Required Field!", "Null Input", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (string.IsNullOrEmpty(NewUserName.Text))
            {
                MessageBox.Show("Please Fill The Required Field!", "Null Input", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                bool userflag = true;
                if (userflag)
                {
                    foreach (var user in dataContext.UserPasses)
                    {
                        if (user.UserName.ToString() == NewUserName.Text)
                        {
                            userflag = false;
                            MessageBox.Show("UserName Already Exists", "Enter Another User", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        }
                    }
                }
                if (userflag)
                {
                    UserPass NewUser = new UserPass();
                    NewUser.UserName = NewUserName.Text;
                    NewUser.Password = NewUserPassword.Password;
                    dataContext.UserPasses.InsertOnSubmit(NewUser);
                    dataContext.SubmitChanges();
                    MessageBox.Show("New Admin Added ", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                
            }
        }

        private void DeleteUserbtn_Click(object sender, RoutedEventArgs e)
        {
            var User = dataContext.UserPasses.First(up => up.UserName.Equals(App.UserName));
            dataContext.UserPasses.DeleteOnSubmit(User);
            dataContext.SubmitChanges();
            Window window = Window.GetWindow(this);
            LoginWindow login = new LoginWindow();
            login.Show();
            window.Close();
        }
    }
}
