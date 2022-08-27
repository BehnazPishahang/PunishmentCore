
namespace Anu.BaseInfo.ServiceModel.GeoInfo
{
    [System.ComponentModel.DisplayName("GeoLocationRequest")]
    public class GeoLocationRequest
    {
        public GeoLocationRequest()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("مکان جغرافيايي در سرویس")]
        public Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract? TheGeoLocationContract { get; set; }



    }
}
