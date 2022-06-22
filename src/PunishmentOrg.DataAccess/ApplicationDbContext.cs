using Microsoft.EntityFrameworkCore;
using Oracle.DbContext;

namespace PunishmentOrg.DataAccess
{
    public class ApplicationDbContext : OracleDbContext //: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //this.UseEntity<T1>();
            //this.UseEntity<T2>();
            //this.UseEntity<T3<object>>();
            this.UseAssembly(typeof(DataModel.BaseInfo.Anu.BaseInfoEntity<>).Assembly);
            this.UseAssembly(typeof(DataModel.PunishemntOrg.Anu.PunishmentOrgEntity<>).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        //public DbSet<Domain.Entities.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes> PDiscoveryMinutes { get; set; }
        //public DbSet<Domain.Entities.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState> ObjectState { get; set; }
    }
}
