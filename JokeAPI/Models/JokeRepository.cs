using Microsoft.EntityFrameworkCore;

namespace JokeAPI.Models
{
    public class JokeRepository : IJokeRepository
    {
        private readonly JokeDbContext _jokeDb;

        public JokeRepository(JokeDbContext jokeDb)
        {
            _jokeDb = jokeDb;
        }

        public async Task<string[]> GetAllCategoryNames()
        {
            return await (from j in _jokeDb.Categories
                         select j.CategoryName).ToArrayAsync();
        }
    }

    public interface IJokeRepository
    {
        /// <summary>
        /// Returns an array of category names
        /// </summary>
        Task<string[]> GetAllCategoryNames();
    }
}
