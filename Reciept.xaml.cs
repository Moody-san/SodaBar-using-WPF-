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
    /// Interaction logic for Reciept.xaml
    /// </summary>
    public partial class Reciept : Window
    {
        MyDataClassDataContext dataContext;
        public Reciept()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            string connectionString = ConfigurationManager.ConnectionStrings["SodaBarProject.Properties.Settings.OOPPROJECTDBConnectionString"].ConnectionString;
            dataContext = new MyDataClassDataContext(connectionString);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu.flag = true;
            this.Close();
        }
        
        public void Total_Bill()
        {
            int price = 0;
            Order.Text = Menu.Soda + " with " + Menu.Syrup;
            OrderQuantity.Text = Menu.Quantity.ToString();
            var Syrup = dataContext.Syrups.First(sp => sp.Name.Equals(Menu.Syrup));
            price = price + Syrup.Price;
            var Soda = dataContext.Sodas.First(sd => sd.Name.Equals(Menu.Soda));
            price = price + Soda.Price;
            price = price * Menu.Quantity;
            if (Menu.NetAmountflag)
            {
                Menu.NetAmount = Menu.NetAmount + price;
                NetBill.Text = Menu.NetAmount.ToString();
            }
            else
            {
                NetBill.Text = price.ToString();
            }
            Bill.Text = price.ToString();
            Sales(price);
        }

        private void Sales(int p)
        {
            MonthlySale Sale = new MonthlySale();
            Sale.Soda = Menu.Soda;
            Sale.Syrup = Menu.Syrup;
            Sale.Quantity = Menu.Quantity;
            Sale.Bill = p;
            DateTime dateTime = DateTime.Now;
            Sale.Date  = dateTime.Date;
            dataContext.MonthlySales.InsertOnSubmit(Sale);
            dataContext.SubmitChanges();
        }
    }
}
