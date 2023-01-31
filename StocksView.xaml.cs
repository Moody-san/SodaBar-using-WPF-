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
    /// Interaction logic for StocksView.xaml
    /// </summary>
    public partial class StocksView : UserControl
    {
        MyDataClassDataContext dataContext;
        public StocksView()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["SodaBarProject.Properties.Settings.OOPPROJECTDBConnectionString"].ConnectionString;
            dataContext = new MyDataClassDataContext(connectionString);
        }

        private void SodaNames_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> SodaName = new List<string>();
            SodaName.Add("CocaCola");
            SodaName.Add("SevenUp");
            SodaName.Add("DrPepper");
            SodaName.Add("Sprite");
            var Combo = sender as ComboBox;
            Combo.ItemsSource = SodaName;
            Combo.SelectedIndex = 0;
        }

        private void SodaStock_Click(object sender, RoutedEventArgs e)
        {
            bool res;
            int a;
            res = int.TryParse(Stocktxt.Text, out a);
            if (res)
            {
                if (a>=0)
                {
                    var Soda = dataContext.Sodas.First(sd => sd.Name.Equals(SodaCombo.SelectedItem));
                    Soda.Stock = a;
                    dataContext.SubmitChanges();
                    MessageBox.Show("Stock Updated", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Stock should be a postive number", "Only Positive Integer Allowed", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Stock should be a number", "Invalid DataType Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void SyrupCombo_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> SyrupName = new List<string>();
            SyrupName.Add("Coconut");
            SyrupName.Add("Cherry");
            SyrupName.Add("Strawberry");
            SyrupName.Add("Vanilla");
            var Combo = sender as ComboBox;
            Combo.ItemsSource = SyrupName;
            Combo.SelectedIndex = 0;
        }

        private void SyrupStock_Click(object sender, RoutedEventArgs e)
        {
            bool res;
            int a;
            res = int.TryParse(Stocktxt2.Text, out a);
            if (res)
            {
                if (a >= 0)
                {
                    var Syrup = dataContext.Syrups.First(sp => sp.Name.Equals(SyrupCombo.SelectedItem));
                    Syrup.Stock = a;
                    dataContext.SubmitChanges();
                    MessageBox.Show("Stock Updated", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Stock should be a postive number", "Only Positive Integer Allowed", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Stock should be a number", "Invalid DataType Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
