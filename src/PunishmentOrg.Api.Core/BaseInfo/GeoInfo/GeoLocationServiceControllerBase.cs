
using Anu.BaseInfo.ServiceModel.GeoInfo;
using Anu.BaseInfo.ServiceModel.GeoInfo;

namespace Anu.BaseInfo.Api.GeoInfo
{
    public abstract class GeoLocationServiceControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
    public GeoLocationServiceControllerBase()
    {
    }
        [Microsoft.AspNetCore.Mvc.HttpPost]
            [Microsoft.AspNetCore.Mvc.Route("api/v1/GeoInfo/GetGeoLocationList")]
        public abstract Task<GeoLocationResponse> GetGeoLocationList([Microsoft.AspNetCore.Mvc.FromBody]GeoLocationRequest request);

    }
    }
