
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("موضوع لازم الاجراي پرونده اجرايي تعزيرات در سرویس")]
    public class PCaseBindingSubjectContract
    {
        public PCaseBindingSubjectContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تاريخ خاتمه محکوميت")]
        public string? EndPenaltyDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت اجرا")]
        public Anu.PunishmentOrg.Enumerations.PUExecutiveStatus? ExecutiveStatus { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ راي مربوطه")]
        public string? JudgeDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره راي مربوطه")]
        public string? JudgeNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("مقدار محکوميت")]
        public decimal? PenaltyAmount { get; set; }

            
            
            [System.ComponentModel.DisplayName("نحوه اعمال مجازات")]
        public Anu.PunishmentOrg.Enumerations.PenaltyGetType? PenaltyGetType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ شروع محکوميت")]
        public string? StartPenaltyDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان موضوع")]
        public string? SubjectTitle { get; set; }

            

    }
    }
