
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("کالا/ارز هاي قبض/رسيد صادر شده بر اساس کلا/ارز هاي صورتجلسه کشف در سرويس")]
    public class PBillStoreProductDiscovery
    {
        public PBillStoreProductDiscovery()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("خروجي کالا/ارز قبض/رسيد کالا/ارز صادر شده")]
            public PBillStoreProduct ThePBillStoreProduct { get; set ;} 
            

    }
    }
