
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("نامه هاي بازگشتي/پيروي نامه جاري در وب سرويس دريافت مکاتبات")]
    public class GMechanizedLetterRelLetters
    {
        public GMechanizedLetterRelLetters()
        {
        }

        
        [System.ComponentModel.DisplayName("نوع از نظر نامه بازگشتي/پيروي")]
        public Anu.BaseInfo.Enumerations.MechanizedLetterRelType RelationType { get; set; }


        [System.ComponentModel.DisplayName("تاريخ نامه بازگشتي/پيروي")]
        public string? RelLetterDate { get; set; }


        
        [System.ComponentModel.DisplayName("نوع از نظر مکانيزه بودن يا غيرمکانيزه بودن نامه بازگشتي/پيروي")]
        public Anu.BaseInfo.Enumerations.MechanizedLetterRelLetterGetType RelLetterGetType { get; set; }


        
        [System.ComponentModel.DisplayName("شماره نامه بازگشتي/پيروي")]
        public string? RelLetterNo { get; set; }


        
        [System.ComponentModel.DisplayName("ورودي سرويس دريافت مکاتبات مکانيزه")]
        public GMechanizedLetter TheMainLetter { get; set; }


        
        [System.ComponentModel.DisplayName("ورودي سرويس دريافت مکاتبات مکانيزه")]
        public GMechanizedLetter TheRelLetter { get; set; }


    }
}
