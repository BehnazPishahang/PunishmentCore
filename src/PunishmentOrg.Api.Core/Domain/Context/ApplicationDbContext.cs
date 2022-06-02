using Microsoft.EntityFrameworkCore;
using PunishmentOrg.Api.Core.Domain.Classes.Anu.BaseInfo.OrganizationChart;

namespace PunishmentOrg.Api.Core.Domain.Context
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Unit> Unit { set; get; }
        public DbSet<GUnitType> GUnitType { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }

            // it should be placed here, otherwise it will rewrite the following settings!
            base.OnModelCreating(modelBuilder); 
        }
    }
}
