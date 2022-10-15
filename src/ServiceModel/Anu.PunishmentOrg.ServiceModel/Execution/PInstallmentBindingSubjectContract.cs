
namespace Anu.PunishmentOrg.ServiceModel.Execution
{
    [System.ComponentModel.DisplayName("موضوع لازم الاجرايي که تقسيط بابت آن صادر شده در سرویس")]
    public class PInstallmentBindingSubjectContract
    {
        public PInstallmentBindingSubjectContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شناسه هاي موضوع لازم الاجراهاي قبلي متعلق به راي نقض شده توسط ديوان عدالت يا عالي")]
        public string? OldCaseBindingIDs { get; set; }

            

    }
    }
