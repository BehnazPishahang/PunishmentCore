using Anu.BaseInfo.DataModel.OrganizationChart;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.DataAccess.OrganizationChart
{
    public class UnitRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.OrganizationChart.Unit>,
        Domain.OrganizationChart.IUnitRepository
    {
        public UnitRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {

        }

        public async Task<Unit> GetByCode(string code)
        {
            return await _context.Set<Anu.BaseInfo.DataModel.OrganizationChart.Unit>().Where(x => x.Code == code).FirstOrDefaultAsync();
        }
    }
}
