
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("اشخاص، درخواست 4گانه در سرویس")]
    public class PChaseLicenseReqSuspectContract
    {
        public PChaseLicenseReqSuspectContract()
        {
        ThePChaseLicenseReqSuspectTypContractList = new List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqSuspectTypContract>();

        }
            
            [System.ComponentModel.DisplayName("نشاني")]
        public string? Address { get; set; }

            
            
            [System.ComponentModel.DisplayName("حساب بانکی")]
        public string? BankAccountInformationAPI { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ تولد")]
        public string? BirthDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
        public Anu.PunishmentOrg.Enumerations.PUConclusion? ConclusionRequest { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي")]
        public string? Family { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام پدر")]
        public string? FatherName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره شناسنامه")]
        public string? IdentityNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("تلفن همراه")]
        public string? MobilNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام")]
        public string? Name { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ملي/شناسه ملی/کد فیدا")]
        public string? NationalCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("مليت")]
        public Anu.BaseInfo.Enumerations.LNationality? Nationality { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره گذرنامه")]
        public string? PassportNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه یکتای شخص")]
        public long? PersonId { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع شخص")]
        public Anu.PunishmentOrg.Enumerations.ChasePersonType? PersonType { get; set; }

            
            
            [System.ComponentModel.DisplayName("تلفن ثابت")]
        public string? PhoneNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("سمت")]
        public Anu.PunishmentOrg.Enumerations.PSuspectPostType? PostType { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام نقش در سامانه قاچاق")]
        public string? RoleNameEN { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتیب")]
        public long? RowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("کشور تابعيت شخص غيرايراني")]
        public Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract? TheNonIranianCitizenship { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("درخواست 4گانه(مجوز بازرسی-تکمیل تحقیقات-اعلام تخلف-تایید مجوز شفاهی) و پاسخ آن در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqContract? ThePChaseLicenseReqContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع مجوز شخص مورد تعقيب درخواست مجوز تعقيب/بازرسي در سرویس")]
        public List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqSuspectTypContract>? ThePChaseLicenseReqSuspectTypContractList { get; set; }

            

    }
    }
