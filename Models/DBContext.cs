using Microsoft.EntityFrameworkCore;

namespace explorphotosdotnetapi.Models
{
    public class ExplorContext : DbContext
    {
        public ExplorContext(DbContextOptions<ExplorContext> options) 
            : base(options)
        {
            
        }

        public DbSet<Photo> Photos { get; set; }
    }
}