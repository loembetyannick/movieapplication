using MovieAPI.Models;
using Newtonsoft.Json;

namespace UnitTests
{
    public class MovieAPIUnitTests
    {
        [Fact]
        public async void GetMovies()
        {
            using(HttpClient client = new HttpClient())
            {
                // Arrange 
                var endpoint = new APIEndpoints().MoviesEndpoint;
                string url = endpoint;

                HttpResponseMessage response = await client.GetAsync(url);
                var result = new List<Movie>();
                
                // Act
                if(response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    result = JsonConvert.DeserializeObject<List<Movie>>(content);
                } 
                else
                {
                    Assert.Fail("failed to make the request");
                }

                // Assert
                if(result != null)
                {
                    Assert.Equal(20, result.Count);
                } 
                else
                {
                    Assert.Fail("results are null");
                }
            }

        }

        [Fact]
        public async void GetMovieTitle() 
        {
            using (HttpClient client = new HttpClient())
            {
                // Arrange 
                var endpoint = new APIEndpoints().MovieTitleEndpoint;
                string url = endpoint;

                HttpResponseMessage response = await client.GetAsync(url);
                var result = new List<Movie>();

                // Act
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    result = JsonConvert.DeserializeObject<List<Movie>>(content);
                }
                else
                {
                    Assert.Fail("failed to make the request");
                }

                // Assert
                if (result != null)
                {
                    Assert.Single(result);
                }
                else
                {
                    Assert.Fail("result is null");
                }
            }
        }

        [Fact]
        public async void GetMovieGenres() 
        {
            using (HttpClient client = new HttpClient())
            {
                // Arrange 
                var endpoint = new APIEndpoints().MovieGenres;
                string url = endpoint;

                HttpResponseMessage response = await client.GetAsync(url);
                var result = new List<Movie>();

                // Act
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    result = JsonConvert.DeserializeObject<List<Movie>>(content);
                }
                else
                {
                    Assert.Fail("failed to make the request");
                }

                // Assert
                if (result != null)
                {
                    var filteredGenres = result.Where(movie => movie.Genre != null && !movie.Genre.Contains("Action") &&
                                          !movie.Genre.Contains("Adventure") &&
                                          !movie.Genre.Contains("Science Fiction"));

                    Assert.Empty(filteredGenres);
                }
                else
                {
                    Assert.Fail("result is null");
                }
            }
        }


        [Fact]
        public async void GetMovieLimits() {
            using (HttpClient client = new HttpClient())
            {
                // Arrange 
                var endpoint = new APIEndpoints().MovieLimitEndpoint;
                string url = endpoint;

                HttpResponseMessage response = await client.GetAsync(url);
                var result = new List<Movie>();

                // Act
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    result = JsonConvert.DeserializeObject<List<Movie>>(content);
                }
                else
                {
                    Assert.Fail("failed to make the request");
                }

                // Assert
                if (result != null)
                {

                    Assert.Equal(20, result.Count);
                }
                else
                {
                    Assert.Fail("result is null");
                }
            }


        }
    }
}