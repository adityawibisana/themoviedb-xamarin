using System;
namespace themoviedbx.Providers
{
	public interface ITMDBAPI
	{
		String GetMovies (String genre);
		String GetMovie (int MovieId);
		String GetGenres();
	}
}

