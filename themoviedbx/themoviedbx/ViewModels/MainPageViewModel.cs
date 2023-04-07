using System;
using System.Collections.ObjectModel;
using themoviedbx.Models;
using themoviedbx.Repositories;
using themoviedbx.Providers;
using Xamarin.Forms;
using System.Windows.Input;
using System.ComponentModel;
using System.Threading.Tasks;

namespace themoviedbx.ViewModels
{
	public class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Genre> _genres;
		public ObservableCollection<Genre> Genres
        {
            get { return _genres; }
            set
            {
                _genres = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Genres)));
            }
        }

        public MainPageViewModel(APIRepository api)
		{
            Task.Run(() =>
            {
                var genres = api.GetGenres();
                Genres = new ObservableCollection<Genre>(genres.Result);
            });
		}

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

