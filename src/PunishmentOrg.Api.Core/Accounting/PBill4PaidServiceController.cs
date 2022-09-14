
using Anu.BaseInfo.Enumerations;
using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.PunishmentOrg.DataModel.Accounting;
using Anu.PunishmentOrg.Domain.Accounting;
using Anu.PunishmentOrg.ServiceModel.Accounting;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Anu.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Security.Policy;
using System.Text;
using Utility;
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
        public const string TerminalId_t135 = "24073332";

        public const string Merchantkey_t135 = "PhynjXUalNJBAp6LpXGOAiq2khgX3hM1";

        public const string TerminalId_tazirat_gov = "24073332";

        public const string MerchantId_t135 = "140332568";

        public const string ReturnUrl = "http://tazirat135.ir/";

        public const string PurchasePage = "https://sadad.shaparak.ir/Purchase";

        /*بعد از دریافت اطلاعات پرداخت موفق و یا نا موفق با پارامتر های مربوطه به این آدرس ریدایرکت میکنیم*/
        public static string SADAD_RETURNURL_WEB_API_WITH_ROUT_t135 { get { return "http://t135.ir/#/PBill4PaidPayMent?id="; } }
        /*آدرسی که سداد بعد از پرداخت موفق یا نا موفق اطلاعات را به سمت وب سایت تعزیرات 135 می فرستد*/
        public static string SADAD_RETURNURL_WEB_API_t135 { get { return "http://t135.ir/api/Payment/post?id="; } }
        public static string Polomp_RETURNURL_WEB_API { get { return "http://localhost:43277/api/PolompPayment/Post?ObjectId="; } }
        public static string SAMAN_RETURNURL_WEB_API_WITH_ROUT { get { return "http://localhost:43277/#/CPolompRequestFollowUpResult?id="; } }
        public static string SAMAN_URL_VERIFY { get { return "http://postepay.post.ir/rest/api/v0/IPGService/AdvicePayment"; } }
        public static string SAMAN_URL_InquiryPayment { get { return "http://postepay.post.ir/rest/api/v0/IPGService/InquiryPayment"; } }

        public static string SAMAN_URL_ReversePayment { get { return "http://postepay.post.ir/rest/api/v0/IPGService/ReversePayment"; } }
        //##########################################################################################################################################

        /*
        * 
        * 
        * ثابت های زیر تماما مربوط به سداد می باشند
        * که از مستندات پیاده سازی پرداخت سداد استخراج شده اند
        * 
        * 
        */
        public const string SADAD_PURCHASE_PAGE = "https://sadad.shaparak.ir/VPG";
        public const string SADAD_URL_PAYMENT_REQUEST = "https://sadad.shaparak.ir/VPG/api/v0/Request/PaymentRequest";
        public const string SADAD_URL_PAYMENT_MultiIdentityRequest = "https://sadad.shaparak.ir/VPG/api/v0/PaymentByMultiIdentityRequest";
        public const string SADAD_URL_PAYMENT_MultiIdentityRequest1 = "https://sadad.shaparak.ir/api/v0/PaymentByMultiIdentityRequest";
        public const string SADAD_URL_PAYMENT_PaymentRequest = "https://sadad.shaparak.ir/api/v0/Request/PaymentRequest";
        public const string SADAD_URL_VERIFY = "https://sadad.shaparak.ir/api/v0/Advice/Verify";
        public const string SADAD_URL_INQUIRY = "https://sadad.shaparak.ir/VPG/api/v0/InquiryTransaction";
        public const int SADAD_VerifyRetryCount_5 = 5;
        public const string SADAD_RESULTCODE_SUCCESS = "0";
        public const string SADAD_RESULTCODE_ERROR = "-1";
        public const string SADAD_RESULTCODE_SIGNDATA_INVALID = "1025";
        public const int SAMAN_RESULTCODE_SUCCESS = 0;
        public static class IBanNumber
        {
            public static readonly List<string> ValidIBanNumber = new List<string>
        {
            "IR120100004054012807565470",
            "IR610100004055012807580155",
            "IR860100004075012807880957",
            "IR150100004061012807670602",
            "IR180100004081012807970636",
            "IR580100004067012807760126",
            "IR370100004073012807850317",
            "IR920100004074012807866155",
            "IR720100004069012807790717",
            "IR880100004060012807655661",
            "IR720100004079012807941052",
            "IR150100004080012807955414",
            "IR270100004057012807611222",
            "IR820100004068012807775164",
            "IR800100004071012807820155",
            "IR290100004063012807700514",
            "IR610100004058012807626468",
            "IR870100004077012807910521",
            "IR290100004076012807895707",
            "IR100100004064012807715453",
            "IR310100004059012807640344",
            "IR800100004056012807595962",
            "IR180100004070012807807062",
            "IR740100004078012807925643",
            "IR270100004052012807536200",
            "IR350100004066012807745458",
            "IR100100004053012807550036",
            "IR610100004051012807520312",
            "IR580100004062012807685104",
            "IR120100004065012807730402",
            "IR460100004072012807835558",
            "IR470100004074012807866189",
            "IR890100004001057601001473",
            "IR910100004001033103006872",
            "IR810100004001012808001826",
            "IR720100004001012808001503",
            "IR060100004001012801015393",
            "IR900100004001000901027400"
        };


        }

        #endregion Properties

        #region Overrides

        [AllowAnonymous]
        public override async Task<GetPaymentInfoResponse> GetPaymentInfo([FromBody] GetPaymentInfoRequest request)
        {
            GetPaymentInfoResponse theGetPaymentInfoResponse = new GetPaymentInfoResponse();

            request.Null(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_Request_Is_Required);

            request.ThePBill4PaidFishNoContract.Null(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_ThePBill4PaidFishNoContract_Is_Required);

            request.ThePBill4PaidFishNoContract!.FishNo.NullOrWhiteSpace(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_FishNo_Is_Required);

            request.ThePBill4PaidFishNoContract!.FishNo!.IsDigit(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_FishNo_Is_Required);

            PBill4Paid thePBill4Paid = await _unitOfWork.Repositorey<IPBill4PaidRepository>().Get_PBill4Paid_By_FishNo(request.ThePBill4PaidFishNoContract!.FishNo);

            thePBill4Paid.Null(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_PBill4Paid_NotFound);

            thePBill4Paid.TheObjectState.Null(GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_PBill4Paid_TheObjectState_Is_Null);

            theGetPaymentInfoResponse.ThePBill4PaidInfoContract = new PBill4PaidInfoContract() 
            {
                CanPay = thePBill4Paid.TheObjectState!.Code == PBill4Cash.Confirmed,
                Desc   = this.GetDesc(thePBill4Paid),
            };

            return theGetPaymentInfoResponse;
        }


        [AllowAnonymous]
        public override async Task<SendPaymentRequestToSadadResponse> SendPaymentRequestToSadad([FromBody] SendPaymentRequestToSadadRequest request)
        {
            SendPaymentRequestToSadadResponse theSendPaymentRequestToSadadResponse = new SendPaymentRequestToSadadResponse();

            request.Null(SendPaymentRequestToSadadResult.PBill4Paid_SendPaymentRequestToSadad_Request_Is_Required);

            request.ThePBill4PaidFishNoContract.Null(SendPaymentRequestToSadadResult.PBill4Paid_SendPaymentRequestToSadad_ThePBill4PaidFishNoContract_Is_Required);

            request.ThePBill4PaidFishNoContract!.FishNo.NullOrWhiteSpace(SendPaymentRequestToSadadResult.PBill4Paid_SendPaymentRequestToSadad_FishNo_Is_Required);

            request.ThePBill4PaidFishNoContract!.FishNo!.IsDigit(SendPaymentRequestToSadadResult.PBill4Paid_SendPaymentRequestToSadad_FishNo_Is_Required);

            PBill4Paid thePBill4Paid = await _unitOfWork.Repositorey<IPBill4PaidRepository>().Get_PBill4Paid_By_FishNo_With_ValidAccount(request.ThePBill4PaidFishNoContract.FishNo!);

            thePBill4Paid.Null(SendPaymentRequestToSadadResult.PBill4Paid_SendPaymentRequestToSadad_PBill4Paid_NotFound);

            thePBill4Paid.TheAccounts!.IBAN.NullOrWhiteSpace(SendPaymentRequestToSadadResult.PBill4Paid_SendPaymentRequestToSadad_IBAN_NotFound);

            thePBill4Paid.TheAccounts.TreasuryID.NullOrWhiteSpace(SendPaymentRequestToSadadResult.PBill4Paid_SendPaymentRequestToSadad_TreasuryID_NotFound);

            thePBill4Paid.TotalPaidCost.Null(SendPaymentRequestToSadadResult.PBill4Paid_SendPaymentRequestToSadad_TotalPaidCost_NotFound);

            if (!IBanNumber.ValidIBanNumber.Contains(thePBill4Paid.TheAccounts.IBAN!))
            {
                theSendPaymentRequestToSadadResponse.Result = SendPaymentRequestToSadadResult.PBill4Paid_SendPaymentRequestToSadad_IBAN_NotValid.GetResult();

                return theSendPaymentRequestToSadadResponse;
            }

            PaymentRequest paymentRequest = new PaymentRequest()
            {
                MerchantId        = MerchantId_t135,
                TerminalId        = TerminalId_t135,
                Amount            = Convert.ToInt64(thePBill4Paid.TotalPaidCost),
                OrderId           = Convert.ToInt64(request.ThePBill4PaidFishNoContract.FishNo),
                LocalDateTime     = DateTime.Now,
                ReturnUrl         = string.Concat(SADAD_RETURNURL_WEB_API_t135, thePBill4Paid.Id),
                SignData          = Anu.Utility.Utility.GetSignedData(TerminalId_t135, thePBill4Paid.FishNo!, Convert.ToInt64(thePBill4Paid.TotalPaidCost), Merchantkey_t135),
                MultiIdentityData = new MultiIdentityData()
                {
                    Type              = MultiIdentityData.MultiplexingType.Amount,
                    MultiIdentityRows = GetMultiplexingRows(thePBill4Paid)
                }
            };

            var payResultData = (await SADAD_URL_PAYMENT_MultiIdentityRequest.CallApi(request, SendPaymentRequestToSadadResult.PBill4Paid_SendPaymentRequestToSadad_CallGetToken_HasError)).JsonDeserialize<PayResultData>();

            if (payResultData == null ||
                !payResultData.ResCode.Equals(SADAD_RESULTCODE_SUCCESS))
            {
                /*
                *
                *
                *
                * هر عددي به غير از صفر در
                * payResultData.ResCode
                * يعني درخواست توکن با خطا مواجه شده است
                *
                *
                *
                */
                theSendPaymentRequestToSadadResponse.Result = SendPaymentRequestToSadadResult.PBill4Paid_SendPaymentRequestToSadad_GetToken_HasError.GetResult();

                return theSendPaymentRequestToSadadResponse;
            }

            theSendPaymentRequestToSadadResponse.ThePBill4PaidTokenContract = new PBill4PaidTokenContract()
            {
                Token = payResultData.Token,
            };

            return theSendPaymentRequestToSadadResponse;
        }

        #endregion Overrides

        #region Methods

        string check(string TreasuryNumber)
        {
            //Criteria criteria = new Criteria();
            //criteria.AddLike(Anu.PunishmentOrgQuery.PTreasuryRandomNum.TreasuryNumber, "%" + TreasuryNumber);
            //IPTreasuryRandomNumCollection PTreasuryRandomNumCollection =
            //(IPTreasuryRandomNumCollection)Anu.InstanceBuilder.GetEntityListByCriteria<PTreasuryRandomNum>(criteria);

            //if (PTreasuryRandomNumCollection.Count > 0)
            //    return GetRandomNumber(13);
            //else
            //    return TreasuryNumber;

            return "";
        }

        string GetRandomNumber(int length)
        {
            string AllowChars = "0123456789";
            char[] chars = new char[length];
            Random rd = new Random();
            for (int i = 0; i < length; i++)
            {
                chars[i] = AllowChars[rd.Next(0, AllowChars.Length)];
            }
            return this.check(new string(chars));
        }

        string GetPayId(PBill4Paid thePBill4Paid)
        {
            string thePBill4PaidAmount = thePBill4Paid.TotalPaidCost.ToString().PadLeft(15, '0');
            string randomNumber        = GetRandomNumber(13);

            string data = $"2{thePBill4Paid.TheAccounts!.TreasuryID}{randomNumber}{thePBill4PaidAmount}";
            string result_b1 = VerhoeffData.Verhoeff.generateVerhoeff(data);

            string data2 = VerhoeffData.Verhoeff.Reverse($"2{thePBill4Paid.TheAccounts!.TreasuryID}{randomNumber}") + VerhoeffData.Verhoeff.Reverse(thePBill4PaidAmount);
            string result_b2 = VerhoeffData.Verhoeff.generateVerhoeff(data2);

            return $"2{result_b1}{result_b2}{thePBill4Paid.TheAccounts!.TreasuryID}{randomNumber}";
        }

        private List<MultiIdentityRows> GetMultiplexingRows(PBill4Paid thePBill4Paid)
        {
            string payId = thePBill4Paid.TheAccounts!.IsTreasuryConstant == YesNo.Yes ? thePBill4Paid.TheAccounts.TreasuryID! : this.GetPayId(thePBill4Paid);

            List<MultiIdentityRows> costLisItemsWithGroupBy = new List<MultiIdentityRows>()
            {
                new MultiIdentityRows()
                {
                    IbanNumber      = thePBill4Paid.TheAccounts.IBAN!,
                    Amount          = Convert.ToInt64(thePBill4Paid.TotalPaidCost),
                    PaymentIdentity = payId
                }
            };

            return costLisItemsWithGroupBy;
        }

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
    public class PaymentRequest
{

