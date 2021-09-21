using Microsoft.EntityFrameworkCore;

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
    }
}