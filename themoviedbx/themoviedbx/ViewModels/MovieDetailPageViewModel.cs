using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using themoviedbx.Models;
using themoviedbx.Repositories;

namespace themoviedbx.ViewModels
{
	public class MovieDetailPageViewModel : INotifyPropertyChanged
	{
		public Movie Movie { get; set; }

        private ObservableCollection<Review> _reviews;
		public ObservableCollection<Review> Reviews
        {
            get { return _reviews; }
            set
            {
                _reviews = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Reviews)));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public MovieDetailPageViewModel(Movie movie, APIRepository api)
		{
			this.Movie = movie;
            Task.Run(() =>
            {
                var reviews = api.GetReviews(movie.Id);
                if (reviews.Result.Count > 0)
                {
                    this.Reviews = new ObservableCollection<Review>(reviews.Result);
                }
            });
        }

        
    }
}

