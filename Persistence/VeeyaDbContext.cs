using Microsoft.EntityFrameworkCore;
using Veeya.Models;

namespace Veeya.Persistence
{
    public class VeeyaDbContext : DbContext
    {
        public VeeyaDbContext(DbContextOptions<VeeyaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
    }
}