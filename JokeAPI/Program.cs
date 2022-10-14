using JokeAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<JokeDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Get array of Categories
app.MapGet("/Categories", () =>
{
    return new string[] { "Programming Jokes", "Dad Jokes" };
});

// Get joke by id
app.MapGet("/Joke/{id}", (int id) =>
{
    return "Here is a joke by id";
});

// Get total number of jokes in all categories
app.MapGet("/Jokes/Count", () =>
{
    return "There are x amount of jokes";
});

// Get joke in specific category
app.MapGet("/Joke", (string? category) =>
{
    if (category == null)
    {
        return "Here is a random joke for you :)";
    }
    
    return $"Here is a {category} joke...some joke here..."; 
});

// Get joke working with category lists
app.MapGet("/Joke/Categories", (string? includedCategories, string? excludedCategories) =>
{
    return $"Some joke within {includedCategories} but not in {excludedCategories}";
});

app.Run();