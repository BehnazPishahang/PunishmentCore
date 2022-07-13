using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel.Constants
{
    public class PunishmentOrgObjectState
    {
        /// <summary>
        /// صورتجلسه کشف
        /// </summary>
        public static class PDiscoveryMinutes
        {

            /// <summary>
            /// ثبت موقت
            /// </summary>
            public const string PrimRegistery = "000620";

            /// <summary>
            /// صورتجلسه کشف ارسال شده به سامانه قاچاق
            /// </summary>
            public const string SendToSmuggling = "000621";

            /// <summary>
            /// ثبت و ارسال به مرجع رسیدگی
            /// </summary>
            public const string ConfirmAndSendToUnit = "000622";

            /// <summary>
            /// ارجاع شده به شعبه رسیدگی کننده
            /// </summary>
            public const string ReferToUnit = "000624";

            /// <summary>
            /// ارسال شده به شهر دیگر به دلیل اشتباه در ارجاع
            /// </summary>
            public const string ReferToCity = "000625";

            /// <summary>
            /// تشکیل پرونده شده توسط شعبه رسیدگی کننده
            /// </summary>
            public const string CreateCaseInUnit = "000626";

            /// <summary>
            /// شروع شده
            /// </summary>
            public const string Start = "000628";

            /// <summary>
            /// ابطال شده
            /// </summary>
            public const string Expire = "000630";

        }

        public static class PBillStore
    {

        /// <summary>
        /// تایید شده
        /// </summary>
        public const string Confirm = "000640";

        /// <summary>
        /// پیش نویس
        /// </summary>
        public const string Draft = "000641";
    }


    }
}
