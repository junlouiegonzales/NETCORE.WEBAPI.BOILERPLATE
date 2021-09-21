using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NETCORE.Persistence.Context
{
    public abstract class NetCoreBasedDbContext : DbContext
    {
        protected NetCoreBasedDbContext(DbContextOptions<NetCoreDbContext> options)
                : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return (await base.SaveChangesAsync(true, cancellationToken));
        }
    }
}