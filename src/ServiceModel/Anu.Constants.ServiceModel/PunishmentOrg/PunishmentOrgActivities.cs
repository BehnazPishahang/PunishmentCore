using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Constants.ServiceModel.PunishmentOrg;

public class PunishmentOrgActivities
{
   public static class PBill4Cash
    {
        /// <summary>
        /// ثبت قبض جهت تایید نهایی
        /// </summary>
        public const string Register = "000322";

        /// <summary>
        /// تایید قبض یا برگشت به ثبت کننده جهت رفع ایراد
        /// </summary>
        public const string ConfirmOrReturnToConfirmer = "000324";

        /// <summary>
        /// آماده الصاق موضوع لازم الاجرا
        /// </summary>
        public const string ReadyForAttachSubject = "000105";

        // رویت قبض پرداخت شده
        public const string View = "000323";

    }

    public static class PCash
    {
        /// <summary>
        /// ثبت دریافت از شخص جهت تایید نهایی
        /// </summary>
        public const string Register = "000102";

        /// <summary>
        /// رویت وجه دریافت شده
        /// </summary>
        public const string ViewPaid = "000103";

        /// <summary>
        /// تایید دریافت از شخص یا برگشت به ثبت کننده جهت رفع ایراد
        /// </summary>
        public const string ConfirmOrReturnToConfirmer = "000104";



    }

    public static class PPaid
    {
        /// <summary>
        /// ثبت پرداخت به شخص جهت تایید نهایی
        /// </summary>
        public const string Register = "000108";

        /// <summary>
        /// تایید پرداخت به شخص یا برگشت به ثبت کننده جهت رفع ایراد
        /// </summary>
        public const string ConfirmOrReturnToConfirmer = "000110";

    }

    /// <summary>
    /// ابلاغنامه
    /// </summary>
    public static class PNotice
    {
        #region MyRegion
        ///// <summary>
        ///// ثبت ابلاغيه جهت تاييد و ارسال
        ///// </summary>
        //public const string RegisterToConfirm = "000120";
        ///// <summary>
        ///// تاييد ابلاغيه جهت ارسال و يا برگشت ابلاغيه به ثبت کننده و يا ابطال ابلاغيه
        ///// </summary>
        //public const string ReturnToRegistrationOrConfirmOrExpire = "000122";
        ///// <summary>
        ///// ارسال ابلاغيه
        ///// </summary> 
        //public const string Send = "000124";
        #endregion
        /// <summary>
        /// ثبت و تایید ابلاغیه جهت ارسال یا ابطال ابلاغیه 
        /// </summary>
        public const string RegisterAndConfirmOrExpire = "000120";
        /// <summary>
        /// برگشت ابلاغیه به ثبت کننده یا ارسال ابلاغیه
        /// </summary>
        public const string ReturnToRegisterAndConfirmOrSend = "000122";
        /// <summary>
        /// رويت نتيجه ابلاغيه
        /// </summary>
        public const string ObservableResult = "000126";
        /// <summary>
        /// ایجاد آگهی ابلاغ
        /// </summary>
        public const string CreateNotice = "000127";
        /// <summary>
        /// ابلاغیه چاپ شده
        /// </summary>
        public const string Print = "000125";
    }

    /// <summary>
    /// نامه وارده
    /// </summary>
    public static class PIncomingLetter
    {
        public const string SendToManager = "000128";
        public const string ViewLetter = "000130";
    }
    /// <summary>
    /// نامه صادره
    /// </summary>
    public static class POutgoingLetter
    {
        public const string RegisterToConfirm = "000136";
        //public const string ConfirmToEmployeeOrSecretariat = "000133";
        public const string ReturnToRegistrationOrConfirmOrExpire = "000134";
        public const string Send = "000132";
        public const string print = "000137";
    }

    /// <summary>
    /// تقسیط
    /// </summary>
    public static class pInstallment
    {
        public const string RegisterForConfirm = "000140";// ثبت تقسیط برای تأیید
        public const string ConfirmOrReturnToRegister = "000142";// تأیید تقسیط یا برگشت به ثبت کننده
        public const string ReturnToConfirm = "000144";//  برگشت به تأیید کننده تقسیط
        public const string ViewPInstallment = "000145";//  رويت تقسيط تاييد شده

    }

