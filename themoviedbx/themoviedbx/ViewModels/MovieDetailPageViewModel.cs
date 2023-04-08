using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using themoviedbx.Models;
using themoviedbx.Repositories;
using Xamarin.Forms;

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

        private ObservableCollection<Video> _videos;
        public ObservableCollection<Video> Videos
        {
            get { return _videos; }
            set
            {
                _videos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Videos)));
            }
        }
        private ICommand _trailerOpenCommand;
        public ICommand TrailerOpenCommand {
            get { return _trailerOpenCommand; }
            set
            {
                _trailerOpenCommand = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TrailerOpenCommand)));
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
            Task.Run(() =>
            {
                var videos = api.GetVideos(movie.Id);
                if (videos.Result.Count > 0)
                {
                    var youtubeOnly = videos.Result.FindAll((t) =>
                    {
                        return t.Site.ToLower().Equals("youtube");
                    });
                    if (youtubeOnly.Count > 0)
                    {
                        this.Videos = new ObservableCollection<Video>(videos.Result);
                        TrailerOpenCommand = new Command(() =>
                        {
                            var url = $"https://www.youtube.com/watch?v={youtubeOnly[0].Key}";
                            Application.Current.MainPage.Navigation.PushAsync(new WebViewPage(url));
                        });
                    }
                }
            });
            
        }
    }
}

