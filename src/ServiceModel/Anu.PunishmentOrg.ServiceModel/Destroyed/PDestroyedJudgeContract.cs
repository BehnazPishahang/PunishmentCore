
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("دادنامه پرونده امحاء در سرویس")]
    public class PDestroyedJudgeContract
    {
        public PDestroyedJudgeContract()
        {
        }
            
            [System.ComponentModel.DisplayName("عنوان شعبه صادر کننده رای")]
        public string? BranchTitle { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره دادنامه در سامانه سمپ")]
        public string? CMSNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ دادنامه")]
        public string? JudgeDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("عنوان موضوع دادنامه")]
        public string? JudgementSubjectTitle { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره دستي راي يا شماره در سامانه قديمي")]
        public string? ManualNo { get; set; }

            

    }
    }
