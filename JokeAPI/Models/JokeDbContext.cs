using Microsoft.EntityFrameworkCore;

namespace JokeAPI.Models
{
    public class JokeDbContext : DbContext
    {
        public JokeDbContext(DbContextOptions<JokeDbContext> options) : base(options)
        {

        }

        public DbSet<Joke> Jokes { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;
    }
}
