using Microsoft.EntityFrameworkCore;

namespace GraphicDesignerPortfolioAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<PortfolioItem> PortfolioItems { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
