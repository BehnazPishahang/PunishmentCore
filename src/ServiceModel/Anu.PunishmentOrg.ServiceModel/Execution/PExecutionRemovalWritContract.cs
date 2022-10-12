
namespace Anu.PunishmentOrg.ServiceModel.Execution
{
    [System.ComponentModel.DisplayName("رفع محدوديت ايجاد شده توسط قرار اجراي احکام در سرویس")]
    public class PExecutionRemovalWritContract
    {
        public PExecutionRemovalWritContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مقام تاييد کننده")]
        public Anu.PunishmentOrg.Enumerations.ConfirmerExecutionDocsType? ConfirmerPostType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره تخصيص داده شده به قرار رفع در سامانه قوه قضاييه")]
        public string? JudNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره دستي قرار يا شماره در سامانه قديمي")]
        public string? ManualNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }

            
            
            [System.ComponentModel.DisplayName("توضيحات اعمال قراررفع ممنوع الخروجي/مسدود الحسابي/ممنوع المعامله توسط اداره گذرنامه")]
        public string? PAssportOfficerDesc { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت رد قرار رفع ممنوع الخروجي/مسدود الحسابي/ممنوع المعامله توسط دادستان")]
        public string? ProsecutorRejectReason { get; set; }

            
            
            [System.ComponentModel.DisplayName("متن جهت رفع محدوديت قرار")]
        public string? WritText { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع قرار")]
        public Anu.PunishmentOrg.Enumerations.PUExecutionWritType? WritType { get; set; }

            

    }
    }
