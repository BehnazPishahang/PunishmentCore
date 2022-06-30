using Microsoft.EntityFrameworkCore;

namespace Anu.DataAccess
{
    public class ApplicationDbContext : Anu.Oracle.DbContext.OracleDbContext //: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //this.UseEntity<T1>();
            //this.UseEntity<T2>();
            //this.UseEntity<T3<object>>();
            this.UseAssembly(typeof(Anu.BaseInfo.DataModel.BaseInfoEntity<>).Assembly);
            this.UseAssembly(typeof(Anu.PunishmentOrg.DataModel.PunishmentOrgEntity<>).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        //public DbSet<Domain.Entities.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes> PDiscoveryMinutes { get; set; }
        //public DbSet<Domain.Entities.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState> ObjectState { get; set; }
    }
}
