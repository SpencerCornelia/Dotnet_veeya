using Microsoft.EntityFrameworkCore;
using Veeya.Models;

namespace Veeya.Persistence
{
    public class VeeyaDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<InvestorToWholesaler>(e => 
            {
                e.HasOne(r => r.Investor).WithMany(u => u.InvestorToWholesalers).HasForeignKey(r => r.InvestorId);
                e.HasOne(r => r.Wholesaler).WithMany(u => u.InvestorToWholesalers).HasForeignKey(r => r.WholesalerId);
            });


            // modelBuilder.Entity<InvestorToWholesaler>()
            //     .HasKey(t => new { t.InvestorId, t.WholesalerId });

            // modelBuilder.Entity<InvestorToWholesaler>()
            //     .HasOne(pt => pt.Investor)
            //     .WithMany(p => p.InvestorToWholesalers)
            //     .HasForeignKey(pt => pt.InvestorId);

            // modelBuilder.Entity<InvestorToWholesaler>()
            //     .HasOne(pt => pt.Wholesaler)
            //     .WithMany(p => p.InvestorToWholesalers)
            //     .HasForeignKey(pt => pt.WholesalerId);
        }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Wholesaler> Wholesalers { get; set; }
        public DbSet<Investor> Investors { get; set; }
        public DbSet<InvestorToWholesaler> InvestorToWholesalers { get; set; }
        public VeeyaDbContext(DbContextOptions<VeeyaDbContext> options)
            : base(options)
        {
        }
    }
}