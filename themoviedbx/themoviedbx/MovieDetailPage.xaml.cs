using System;
using System.Collections.Generic;
using themoviedbx.Models;
using Xamarin.Forms;

namespace themoviedbx
{	
	public partial class MovieDetailPage : ContentPage
	{	
		public MovieDetailPage (Movie movie)
		{
			InitializeComponent ();
			Title = movie.Title;
		}
	}
}

