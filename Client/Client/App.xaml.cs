using Prism.Ioc;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        public App()
        {
            //HttpClient httpClient = new HttpClient();
            //var resp = httpClient.GetAsync("http://localhost:5000/WeatherForecast").GetAwaiter().GetResult();
            //string values = resp.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<Views.MainWindow>();
        }

        protected override void InitializeShell(Window shell)
        {
            if (Container.Resolve<Views.WinLogin>().ShowDialog() == true)
                shell.ShowDialog();
            Application.Current.Shutdown();

        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
