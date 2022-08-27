using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataAccess.OrganizationChart
{
    public class UnitRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.OrganizationChart.Unit>,
        Domain.OrganizationChart.IUnitRepository
    {
        public UnitRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {

        }

        public async Task<DataModel.OrganizationChart.Unit> FindRelatedUnitToGeoLocation(string locationCode , List<string> gUnitTypes)
        {
            return await _context.Set<Anu.BaseInfo.DataModel.OrganizationChart.Unit>().
                Where(x =>  x.TheGeoLocation.LocationCode == locationCode
                      && x.State == Anu.BaseInfo.Enumerations.State.Valid
                      && gUnitTypes.Contains(x.TheGUnitType.Code))
                .FirstOrDefaultAsync();
        }

        public async Task<Anu.BaseInfo.DataModel.OrganizationChart.Unit> GetByCode(string unitNo)
        {
            return await _context.Set<Anu.BaseInfo.DataModel.OrganizationChart.Unit>().Where(x => x.UnitNo == unitNo).FirstOrDefaultAsync();
        }
    }
}
