using System;
using System.Collections.Generic;
using themoviedbx.Models;
using themoviedbx.Repositories;
using themoviedbx.ViewModels;
using Xamarin.Forms;

namespace themoviedbx
{	
	public partial class MovieDetailPage : ContentPage
	{
        MovieDetailPageViewModel vm;
		public MovieDetailPage (Movie movie)
		{
			InitializeComponent ();
			Title = movie.Title;

            var repository = DependencyService.Resolve<APIRepository>();
            vm = new MovieDetailPageViewModel(movie, repository);
            BindingContext = vm;
        }
	}
}

