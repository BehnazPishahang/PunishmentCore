
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("تاريخچه جستجو بر روي پايگاه داده محکومين قوه قضاييه در سرویس")]
    public class PIllicitPersonSearchLogContract
    {
        public PIllicitPersonSearchLogContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تاريخ تولد")]
        public string? BirthDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پرونده")]
        public string? CaseNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام رايانه که جستجو بر روي آن انجام شده")]
        public string? ComputerName { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي")]
        public string? Family { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام پدر")]
        public string? FatherName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره شناسنامه")]
        public string? IdentityNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا با شرايط داده شده سابقه اي يافت شد؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsFindHistory { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره راي")]
        public string? JudgeNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
        public string? Name { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ملي/شناسه ملي")]
        public string? NationalCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پرونده تعزيرات")]
        public string? PCaseNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه شخص پرونده که اطلاعات وي جستجو شده")]
        public string? PCasePersonId { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره فرعي پرونده تعزيرات")]
        public long? PCaseSubNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع شخص")]
        public Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ و ساعت جستجو")]
        public string? SearchDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ميلي ثانيه جستجو")]
        public string? SearchMiliSecond { get; set; }

            

    }
    }
