using System;
using System.Threading.Tasks;

namespace themoviedbx.Providers
{
	public interface ITMDBAPI
	{
		Task<String> GetMovies (int genreId);
		Task<String> GetMovie (int MovieId);
		Task<String> GetGenres();
	}
}

