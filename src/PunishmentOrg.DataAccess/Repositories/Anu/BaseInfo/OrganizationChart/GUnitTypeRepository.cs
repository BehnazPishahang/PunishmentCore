using PunishmentOrg.Domain.Entities.Anu.BaseInfo.OrganizationChart;
using PunishmentOrg.Domain.Interface.Anu.BaseInfo.OrganizationChart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.DataAccess.Repositories.Anu.BaseInfo.OrganizationChart
{
    public class GUnitTypeRepository : GenericRepository<GUnitType>, IGUnitTypeRepository
    {
        public GUnitTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
