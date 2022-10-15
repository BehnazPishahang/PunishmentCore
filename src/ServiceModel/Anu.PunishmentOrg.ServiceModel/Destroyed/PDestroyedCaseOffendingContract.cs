
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("متهم پرونده امحاء در سرویس")]
    public class PDestroyedCaseOffendingContract
    {
        public PDestroyedCaseOffendingContract()
        {
        }
            
            [System.ComponentModel.DisplayName("نام خانوادگي")]
        public string? Family { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
        public string? Name { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ملي/شناسه ملي/کدفراگير")]
        public string? NationalCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع شخص")]
        public Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            

    }
    }