    /// <summary>
    /// بازداشتی
    /// </summary>
    public static class pArrested
    {
        public const string RegisterToConfirm = "000146";//ثبت برای تأیید بازداشتی
        public const string ConfirmOrReturnToRegister = "000148";// تأیید بازداشتی یا برگشت به ثبت کننده
        public const string EndArrested = "000150";// پایان بازداشت

    }

    /// <summary>
    /// زندانی
    /// </summary>
    public static class pPrison
    {
        public const string RegisterForConfirm = "000152";//  ثبت برای تأیید زندانی
        public const string ConfirmOrReturnToRegister = "000154";// تأیید زندانی یا برگشت به ثبت کننده زندانی
        public const string ReturnToConfirm = "000156";//  برگشت به تأیید کننده زندانی
    }


    /// <summary>
    /// قرار قبولی تامین
    /// </summary>
    public static class PSaftyWriteAccept
    {
        /// <summary>
        /// ثبت جهت تاييد قرار قبولي تامين
        /// </summary>
        public const string RegisterToConfirm = "000160";
        /// <summary>
        /// تاييد ويا برگشت از تاييد قرار قبولي تامين
        /// </summary>
        public const string ConfirmOrReturnToAlignment = "000164";
        /// <summary>
        /// قرار قبولي تامين چاپ گرفته شده
        /// </summary>
        public const string Printed = "000166";
    }

    public static class PSaftyWrite
    {
        /// <summary>
        /// ثبت جهت تاييد قرار تامين
        /// </summary>
        public const string RegisterToConfirm = "000170";
        /// <summary>
        /// تاييد ويا برگشت از تاييد قرار تامين
        /// </summary>
        public const string ConfirmOrReturnToAlignment = "000174";
        /// <summary>
        /// چاپ قرار تامین
        /// </summary>
        public const string print = "000176";

    }

    public static class PCancelSaftyWrite
    {
        /// <summary>
        /// ثبت جهت تاييد فک قرار تامين
        /// </summary>
        public const string RegisterToConfirm = "000326";
        /// <summary>
        /// تاييد ويا برگشت از تاييد فک قرار تامين
        /// </summary>
        public const string ConfirmOrReturnToAlignment = "000328";
        /// <summary>
        /// چاپ فک قرار تامین
        /// </summary>
        public const string print = "000330";

    }

    /// <summary>
    /// تجدید نظر خواهی
    /// </summary>
    public static class PRevisionRequest
    {
        /// <summary>
        /// ثبت جهت تاييد تجدید نظر خواهی
        /// </summary>
        public const string RegisterToConfirm = "000180";
        /// <summary>
        /// تاييد ويا برگشت از تاييد تجدید نظر خواهی
        /// </summary>
        public const string ConfirmOrReturnToAlignment = "000184";
    }

    /// <summary>
    /// قرار اعدادی
    /// </summary>
    public static class PEnumerationWrit
    {
        /// <summary>
        /// ثبت جهت تاييد قرار اعدادی
        /// </summary>
        public const string RegisterToConfirm = "000190";
        /// <summary>
        /// تاييد ويا برگشت به ثبت کننده قرار اعدادی
        /// </summary>
        public const string ConfirmOrReturnToAlignment = "000194";
        /// <summary>
        /// صدور احضاریه و یا برگشت از تایید قرار اعدادی
        /// </summary>
        public const string CreateNoticeOrReturnFromConfirm = "000195";
        /// <summary>
        /// قرار اعدادی چاپ شده
        /// </summary>
        public const string Print = "000196";



    }

    /// <summary>
    /// صورتجلسه رسیدگی
    /// </summary>
    public static class PProceedingMinute
    {
        /// <summary>
        /// ثبت جهت تاييد صورتجلسه رسیدگی
        /// </summary>
        public const string RegisterToConfirm = "000198";

        /// <summary>
        /// تاييد ويا برگشت از تاييد صورتجلسه رسیدگی
        /// </summary>
        public const string ConfirmOrReturnToAlignment = "000200";

