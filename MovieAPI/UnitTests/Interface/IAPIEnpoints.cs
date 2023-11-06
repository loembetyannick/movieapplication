using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Interface
{
    public interface IAPIEnpoints
    {
        string MoviesEndpoint { get; }

        string MovieTitleEndpoint { get; }

        string MovieGenres { get; }

        string MovieLimitEndpoint { get; }

        string SingleMovieEndpoint { get; }
    }
}
