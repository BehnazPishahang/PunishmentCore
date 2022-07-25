
namespace Anu.PunishmentOrg.ServiceModel.BillStore
{
    [System.ComponentModel.DisplayName("خروجی سرویس دریافت قبض انبار")]
    public class PBillStoreServiceResponse
    {
        public PBillStoreServiceResponse()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("قبض/رسيد کالا/ارز صادر شده توسط سازمان مسئول نگه داري کالا/ارز در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.BillStore.PBillStoreContract? ThePBillStoreContract { get; set; }

            

    }
    }
