using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Domain.Entities.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes> PDiscoveryMinutes { get; set; }
        public DbSet<Domain.Entities.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState> ObjectState { get; set; }
    }
}
