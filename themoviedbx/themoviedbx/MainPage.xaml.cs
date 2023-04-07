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
        public MainPage()
        {
            InitializeComponent();

            var repository = DependencyService.Resolve<APIRepository>();
            BindingContext = new MainPageViewModel(repository);
        }
    }
}

