
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
        [Microsoft.AspNetCore.Mvc.Route("api/v1/PBill4Paid/GetPBill4PaidByFishNo")]
        public abstract Task<GetPBill4PaidByFishNoResponse> GetPBill4PaidByFishNo([Microsoft.AspNetCore.Mvc.FromBody]GetPBill4PaidByFishNoRequest request);

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/PBill4Paid/GetPBill4PaidListByNationalCode")]
        public abstract Task<GetPBill4PaidListByNationalCodeResponse> GetPBill4PaidListByNationalCode([Microsoft.AspNetCore.Mvc.FromBody] GetPBill4PaidListByNationalCodeRequest request);

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/PBill4Paid/SendPaymentRequestToSadad")]
        public abstract Task<SendPaymentRequestToSadadResponse> SendPaymentRequestToSadad([Microsoft.AspNetCore.Mvc.FromBody] SendPaymentRequestToSadadRequest request);

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/PBill4Paid/GetCountOfPaidPBill4PaidByNationalCode")]
        public abstract Task<GetCountOfPaidPBill4PaidByNationalCodeResponse> GetCountOfPaidPBill4PaidByNationalCode([Microsoft.AspNetCore.Mvc.FromBody] GetCountOfPaidPBill4PaidByNationalCodeRequest request);
    }
    }
