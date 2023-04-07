using System;
using themoviedbx.Providers;
using themoviedbx.Repositories;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace themoviedbx
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            var provider = new MockTMDBAPI();
            var api = new APIRepository(provider);
            DependencyService.RegisterSingleton<APIRepository>(api);

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

