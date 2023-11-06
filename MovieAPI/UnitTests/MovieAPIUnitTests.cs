using MovieAPI.Helper;
using MovieAPI.Models;
using Newtonsoft.Json;
using System.Linq.Expressions;

namespace UnitTests
{
    public class MovieAPIUnitTests
    {
        [Fact]
        public void GetMovies()
        {
            try
            {
                // Arrange 
                var movie = new MovieGenerator();

                // Act
                

                // Assert
                if (movie._movies != null)
                {
                    Assert.Equal(19, (int?)movie?._movies?.Count());
                }
                else
                {
                    Assert.Fail("results are null");
                }
            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message);
            }


        }

        [Fact]
        public void GetMovieTitle() 
        {
            try
            {
                // Arrange 
                var movie = new MovieGenerator();

                // Act
                var result = movie?._movies?.Where(movie => movie.Title == "Spider-Man: No Way Home");

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
            catch (Exception)
            {
                throw new Exception();
            }
        }

        [Fact]
        public void GetMovieGenres() 
        {
            try
            {
                // Arrange 
                var movie = new MovieGenerator();
                // Act
                IEnumerable<Movie?>? filteredGenres = null; 
                if (movie._movies != null)
                {
                     filteredGenres = movie?._movies?.Where(movie => movie.Genre != null && movie.Genre.Contains("Action") &&
                                          movie.Genre.Contains("Adventure") &&
                                          movie.Genre.Contains("Science Fiction"));

                }
                // Assert
                if (filteredGenres != null)
                {
                    Assert.Single(filteredGenres);
                }
                else
                {
                    Assert.Fail("result is null");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}