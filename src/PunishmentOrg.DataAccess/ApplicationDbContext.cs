using Microsoft.EntityFrameworkCore;
using PunishmentOrg.Domain.Entities.Anu.BaseInfo.OrganizationChart;
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
        public DbSet<Unit> Unit { get; set; }
        public DbSet<GUnitType> GUnitType { get; set; }
    }
}
