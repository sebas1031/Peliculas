using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using MoviesProy.Client.Model;
using Newtonsoft.Json;
using System;

namespace MoviesProy.Client.Services
{

    public class ComingSoonService: ComingSoonServiceInterface
    {
        private readonly HttpClient _httpClient;

        public ComingSoonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<NewMovieData> GetAllMovies()
        {
           NewMovieData peliculas = new NewMovieData();
           _httpClient.BaseAddress = new Uri("https://imdb-api.com/en/API/ComingSoon/k_1yrn8726");
           peliculas = JsonConvert.DeserializeObject<NewMovieData>(await _httpClient.GetStringAsync("")); 
           Console.WriteLine(peliculas.Items.Count);
           return peliculas;
        }
    }
}