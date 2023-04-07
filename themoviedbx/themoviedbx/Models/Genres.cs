using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace themoviedbx.Models
{
	public class Genres
	{
		public Genres()
		{
            
        }

        [JsonProperty(PropertyName = "genres")]
        public List<Genre> List { get; set; }
    }
}

