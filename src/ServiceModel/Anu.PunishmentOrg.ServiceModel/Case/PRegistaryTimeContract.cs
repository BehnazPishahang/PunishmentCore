
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("وقت شعبه در سرویس")]
    public class PRegistaryTimeContract
    {
        public PRegistaryTimeContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شماره پرونده ها/فرعي هاي مربوطه")]
        public string? CasesNoSubno { get; set; }

            
            
            [System.ComponentModel.DisplayName("ساعت خاتمه جلسه رسيدگي")]
        public string? EndTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ وقت")]
        public string? RegisterDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("ساعت شروع جلسه رسيدگي")]
        public string? StartTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("نتيجه وقت")]
        public string? TimeResult { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت وقت")]
        public Anu.PunishmentOrg.Enumerations.PURegisterTimeStatus? TimeStatus { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع وقت")]
        public Anu.PunishmentOrg.Enumerations.PURegisterTimeType? TimeType { get; set; }

            

    }
    }
