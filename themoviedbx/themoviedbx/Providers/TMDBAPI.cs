﻿using System;
namespace themoviedbx.Providers
{
	public class TMDBAPI : ITMDBAPI
	{
		public TMDBAPI()
		{
		}

        string ITMDBAPI.GetMovie(int MovieId)
        {
            throw new NotImplementedException();
        }

        string ITMDBAPI.GetMovies()
        {
            throw new NotImplementedException();
        }
    }
}
