
namespace Anu.PunishmentOrg.ServiceModel.Execution
{
    [System.ComponentModel.DisplayName("انجام امور عام المنفعه بدل از جزاي نقدي در سرویس")]
    public class PPublicWorksExecContract
    {
        public PPublicWorksExecContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مقام تاييد کننده")]
        public Anu.PunishmentOrg.Enumerations.ConfirmerExecutionDocsType? ConfirmerPostType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ خاتمه کار عام المنفعه")]
        public string? FreeDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تعداد روزهايي که محکوم بايد کار کند با احتساب مدت زمان بازداشتي")]
        public long? NumDayRemain { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نحوه حضور")]
        public Anu.PunishmentOrg.Enumerations.PUPublicWorkTime? Presence { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان محل انجام امور عام المنفعه")]
        public string? PublicWorkName { get; set; }

            
            
            [System.ComponentModel.DisplayName("آدرس محل انجام امور عام المنفعه")]
        public string? PublicWorkPlaceAddress { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ شروع کار عام المنفعه")]
        public string? StartDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تعداد ساعت انجام کار عام المنفعه در هر روز")]
        public long? WorkTimeCount { get; set; }

            

    }
    }
