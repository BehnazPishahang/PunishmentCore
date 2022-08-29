using Anu.BaseInfo.DataModel.GeoInfo;
using Anu.BaseInfo.Enumerations;
using Anu.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataAccess.GeoInfo;

public class GeoLocationRepository : Anu.DataAccess.Repositories.GenericRepository<Anu.BaseInfo.DataModel.GeoInfo.GeoLocation>, Anu.BaseInfo.Domain.GeoInfo.IGeoLocationRepository
{
    public GeoLocationRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<GeoLocation>> GetGeoLocationListWithParentLocationCode(string LocationCode, Anu.BaseInfo.Enumerations.LocationType locationType)
    {
        return await _context.Set<Anu.BaseInfo.DataModel.GeoInfo.GeoLocation>().Where(x => x.TheParentLocation.LocationCode == LocationCode && x.LocationType == locationType).ToListAsync();
    }

    public async Task<Anu.BaseInfo.DataModel.GeoInfo.GeoLocation> GetGeoLocationWithLocationCode(string LocationCode)
    {
        return await _context.Set<Anu.BaseInfo.DataModel.GeoInfo.GeoLocation>().Where(x => x.LocationCode == LocationCode).FirstOrDefaultAsync();

    }
}
