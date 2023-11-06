using System;
using System.Collections.Generic;

namespace MovieAPI.Models;

public partial class Movie
{
    public long Id { get; set; }

    public string? ReleaseDate { get; set; }

    public string? Title { get; set; }

    public string? Overview { get; set; }

    public double? Popularity { get; set; }

    public long? VoteCount { get; set; }

    public long? VoteAverage { get; set; }

    public string? OriginalLanguage { get; set; }

    public string? Genre { get; set; }

    public string? PosterUrl { get; set; }
}
