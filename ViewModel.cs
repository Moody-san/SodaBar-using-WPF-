using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SodaBarProject
{
    class ViewModel
    {
        int c,su,s,dp,co,va,ch,st;
        MyDataClassDataContext dataContext;
        public List<Sales> SodaData { get; set; }
        public List<Sales> SyrupData { get; set; }
        public ViewModel()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SodaBarProject.Properties.Settings.OOPPROJECTDBConnectionString"].ConnectionString;
            dataContext = new MyDataClassDataContext(connectionString);
            popularity_checker();
            PiechartData();
        }
        public void PiechartData()
        {

            SodaData = new List<Sales>()
            {
                 new Sales{Soda="CocaCola",SodaQ=c},
                 new Sales{Soda="SevenUp",SodaQ=su},
                 new Sales{Soda="Sprite",SodaQ=s},
                 new Sales{Soda="DrPepper",SodaQ=dp}
            };
            SyrupData = new List<Sales>()
            {
                 new Sales{Syrup="Coconut",SyrupQ=co},
                 new Sales{Syrup="Strawberry",SyrupQ=st},
                 new Sales{Syrup="Vanilla",SyrupQ=va},
                 new Sales{Syrup="Cherry",SyrupQ=ch}
            };
        }
        private void check_soda_popularity(string soda_name)
        {
            foreach (var SODA in dataContext.MonthlySales)
            {
                if (SODA.Soda.ToString() == soda_name)
                {
                    if (soda_name == "CocaCola")
                    {
                        c = c + SODA.Quantity;
                    }
                    else if (soda_name == "SevenUp")
                    {
                        su = su + SODA.Quantity;
                    }
                    else if (soda_name == "DrPepper")
                    {
                        dp = dp + SODA.Quantity;
                    }
                    else if (soda_name == "Sprite")
                    {
                        s = s + SODA.Quantity;
                    }

                }
            }
        }
        private void check_syrup_popularity(string syrup_name)
        {
            foreach (var SYRUP in dataContext.MonthlySales)
            {
                if (SYRUP.Syrup.ToString() == syrup_name)
                {
                    if (syrup_name == "Coconut")
                    {
                        co = co + SYRUP.Quantity;
                    }
                    else if (syrup_name == "Vanilla")
                    {
                        va = va + SYRUP.Quantity;
                    }
                    else if (syrup_name == "Cherry")
                    {
                        ch = ch + SYRUP.Quantity;
                    }
                    else if (syrup_name == "Strawberry")
                    {
                        st = st + SYRUP.Quantity;
                    }

                }
            }
        }
        private void popularity_checker()
        {
            check_soda_popularity("CocaCola");
            check_soda_popularity("SevenUp");
            check_soda_popularity("DrPepper");
            check_soda_popularity("Sprite");
            check_syrup_popularity("Cherry");
            check_syrup_popularity("Coconut");
            check_syrup_popularity("Strawberry");
            check_syrup_popularity("Vanilla");
        }
    }
}
