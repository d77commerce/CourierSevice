using CourierService.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CourierService.Infrastructure.Data
{
    public class ParcelDbContext : DbContext
    {
        public ParcelDbContext(DbContextOptions<ParcelDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Parcel> Parcels { get; set; } = null!;
        public DbSet<PartOfParcel> PartOfParcels { get; set; } = null!;
    }
}
