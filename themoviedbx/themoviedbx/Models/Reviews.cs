using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace themoviedbx.Models
{
	public class Reviews
	{
		public Reviews()
		{
		}

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "page")]
        public int Page { get; set; }

        [JsonProperty(PropertyName = "results")]
        public List<Review> List { get; set; }
    }
}

