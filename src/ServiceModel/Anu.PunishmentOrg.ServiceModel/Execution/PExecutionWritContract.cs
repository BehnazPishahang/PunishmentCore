
namespace Anu.PunishmentOrg.ServiceModel.Execution
{
    [System.ComponentModel.DisplayName("قرار اجراي احکام در سرویس")]
    public class PExecutionWritContract
    {
        public PExecutionWritContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تاريخ تولد محکوم عليه")]
        public string? BirthDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مقام تاييد کننده")]
        public Anu.PunishmentOrg.Enumerations.ConfirmerExecutionDocsType? ConfirmerPostType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("درصد کاهش بدهي/عفو محکوم عليه")]
        public long? DebtReductionPercent { get; set; }

            
            
            [System.ComponentModel.DisplayName("ميزان کاهش بدهي/عفو محکوم عليه")]
        public long? DebtReductionValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ خاتمه محدوديت")]
        public string? EndWritDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي محکوم عليه")]
        public string? Family { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام پدر محکوم عليه")]
        public string? FatherName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره شناسنامه محکوم عليه")]
        public string? IdentityNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره تخصيص داده شده به قرار در سامانه قوه قضاييه")]
        public string? JudNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("مستند قانوني کاهش بدهي")]
        public Anu.PunishmentOrg.Enumerations.PLegalDoc4Debt? LegalDoc4Debt { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره دستي قرار يا شماره در سامانه قديمي")]
        public string? ManualNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام محکوم عليه")]
        public string? Name { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ملي محکوم عليه")]
        public string? NationalCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }

            
            
            [System.ComponentModel.DisplayName("توضيحات اعمال قرار ممنوع الخروجي/مسدود الحسابي/ممنوع المعامله توسط اداره گذرنامه")]
        public string? PAssportOfficerDesc { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت رد قرار ممنوع الخروجي/مسدود الحسابي/ممنوع المعامله توسط دادستان")]
        public string? ProsecutorRejectReason { get; set; }

            
            
            [System.ComponentModel.DisplayName("جنسيت محکوم عليه")]
        public Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ شروع محدوديت")]
        public string? StartWritDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("زمان پايان ممنوع الخروجي")]
        public Anu.PunishmentOrg.Enumerations.PTravelBanEndTime? TravelBanEndTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("متن قرار")]
        public string? WritText { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع قرار")]
        public Anu.PunishmentOrg.Enumerations.PUExecutionWritType? WritType { get; set; }

            

    }
    }
