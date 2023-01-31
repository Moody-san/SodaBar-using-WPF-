using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SodaBarProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       static public string UserName { get; set; }
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDQ4MTYyQDMxMzkyZTMxMmUzMGdiaDVTbXZPUzNuYmcvM0xpY2xiQTFlcE1KaExiMytLWExnKyt5Rjg1RWs9");
        }
    }
}
