using System;
using System.Collections.ObjectModel;
using themoviedbx.Models;
using themoviedbx.Repositories;

namespace themoviedbx.ViewModels
{
	public class DiscoverPageViewModel
	{
		public String Genre { get; set; }
        public ObservableCollection<Movie> Movies { get; set; }

        public DiscoverPageViewModel(APIRepository api, String genre)
		{
			Movies = new ObservableCollection<Movie>(api.GetMovies(genre));
			this.Genre = genre;
		}
	}
}

