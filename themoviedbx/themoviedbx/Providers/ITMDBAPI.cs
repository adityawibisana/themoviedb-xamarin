using System;
namespace themoviedbx.Providers
{
	public interface ITMDBAPI
	{
		String GetMovies ();
		String GetMovie (int MovieId);
	}
}

