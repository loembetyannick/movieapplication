using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;
#nullable disable

namespace MovieAPI.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MoviesdbContext _context;

        public MovieController(MoviesdbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> Movies(
            [FromQuery] int startLimit,
            [FromQuery] int endLimit,
            [FromQuery] string genre,
            [FromQuery] string title,
            [FromQuery] bool isReleaseDateOrdered,
            [FromQuery] int limit = 20
            )
        {
            var querys = _context.Movies.Take(limit);

            try
            {
                if ((startLimit < 0 || endLimit < 0) &&
                
                    int.TryParse(startLimit.ToString(), out int startLimitResult) &&
                    int.TryParse(endLimit.ToString(), out int endLimitResult)
                )
                {
                    querys = querys.Where(movie => movie.Id >= startLimit && movie.Id <= endLimit);
                }

                if (genre != null)
                {
                    querys = querys.Where(movie => movie.Genre.Contains(genre));
                }

                if (title != null)
                {
                    querys = querys.Where(movie => movie.Title.Contains(title));
                }

                if (isReleaseDateOrdered)
                {
                    querys = querys.OrderBy(movie => movie.ReleaseDate);
                }

                return await querys.ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
