using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using themoviedbx.Models;
using themoviedbx.Repositories;
using Xamarin.Forms;

namespace themoviedbx.ViewModels
{
	public class DiscoverPageViewModel : INotifyPropertyChanged
    {
        private int page = 1;
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
        public ICommand LoadMore
        {
            get;
            set;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public DiscoverPageViewModel(APIRepository api, Genre genre)
        {
            this.Genre = genre.Name;
            Task.Run(() =>
            {
                var t = api.GetMoviesAsync(genre.Id, page);
                Movies = new ObservableCollection<Movie>(t.Result);
            });
            this.LoadMore = new Command(() =>
            {
                page++;
                LoadMoreList(api, genre, page);
            });
        }

        public void LoadMoreList(APIRepository api, Genre genre, int page) {
            Task.Run(() =>
            {
                var t = api.GetMoviesAsync(genre.Id, page);
                t.Result.ForEach((m) =>
                {
                    Movies.Add(m);
                    OnpropertyChanged("Movies");
                });
            });
        }

        void OnpropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

