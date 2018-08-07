using Microsoft.EntityFrameworkCore;

namespace explorphotosdotnetapi.Models
{
    public class ExplorContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }

        public ExplorContext(DbContextOptions<ExplorContext> options) 
            : base(options)
        {
            
        }
    }
}