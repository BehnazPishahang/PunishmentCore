
namespace Anu.PunishmentOrg.ServiceModel.Execution
{
    [System.ComponentModel.DisplayName("دستور توقف عمليات اجرايي در سرویس")]
    public class PStopExecutiveOrderContract
    {
        public PStopExecutiveOrderContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ خاتمه توقف عمليات اجرايي")]
        public string? EndStopDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره شعبه بدوي/تجديدنظر ديوان عدالت اداري صادر کننده دستور توقف")]
        public long? OfficeCourtNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("متن دستور مرجع عالي")]
        public string? OrderText { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ نامه نامه دستور رفع توقف عمليات اجرايي")]
        public string? RestartOrderLetterDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره نامه دستور رفع توقف عمليات اجرايي")]
        public string? RestartOrderLetterNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ شروع توقف عمليات اجرايي")]
        public string? StartStopDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ نامه نامه دستور توقف عمليات اجرايي")]
        public string? StopOrderLetterDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره نامه دستور توقف عمليات اجرايي")]
        public string? StopOrderLetterNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع مرجع عالي صادر کننده دستور توقف عمليات اجرايي")]
        public Anu.PunishmentOrg.Enumerations.SupremeCourtType? SupremeCourtType { get; set; }

            

    }
    }
