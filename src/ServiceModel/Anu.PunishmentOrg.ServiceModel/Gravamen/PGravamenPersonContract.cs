
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("شخص شکوائیه/گزارش مردمی در سرویس")]
    public class PGravamenPersonContract
    {
        public PGravamenPersonContract()
        {
        }

        [System.ComponentModel.DisplayName("نشاني")]
        public string? Address { get; set; }


        [System.ComponentModel.DisplayName("تاريخ تولد/ثبت")]
        public string? BirthDate { get; set; }

        [System.ComponentModel.DisplayName("نام خانوادگي")]
        public string? Family { get; set; }

        [System.ComponentModel.DisplayName("نام پدر")]
        public string? FatherName { get; set; }

        [System.ComponentModel.DisplayName("شماره شناسنامه/شماره ثبت")]
        public string? IdentityNumber { get; set; }

        [System.ComponentModel.DisplayName("تلفن همراه")]
        public string? MobilNumber { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نام")]
        public string? Name { get; set; }


        [System.ComponentModel.DisplayName("شماره ملي/شناسه ملي")]
        public string? NationalCode { get; set; }


        [System.ComponentModel.DisplayName("تابعيت")]
        public Anu.BaseInfo.Enumerations.LNationality? Nationality { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("رمز شخص")]
        public string? PersonPassword { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("سمت شخص در شروع دادرسي")]
        public Anu.PunishmentOrg.Enumerations.PUPersonStartPost? PersonStartPost { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نوع شخص")]
        public Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }


        [System.ComponentModel.DisplayName("کد پستي")]
        public string? PostCode { get; set; }





        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }



        [System.ComponentModel.DisplayName("جنسيت")]
        public Anu.BaseInfo.Enumerations.SexType Sex { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شکوائیه/گزارش مردمی در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Gravamen.PGravamenContract? ThePGravamenContract { get; set; }



        [System.ComponentModel.DisplayName("نام واحد صنفي مربوطه")]
        public string? TradeUnitName { get; set; }



    }
}
