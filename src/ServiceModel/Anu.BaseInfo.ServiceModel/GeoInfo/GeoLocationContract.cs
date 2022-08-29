
namespace Anu.BaseInfo.ServiceModel.GeoInfo
{
    [System.ComponentModel.DisplayName("مکان جغرافيايي در سرویس")]
    public class GeoLocationContract
    {
        public GeoLocationContract()
        {
        }

        [System.ComponentModel.DisplayName("نوع مکان جغرافیایی درخواست شده")]
        public Anu.BaseInfo.Enumerations.LocationType? ChildLocationType { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نام کامل")]
        public string? FullLocationName { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("کد")]
        public string? LocationCode { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نام")]
        public string? LocationName { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نوع")]
        public Anu.BaseInfo.Enumerations.LocationType? LocationType { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.PunishmentOrg.Enumerations.PULegalPersonState? State { get; set; }



    }
}
