using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Constants.ServiceModel.PunishmentOrg
{
    public class PunishmentOrgConstants
    {
        public static class GFESUserAccessType
        {
            /// <summary>
            /// فراخواننده سرويس ارسال صورتجلسه كشف به سازمان تعزیرات
            /// </summary>
            public const string SendPDiscoveryMinute = "0003";

            /// <summary>
            /// سرویس اموال تملیکی
            /// </summary>
            public const string SendPBillStore_AmvalTamliki = "007";


            /// <summary>
            /// فراخواننده سرويس ارسال گزارش بازرسي به سازمان تعزیرات
            /// </summary>
            public const string SendPDiscoveryReport = "0004";

            /// <summary>
            /// فراخواننده سرويس ارسال رسيد کالا به سازمان تعزیرات
            /// </summary>
            public const string SendPBillStoreService = "0018";

            /// <summary>
            /// فراخواننده سرويس ارسال درخواست مجوز تعقيب به سازمان تعزیرات
            /// </summary>
            public const string SendPChaseLicenseReqServices = "0019";

            /// <summary>
            /// فراخواننده سرويس ارسال پاسخ درخواست مجوز تعقيب به سازمان تعزیرات
            /// </summary>
            public const string SendPChaseLicenseReqResultServices = "0020";

            /// <summary>
            /// فراخواننده سرويس ارسال گزارش بازرسی به سازمان تعزیرات
            /// </summary>
            public const string SendPInspectionReportServices = "0021";

            /// <summary>
            /// فراخواننده سرویس ارسال مکاتبات مکانیزه به سازمان تعزیرات
            /// </summary>
            public const string SendGMechanizedLetterServices = "0022";

            /// <summary>
            /// فراخواننده سرویس دریافت مکاتبات مکانیزه به سازمان تعزیرات
            /// </summary>
            public const string MechanizedLetterServices = "024";

            /// <summary>
            /// فراخواننده سرويس دريافت درخواست مجوز تعقيب/بازرسي و پاسخ آن
            /// </summary>
            public const string SendPChaseLicenseReqList = "025";

            /// <summary>
            /// کاربر سامانه 135 تعزیرات
            /// </summary>
            public const string Tazirat135Users = "026";
        }

        public static class NajaUnit
        {
            /// <summary>
            /// سازمان حمايت مصرف كننده - سازمانهاي صنعت، معدن و تجارت
            /// </summary>
            public const string ConsumerProtection = "00117";

            /// <summary>
            /// گمرك جمهوري اسلامي ايران
            /// </summary>
            public const string Customs = "00025";

            /// <summary>
            /// وازرت اطلاعات
            /// </summary>
            public const string InformationMinistry = "00043";

            /// <summary>
            /// سپاه پاسداران انقلاب اسلامي
            /// </summary>
            public const string Irgc = "00010";

            /// <summary>
            /// نيروي انتظامي-ناجا
            /// </summary>
            public const string Naja = "00118";

            /// <summary>
            /// وزارت جهاد كشاورزي و واحدهاي تابعه
            /// </summary>
            public const string AgricultureMinistry = "00027";

            /// <summary>
            /// سازمان شيلات ايران
            /// </summary>
            public const string FisheriesOrganization = "22001";

            /// <summary>
            /// سازمان جنگلها و مراتع كشور
            /// </summary>
            public const string ForestsOrganization = "00062";

            /// <summary>
            /// شركت ملي توليد و پخش فرآورده هاي نفتي
            /// </summary>
            public const string OilCompany = "00040";

            /// <summary>
            /// وزارت ميراث فرهنگي و گردشگري و صنايع دستي
            /// </summary>
            public const string CulturalHeritageMinistry = "00048";

            /// <summary>
            /// سازمان حفاظت محيط زيست
            /// </summary>
            public const string EnvironmentalProtectionOrganization = "00058";

            /// <summary>
            /// بانك مركزي
            /// </summary>
            public const string CentralBank = "00016";

            /// <summary>
            /// ستاد مركزي سازمان غذا و دارو
            /// </summary>
            public const string FoodDrugOrganization = "280000";

            /// <summary>
            /// سازمان تعزیرات حکومتی
            /// این ناجا یونیت برای کاربران سامانه ی 135 تعزیرات استفاده شده است
            /// </summary>
            public const string PunishmentOrg = "00006";
        }

        public enum NajaUnitCode
        {
            ConsumerProtection = 1,
            Customs,
            InformationMinistry,
            Irgc,
            Naja,
            AgricultureMinistry,
            FisheriesOrganization,
            ForestsOrganization,
            OilCompany,
            CulturalHeritageMinistry,
            EnvironmentalProtectionOrganization,
            CentralBank,
            FoodDrugOrganization
        }

        public enum PersonRole
        {
            Transferee = 1,
            Delivery
        }

        public static class GfesUserPassword
        {
            public const string Password = "137402";
        }

        public static class SadaPayment
        {
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
        }
    }



}
