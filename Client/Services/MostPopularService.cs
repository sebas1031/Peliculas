using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using MoviesProy.Client.Model;
using Newtonsoft.Json;
using System;

namespace MoviesProy.Client.Services
{
    public class MostPopularService: MostPopularServiceInterface
    {
        private readonly HttpClient _httpClient;

        public MostPopularService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public MostPopularData peliculas { get; set; } = new MostPopularData();
        public event Action OnChange;
        public async Task<MostPopularData> GetAllMovies()
        {
           
           _httpClient.BaseAddress = new Uri("https://imdb-api.com/en/API/MostPopularMovies/k_1yrn8726");
           peliculas = JsonConvert.DeserializeObject<MostPopularData>(await _httpClient.GetStringAsync(""));  
           Console.WriteLine(peliculas.Items.Count);
           return peliculas;
        }
    }
}