    //public PaymentRequest()
    //{
    //    MultiplexingData = new MultiplexingData();
    //}

    //[Display(Name = @"شماره ترمينال")]
    //[Required(ErrorMessage = "شماره پايانه اجباري است ")]
    public string TerminalId { get; set; }

    //[Display(Name = @"شماره پذيرنده")]
    //[Required(ErrorMessage = "شماره پذيرنده اجباري است ")]
    public string MerchantId { get; set; }

    //[Required(ErrorMessage = "مبلغ اجباري است ")]
    //[Display(Name = @"مبلغ")]
    public long Amount { get; set; }

    public long? OrderId { get; set; }

    //public string AdditionalData { get; set; }

    public DateTime LocalDateTime { get; set; }

    public string ReturnUrl { get; set; }

    public string SignData { get; set; }

    //[Display(Name = @"پرداخت تسهيم")]
    //public bool EnableMultiplexing { get; set; }

    //public MultiplexingData MultiplexingData { get; set; }
    public MultiIdentityData MultiIdentityData { get; set; }

    //[display(name = @"کليد پذيرنده")]
    //[required(errormessage = "کليدپذيرنده اجباري است ")]
    //public string Merchantkey { get; set; }

    //[Display(Name = @"آدرس درگاه")]
    //[Required(ErrorMessage = "آدرس درگاه اجباري است ")]
    // public string PurchasePage { get; set; }
}

