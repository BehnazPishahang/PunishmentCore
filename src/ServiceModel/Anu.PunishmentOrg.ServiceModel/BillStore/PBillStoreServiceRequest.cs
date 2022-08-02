
using Anu.Commons.ServiceModel.SeviceRequest;
using Anu.PunishmentOrg.ServiceModel.ServiceContract;

namespace Anu.PunishmentOrg.ServiceModel.BillStore
{
    [System.ComponentModel.DisplayName("ورودی سرویس دریافت قبض انبار")]
    public class PBillStoreServiceRequest:PBillStoreFromScms, IRequestMessage
    {

        public Request Request { get; set; }

        public PBillStoreServiceRequest()
        {
            Request = new Request();
        }
            
            [System.ComponentModel.DisplayName("قبض/رسيد کالا/ارز صادر شده توسط سازمان مسئول نگه داري کالا/ارز در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.BillStore.PBillStoreContract? ThePBillStoreContract { get; set; }

            

    }
    }
