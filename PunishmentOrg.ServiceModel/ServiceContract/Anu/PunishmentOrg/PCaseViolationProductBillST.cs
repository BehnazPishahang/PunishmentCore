
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("کالا/ارز هاي پرونده بر اساس کالا/ارز هاي قبض/رسيد صادر شده در سرويس")]
    public class PCaseViolationProductBillST
    {
        public PCaseViolationProductBillST()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("خروجي کالا/ارز قبض/رسيد کالا/ارز صادر شده")]
            public Anu.PunishmentOrg.ServiceContract.PBillStoreProduct ThePBillStoreProduct { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کالا/ارز/خدمات مربوط به پرونده تعزيرات در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PCaseProduct ThePCaseProduct { get; set ;} 
            

    }
    }
