using System;
using System.Net.Http;
using System.Net.Http.Headers;
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

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            DependencyService.RegisterSingleton<HttpClient>(httpClient);
            var provider = new TMDBAPI(httpClient);
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

