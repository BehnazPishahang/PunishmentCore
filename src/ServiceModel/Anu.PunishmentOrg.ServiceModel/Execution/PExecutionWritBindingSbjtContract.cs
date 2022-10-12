
namespace Anu.PunishmentOrg.ServiceModel.Execution
{
    [System.ComponentModel.DisplayName("موضوع لازم الاجرايي که قرار بابت آن صادر شده در سرویس")]
    public class PExecutionWritBindingSbjtContract
    {
        public PExecutionWritBindingSbjtContract()
        {
        }
            
            [System.ComponentModel.DisplayName("ميزان کاهش بدهي/عفو محکوم عليه")]
        public long? DebtReductionValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه هاي موضوع لازم الاجراهاي قبلي متعلق به راي نقض شده توسط ديوان عدالت يا عالي")]
        public string? OldCaseBindingIDs { get; set; }

            

    }
    }
