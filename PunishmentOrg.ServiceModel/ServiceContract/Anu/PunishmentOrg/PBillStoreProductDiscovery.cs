
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("کالا/ارز هاي قبض/رسيد صادر شده بر اساس کلا/ارز هاي صورتجلسه کشف در سرويس")]
    public class PBillStoreProductDiscovery
    {
        public PBillStoreProductDiscovery()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("خروجي کالا/ارز قبض/رسيد کالا/ارز صادر شده")]
            public Anu.PunishmentOrg.ServiceContract.PBillStoreProduct ThePBillStoreProduct { get; set ;} 
            

    }
    }