        /// <summary>
        ///  صورتجلسه رسیدگی چاپ شده
        /// </summary>
        public const string Printed = "000202";
    }

    public static class PJudgment
    {
        /// <summary>
        /// اعمال رای دادگاه عالی بر روی پرونده اجرایی
        /// </summary>
        public const string Build = "000205";
        /// <summary>
        /// ثبت پیش نویس رای
        /// </summary>
        public const string RegisterToConfirm = "000204";
        /// <summary>
        /// تایید و یا برگشت و یا ابطال رای
        /// </summary>
        public const string ConfirmOrReturnOrExpire = "000206";
        /// <summary>
        /// صدور ابلاغنامه و یا برگشت از تایید رای
        /// </summary>
        public const string NoticeOrReturn = "000207";
        /// <summary>
        /// اصلاح رای برگشت داده شده
        /// </summary>
        public const string Repair = "000208";

    }

    public static class PGravamen
    {
        /// <summary>
        ///ثبت ورود شکوائیه به تعزیرات یا رد شکوائیه ویا ارسال شکوائیه به بازرسی
        /// </summary>
        public const string RegisterInputGravamen = "000298";
        /// <summary>
        /// ارجاع شکوائیه به شعبه
        /// </summary>
        public const string ReferOrFail = "000300";
        /// <summary>
        /// تشکیل پرونده از روی شکوائیه
        /// </summary>
        public const string RegisterCase = "000302";

    }

    public static class PChaseLicenseReqSilver
    {
        /// <summary>
        ///تایید و ارسال درخواست مجوز تعقيب/بازرسي به مدیر
        /// </summary>
        public const string RegisteredToManagerFromExpert = "000430";
        /// <summary>
        ///تایید و ارسال درخواست مجوز تعقيب/بازرسي به ارجاع دهنده
        /// </summary>
        public const string RegisteredToManagerFromSecretariat = "000432";
        /// <summary>
        /// ثبت درخواست مجوز تعقيب/بازرسي جهت تاييد مدير
        /// </summary>
        public const string RegisteredToManagerConfirm = "000434";
        /// <summary>
        /// تاييد و ارسال درخواست مجوز تعقيب/بازرسي به سازمان تعزيرات يا برگشت به ثبت کننده
        /// </summary>
        public const string SendToPunishmentOrReturn = "000436";
        /// <summary>
        /// ارجاع درخواست مجوز تعقيب/بازرسي به شعبه جهت رسيدگي و يا ابطال آن
        /// </summary>
        public const string ExpireOrReffer = "000438";
        /// <summary>
        /// اعلام نتیجه درخواست مجوز تعقيب/بازرسي يا برگشت به ارجاع دهنده
        /// </summary>
        public const string RegisterCase = "000440";
        /// <summary>
        /// رویت درخواست مجوز تعقیب/بازرسی عدم کشف قاچاق/تخلف
        /// </summary>
        public const string NonDiscoveryView = "000442";
        /// <summary>
        /// رويت پاسخ نهاد صالح به درخواست صدور مجوز تعقيب/بازرسي
        /// </summary>
        public const string AnswerView = "000427";
        /// <summary>
        /// درخواست مجوز تعقیب/بازرسی منجر به صورتجلسه کشف
        /// </summary>
        public const string DiscoveryReportSended = "000443";
        /// <summary>
        /// درخواست مجوز تعقیب/بازرسی منجر به گزارش کشف اسنادی
        /// </summary>
        public const string SmugglingDetectionReportSended = "000444";

    }


    public static class PInspectionReport
    {
        /// <summary>
        ///تایید و ارسال گزارش به مدیر
        /// </summary>
        public const string RegisteredToManagerFromExpert = "000313";
        /// <summary>
        ///تایید و ارسال گزارش به ارجاع دهنده
        /// </summary>
        public const string RegisteredToManagerFromSecretariat = "000315";
        /// <summary>
        /// ثبت گزارش بازرسي جهت تاييد مدير
        /// </summary>
        public const string RegisteredToManagerConfirm = "000312";
        /// <summary>
        /// تاييد و ارسال گزارش به سازمان تعزيرات يا برگشت به ثبت کننده
        /// </summary>
        public const string SendToPunishmentOrReturn = "000314";
        /// <summary>
        /// ارجاع گزارش بازرسي به شعبه جهت رسيدگي و يا ابطال آن
        /// </summary>
        public const string ExpireOrReffer = "000316";
        /// <summary>
        /// تشکيل پرونده از روي گزارش بازرسي يا برگشت به ارجاع دهنده
        /// </summary>
        public const string RegisterCase = "000318";
    }

