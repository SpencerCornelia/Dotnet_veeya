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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvestorToWholesaler>()
                .HasKey(t => new { t.InvestorId, t.WholesalerId });

            modelBuilder.Entity<InvestorToWholesaler>()
                .HasOne(pt => pt.Investor)
                .WithMany(p => p.InvestorToWholesalers)
                .HasForeignKey(pt => pt.InvestorId);

            modelBuilder.Entity<InvestorToWholesaler>()
                .HasOne(pt => pt.Wholesaler)
                .WithMany(p => p.InvestorToWholesalers)
                .HasForeignKey(pt => pt.WholesalerId);
        }
    }
}