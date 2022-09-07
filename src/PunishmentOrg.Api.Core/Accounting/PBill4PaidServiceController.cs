
using Anu.PunishmentOrg.ServiceModel.Accounting;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Microsoft.AspNetCore.Mvc;
using Utility.Guard;

namespace Anu.PunishmentOrg.Api.Accounting
{
    public class PBill4PaidServiceController : PBill4PaidServiceControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;

        #region Constructor
        public PBill4PaidServiceController(Anu.DataAccess.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides

        public override async Task<GetPaymentInfoResponse> GetPaymentInfo([FromBody] GetPaymentInfoRequest request)
        {
            request.Null(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_Request_Is_Required);

            request.ThePBill4PaidFishNoContract.Null(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_ThePBill4PaidFishNoContract_Is_Required);

            request.ThePBill4PaidFishNoContract!.FishNo.NullOrWhiteSpace(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_FishNo_Is_Required);

            return new GetPaymentInfoResponse(){ };
        }

        #endregion Overrides

        #region Methods
        #endregion Methods
    }
}