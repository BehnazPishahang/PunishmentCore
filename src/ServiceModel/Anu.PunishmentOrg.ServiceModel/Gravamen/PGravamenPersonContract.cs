
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("شخص شکوائیه/گزارش مردمی در سرویس")]
    public class PGravamenPersonContract
    {
        public PGravamenPersonContract()
        {
        }

        [System.ComponentModel.DisplayName("نشانی")]
        public virtual string? Address { get; set; }

        [System.ComponentModel.DisplayName("تاریخ تولد/ثبت")]
        public virtual string? BirthDate { get; set; }

        [System.ComponentModel.DisplayName("نام خانوادگی")]
        public virtual string? Family { get; set; }

        [System.ComponentModel.DisplayName("نام پدر")]
        public virtual string? FatherName { get; set; }

        [System.ComponentModel.DisplayName("شماره شناسنامه/شماره ثبت")]
        public virtual string? IdentityNumber { get; set; }

        [System.ComponentModel.DisplayName("تلفن همراه")]
        public virtual string? MobileNumber { get; set; }

        [System.ComponentModel.DisplayName("نام")]
        public virtual string? Name { get; set; }

        [System.ComponentModel.DisplayName("شماره ملی/شناسه ملی")]
        public virtual string? NationalCode { get; set; }

        [System.ComponentModel.DisplayName("تابعیت")]
        public virtual Anu.BaseInfo.Enumerations.LNationality? Nationality { get; set; }

        [System.ComponentModel.DisplayName("رمز شخص")]
        public virtual string? PersonPassword { get; set; }

        [System.ComponentModel.DisplayName("سمت شخص در شروع دادرسی")]
        public virtual Anu.PunishmentOrg.Enumerations.PUPersonStartPost? PersonStartPost { get; set; }

        [System.ComponentModel.DisplayName("نوع شص")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [System.ComponentModel.DisplayName("کد پستی")]
        public virtual string? PostCode { get; set; }

        [System.ComponentModel.DisplayName("شماره ترتیب")]
        public virtual long? RowNumber { get; set; }

        [System.ComponentModel.DisplayName("جنسیت")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [System.ComponentModel.DisplayName("شکوائیه/گزارش مردمی")]
        public virtual Anu.PunishmentOrg.DataModel.Gravamen.PGravamen? ThePGravamen { get; set; }

        [System.ComponentModel.DisplayName("نام واحد صنفی مربوطه")]
        public virtual string? TradeUnitName { get; set; }


    }
}
