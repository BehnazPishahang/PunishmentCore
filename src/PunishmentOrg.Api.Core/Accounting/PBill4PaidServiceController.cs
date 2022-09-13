
using Anu.PunishmentOrg.DataModel.Accounting;
using Anu.PunishmentOrg.Domain.Accounting;
using Anu.PunishmentOrg.ServiceModel.Accounting;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Text;
using Utility.Guard;
using static Anu.Constants.ServiceModel.PunishmentOrg.PunishmentOrgObjectState;

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

        [AllowAnonymous]
        public override async Task<GetPaymentInfoResponse> GetPaymentInfo([FromBody] GetPaymentInfoRequest request)
        {
            GetPaymentInfoResponse theGetPaymentInfoResponse = new GetPaymentInfoResponse()
            {
                ThePBill4PaidInfoContract = new PBill4PaidInfoContract()
                {
                    CanPay = false,
                    Desc   = string.Empty,
                }
            };

            request.Null(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_Request_Is_Required);

            request.ThePBill4PaidFishNoContract.Null(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_ThePBill4PaidFishNoContract_Is_Required);

            request.ThePBill4PaidFishNoContract!.FishNo.NullOrWhiteSpace(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_FishNo_Is_Required);

            request.ThePBill4PaidFishNoContract!.FishNo!.IsDigit(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_FishNo_Is_Required);

            PBill4Paid thePBill4Paid = await _unitOfWork.Repositorey<IPBill4PaidRepository>().GetPBill4PaidByFishNo(request.ThePBill4PaidFishNoContract!.FishNo);

            thePBill4Paid.Null(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_PBill4Paid_NotFound);

            thePBill4Paid.TheObjectState.Null(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_PBill4Paid_TheObjectState_Is_Null);

            theGetPaymentInfoResponse.ThePBill4PaidInfoContract.CanPay = thePBill4Paid.TheObjectState!.Code == PBill4Cash.Confirmed ? true : false ;
            theGetPaymentInfoResponse.ThePBill4PaidInfoContract.Desc   = this.GetDesc(thePBill4Paid);

            return theGetPaymentInfoResponse;
        }

        #endregion Overrides

        #region Methods

        private string GetDesc(PBill4Paid thePBill4Paid)
        {
            StringBuilder stringBuilder = new StringBuilder();

            switch (thePBill4Paid.TheObjectState!.Code)
            {
                case PBill4Cash.Confirmed:
                    stringBuilder.Append("شناسه قبض وارد شده آماده پرداخت است");
                    stringBuilder.AppendLine();
                    stringBuilder.AppendFormat("شماره قبض : {0}", thePBill4Paid.FishNo);
                    stringBuilder.AppendLine();
                    stringBuilder.Append("مبلغ: ");
                    stringBuilder.AppendFormat(" {0} ریال ", thePBill4Paid.TotalPaidCost);
                    stringBuilder.AppendLine();
                    stringBuilder.Append("لطفا بعد از مطالعه با استفاده از دکمه تایید و پرداخت فرآیند پرداخت را ادامه دهید. ");
                    break;
                case PBill4Cash.Paid:
                    stringBuilder.Append("وجه قبض با شناسه پرداخت ");
                    stringBuilder.AppendFormat(" {0} ", thePBill4Paid.FishNo);
                    stringBuilder.Append("پرداخت شده است.");
                    break;
                default:
                    stringBuilder.Append("قبض مد نظر با شناسه پرداخت : ");
                    stringBuilder.AppendFormat(" {0} ", thePBill4Paid.FishNo);
                    stringBuilder.Append("آماده پرداخت نمی باشد.");
                    break;
            }

            return stringBuilder.ToString();
        }

        #endregion Methods
    }
}