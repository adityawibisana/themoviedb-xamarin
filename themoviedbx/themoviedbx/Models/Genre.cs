using System;
using Newtonsoft.Json;

namespace themoviedbx.Models
{
	public class Genre
	{
		public Genre()
		{
		}

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public String Name { get; set; }
    }
}

