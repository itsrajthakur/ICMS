using ICMS2.Models;
using Microsoft.EntityFrameworkCore;

namespace ICMS2.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Mapping> Mappings { get; set; }
    }
}
