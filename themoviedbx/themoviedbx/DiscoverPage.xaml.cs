using System;
using System.Collections.Generic;
using themoviedbx.Models;
using themoviedbx.Repositories;
using themoviedbx.ViewModels;
using Xamarin.Forms;

namespace themoviedbx
{	
	public partial class DiscoverPage : ContentPage
	{	
		public DiscoverPage (String genre)
		{
			InitializeComponent ();

			var repository = DependencyService.Resolve<APIRepository>();
			BindingContext = new DiscoverPageViewModel(repository, genre);

			Title = genre;
		}

        public void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var movie = e.Item as Movie;
            Navigation.PushAsync(new MovieDetailPage(movie));
        }
    }
}

