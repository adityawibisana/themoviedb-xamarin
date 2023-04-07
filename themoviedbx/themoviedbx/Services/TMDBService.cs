using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace themoviedbx.Services
{
	public class TMDBService
	{
		private HttpClient httpClient;

		const String apiKey = "fc2d3123db51dc904176fe0bfa8f6ff6";
		const String baseUrl = "https://api.themoviedb.org/3";


        public TMDBService()
		{
			httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

		~TMDBService()
		{
			httpClient.Dispose();
		}
	}
}

