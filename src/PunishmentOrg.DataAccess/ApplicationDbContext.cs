using Anu;
using Microsoft.EntityFrameworkCore;
using Oracle.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.UseAssembly(typeof(BaseInfoEntity<>).Assembly);
            this.UseAssembly(typeof(PunishmentOrgEntity<>).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        //public DbSet<Domain.Entities.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes> PDiscoveryMinutes { get; set; }
        //public DbSet<Domain.Entities.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState> ObjectState { get; set; }
    }
}
