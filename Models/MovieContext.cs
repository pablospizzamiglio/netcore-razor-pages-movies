using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovies.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<RazorPagesMovies.Models.Movie> Movie { get; set; }
    }
}