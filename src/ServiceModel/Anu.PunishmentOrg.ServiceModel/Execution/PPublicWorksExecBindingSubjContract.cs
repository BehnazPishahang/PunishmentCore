
namespace Anu.PunishmentOrg.ServiceModel.Execution
{
    [System.ComponentModel.DisplayName("موضوع لازم الاجرايي که امور عام المنفعه بابت آن انجام ميشود در سرویس")]
    public class PPublicWorksExecBindingSubjContract
    {
        public PPublicWorksExecBindingSubjContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شناسه هاي موضوع لازم الاجراهاي قبلي متعلق به راي نقض شده توسط ديوان عدالت يا عالي")]
        public string? OldCaseBindingIDs { get; set; }

            

    }
    }
