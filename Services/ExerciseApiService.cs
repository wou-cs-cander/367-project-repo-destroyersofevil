// This service will handle making HTTP requests to the ExerciseDB API
public class ExerciseApiService
{
    private readonly HttpClient _httpClient;

    // Inject HttpClient via constructor
    public ExerciseApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Method to get a list of exercises from the API
    public async Task<List<Exercise>> GetExercisesAsync()
    {
        // Create an HTTP GET request to the ExerciseDB endpoint
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://exercisedb.p.rapidapi.com/exercises"),
            Headers =
            {
                { "X-RapidAPI-Key", "64b50cb8e7mshcf7a28461bd1794p1d0e79jsnaf212d08d0d9" }, //Our API key
                { "X-RapidAPI-Host", "exercisedb.p.rapidapi.com" }
            }
        };

        // Send the request and wait for a response
        using var response = await _httpClient.SendAsync(request);

        // Throw an exception if the API call failed
        response.EnsureSuccessStatusCode();

        // Read the response content as a string
        var json = await response.Content.ReadAsStringAsync();

        // Deserialize the JSON into a list of Exercise objects
        return JsonSerializer.Deserialize<List<Exercise>>(json);
    }
}
