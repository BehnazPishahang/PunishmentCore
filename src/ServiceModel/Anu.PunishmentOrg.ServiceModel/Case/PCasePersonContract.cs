
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("شخص پرونده تعزيرات در سرویس")]
    public class PCasePersonContract
    {
        public PCasePersonContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تاريخ اضافه شدن متهم به پرونده")]
        public string? AddingAccusedDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("نشاني")]
        public string? Address { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ تولد/ثبت")]
        public string? BirthDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ کارت مباشرت")]
        public string? CardStewardshipDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره کارت مباشرت")]
        public string? CardStewardshipNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع شرکت")]
        public string? CompanyType { get; set; }

            
            
            [System.ComponentModel.DisplayName("خسارت وارده شده به شخص شاکي")]
        public long? DamageCausedValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("آدرس رايانامه")]
        public string? EMail { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي")]
        public string? Family { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام پدر")]
        public string? FatherName { get; set; }

            
            
            [System.ComponentModel.DisplayName("عنوان سازمان دولتي مالک واحد صنفي")]
        public string? GovOrgOwner { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا ساکن واحد صنفي کارت مباشرت دارد")]
        public Anu.BaseInfo.Enumerations.YesNo? HasCardStewardship { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره شناسنامه/شماره ثبت")]
        public string? IdentityNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا سوابق اتهامي قبلي شخص از طريق پايگاه داده محکومين جستجو شده؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsSearchHistory { get; set; }

            
            
            [System.ComponentModel.DisplayName("شغل")]
        public string? JobTitle { get; set; }

            
            
            [System.ComponentModel.DisplayName("وضعيت شخصيت حقوقي")]
        public Anu.PunishmentOrg.Enumerations.PULegalPersonState? LegalPersonState { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ تولد صاحب پروانه/مجوز کسب واحد صنفي")]
        public string? LicenseOwnerBirthDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي صاحب پروانه/مجوز کسب واحد صنفي")]
        public string? LicenseOwnerFamily { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام صاحب پروانه/مجوز کسب واحد صنفي")]
        public string? LicenseOwnerName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ملي صاحب پروانه/مجوز کسب واحد صنفي")]
        public string? LicenseOwnerNationalCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("جنسيت صاحب پروانه/مجوز کسب واحد صنفي")]
        public Anu.BaseInfo.Enumerations.SexType? LicenseOwnerSex { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع پروانه کسب")]
        public Anu.PunishmentOrg.Enumerations.PULicenseType? LicenseType { get; set; }

            
            
            [System.ComponentModel.DisplayName("وضعيت حيات")]
        public Anu.PunishmentOrg.Enumerations.PULifeState? LifeState { get; set; }

            
            
            [System.ComponentModel.DisplayName("تلفن همراه")]
        public string? MobilNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
        public string? Name { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ملي/شناسه ملي/کدفراگير")]
        public string? NationalCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("تابعيت")]
        public Anu.BaseInfo.Enumerations.LNationality? Nationality { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع مالکيت محل واحد صنفي")]
        public Anu.PunishmentOrg.Enumerations.OwnerEstateType? OwnerEstateType { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع مالکيت")]
        public Anu.PunishmentOrg.Enumerations.PUOwnershipType? OwnershipType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("رمز شخص")]
        public string? PersonPassword { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سمت شخص در شروع دادرسي")]
        public Anu.PunishmentOrg.Enumerations.PUPersonStartPost? PersonStartPost { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع شخص")]
        public Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

            
            
            [System.ComponentModel.DisplayName("تلفن ثابت")]
        public string? PhoneNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد پستي")]
        public string? PostCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("دين")]
        public Anu.BaseInfo.Enumerations.LReligion? Religion { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("جنسيت")]
        public Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه شخص مبدا")]
        public string? SourceObjectId { get; set; }

            
            
            [System.ComponentModel.DisplayName("وضعيت پروانه کسب/مجوز")]
        public Anu.PunishmentOrg.Enumerations.PULicenseType? TradeLicense { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ صدور پروانه/مجوز کسب واحد صنفي")]
        public string? TradeLicenseDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پروانه/مجوز کسب واحد صنفي")]
        public string? TradeLicenseNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه يکتاي واحد صنفي مربوطه")]
        public string? TradeUnitIdentityNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام واحد صنفي مربوطه")]
        public string? TradeUnitName { get; set; }

            

    }
    }
