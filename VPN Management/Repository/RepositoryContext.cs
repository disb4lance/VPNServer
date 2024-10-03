

using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<VPNServer>? VPNServers { get; set; }
        public DbSet<VPNConfiguration>? VPNConfigurations { get; set; }
        public DbSet<VPNSession>? VPNSessions { get; set; }
    }
}
