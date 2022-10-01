
namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("مدرک مورد آگهي ابلاغ در سرویس")]
    public class PNoticeAdvertisingDocContract
    {
        public PNoticeAdvertisingDocContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره مدرک مورد آگهي ابلاغ")]
        public string? RelatedDocNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه مدرک مورد آگهي ابلاغ")]
        public string? RelatedObjectId { get; set; }

            

    }
    }
