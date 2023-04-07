using System;
using System.Collections.Generic;
using themoviedbx.Repositories;
using themoviedbx.ViewModels;
using Xamarin.Forms;
namespace themoviedbx
{	
	public partial class OfficialGenrePage : ContentPage
	{	
		public OfficialGenrePage ()
		{
			InitializeComponent ();
            var repository = DependencyService.Resolve<APIRepository>();
            BindingContext = new MainPageViewModel(repository);
        }
	}
}

