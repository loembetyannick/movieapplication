using MovieAPI.Models;
using MovieAPI.Services.Abstract;
using Newtonsoft.Json;


namespace MovieAPI.Services.Concrete
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;

        public MovieService(
                IHttpClientFactory httpClientFactory,
                ILogger<MovieService> log
            )
        {
            _httpClient = httpClientFactory.CreateClient("MoviesDB");
            _logger = log;
        }
        public async Task<IEnumerable<Movie>?> GetMoviesAsync()
        {
            IEnumerable<Movie>? result = null;
            try
            {
                using var response = await _httpClient.GetAsync($"Movies");
                result = JsonConvert.DeserializeObject<IEnumerable<Movie>>(response.Content.ReadAsStringAsync().Result);

            } catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }

            return result;
        }

        public async Task<IEnumerable<Movie>?> GetFilteredMoviesAsync(
                int startLimit,
                int endLimit,
                string genre,
                string title,
                bool isReleaseDateOrdered,
                int limit = 20
            )
        {
            IEnumerable<Movie>? result = null;
            try
            {
                using var response = await _httpClient.GetAsync(
                    $"Movies?startLimit={startLimit}&endLimit={endLimit}&genre={genre}&title={title}&isReleaseDateOrdered={isReleaseDateOrdered}&limit={limit}");
                result = JsonConvert.DeserializeObject<IEnumerable<Movie>>(response.Content.ReadAsStringAsync().Result);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }

            return result;
        }
    }
}
