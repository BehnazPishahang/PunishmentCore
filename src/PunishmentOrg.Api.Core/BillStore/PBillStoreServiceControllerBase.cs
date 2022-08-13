
using Anu.PunishmentOrg.ServiceModel.BillStore;
using Anu.PunishmentOrg.ServiceModel.BillStore;

namespace Anu.PunishmentOrg.Api.BillStore
{
    public abstract class PBillStoreServiceControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
    public PBillStoreServiceControllerBase()
    {
    }
        [Microsoft.AspNetCore.Mvc.HttpPost]
            [Microsoft.AspNetCore.Mvc.Route("api/v2/BillStore/InquiryByNo")]
        public abstract PBillStoreServiceResponse SendPBillStore([Microsoft.AspNetCore.Mvc.FromBody]PBillStoreServiceRequest request);
        [Microsoft.AspNetCore.Mvc.HttpPost]
            [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]/[action]")]
        public abstract Task<PBillStoreServiceResponse> ReceivePBillStoreFromScms([Microsoft.AspNetCore.Mvc.FromBody]PBillStoreServiceRequest request);

    }
    }
