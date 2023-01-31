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
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MenuView : UserControl
    {
        MyDataClassDataContext dataContext;
        public MenuView()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["SodaBarProject.Properties.Settings.OOPPROJECTDBConnectionString"].ConnectionString;
            dataContext = new MyDataClassDataContext(connectionString);
            Menu.Soda = "CocaCola";
            Menu.Syrup = "Vanilla";

        }
        private void Soda_Click(object sender, RoutedEventArgs e)
        {
            var radiobutton = sender as RadioButton;
            Menu.Soda = radiobutton.Name;
        }

        private void Syrup_Click(object sender, RoutedEventArgs e)
        {
            var radiobutton = sender as RadioButton;
            Menu.Syrup = radiobutton.Name;
        }


        private void Check_Soda_Stock()
        {
            var Soda = dataContext.Sodas.First(sd => sd.Name.Equals(Menu.Soda));
            if (Soda.Stock > 0 && Soda.Stock >= Menu.Quantity)
            {
                Menu.flag = true;
            }
            else
            {
                Menu.flag = false;
            }
        }
        private void Check_Syrup_Stock()
        {
            var Syrup = dataContext.Syrups.First(sp => sp.Name.Equals(Menu.Syrup));
            if (Syrup.Stock > 0 && Syrup.Stock >= Menu.Quantity)
            {
                Menu.flag = true;
            }
            else
            {
                Menu.flag = false;
            }
        }
        private void Update_Soda_Stock()
        {
            var Soda = dataContext.Sodas.First(sd => sd.Name.Equals(Menu.Soda));
            Soda.Stock = Soda.Stock - Menu.Quantity;
            dataContext.SubmitChanges();
        }
        private void Update_Syrup_Stock()
        {
            var Syrup = dataContext.Syrups.First(sp => sp.Name.Equals(Menu.Syrup));
            Syrup.Stock = Syrup.Stock - Menu.Quantity;
            dataContext.SubmitChanges();
        }
        private void ValidationAndBill()
        {
            bool res;
            int a;
            res = int.TryParse(Quantity.Text, out a);
            if (res)
            {
                if (a > 0 && a < 100)
                {
                    Menu.Quantity = a;
                    Check_Soda_Stock();
                    if (Menu.flag == true)
                    {
                        Check_Syrup_Stock();
                        if (Menu.flag == true)
                        {
                            Update_Soda_Stock();
                            Update_Syrup_Stock();
                            var reciept = new Reciept();
                            reciept.Total_Bill();
                            reciept.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(Menu.Syrup + " is out of stock", "Stock needs to be Updated", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Menu.Soda + " is out of stock", "Stock needs to be Updated", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Range should be between 0-99", "Out Of Range Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Quantity should be a number", "Invalid DataType Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void Confirm_Order_Click(object sender, RoutedEventArgs e)
        {
            ValidationAndBill();
            reset();
        }
        private void reset()
        {
            Menu.flag = true;
            Quantity.Text = "1";
            CocaCola.IsChecked = true;
            Vanilla.IsChecked = true;
            Menu.Soda = "CocaCola";
            Menu.Syrup = "Vanilla";
        }

        private void Toggle_Grand_Total_Click(object sender, RoutedEventArgs e)
        {
            reset();
            Menu.counter++;
            if (Menu.counter % 2 == 0)
            {
                Menu.NetAmountflag = true;
                Toggle_Grand_Total.Background = Brushes.Red;
            }
            else
            {
                Toggle_Grand_Total.Background = Brushes.Transparent;
                Menu.NetAmountflag = false;
                Menu.NetAmount = 0;
            }

        }

    }
}
