using Microsoft.EntityFrameworkCore;
using NETCORE.Domain.Entities;

namespace NETCORE.Persistence.Context
{
    public class NetCoreDbContext : NetCoreBasedDbContext
    {
        public NetCoreDbContext(DbContextOptions<NetCoreDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Weather> Weathers { get; set; }
    }
}