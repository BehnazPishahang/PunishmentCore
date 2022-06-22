
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("پرونده سازمان تعزيرات در سرويس")]
    public class PCase
    {
        public PCase()
        {
            this.ThePBillStoreList = new List<Anu.PunishmentOrg.ServiceContract.PBillStore>(); 
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره پرونده")]
            public string No { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس قبض/رسيد انبار")]
            public List<Anu.PunishmentOrg.ServiceContract.PBillStore> ThePBillStoreList { get; set ;} 
            

    }
    }
