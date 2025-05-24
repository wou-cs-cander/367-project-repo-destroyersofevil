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

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();

            var exercises = JsonSerializer.Deserialize<List<Exercise>>(json);
            return exercises ?? new List<Exercise>();
        }
    }
}

