using System.ComponentModel.DataAnnotations;

namespace JokeAPI.Models
{
    public class Joke
    {
        [Key]
        public int JokeId { get; set; }

        public string JokeText { get; set; } = null!;

        public Category? Category { get; set; }
    }

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;

        public ICollection<Joke> Jokes { get; set; } = new List<Joke>();
    }
}
