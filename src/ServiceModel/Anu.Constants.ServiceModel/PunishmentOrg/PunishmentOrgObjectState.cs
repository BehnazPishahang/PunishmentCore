using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Constants.ServiceModel.PunishmentOrg
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

        /// <summary>
        /// قبض انبار
        /// </summary>
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

        public static class PInspectionReport
        {
            /// <summary>
            /// پيش نويس
            /// </summary>
            public const string Drafted_old = "000518";
            /// <summary>
            /// گزارش بازرسي ارجاع شده
            /// </summary>
            public const string Refered_old = "000522";
            /// <summary>
            /// پيش نويس
            /// </summary>
            public const string Drafted = "000536";
            /// <summary>
            /// برگشت شده به ثبت کننده جهت اصلاح
            /// </summary>
            public const string ReturndToRegistrar = "000538";
            /// <summary>
            /// ثبت شده جهت تاييد مدير
            /// </summary>
            public const string RegisteredToManagerConfirm = "000540";
            /// <summary>
            /// ارسال شده به سازمان تعزيرات
            /// </summary>
            public const string SendedToPunishment = "000542";
            /// <summary>
            /// دريافت شده از سازمان گزارش دهنده
            /// </summary>
            public const string ReceivedFromSupportOrg = "000544";
            /// <summary>
            /// ابطال شده
            /// </summary>
            public const string Expired = "000546";
            /// <summary>
            /// برگشت شده به شهرستان ارجاع دهنده جهت اصلاح
            /// </summary>
            public const string ReturndToReferrer = "000548";
            /// <summary>
            /// ارجاع شده به شعبه
            /// </summary>
            public const string Referred = "000550";
            /// <summary>
            /// ارجاع شده به شهرستان
            /// </summary>
            public const string ReferredToCity = "000551";
            /// <summary>
            /// تشکيل پرونده شده
            /// </summary>
            public const string RegisterCase = "000552";
            /// <summary>
            /// برگشت شده به سازمان ارسال کننده
            /// </summary>
            public const string ReturndToSender = "000549";

        }

        /// <summary>
        /// ارسال مکاتبه مكانيزه درون سازماني
        /// </summary>
        public static class PMechanizeLetter
        {
            /// <summary>
            /// شروع
            /// </summary>
            public const string Start = "000360";
            /// <summary>
            /// پیش نویس شده
            /// </summary>
            public const string Draft = "000362";
            /// <summary>
            /// تاييد شده جهت ارسال
            /// </summary>
            public const string ConfirmedToSend = "000364";
            /// <summary>
            /// برگشت داده شده به ثبت كننده جهت رفع اشكال
            /// </summary>
            public const string ReturnToConfirmer = "000366";
            /// <summary>
            /// ارسال شده
            /// </summary>
            public const string Sended = "000368";
            /// <summary>
            /// ارسال نشده به گيرنده نامه مكانيزه
            /// </summary>
            public const string ViewByReceiver = "000370";

            /// <summary>
            /// ارسال شده به گيرنده نامه مكانيزه
            /// </summary>
            public const string ReceivedByReceiverUnit = "000372";

            /// <summary>
            /// رويت شده توسط گيرنده نامه مكانيزه
            /// </summary>
            public const string View = "000374";
            /// <summary>
            /// رويت و ارجاع شده توسط گيرنده نامه مكانيزه
            /// </summary>
            public const string ReturnToReferrer = "000376";
            /// <summary>
            /// چاپ مدرك
            /// </summary>
            public const string PrintForSend = "000378";
            /// <summary>
            /// چاپ مدرك
            /// </summary>
            public const string PrintForReceive = "000380";
            /// <summary>
            /// باطل شده
            /// </summary>
            public const string Expired = "000382";

        }

        public static class PGravamen
    {
        public const string Start = "000499";//شروع
        public const string TemporaryRegisteredByApplicant = "000501";//پذیرش اولیه شده توسط متقاضی 
        public const string PermanentRegisteredByApplicant = "000503";//پذیرش نهایی شده توسط متقاضی
        public const string RegisterPlaintiff = "000498";//ثبت شده توسط شاکی
        public const string RegisterInput = "000500";//ثبت ورود شده
        public const string Referred = "000502";//ارجاع شده
        public const string Failing = "000497";//نقص
        public const string Failed = "000504";//رد شده
        public const string Send = "000505";//ارسال شده
        public const string RegisterCase = "000506";//تشکیل پرونده شده
    }

        /// <summary>
        /// قبض جهت پرداخت وجه
        /// </summary>
        public static class PBill4Cash
        {
            /// <summary>
            /// شروع
            /// </summary>
            public const string Start = "000560";
            /// <summary>
            /// ثبت شده جهت تایید
            /// </summary>
            public const string Registered = "000562";
            /// <summary>
            ///  تایید شده
            /// </summary>
            public const string Confirmed = "000564";
            /// <summary>
            /// برگشت داده شده به ثبت کننده جهت رفع ایراد
            /// </summary>
            public const string ReturnToConfirmer = "000566";
            /// <summary>
            /// پیش نویس شده
            /// </summary>
            public const string Draft = "000568";
            /// <summary>
            /// ابطال شده
            /// </summary>        
            public const string Expired = "000570";
            /// <summary>
            /// وجه قبض پرداخت شده
            /// </summary>
            public const string Paid = "000569";
            /// <summary>
            /// صدور دريافت وجه شده
            /// </summary>
            public const string CreatedPcash = "000567";
            /// <summary>
            /// پرداخت رويت شده
            /// </summary>
            public const string View = "000565";



        }
    }
}
