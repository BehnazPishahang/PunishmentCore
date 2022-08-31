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
            public const string MechanizedLetterServices="024";

            /// <summary>
            /// فراخواننده سرويس دريافت درخواست مجوز تعقيب/بازرسي و پاسخ آن
            /// </summary>
            public const string SendPChaseLicenseReqList = "025";
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
    }
    

    
}
