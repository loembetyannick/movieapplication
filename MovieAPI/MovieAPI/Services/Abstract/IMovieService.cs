using Microsoft.AspNetCore.Mvc;
using MovieAPI.Helper;
using MovieAPI.Models;

namespace MovieAPI.Services.Abstract
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>?> GetMoviesAsync();

        Task<IEnumerable<Movie>?> GetFilteredMoviesAsync(
                int startLimit,
                int endLimit,
                string genre,
                string title,
                bool isReleaseDateOrdered,
                int limit = 20
        );
    }
}
