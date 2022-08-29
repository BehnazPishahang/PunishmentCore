
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.BaseInfo.ServiceModel.GeoInfo
{
    [System.ComponentModel.DisplayName("GeoLocationResponse")]
    public class GeoLocationResponse : IResponseMessage
    {
        public GeoLocationResponse()
        {
            TheGeoLocationContractList = new List<Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract>();
            Result = new Result();
        }

        [System.ComponentModel.DisplayName("مکان جغرافيايي در سرویس")]
        public List<Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract>? TheGeoLocationContractList { get; set; }

        public Result Result { get; set; }




    }
}
