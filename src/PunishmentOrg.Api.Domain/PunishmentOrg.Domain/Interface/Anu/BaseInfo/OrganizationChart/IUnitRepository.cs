using PunishmentOrg.Domain.Entities.Anu.BaseInfo.OrganizationChart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.Domain.Interface.Anu.BaseInfo.OrganizationChart
{
    public interface IUnitRepository : IGenericRepository<Unit>
    {
        Task<IEnumerable<Unit>> GetUnitWithParentUnitList(string Id);
    }
}
