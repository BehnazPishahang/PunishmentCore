
namespace Anu.BaseInfo.ServiceModel.MechanizedLetter
{
    [System.ComponentModel.DisplayName("نامه هاي بازگشتي/پيروي نامه جاري در سرویس")]
    public class GMechanizedLetterRelLettersContract
    {
        public GMechanizedLetterRelLettersContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع از نظر نامه بازگشتي/پيروي")]
        public Anu.BaseInfo.Enumerations.MechanizedLetterRelType? RelationType { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ نامه بازگشتي/پيروي")]
        public string? RelLetterDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع از نظر مکانيزه بودن يا غيرمکانيزه بودن نامه بازگشتي/پيروي")]
        public Anu.BaseInfo.Enumerations.MechanizedLetterRelLetterGetType? RelLetterGetType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره نامه بازگشتي/پيروي")]
        public string? RelLetterNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نامه مکانيزه بازگشتي/پيروي نامه جاري")]
        public Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterContract? TheGMechanizedLetterContract { get; set; }

            

    }
    }
