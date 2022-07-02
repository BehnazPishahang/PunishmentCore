using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel.Constants
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
    }

}
