using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using MoviesProy.Client.Model;
using Newtonsoft.Json;
using System;

namespace MoviesProy.Client.Services
{

    public class TitleDataService : TitleDataServiceInterface
    {
        private readonly HttpClient _httpClient;

        public TitleDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<TitleData> GetMovie(String id)
        {
           TitleData pelicula = new TitleData();
           _httpClient.BaseAddress = new Uri("https://imdb-api.com/en/API/Title/k_1yrn8726/");
           pelicula = JsonConvert.DeserializeObject<TitleData>(await _httpClient.GetStringAsync(id +"/Trailer")); 
           Console.WriteLine(pelicula.Title);
           return pelicula;
        }
    }
}