
namespace Anu.PunishmentOrg.ServiceModel.Execution
{
    [System.ComponentModel.DisplayName("موضوع لازم الاجرايي که حبس بدل از محکوميت مالي بابت آن صادر شده در سرویس")]
    public class PPrisonerBindingSubjectContract
    {
        public PPrisonerBindingSubjectContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شناسه هاي موضوع لازم الاجراهاي قبلي متعلق به راي نقض شده توسط ديوان عدالت يا عالي")]
        public string? OldCaseBindingIDs { get; set; }

            

    }
    }
