
using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.ServiceContract;

namespace Anu.PunishmentOrg.ServiceModel.BillStore
{
    [System.ComponentModel.DisplayName("خروجی سرویس دریافت قبض انبار")]
    public class PBillStoreServiceResponse : PBillStoreResponse ,IResponseMessage
    {

        public Result Result { get; set; }

        public PBillStoreServiceResponse()
        {
            Result = new Result();
        }
            
            [System.ComponentModel.DisplayName("قبض/رسيد کالا/ارز صادر شده توسط سازمان مسئول نگه داري کالا/ارز در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.BillStore.PBillStoreContract? ThePBillStoreContract { get; set; }
       
    }
    }
