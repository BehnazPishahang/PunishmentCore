
namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("مدرک مورد ابلاغ در سرویس")]
    public class PNoticeDocContract
    {
        public PNoticeDocContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره مدرک مورد ابلاغ")]
        public string? RelatedDocNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه مدرک مورد ابلاغ")]
        public string? RelatedObjectId { get; set; }

            

    }
    }
