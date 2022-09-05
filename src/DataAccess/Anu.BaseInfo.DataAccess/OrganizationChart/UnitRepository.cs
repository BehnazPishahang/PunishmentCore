using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataAccess.OrganizationChart
{
    public class UnitRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.OrganizationChart.Unit>,
        Domain.OrganizationChart.IUnitRepository
    {
        public UnitRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {

        }

        public async Task<DataModel.OrganizationChart.Unit> FindRelatedUnitToGeoLocation(string locationCode, List<string> gUnitTypes)
        {
            //to
            return await _context.Set<Anu.BaseInfo.DataModel.OrganizationChart.Unit>()
                .Where(x => x.TheGeoLocation.LocationCode == locationCode
                      && x.State == Anu.BaseInfo.Enumerations.State.Valid
                      && gUnitTypes.Contains(x.TheGUnitType.Code)).Include(u => u.TheCMSOrganizationList).FirstOrDefaultAsync();
        }

        public async Task<Anu.BaseInfo.DataModel.OrganizationChart.Unit> GetByCode(string code)
        {
            return await _context.Set<Anu.BaseInfo.DataModel.OrganizationChart.Unit>().Where(x => x.Code == code)
                .Include(x=> x.TheGUnitType)
                .FirstOrDefaultAsync();
        }
    }
}
