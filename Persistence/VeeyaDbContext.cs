using Microsoft.EntityFrameworkCore;
using Veeya.Models;

namespace Veeya.Persistence
{
    public class VeeyaDbContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }
        public DbSet<Wholesaler> Wholesalers { get; set; }
        public DbSet<Investor> Investors { get; set; }
        public VeeyaDbContext(DbContextOptions<VeeyaDbContext> options)
            : base(options)
        {
        }
    }
}