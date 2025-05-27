using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using _367_project_repo_destroyersofevil.Models;

namespace _367_project_repo_destroyersofevil.Services
{
    public class ExerciseApiService
    {
        private readonly HttpClient _httpClient;

        public ExerciseApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Exercise>> GetExercisesAsync()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://exercisedb.p.rapidapi.com/exercises"),
                Headers =
                {
                    { "X-RapidAPI-Key", "64b50cb8e7mshcf7a28461bd1794p1d0e79jsnaf212d08d0d9" },
                    { "X-RapidAPI-Host", "exercisedb.p.rapidapi.com" }
                }
            };

          var response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Exercise>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }) ?? new List<Exercise>();
            }

            return new List<Exercise>();
        }
    }
}

