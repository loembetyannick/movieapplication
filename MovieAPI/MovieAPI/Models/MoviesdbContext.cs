using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MovieAPI.Models;

public partial class MoviesdbContext : DbContext
{
    public MoviesdbContext()
    {
    }

    public MoviesdbContext(DbContextOptions<MoviesdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=moviesdb.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_Movies_ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OriginalLanguage).HasColumnName("Original_Language");
            entity.Property(e => e.PosterUrl).HasColumnName("Poster_Url");
            entity.Property(e => e.ReleaseDate).HasColumnName("Release_Date");
            entity.Property(e => e.VoteAverage).HasColumnName("Vote_Average");
            entity.Property(e => e.VoteCount).HasColumnName("Vote_Count");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
