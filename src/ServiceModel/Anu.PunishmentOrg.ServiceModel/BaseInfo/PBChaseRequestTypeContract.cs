
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("نوع موضوع درخواست، درخواست 4گانه در سرویس")]
    public class PBChaseRequestTypeContract
    {
        public PBChaseRequestTypeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("موضوع درخواست")]
        public string? Subject { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد موضوع درخواست")]
        public long? SubjectId { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان درخواست")]
        public string? Title { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد عنوان درخواست")]
        public long? TitleId { get; set; }

            

    }
    }
