using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Helper
{
    public class MovieQueryParameters
    {
        public int startLimit { get; set; }
        public int endLimit { get; set; }
        public string genre { get; set; }
        public string title { get; set; }
        public bool isReleaseDateOrdered { get; set; }
        public int limit { get; set; } = 20;
    }
}
