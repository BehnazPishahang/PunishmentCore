
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("پرونده های لف شده پرونده امحاء در سرویس")]
    public class PDestroyedCaseWrapContract
    {
        public PDestroyedCaseWrapContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شماره پرونده در سامانه سمپ")]
        public string? CMSNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("کلاسه دستي پرونده يا شماره در سامانه قديمي")]
        public string? ManualNo { get; set; }

            

    }
    }
