
using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Entities.Auction> Auctions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Property>().ToTable("Properties");
            modelBuilder.Entity<Entities.Auction>()
                .HasOne(x => x.Property)
                .WithOne(x => x.Auction)
                .HasForeignKey<Entities.Property>(p => p.Auctionid);
        }
    }
}
