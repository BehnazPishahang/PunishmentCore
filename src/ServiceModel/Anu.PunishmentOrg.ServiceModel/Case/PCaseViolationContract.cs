
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("تخلف پرونده تعزيرات در سرویس")]
    public class PCaseViolationContract
    {
        public PCaseViolationContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه تخلف مبدا")]
        public string? SourceObjectId { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان موضوع")]
        public string? SubjectTitle { get; set; }

            
            
            [System.ComponentModel.DisplayName("نشاني محل وقوع/کشف تخلف")]
        public string? ViolationAddress { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ وقوع تخلف")]
        public string? ViolationDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("توضيحات")]
        public string? ViolationDesc { get; set; }

            
            
            [System.ComponentModel.DisplayName("ارزش مالي تخلف از نظر کاشف")]
        public long? ViolationPrice { get; set; }

            
            
            [System.ComponentModel.DisplayName("ارزش مالي تخلف از نظر شعبه")]
        public long? ViolationPriceByCourt { get; set; }

            
            
            [System.ComponentModel.DisplayName("ارزش مالي تخلف از نظر کارشناس")]
        public long? ViolationPriceByExpert { get; set; }

            

    }
    }