    public static class CorrectiveJudge
    {
        /// <summary>
        /// ثبت پیش نویس رای
        /// </summary>
        public const string RegisterToConfirm = "000290";
        /// <summary>
        /// تایید و یا برگشت و یا ابطال رای
        /// </summary>
        public const string ConfirmOrReturnOrExpire = "000292";
        /// <summary>
        /// صدور ابلاغنامه و یا برگشت از تایید رای
        /// </summary>
        public const string NoticeOrReturn = "000294";
        /// <summary>
        /// اصلاح رای برگشت داده شده
        /// </summary>
        public const string Repair = "000296";

    }


    public static class PTerminateOrder
    {
        /// <summary>
        /// ثبت پیش نویس سایر تصمیمات مختومه کننده
        /// </summary>
        public const string RegisterToConfirm = "000278";
        /// <summary>
        /// تایید و یا برگشت و یا ابطال سایر تصمیمات مختومه کننده
        /// </summary>
        public const string ConfirmOrReturnOrExpire = "000280";
        /// <summary>
        /// صدور ابلاغنامه و یا برگشت از تایید سایر تصمیمات مختومه کننده
        /// </summary>
        public const string Return = "000282";
        /// <summary>
        /// اصلاح سایر تصمیمات مختومه کننده برگشت داده شده
        /// </summary>
        public const string Repair = "000284";

    }



    /// <summary>
    /// آگهی ابلاغ
    /// </summary>
    public static class PNoticeAdvertising
    {
        /// <summary>
        /// ثبت جهت تاييد آگهی ابلاغ
        /// </summary>
        public const string RegisterToConfirm = "000220";
        /// <summary>
        /// تاييد ويا برگشت از تاييد آگهی ابلاغ
        /// </summary>
        public const string ConfirmOrReturnToAlignment = "000224";
        /// <summary>
        /// ارسال آگهی ابلاغ
        /// </summary>
        public const string Send = "000226";
        /// <summary>
        ///  آگهی ابلاغ چاپ گرفته شده
        /// </summary>
        public const string Printed = "000228";
        /// <summary>
        /// رويت نتيجه آگهی
        /// </summary>
        public const string ObservableResult = "000230";
    }

    /// <summary>
    /// نامه مکانیزه درون سازمانی
    /// </summary>
    public static class PMechanizeLetter
    {
        /// <summary>
        /// ثبت مكاتبه مكانيزه درون سازماني جهت تاييد مدير 
        /// </summary>
        public const string ConfirmToSend = "000232";
        /// <summary>
        /// تاييد و ارسال مكاتبه مكانيزه درون سازماني  و يا برگشت آن به ثبت كننده جهت رفع اشكال
        /// </summary>
        public const string SendOrReturnToConfirmer = "000234";
        /// <summary>
        /// رويت  و يا  ارجاع/ارسال  مكاتبه مكانيزه درون سازماني
        /// </summary>
        public const string ViewOrRefer = "000236";
        /// <summary>
        /// رويت  و يا ارجاع/ارسال  و يا بازگشت  مكاتبه مكانيزه درون سازماني
        /// </summary>
        public const string ViewOrReferOrReturn = "000238";
    }

    /// <summary>
    /// فعاليت عام المنفعه
    /// </summary>
    public static class PPublicWorksExec
    {
        /// <summary>
        /// ثبت جهت تاييد فعاليت عام المنفعه
        /// </summary>
        public const string RegisterForConfirm = "000250";
        /// <summary>
        /// تاييد ويا برگشت به ثبت کننده فعاليت عام المنفعه
        /// </summary>
        public const string ConfirmOrReturnToRegister = "000252";
        /// <summary>
        /// فعالیت عام المنفعه تایید شده
        /// </summary>
        public const string Confirmed = "000254";
    }

