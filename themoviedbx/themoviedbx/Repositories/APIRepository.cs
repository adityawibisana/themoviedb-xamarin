using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using themoviedbx.Models;
using themoviedbx.Providers;

namespace themoviedbx.Repositories
{
	public class APIRepository
	{
		ITMDBAPI ApiProvider;
		JsonSerializerSettings setting;

        public APIRepository(ITMDBAPI ApiProvider)
		{
			this.ApiProvider = ApiProvider;

			setting = new JsonSerializerSettings();
			setting.MissingMemberHandling = MissingMemberHandling.Ignore;
		}

		public async Task<List<Movie>> GetMoviesAsync(int genreId, int page)
		{
			var result = await ApiProvider.GetMovies(genreId, page);
			var discover = JsonConvert.DeserializeObject<Discover>(result, setting);
			return discover.Movies;
        }

		public async Task<List<Genre>> GetGenres()
		{
			var result = await ApiProvider.GetGenres();
			var genres = JsonConvert.DeserializeObject<Genres>(result, setting);
			return genres.List;
		}

		public async Task<Movie> GetMovieAsync(int Id)
		{
			var result = await ApiProvider.GetMovie(Id);
			return JsonConvert.DeserializeObject<Movie>(result, setting);
		}

		public async Task<List<Review>> GetReviews(int movieId)
		{
			var result = await ApiProvider.GetReviews(movieId);
			var results = JsonConvert.DeserializeObject<Reviews>(result);
			return results.List;
		}

        public async Task<List<Video>> GetVideos(int movieId)
        {
            var result = await ApiProvider.GetVideos(movieId);
            var results = JsonConvert.DeserializeObject<Videos>(result);
            return results.List;
        }
    }
}

