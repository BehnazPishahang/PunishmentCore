
using Anu.PunishmentOrg.ServiceModel.Accounting;
using Anu.PunishmentOrg.ServiceModel.Accounting;

namespace Anu.PunishmentOrg.Api.Accounting
{
    public abstract class PBill4PaidServiceControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
    public PBill4PaidServiceControllerBase()
    {
    }
        [Microsoft.AspNetCore.Mvc.HttpPost]
            [Microsoft.AspNetCore.Mvc.Route("api/v1/PBill4Paid/GetPaymentInfo")]
        public abstract Task<GetPaymentInfoResponse> GetPaymentInfo([Microsoft.AspNetCore.Mvc.FromBody]GetPaymentInfoRequest request);

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/PBill4Paid/SendPaymentRequestToSadad")]
        public abstract Task<SendPaymentRequestToSadadResponse> SendPaymentRequestToSadad([Microsoft.AspNetCore.Mvc.FromBody] SendPaymentRequestToSadadRequest request);
    }
    }