    /// <summary>
    /// قرار اجرای احکام
    /// </summary>
    public static class PExecutionWrit
    {
        /// <summary>
        /// ثبت جهت تاييد قرار اجرای احکام
        /// </summary>
        public const string RegisterForConfirm = "000260";
        /// <summary>
        /// تاييد ويا برگشت به ثبت کننده قرار اجرای احکام
        /// </summary>
        public const string ConfirmOrReturnToRegister = "000262";
        /// <summary>
        /// قرار اجرای احکام تایید شده در شعبه صادر کننده رای
        /// </summary>
        public const string ConfirmInJudgUnit = "000264";
        /// <summary>
        /// قرار اجرای احکام چاپ گرفته شده
        /// </summary>
        public const string Printed = "000266";
        /// <summary>
        /// تایید قرار اجرای احکام توسط مدیر کل استان
        /// </summary>
        public const string ConfirmByProvinceManager = "000265";
        /// <summary>
        /// اطلاع از تایید  توسط دادستان
        /// </summary>
        public const string NoticeOfConfirmByProsecutor = "000267";
        /// <summary>
        /// اطلاع از رد توسط دادستان
        /// </summary>
        public const string NoticeOfRejectByProsecutor = "000268";
        /// <summary>
        /// اطلاع از تایید  توسط اداره گذرنامه
        /// </summary>
        public const string NoticeOfConfirmByPassportOfficer = "000261";
        /// <summary>
        /// اطلاع از رد توسط اداره گذرنامه
        /// </summary>
        public const string NoticeOfRejectByPassportOfficer = "000263";
    }



    /// <summary>
    /// رای دیوان عدالت اداری
    /// </summary>
    public static class PJudgmentCourt
    {
        /// <summary>
        /// ثبت جهت تاييد رای دیوان عدالت اداری
        /// </summary>
        public const string RegisterForConfirm = "000426";
        /// <summary>
        /// تاييد ويا برگشت به ثبت کننده رای دیوان عدالت اداری
        /// </summary>
        public const string ConfirmOrReturnToRegister = "000428";
    }

    /// <summary>
    /// رفع محدوديت ايجاد شده توسط قرار اجراي احکام
    /// </summary>
    public static class PExecutionRemovalWrit
    {
        /// <summary>
        /// ثبت جهت تاييد رفع محدوديت ايجاد شده توسط قرار اجراي احکام
        /// </summary>
        public const string RegisterForConfirm = "000270";
        /// <summary>
        /// تاييد ويا برگشت به ثبت کننده رفع محدوديت ايجاد شده توسط قرار اجراي احکام
        /// </summary>
        public const string ConfirmOrReturnToRegister = "000272";
        /// <summary>
        /// برگشت از تاييد رفع محدوديت ايجاد شده توسط قرار اجراي احکام
        /// </summary>
        public const string ReturnToConfirm = "000274";
        /// <summary>
        /// رفع محدوديت ايجاد شده توسط قرار اجراي احکام چاپ گرفته شده شده
        /// </summary>
        public const string Printed = "000276";
        /// <summary>
        /// تایید قرار اجرای احکام توسط مدیر کل استان
        /// </summary>
        public const string ConfirmByProvinceManager = "000275";
        /// <summary>
        /// اطلاع از تایید  توسط دادستان
        /// </summary>
        public const string NoticeOfConfirmByProsecutor = "000271";
        /// <summary>
        /// اطلاع از رد توسط دادستان
        /// </summary>
        public const string NoticeOfRejectByProsecutor = "000273";
        /// <summary>
        /// اطلاع از تایید  توسط اداره گذرنامه
        /// </summary>
        public const string NoticeOfConfirmByPassportOfficer = "000277";
        /// <summary>
        /// اطلاع از رد توسط اداره گذرنامه
        /// </summary>
        public const string NoticeOfRejectByPassportOfficer = "000279";
    }
    /// <summary>
    /// نامه مکانیزه درون سازمانی
    /// </summary>
    public static class PMechanizeLetterRefer
    {

