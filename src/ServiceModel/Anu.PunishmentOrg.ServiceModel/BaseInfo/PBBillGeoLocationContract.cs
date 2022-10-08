
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("مکان جغرافيايي سازمان تعامل کننده در سرویس")]
    public class PBBillGeoLocationContract
    {
        public PBBillGeoLocationContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
        public string? LocationCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
        public string? LocationName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع")]
        public Anu.BaseInfo.Enumerations.LocationType? LocationType { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد در سامانه سازمان تعامل کننده")]
        public string? OrgCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه در سامانه سازمان تعامل کننده")]
        public long? OrgID { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            

    }
    }
