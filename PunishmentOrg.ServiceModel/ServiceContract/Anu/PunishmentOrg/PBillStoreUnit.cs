
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("سازمان داراي دسترسي به قبض/رسيد کالا/ارز صادر شده توسط سازمان مسئول نگه داري کالا/ارز در سرويس")]
    public class PBillStoreUnit
    {
        public PBillStoreUnit()
        {
            this.ThePBillStoreList = new List<Anu.PunishmentOrg.ServiceContract.PBillStore>(); 
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سازمان هاي تعامل کننده در مورد پرونده در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PBExchangeUnit ThePBExchangeUnit { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس قبض/رسيد انبار")]
            public List<Anu.PunishmentOrg.ServiceContract.PBillStore> ThePBillStoreList { get; set ;} 
            

    }
    }
