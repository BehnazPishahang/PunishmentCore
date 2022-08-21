
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("تخلفات شکوائیه/گزارش مردمی در سرویس")]
    public class PGravamenViolationContract
    {
        public PGravamenViolationContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان موضوع")]
        public string? SubjectTitle { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شکوائیه/گزارش مردمی در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Gravamen.PGravamenContract? ThePGravamenContract { get; set; }

            
            
            [System.ComponentModel.DisplayName("نشاني محل وقوع/کشف تخلف")]
        public string? ViolationAddress { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ وقوع تخلف")]
        public string? ViolationDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("توضيحات")]
        public string? ViolationDesc { get; set; }

            
            
            [System.ComponentModel.DisplayName("ارزش مالي تخلف")]
        public long? ViolationPrice { get; set; }

            

    }
    }
