using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestUniverseApp.Services;
using TestUniverseApp.Views;

namespace TestUniverseApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
