using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.GeoInfo;

public interface IGeoLocationRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.GeoInfo.GeoLocation>
{
    public Task<Anu.BaseInfo.DataModel.GeoInfo.GeoLocation> GetGeoLocationWithLocationCode(string LocationCode);

    public Task<IEnumerable<Anu.BaseInfo.DataModel.GeoInfo.GeoLocation>> GetGeoLocationListWithParentLocationCode(string LocationCode , Anu.BaseInfo.Enumerations.LocationType locationType);
}
