
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("کالا/ارز هاي پرونده بر اساس کالا/ارز هاي قبض/رسيد صادر شده در سرويس")]
    public class PCaseViolationProductBillST
    {
        public PCaseViolationProductBillST()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("خروجي کالا/ارز قبض/رسيد کالا/ارز صادر شده")]
            public PBillStoreProduct ThePBillStoreProduct { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کالا/ارز/خدمات مربوط به پرونده تعزيرات در سرويس")]
            public PCaseProduct ThePCaseProduct { get; set ;} 
            

    }
    }
