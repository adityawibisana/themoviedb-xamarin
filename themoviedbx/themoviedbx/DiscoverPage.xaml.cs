using System;
using System.Collections.Generic;
using themoviedbx.Repositories;
using themoviedbx.ViewModels;
using Xamarin.Forms;

namespace themoviedbx
{	
	public partial class DiscoverPage : ContentPage
	{	
		public DiscoverPage ()
		{
			InitializeComponent ();

			var repository = DependencyService.Resolve<APIRepository>();
			BindingContext = new MainPageViewModel(repository);
		}
	}
}

