using Microsoft.EntityFrameworkCore;
using PunishmentOrg.Domain.Entities.Anu.BaseInfo.OrganizationChart;
using PunishmentOrg.Domain.Interface;
using PunishmentOrg.Domain.Interface.Anu.BaseInfo.OrganizationChart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.DataAccess.Repositories.Anu.BaseInfo.OrganizationChart
{
    public class UnitRepository : GenericRepository<Unit>, IUnitRepository
    {
        public UnitRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Unit>> GetUnitWithParentUnitList(string Id)
        {
            return await _context.Unit.Include(x => x.TheGUnitType).Where(x => x.Id == Id).ToListAsync();



            //_context.Set<Unit>().FromSqlRaw("select * from ");


        }
    }
}
