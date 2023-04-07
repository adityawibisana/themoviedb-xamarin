using System;
using Newtonsoft.Json;

namespace themoviedbx.Models
{
	public class Review
	{
		public Review()
		{
		}

        [JsonProperty(PropertyName = "author")]
        public String Author { get; set; }

        [JsonProperty(PropertyName = "content")]
        public String Content { get; set; }
    }
}

