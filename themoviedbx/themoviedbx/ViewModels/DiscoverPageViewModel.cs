using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
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
            this.Genre = genre;
            Task.Run(() =>
			{
				var t = api.GetMoviesAsync(genre);
                Movies = new ObservableCollection<Movie>(t.Result);

            });
        }
	}
}

