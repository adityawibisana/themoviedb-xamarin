using System;
using System.Collections.ObjectModel;
using themoviedbx.Models;
using themoviedbx.Repositories;
using themoviedbx.Providers;
using Xamarin.Forms;
using System.Windows.Input;
using System.ComponentModel;

namespace themoviedbx.ViewModels
{
	public class MainPageViewModel
    {
		public ObservableCollection<Genre> Genres { get; set; }

        public MainPageViewModel(APIRepository Api)
		{
			Genres = new ObservableCollection<Genre>(Api.GetGenres());
		}
        
    }
}

