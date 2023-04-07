using System;
using themoviedbx.Models;
using themoviedbx.Repositories;

namespace themoviedbx.ViewModels
{
	public class MovieDetailPageViewModel
	{
		public Movie Movie { get; set; }

		public MovieDetailPageViewModel(Movie movie, APIRepository repository)
		{
			this.Movie = movie;
		}
	}
}