        /// <summary>
        /// رويت  و يا  ارجاع دریافت  مكاتبه مكانيزه درون سازماني
        /// </summary>
        public const string ViewOrRefer = "000286";
        /// <summary>
        ///  بازگشت  مكاتبه مكانيزه درون سازماني
        /// </summary>
        public const string Return = "000288";
    }

    public static class PStopExecutiveOrder
    {

        /// <summary>
        /// تایید دستور توقف عملیات اجرایی
        /// </summary>
        public const string Confirm = "000334";
        /// <summary>
        /// ثبت دستور توقف عملیات اجرایی
        /// </summary>
        public const string Register4Confirm = "000336";
        /// <summary>
        /// رویت دستور توقف عملیات اجرایی
        /// </summary>
        public const string View = "000337";
    }

    public static class PCashByMobilePOS
    {

        /// <summary>
        /// صدور فیش براساس دریافتی از کارت خوان سیار
        /// </summary>
        public const string ReadyForAttachSubject = "000338";
        /// <summary>
        /// یک دریافتی از طریق پوز سیار برای شما صادر شده
        /// </summary>
        public const string CreatedPcashByMobilePos = "000340";
    }
    /// <summary>
    /// صورتجلسه کشف
    /// </summary>
    public static class PDiscoveryMinutes
    {

        /// <summary>
        /// ثبت و ارسال صورتجلسه کشف به مرجع رسیدگی کننده
        /// </summary>
        public const string ConfirmAndSendToUnit = "000350";
        /// <summary>
        /// ارجاع صورتجلسه کشف به واحد رسیدگی کننده
        /// </summary>
        public const string ReferToUnit = "000351";
        /// <summary>
        /// تشکيل پرونده از روي صورتجلسه کشف
        /// </summary>
        public const string RegisterCase = "000352";
    }

    public static class PChaseLicenseReq
    {

        /// <summary>
        /// ارسال درخواست مجوز تعقیب/بازرسی به واحد تعزیراتی
        /// </summary>
        public const string SendToPuoUnit = "000425";
    }

    public static class PArticle23ActionRequest
    {
        /// <summary>
        /// ارجاع درخواست به مدیر کل رسیدگی به شکایات
        /// </summary>
        public const string ReferOrReject = "000356";

        /// <summary>
        /// اظهار نظر کارشناس در مورد درخواست اعمال تبصره ماده 23 آيين نامه سازمان
        /// </summary>
        public const string ExpertIdea = "000358";
        /// <summary>
        /// تایید درخواست جهت ارسال به مدیر کل استانی
        /// </summary>
        public const string confirm = "000360";
        /// <summary>
        /// ارسال درخواست به رییس سازمان
        /// </summary>
        public const string SendOrReject = "000362";
        /// <summary>
        /// ارسال درخواست به مدیر کل رسیدگی به شکایات
        /// </summary>
        public const string orderByHead = "000364";
        
        /// <summary>
        /// ارجاع درخواست به مدیر کل استان
        /// </summary>
        public const string ReferToManager = "000366";
        /// <summary>
        /// ارجاع درخواست به ارسال کننده
        /// </summary>
        public const string ReferToRegister = "000368";
        /// <summary>
        /// رویت درخواست رد شده
        /// </summary>
        public const string ViewRegectedRequest = "000370";
        /// <summary>
        /// رویت پرونده ارجاع شده
        /// </summary>
        public const string ViewReferedCase = "000372";
        /// <summary>
        /// ارجاع درخواست به کارشناس
        /// </summary>
        public const string ReferToExpert = "000373";
        /// <summary>
        /// اظهار نظر مدير كل رسيدگي به شكايات و ارجاع به مشاور
        /// </summary>
        public const string SendToConsultantbyHead = "000374";
        /// <summary>
        /// اظهار نظر مشاور حقوقی در مورد درخواست اعمال تبصره ماده 23 آيين نامه سازمان
        /// </summary>
        public const string SendToConsultant = "000375";
        /// <summary>
        /// صدور دستور لازم توسط رئیس سازمان
        /// </summary>
        public const string orderByHeadsecond = "000376";
        /// <summary>
        /// درخواست ارجاع شده به ثبت کننده جهت رفع ایراد
        /// </summary>
        public const string RejectToRegister = "000377";
        /// <summary>
        /// ارسال درخواست به رئیس سازمان
        /// </summary>
        public const string SendToChiefByHead = "000378";
        /// <summary>
        /// رویت درخواست ارسال شده به رئیس سازمان
        /// </summary>
        public const string ViewbyManager = "000379";
        /// <summary>
        /// درخواست ارجاع شده به شعبه ارسال کننده جهت رفع ایراد
        /// </summary>
        public const string RejectToRegister2 = "000371";
        /// <summary>
        /// صدور دستور لازم توسط مدیر کل رسیدگی به شکایات
        /// </summary>
        public const string OrderByHeadquarters = "000369";

    }

