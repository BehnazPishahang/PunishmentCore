using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.PunishmentOrg.Domain.BaseInfo;
using Microsoft.EntityFrameworkCore;
using Utility.Guard;

namespace Anu.PunishmentOrg.DataAccess.BaseInfo;

public class PBCountyLocatedUnitRepository : GenericRepository<Anu.PunishmentOrg.DataModel.BaseInfo.PBCountyLocatedUnit>, IPBCountyLocatedUnitRepository
{
    public PBCountyLocatedUnitRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
    {
    }

    public async Task<Anu.PunishmentOrg.DataModel.BaseInfo.PBCountyLocatedUnit> GetRelatedPBCountyLocatedUnitToGeolocationWithLocationCode(string geoLocationCode)
    {
        return await _context.Set<Anu.PunishmentOrg.DataModel.BaseInfo.PBCountyLocatedUnit>().Where(a => a.TheGeoLocation.LocationCode == geoLocationCode)
            .FirstOrDefaultAsync();
    }
}


