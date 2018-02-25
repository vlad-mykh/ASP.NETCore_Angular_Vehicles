using Vehicles.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Vehicles.Persistence
{
    public class VehiclesDbContext : DbContext
    {
        public VehiclesDbContext(DbContextOptions<VehiclesDbContext> options) : base(options) {

        }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Feature> Features { get; set; }
    }
}