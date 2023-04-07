using System;
using Newtonsoft.Json;

namespace themoviedbx.Models
{
	public class Video
	{
		public Video()
		{
		}

        [JsonProperty(PropertyName = "key")]
        public String Key { get; set; }

        // only open if site = YouTube
        [JsonProperty(PropertyName = "site")]
        public String Site { get; set; }
    }
}

