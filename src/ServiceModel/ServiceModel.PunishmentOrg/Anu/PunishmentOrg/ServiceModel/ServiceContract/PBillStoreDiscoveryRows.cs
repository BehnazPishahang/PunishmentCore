
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("شماره رديف هاي کالاهاي صورتجلسه کشف در قبض انبار")]
    public class PBillStoreDiscoveryRows
    {
        public PBillStoreDiscoveryRows()
        {
        }
            
            [System.ComponentModel.DisplayName("توضيحات")]
            public string Description { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? DiscoveryRowNumbers { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("خروجي کالا/ارز قبض/رسيد کالا/ارز صادر شده")]
            public PBillStoreProduct ThePBillStoreProduct { get; set ;} 
            

    }
    }
