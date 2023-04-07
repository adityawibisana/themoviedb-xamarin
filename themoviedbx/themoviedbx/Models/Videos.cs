using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace themoviedbx.Models
{
	public class Videos
	{
		public Videos()
		{
		}

        [JsonProperty(PropertyName = "results")]
        public List<Video> List { get; set; }
    }
}

