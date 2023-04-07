using System;
using System.Collections.ObjectModel;
using themoviedbx.Models;
using themoviedbx.Repositories;
using themoviedbx.Providers;

namespace themoviedbx.ViewModels
{
	public class MainPageViewModel
	{
		public ObservableCollection<Movie> Movies { get; set; }

		public MainPageViewModel()
		{
			var provider = new MockTMDBAPI();
			var api = new APIRepository(provider);
			Movies = new ObservableCollection<Movie>(api.GetMovies());
	
		}
	}
}

