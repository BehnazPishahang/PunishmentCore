
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("گروه کالا/ارز سازمان هاي نعامل کننده در سرویس")]
    public class PBBillProductGrpContract
    {
        public PBBillProductGrpContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
        public string? Name { get; set; }

            
            
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
