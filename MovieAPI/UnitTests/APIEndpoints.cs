using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Interface;

namespace UnitTests
{
    public class APIEndpoints : IAPIEnpoints
    {
        public string MoviesEndpoint { get; } = "https://localhost:7142/api/Movie";

        public string MovieTitleEndpoint { get; } = "https://localhost:7142/api/Movie?title=Spider-Man%3A%20No%20Way%20Home";

        public string MovieGenres { get; } = "https://localhost:7142/api/Movie?genre=Action%2C%20Adventure%2C%20Science%20Fiction";

        public string MovieLimitEndpoint { get; } = "https://localhost:7142/api/Movie?startLimit=1&endLimit=20";

        public string SingleMovieEndpoint { get;  } = "https://localhost:7142/api/Movie?title=Spider-Man%3A%20No%20Way%20Home";

    }
}
