﻿using System;
using System.Threading.Tasks;

namespace themoviedbx.Providers
{
	public interface ITMDBAPI
	{
		Task<String> GetMovies (String genre);
		Task<String> GetMovie (int MovieId);
		Task<String> GetGenres();
	}
}

