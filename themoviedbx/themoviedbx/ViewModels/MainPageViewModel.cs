using System;
using System.Collections.ObjectModel;
using themoviedbx.Models;
using themoviedbx.Repositories;
using themoviedbx.Providers;
using Xamarin.Forms;

namespace themoviedbx.ViewModels
{
	public class MainPageViewModel
	{
		public ObservableCollection<Movie> Movies { get; set; }

		public MainPageViewModel(APIRepository Api)
		{
			Movies = new ObservableCollection<Movie>(Api.GetMovies());
		}
	}
}

