using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace themoviedbx.Models
{
	public class Discover
	{
		public Discover()
		{
		}

        [JsonProperty(PropertyName = "page")]
        public int Page { get; set; }

        [JsonProperty(PropertyName = "results")]
        public List<Movie> Movies { get; set; }
    }
}