public class MultiIdentityData
{
    public MultiIdentityData()
    {
        MultiIdentityRows = new List<MultiIdentityRows>();
    }
    public enum MultiplexingType
    {
        Percentage,
        Amount,
        PaymentIdentity
    }

    //[Display(Name = @"نوع تسهيم")]
    public MultiplexingType? Type { get; set; }

    public List<MultiIdentityRows> MultiIdentityRows { get; set; }

    public bool IsValid()
    {
        if (!this.Type.HasValue) return false;
        if (!this.MultiIdentityRows.Any()) return false;
        if (this.MultiIdentityRows.Any(t => t.Amount < 0)) return false;

        switch (this.Type.Value)
        {
            case MultiplexingType.Percentage:
                if (this.MultiIdentityRows.Sum(t => t.Amount) > 100)
                    return false;
                if (this.MultiIdentityRows.Any(t => t.Amount > 99))
                    return false;
                break;
            case MultiplexingType.Amount:
                break;
            default:
                break;
        }

        return true;
    }

}

    public class MultiplexingDataItem
    {
        public string IbanNumber { get; set; }
        public long Value { get; set; }
    }

    public class MultiIdentityRows
    {
        public string IbanNumber { get; set; }
        public long Amount { get; set; }
        public string PaymentIdentity { get; set; }
    }

    public class MultiplexRowReq
    {
        public string IBAN { get; set; }
        public decimal Amount { get; set; }
        public string DepositID { get; set; }
    }

    public class PayResultData
    {
        public PayResultData()
        {
            this.ResCode     = "XXX";
            this.Token       = "XXX";
            this.OrderId     = "XXX";
            this.Id          = "XXX";
            this.Description = "XXX";
        }
        public string Id { get; set; }
        public string OrderId { get; set; }
        public string ResCode { get; set; }
        public string Token { get; set; }
        public string Description { get; set; }
    }

    /// <summary>
    /// For more information cf. http://en.wikipedia.org/wiki/Verhoeff_algorithm
    /// Dihedral Group stuff: http://en.wikipedia.org/wiki/Dihedral_group
    /// Dihedral Group order 10: http://mathworld.wolfram.com/DihedralGroupD5.html
    /// </summary>
    public static class Verhoeff
    {

        // The multiplication table
        static int[,] d = new int[,]
        {
            {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
            {1, 2, 3, 4, 0, 6, 7, 8, 9, 5},
            {2, 3, 4, 0, 1, 7, 8, 9, 5, 6},
            {3, 4, 0, 1, 2, 8, 9, 5, 6, 7},
            {4, 0, 1, 2, 3, 9, 5, 6, 7, 8},
            {5, 9, 8, 7, 6, 0, 4, 3, 2, 1},
            {6, 5, 9, 8, 7, 1, 0, 4, 3, 2},
            {7, 6, 5, 9, 8, 2, 1, 0, 4, 3},
            {8, 7, 6, 5, 9, 3, 2, 1, 0, 4},
            {9, 8, 7, 6, 5, 4, 3, 2, 1, 0}
        };

        // The permutation table
        static int[,] p = new int[,]
        {
            {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
            {1, 5, 7, 6, 2, 8, 3, 0, 9, 4},
            {5, 8, 0, 3, 7, 9, 6, 1, 4, 2},
            {8, 9, 1, 6, 0, 4, 3, 5, 2, 7},
            {9, 4, 5, 3, 1, 2, 6, 8, 7, 0},
            {4, 2, 8, 6, 5, 7, 3, 9, 0, 1},
            {2, 7, 9, 3, 8, 0, 6, 4, 1, 5},
            {7, 0, 4, 6, 9, 1, 3, 2, 5, 8}
        };

        // The inverse table
        static int[] inv = { 0, 4, 3, 2, 1, 5, 6, 7, 8, 9 };

        /// <summary>
        /// Validates that an entered number is Verhoeff compliant.
        /// NB: Make sure the check digit is the last one!
        /// </summary>
        /// <param name="num"></param>
        /// <returns>True if Verhoeff compliant, otherwise false</returns>
        public static bool validateVerhoeff(string num)
        {
            int c = 0;
            int[] myArray = StringToReversedIntArray(num);

            for (int i = 0; i < myArray.Length; i++)
            {
                c = d[c, p[(i % 8), myArray[i]]];
            }

            return c == 0;

        }

        /// <summary>
        /// For a given number generates a Verhoeff digit
        /// Append this check digit to num
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Verhoeff check digit as string</returns>
        public static string generateVerhoeff(string num)
        {
            int c = 0;
            int[] myArray = StringToReversedIntArray(num);

            for (int i = 0; i < myArray.Length; i++)
            {
                c = d[c, p[((i + 1) % 8), myArray[i]]];
            }

            return inv[c].ToString();
        }

        /// <summary>
        /// Converts a string to a reversed integer array.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Reversed integer array</returns>
        private static int[] StringToReversedIntArray(string num)
        {
            int[] myArray = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                myArray[i] = int.Parse(num.Substring(i, 1));
            }

            Array.Reverse(myArray);

            return myArray;

        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}