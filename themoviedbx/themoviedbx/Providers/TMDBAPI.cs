using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Android.Gestures;
using Java.Net;
using Newtonsoft.Json;

namespace themoviedbx.Providers
{
	public class TMDBAPI : ITMDBAPI
	{
        const String apiKey = "fc2d3123db51dc904176fe0bfa8f6ff6";
        const String baseUrl = "https://api.themoviedb.org/3";

        HttpClient httpClient;
        
		public TMDBAPI(HttpClient httpClient)
		{
            this.httpClient = httpClient;
        }

        async Task<String> ITMDBAPI.GetGenres()
        {
            var url = $"{baseUrl}/genre/movie/list?api_key={apiKey}";
            return await getResult(url);
        }

        async Task<String> ITMDBAPI.GetMovie(int MovieId)
        {
            var url = $"{baseUrl}/movie/{MovieId}&api_key={apiKey}";
            return await getResult(url);
        }

        async Task<String> ITMDBAPI.GetMovies(int genreId)
        {
            var url = $"{baseUrl}/discover/movie?with_genres={genreId}&api_key={apiKey}";
            return await getResult(url);
        }

        async Task<String> ITMDBAPI.GetReviews(int movieId)
        {
            var url = $"{baseUrl}/movie/{movieId}/reviews?api_key={apiKey}";
            return await getResult(url);
        }

        async Task<String> ITMDBAPI.GetVideos(int movieId)
        {
            var url = $"{baseUrl}/movie/{movieId}/videos?api_key={apiKey}";
            return await getResult(url);
        }

        async Task<String> getResult(String url)
        {
            var response = await httpClient.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            return await Task.FromResult(json);
        }

        ~TMDBAPI()
        {
            httpClient.Dispose();
        }
    }
}

