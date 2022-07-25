
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("پرونده سازمان تعزيرات در سرويس")]
    public class PCase
    {
        public PCase()
        {
            this.ThePBillStoreList = new List<PBillStore>(); 
        }
            
            
            [System.ComponentModel.DisplayName("شماره پرونده")]
            public string? No { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس قبض/رسيد انبار")]
            public List<PBillStore> ThePBillStoreList { get; set ;} 
            

    }
    }
