using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Calorias.Vistas;

namespace Calorias
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuCaratula());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