    public static class PNote1Article21Protest
    {
        /// <summary>
        /// ارجاع به شعبه جهت رسیدگی و تشکیل پرونده و ابطال
        /// </summary>
        public const string ReferedToBranch = "000380";

    }

    public static class PArticle50ActionRequest
    {
        /// <summary>
        /// تایید درخواست جهت ارسال به مدیر کل استانی
        /// </summary>
        public const string confirm = "000390";

        /// <summary>
        /// درخواست ارجاع شده به ثبت کننده جهت رفع ایراد
        /// </summary>
        public const string RejectToRegister = "000392";

        /// <summary>
        /// ارجاع درخواست به مدیر كل پيشگيري و نظارت بر امور قاچاق كالا و ارز
        /// </summary>
        public const string ReferOrReject = "000394";

        /// <summary>
        /// ارسال درخواست به رییس سازمان
        /// </summary>
        public const string SendOrReject = "000396";

        /// <summary>
        /// درخواست ارجاع شده به شعبه ارسال کننده جهت رفع ایراد
        /// </summary>
        public const string RejectToRegister2 = "000398";

        /// <summary>
        /// رویت درخواست ارسال شده به رئیس سازمان
        /// </summary>
        public const string ViewbyManager = "000400";

        /// <summary>
        /// اظهار نظر کارشناس در مورد درخواست تجديدنظرخواهي موضوع تبصره 4 ماده 50 قانون قاچاق کالا و ارز
        /// </summary>
        public const string ExpertIdea = "000402";

        /// <summary>
        /// اظهار نظر مدیر كل پيشگيري و نظارت بر امور قاچاق كالا و ارز و ارجاع به رئیس سازمان
        /// </summary>
        public const string SendToConsultantbyHead = "000404";

        /// <summary>
        /// صدور دستور لازم توسط رئیس سازمان
        /// </summary>
        public const string orderByHead = "000406";

        /// <summary>
        /// ارجاع درخواست به ارسال کننده
        /// </summary>
        public const string ReferToRegister = "000408";

        /// <summary>
        /// رویت درخواست رد شده
        /// </summary>
        public const string ViewRegectedRequest = "000410";

        /// <summary>
        /// رویت پرونده ارجاع شده
        /// </summary>
        public const string ViewReferedCase = "000412";

        /// <summary>
        /// ارجاع درخواست به کارشناس
        /// </summary>
        public const string ReferToExpert = "000414";

        /// <summary>
        /// صدور دستور لازم توسط مدیر کل استان
        /// </summary>
        public const string OrderByHeadquarters = "000416";

    }

    /// <summary>
    /// گزارش وقوع تخلف/جرم
    /// </summary>
    public static class PReportViolation
    {

        /// <summary>
        /// ثبت و ارسال گزارش وقوع تخلف/جرم به مرجع رسیدگی کننده
        /// </summary>
        public const string ConfirmAndSendToUnit = "000420";
        /// <summary>
        /// ارجاع گزارش وقوع تخلف/جرم به واحد رسیدگی کننده
        /// </summary>
        public const string ReferToUnit = "000422";
        /// <summary>
        /// تشکيل پرونده از روي گزارش وقوع تخلف/جرم
        /// </summary>
        public const string RegisterCase = "000424";
    }
    public static class MechanizedLetter
    {
        /// <summary>
        /// رويت و يا ارجاع/ارسال مكاتبه مكانيزه
        /// </summary>
        public const string ViewOrRefer = "000236";
    }
}



