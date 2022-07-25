
namespace Anu.PunishmentOrg.ServiceModel.BillStore
{
    [System.ComponentModel.DisplayName("ورودی سرویس دریافت قبض انبار")]
    public class PBillStoreServiceRequest
    {
        public PBillStoreServiceRequest()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("قبض/رسيد کالا/ارز صادر شده توسط سازمان مسئول نگه داري کالا/ارز در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.BillStore.PBillStoreContract? ThePBillStoreContract { get; set; }

            

    }
    }
