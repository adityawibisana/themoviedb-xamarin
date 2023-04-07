using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using themoviedbx.Repositories;
using themoviedbx.ViewModels;
using Xamarin.Forms;

namespace themoviedbx
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;
        public MainPage()
        {
            InitializeComponent();

            var repository = DependencyService.Resolve<APIRepository>();
            vm = new MainPageViewModel(repository);
            BindingContext = vm;
        }

        public void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var x = e.Item;
            Navigation.PushAsync(new DiscoverPage());
        }
    }
}

