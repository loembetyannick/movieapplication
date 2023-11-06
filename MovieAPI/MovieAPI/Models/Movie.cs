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

    public double? VoteAverage { get; set; }

    public string? OriginalLanguage { get; set; }

    public string? Genre { get; set; }

    public string? PosterUrl { get; set; }

    public Movie(
        long id,
        string? releaseDate,
        string? title,
        string? overview,
        double? popularity,
        long? voteCount,
        double? voteAverage,
        string? originalLanguage,
        string? genre,
        string? posterUrl)
    {
        Id = id;
        ReleaseDate = releaseDate;
        Title = title;
        Overview = overview;
        Popularity = popularity;
        VoteCount = voteCount;
        VoteAverage = voteAverage;
        OriginalLanguage = originalLanguage;
        Genre = genre;
        PosterUrl = posterUrl;
    }

    public Movie()
    {
        
    }
}
