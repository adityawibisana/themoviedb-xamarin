using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using themoviedbx.Models;
using themoviedbx.Repositories;

namespace themoviedbx.ViewModels
{
	public class DiscoverPageViewModel : INotifyPropertyChanged
    {
		public String Genre { get; set; }
        private ObservableCollection<Movie> _movies;
        public ObservableCollection<Movie> Movies
        {
            get { return _movies; }
            set
            {
                _movies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Movies)));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public DiscoverPageViewModel(APIRepository api, Genre genre)
		{
            this.Genre = genre.Name;
            Task.Run(() =>
			{
				var t = api.GetMoviesAsync(genre.Id);
                Movies = new ObservableCollection<Movie>(t.Result);
            });
        }

        
    }
}

