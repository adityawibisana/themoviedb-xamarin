using System;
using System.Threading.Tasks;

namespace themoviedbx.Providers
{
	public interface ITMDBAPI
	{
		Task<String> GetMovies (int genreId, int page);
		Task<String> GetMovie (int MovieId);
		Task<String> GetGenres();
		Task<String> GetReviews(int MovieId);
		Task<String> GetVideos(int MovieId);
	}
}

