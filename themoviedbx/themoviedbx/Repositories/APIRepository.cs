﻿using System;
using System.Collections.Generic;
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

		public List<Movie> GetMovies()
		{
			var result = ApiProvider.GetMovies();
			var discover = JsonConvert.DeserializeObject<Discover>(result, setting);
			return discover.Movies;
        }

		public Movie GetMovie(int Id)
		{
			var result = ApiProvider.GetMovie(Id);
			return JsonConvert.DeserializeObject<Movie>(result, setting);
		}
	}
}

