using Anu.BaseInfo.DataModel.GeoInfo;
using Anu.BaseInfo.DataModel.OrganizationChart;
using Anu.BaseInfo.Enumerations;
using Anu.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataAccess.Unit;

public class UnitRepository : Anu.DataAccess.Repositories.GenericRepository<Anu.BaseInfo.DataModel.OrganizationChart.Unit>, Anu.BaseInfo.Domain.Unit.IUnitRepository
{
    public UnitRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<Anu.BaseInfo.DataModel.OrganizationChart.Unit> GetByUnitNo(string unitNo)
    {
        return await _context.Set<Anu.BaseInfo.DataModel.OrganizationChart.Unit>().Where(u => u.UnitNo == unitNo).FirstOrDefaultAsync();
    }
}
