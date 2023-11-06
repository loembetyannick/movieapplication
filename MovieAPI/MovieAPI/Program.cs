using Microsoft.EntityFrameworkCore;
using MovieAPI.Constants;
using MovieAPI.Models;
using MovieAPI.Services.Abstract;
using MovieAPI.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var endpoints = new SystemsConstant();
builder.Services.AddSingleton(endpoints);

builder.Services.AddHttpClient("MovieAPIEndpoint", 
    client => client.BaseAddress = new Uri(endpoints.BaseUrl));
builder.Services.AddDbContext<MoviesdbContext>(options => options.UseSqlite(
        builder.Configuration.GetConnectionString("MoviesDB")));
builder.Services.AddScoped<IMovieService, MovieService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
