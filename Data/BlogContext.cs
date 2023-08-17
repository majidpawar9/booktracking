using Microsoft.EntityFrameworkCore;
using booktracking.Models;

namespace booktracking.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) 
            : base(options)
        {

        }
        public DbSet<Book> Books { get; set; } =null!;

    }
}