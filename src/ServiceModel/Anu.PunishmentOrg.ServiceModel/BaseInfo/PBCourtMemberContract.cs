
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("عضو شعبه هيات تعزيرات در سرویس")]
    public class PBCourtMemberContract
    {
        public PBCourtMemberContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تاريخ خاتمه اعتبار")]
        public string? EndDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام خانوادگي")]
        public string? Family { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سازمان مربوطه به عضو")]
        public Anu.PunishmentOrg.Enumerations.PUMemberType? MemberType { get; set; }

            
            
            [System.ComponentModel.DisplayName("تلفن همراه")]
        public string? MobilNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
        public string? Name { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ترتيب در چاپ")]
        public long? PrintOrder { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("متن امضاء شخص")]
        public string? SignText { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            

    }
    }
