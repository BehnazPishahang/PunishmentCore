
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("سازمان داراي دسترسي به قبض/رسيد کالا/ارز صادر شده توسط سازمان مسئول نگه داري کالا/ارز در سرويس")]
    public class PBillStoreUnit
    {
        public PBillStoreUnit()
        {
            this.ThePBillStoreList = new List<PBillStore>(); 
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سازمان هاي تعامل کننده در مورد پرونده در سرويس")]
            public PBExchangeUnit ThePBExchangeUnit { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس قبض/رسيد انبار")]
            public List<PBillStore> ThePBillStoreList { get; set ;} 
            

    }
    }
