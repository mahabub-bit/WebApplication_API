using Microsoft.EntityFrameworkCore;
using Web_API.Models;

namespace Web_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryType> CategoryTypes { get; set; }

        public DbSet<Service> Services { get; set; }
    }
}
