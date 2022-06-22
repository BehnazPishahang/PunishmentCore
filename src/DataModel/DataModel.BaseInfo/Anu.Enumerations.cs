using System;
using System.ComponentModel;

namespace DataModel.BaseInfo.Anu.Enumerations
{
    //بازگرداندن نسخه پایدار به ورژن
    //985 شماره tfs

    [Description("EnmCoopraiveActivity")]
    public enum CoopraiveActivity
    {
        [Description("کشاورزي")]
        Agriculture = 1,
        [Description("عمراني")]
        Civil = 15,
        [Description("اتحاديه تعاوني هاي نظارت و هماهنگي")]
        CoordinationCooperatives = 16,
        [Description("اعتبار")]
        Credit = 8,
        [Description("فرش دستباف")]
        HandmadeCarpet = 5,
        [Description("مسکن")]
        Housing = 4,
        [Description("صنعتي")]
        Industrial = 14,
        [Description("سهام عدالت")]
        JusticeShares = 13,
        [Description("تأمين نياز مصرف کنندگان")]
        MeetConsumersNeeds = 7,
        [Description("تأمين نياز توليدکنندگان")]
        MeetManufacturersNeeds = 6,
        [Description("تأمين نياز صنوف خدماتي")]
        MeetServicesNeeds = 11,
        [Description("تامين نياز صنفي")]
        MeetUnionNeeds = 12,
        [Description("معدني")]
        Mineral = 2,
        [Description("چند منظوره")]
        Multipurpose = 10,
        [Description("خدمات")]
        Services = 3,
        [Description("حمل و نقل")]
        Transportation = 9,
        [Description("")]
        None = 0
    }

    [Description("EnmAddressType")]
    public enum AddressType
    {
        [Description("اعلامي متعهد له")]
        Creditor = 2,
        [Description("اعلامي متعهد")]
        Debtor = 3,
        [Description("متن سند")]
        DocAddress = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmAdvertisingState")]
    public enum AdvertisingState
    {
        [Description("تاييد شده")]
        Confirmed = 2,
        [Description("ابطال شده")]
        Disproofed = 7,
        [Description("پيش نويس شده")]
        PreSend = 6,
        [Description("ثبت شده جهت تاييد")]
        Registered = 1,
        [Description("برگشت داده شده")]
        Return = 4,
        [Description("ارسال شده")]
        Sended = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmAgentedPerson")]
    public enum AgentedPerson
    {
        [Description("متعهد له")]
        AgentCreditor = 2,
        [Description("متعهد")]
        AgentDebtor = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmAlarmType")]
    public enum AlarmType
    {
        [Description("خطا و توقف")]
        ErrorAlarm = 1,
        [Description("هشدار و اخذ اجازه")]
        WarningAlarm = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmAlarmViewerType")]
    public enum AlarmViewerType
    {
        [Description("درون سازماني")]
        InnerOrg = 1,
        [Description("برون سازماني")]
        OutterOrg = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmAndOr")]
    public enum AndOr
    {
        [Description("و")]
        AndOperand = 2,
        [Description("يا")]
        OrOperand = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmApplicantFunctionType")]
    public enum ApplicantFunctionType
    {
        [Description("موافقتنامه")]
        Agreement = 3,
        [Description("تخصيص")]
        Allocation = 4,
        [Description("اعتبارات")]
        BudgetForm = 1,
        [Description("صورتجلسه")]
        Minutes = 5,
        [Description("ابلاغ   ")]
        Notice = 2,
        [Description("ساير")]
        Other = 99,
        [Description("عملکرد")]
        Proceeds = 6,
        [Description("رابت")]
        RABeT = 21,
        [Description("")]
        None = 0
    }
    [Description("EnmApplicantType")]
    public enum ApplicantType
    {
        [Description("جهت محاسبه کردن مقدار ستون")]
        CalcCol = 1,
        [Description("جهت شرط براي فقط خواندني کردن کل سطر")]
        CondCol = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmArchiveStatus")]
    public enum ArchiveStatus
    {
        [Description("مفقود شده")]
        Lost = 3,
        [Description("خارج از بايگاني")]
        OutOfArchive = 2,
        [Description("داخل بايگاني")]
        InArchive = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmAssetOrRight")]
    public enum AssetOrRight
    {
        [Description("اموال غيرمنقول")]
        ImmovableAsset = 1,
        [Description("اموال منقول")]
        LinkageAsset = 2,
        [Description("حق و امتياز")]
        Right = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmAsyncType")]
    public enum AsyncType
    {
        [Description("جهت به روز رساني")]
        ToCommit = 2,
        [Description("جهت حذف")]
        ToDelete = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmAttachmentProcessState")]
    public enum AttachmentProcessState
    {
        [Description("پرونده مربوطه درج شده است")]
        CaseInserted = 5,
        [Description("پيوست پيدا نشد")]
        FileNotFound = 3,
        [Description(" حجم پيوست از اندازه استادارد بزرگتر است")]
        FileSizeInvalid = 2,
        [Description("مسير ذخيره سازي فايل نامعتبر است")]
        PathAndFileNameIsInvalid = 4,
        [Description("پيوست به درستي پردازش شده")]
        ProcessedSuccessfully = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmAttachmentType")]
    public enum AttachmentType
    {
        [Description("فايل اتوکد")]
        Autocad = 2,
        [Description("تصوير")]
        Image = 1,
        [Description("فايل آفيس")]
        Office = 4,
        [Description("ساير")]
        Other = 9,
        [Description("فيلم")]
        Video = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmBankType")]
    public enum BankType
    {
        [Description("موسسه مالي و اعتباري")]
        FinanceAndCreditInstitute = 3,
        [Description("قرض الحسنه")]
        GharzAlHasaneh = 4,
        [Description("دولتي")]
        Governmental = 2,
        [Description("خصوصي")]
        Private = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmBaseInfoChangeType")]
    public enum BaseInfoChangeType
    {
        [Description("تفکيک")]
        Breaking = 2,
        [Description("تبديل")]
        ChangeName = 3,
        [Description("ادغام")]
        Merger = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmCalcFuncType")]
    public enum CalcFuncType
    {
        [Description("تابع محاسبه کننده چند قلم/ستون")]
        CalcMultiFieldColumn = 2,
        [Description("تابع محاسبه کننده فقط يک قلم/ستون")]
        CalcOneFieldColumn = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmCartableActivationMethod")]
    public enum CartableActivationMethod
    {
        [Description("رخدادي")]
        Event = 2,
        [Description("عادي")]
        Normal = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmCartableCategory")]
    public enum CartableCategory
    {
        [Description("اطلاعي")]
        Notify = 2,
        [Description("اقدامي")]
        Perform = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmCaseMechanizeState")]
    public enum CaseMechanizeState
    {
        [Description("مکانيزه")]
        Mechanize = 1,
        [Description("غير مکانيزه")]
        NonMechanize = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmCaseOwner")]
    public enum CaseOwner
    {
        [Description("متعلق به پرونده ديگر")]
        OwnerOtherCase = 2,
        [Description("متعلق به همين پرونده")]
        OwnerThisCase = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmCasePersonOtherDataType")]
    public enum CasePersonOtherDataType
    {
        [Description("داراي مقادير پيش فرض")]
        HaveLookup = 1,
        [Description("بدون مقادير پيش فرض")]
        HaveNotLookup = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmCaseStatisticState")]
    public enum CaseStatisticState
    {
        [Description("جاري")]
        Active = 1,
        [Description("مختومه")]
        Dismantled = 9,
        [Description("توقف عمليات اجرايي از طرف واحد قضايي")]
        EnmStopByJudge = 7,
        [Description("توقف از طرف بستانکار")]
        StopByCreditor = 5,
        [Description("")]
        None = 0
    }
    [Description("EnmCaseSubject")]
    public enum CaseSubject
    {
        [Description("جرائم اطفال")]
        BabyAccuse = 4,
        [Description("دعاوي ديوان عدالت اداري")]
        DivanEdalatPetition = 7,
        [Description("جرائم موضوع صلاحيت دادگاه انقلاب")]
        EnghelabAccuse = 5,
        [Description("دعاوي خانواده")]
        FamilyPetition = 3,
        [Description("جرائم عمومي کيفري")]
        GeneralAccuse = 1,
        [Description("دعاوي عمومي حقوقي")]
        GeneralCivil = 2,
        [Description("تخلفات انتظامي قضات")]
        JudgeAccuse = 9,
        [Description("جرائم نظامي")]
        MilitaryAccuse = 8,
        [Description("جرائم موضوع صلاحيت دادگاه کيفري استان")]
        OstanAccuse = 6,
        [Description("")]
        None = 0
    }
    [Description("EnmCaseWealthChangeState")]
    public enum CaseWealthChangeState
    {
        [Description("تاييد شده")]
        Confirmed = 1,
        [Description("تاييد نشده")]
        NotConfirmed = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmCaseWealthState")]
    public enum CaseWealthState
    {
        [Description("مال بابت طلب به نفع بستانکار ضبط شده")]
        Concede = 5,
        [Description("وجود مال متعلق به بدهکار تاييد شده")]
        Confirm = 2,
        [Description("مال به خريدار تحويل داده شد")]
        Deliver2Buyer = 12,
        [Description("مال به بدهکار تحويل داده شد")]
        Deliver2Debtor = 13,
        [Description("مال به موجر تحويل داده شد")]
        Deliver2Lessor = 17,
        [Description("مال به بستانکار تحويل داده شد")]
        DeliverCreditor = 14,
        [Description("مال بازداشت شده")]
        Detention = 3,
        [Description("مال به فروش رفته به نفع بستانکار")]
        GoingToSell = 4,
        [Description("معرفي شده ولي تاييد نشده")]
        IntroducedNotConfirm = 1,
        [Description("رفع بازداشت با دستور تمام قضايي")]
        ReleaseByCourtOrders = 16,
        [Description("رفع بازداشت به تقاضاي بستانکار")]
        ReleaseByCreditorDemands = 15,
        [Description("رفع بازداشت مال به دليل تسويه حساب بدهکار")]
        ReleasePony = 6,
        [Description("توقف عمليات در مورد مال به حکم دادگاه")]
        StopByJudge = 7,
        [Description("")]
        None = 0
    }
    [Description("EnmCertificateType")]
    public enum CertificateType
    {
        [Description("گواهي قطعيت دادنامه")]
        JudgmentFinalCertificate = 2,
        [Description("گواهي ماده 212 قانون آيين دادرسي مدني")]
        Law212Certificate = 3,
        [Description("گواهي اقامه دعوا در دادگاه صالحه")]
        ProceedingsCertificate = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmCertification")]
    public enum Certification
    {
        [Description("گواهي مي شود")]
        Certification = 1,
        [Description("گواهي نمي شود")]
        NonCertification = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmChangedFiledDataType")]
    public enum ChangedFiledDataType
    {
        [Description("ExcelFIle")]
        ExcelFile = 5,
        [Description("تصوير")]
        ImageField = 3,
        [Description("MHTFile")]
        MHTFile = 6,
        [Description("عددي")]
        Numerical = 1,
        [Description("PDFFile")]
        PDFFile = 7,
        [Description("RARFile")]
        RARFile = 8,
        [Description("متني ساده")]
        SimpleText = 2,
        [Description("WordFile")]
        WordFile = 4,
        [Description("ZIPFile")]
        ZIPFile = 9,
        [Description("")]
        None = 0
    }
    [Description("EnmCheckNatinalityStatus")]
    public enum CheckNatinalityStatus
    {
        [Description("اطلاعات با ثبت احوال چک شد و معتبر بود")]
        Confirm = 1,
        [Description("اطلاعات با ثبت احوال راستي آزمايي نشده است")]
        NotChecked = 2,
        [Description("اطلاعات مورد تاييد ثبت احوال نبود")]
        Refuse = 3,
        [Description("منتظر بررسي مدير سيستم")]
        Wait4Check = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmCLPUserState")]
    public enum CLPUserState
    {
        [Description("تاييد شده و فعال")]
        Active = 2,
        [Description("غير فعال")]
        InActive = 3,
        [Description("تعريف شده و تاييد نشده")]
        NotConfirm = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmCMSEMailStatus")]
    public enum CMSEMailStatus
    {
        [Description("عدم توانايي براي رساندن به مقصد")]
        CanNotReceive = 5,
        [Description("ارسال نشده")]
        NotSended = 1,
        [Description("به مقصد رسيده")]
        Receive = 3,
        [Description("ارسال شده و منتظر اولين پاسخ")]
        Sended = 5,
        [Description("منتظر مانده")]
        Wait = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmCMSSMSStatus")]
    public enum CMSSMSStatus
    {
        [Description("عدم توانايي براي رساندن به مقصد")]
        CanNotReceive = 5,
        [Description("ارسال نشده")]
        NotSended = 1,
        [Description("به مقصد رسيده")]
        Receive = 3,
        [Description("ارسال شده")]
        Sended = 2,
        [Description("منتظر مانده")]
        Wait = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmCommandType")]
    public enum CommandType
    {
        [Description("حذف")]
        Delete = 3,
        [Description("درج")]
        Insert = 1,
        [Description("حذف در ساير نرم افزارها")]
        OtherSoftwareDelete = 6,
        [Description("درج در ساير نرم افزارها")]
        OtherSoftwareInsert = 4,
        [Description("به روزرساني در ساير نرم افزارها")]
        OtherSoftwareUpdate = 5,
        [Description("به روز رساني")]
        Update = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmCompetentAuthority")]
    public enum CompetentAuthority
    {
        [Description("قضايي مكانيزه")]
        Justic = 1,
        [Description("غيرقضايي ")]
        NonJustic = 2,
        [Description("قضايي غير مكانيزه")]
        NonMechanizeJustic = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmConditionAffect")]
    public enum ConditionAffect
    {
        [Description("فقط خواندني")]
        ReadOnly = 1,
        [Description("غيرقابل رويت")]
        UnVisible = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmConditionParameterType")]
    public enum ConditionParameterType
    {
        [Description("")]
        None = 0
    }
    [Description("EnmConfirmerNoticeState")]
    public enum ConfirmerNoticeState
    {
        [Description("صحت عمليات ابلاغ تاييد شده است")]
        Confirm = 1,
        [Description("هنوز نظري داده نشده است")]
        NoOpinion = 3,
        [Description("صحت عمليات ابلاغ تاييد نشده است")]
        Refuse = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmContextVariableType")]
    public enum ContextVariableType
    {
        [Description("لايه بودجه اي جاري")]
        CurrentBudgetPhase = 3,
        [Description("سال بودجه اي جاري")]
        CurrentBudgetYear = 2,
        [Description("کاربر بهمراه سمت جاري")]
        CurrentRegisterUser = 4,
        [Description("واحد جاري")]
        CurrentUnit = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmConvictionState")]
    public enum ConvictionState
    {
        [Description("در حال انجام")]
        Active = 1,
        [Description("خاتمه يافته")]
        Passive = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmCourtType")]
    public enum CourtType
    {
        [Description("دادگاه تجديد نظر")]
        AmendmentCourt = 8,
        [Description("دادگاه عمومي بخش")]
        BakhshCourt = 13,
        [Description("بازپرسي")]
        Bazpors = 3,
        [Description("دادگاه كيفري")]
        CriminalCourt = 6,
        [Description("واحد اظهار نظر")]
        CriminalRemark = 2,
        [Description("دادستاني")]
        Dadsetan = 4,
        [Description("دادياري تحقيق")]
        Dadyar = 7,
        [Description("دادياري سرپرستي")]
        DadyariSarparsti = 12,
        [Description("شوراي حل اختلاف")]
        DiscordCouncilResolve = 10,
        [Description("اجراي احکام شورا")]
        ExecuteDiscordCouncilResolve = 15,
        [Description("واحد اجراي احكام مدني")]
        ExecutorCivil = 11,
        [Description("واحد اجراي احكام كيفري")]
        ExecutorCriminal = 1,
        [Description("کشيک دادگاه")]
        KeskikDadgah = 17,
        [Description("کشيک دادسرا")]
        KeskikDadsara = 16,
        [Description("دادگاه حقوقي")]
        LegalCourt = 5,
        [Description("دادگاه كيفري استان")]
        OstanCriminal = 14,
        [Description("شعبه ديوانعالي كشور")]
        SupremeCourt = 9,
        [Description("")]
        None = 0
    }
    [Description("EnmCrimes")]
    public enum Crimes
    {
        [Description("مباشرت در قاچاق کالاي ورودي")]
        E01stewardshipIncomingGoods = 1,
        [Description("مباشرت در قاچاق کالاي خروجي")]
        E02stewardshipOutgoingGoods = 2,
        [Description("مباشرت در حمل کالاي قاچاق")]
        E03stewardshipGoodsTranspotation = 3,
        [Description("مباشرت در نگهداري کالاي قاچاق")]
        E04stewardshipGoodsKeeping = 4,
        [Description("مباشرت در ارتکاب تخلفات موضوع تبصره 4 ماده 18 قانون مبارزه با قاچاق کالا و ارز(خريد،فروش،حمل، نگهداري کالاهاي موضوع قاچاق)")]
        E05stewardshipGoodsArticle18 = 5,
        [Description("مباشرت در نگهداري،عرضه يا فروش کالا و ارز قاچاق توسط واحدهاي صنفي يا صرافي ها")]
        E06stewardshipGoodsExchange = 6,
        [Description("مباشرت در قاچاق ارز ورودي")]
        E07stewardshipIncomingCurrency = 7,
        [Description("مباشرت در قاچاق ارز خروجي")]
        E08stewardshipOutgoingCurrency = 8,
        [Description("مباشرت در حمل ارز قاچاق")]
        E09stewardshipCurrencyTranspotation = 9,
        [Description("مباشرت در نگهداري ارز قاچاق")]
        E10stewardshipCurrencyKeeping = 10,
        [Description("مباشرت در خريد،فروش، حواله ارز")]
        E11stewardshipCurrencyُSelling = 11,
        [Description("معاونت در قاچاق کالاي ورودي")]
        E12AssistanceIncomingGoods = 12,
        [Description("معاونت در قاچاق کالاي خروجي")]
        E13AssistanceOutgoingGoods = 13,
        [Description("معاونت در حمل کالاي قاچاق")]
        E14AssistanceGoodsTranspotation = 14,
        [Description("معاونت در نگهداري کالاي قاچاق")]
        E15AssistanceGoodsKeeping = 15,
        [Description("معاونت در ارتکاب تخلفات موضوع تبصره 4 ماده 18 قانون مبارزه با قاچاق کالا و ارز(خريد،فروش،حمل، نگهداري کالاهاي موضوع قاچاق)")]
        E16AssistanceGoodsArticle18 = 16,
        [Description("معاونت در نگهداري،عرضه يا فروش کالا و ارز قاچاق توسط واحدهاي صنفي يا صرافي ها")]
        E17AssistanceGoodsExchange = 17,
        [Description("معاونت در قاچاق ارز ورودي")]
        E18AssistanceIncomingCurrency = 18,
        [Description("معاونت در قاچاق ارز خروجي")]
        E19AssistanceOutgoingCurrency = 19,
        [Description("معاونت در حمل ارز قاچاق")]
        E20AssistanceCurrencyTranspotation = 20,
        [Description("معاونت در نگهداري ارز قاچاق")]
        E21AssistanceCurrencyKeeping = 21,
        [Description("معاونت در خريد،فروش،حواله ارز")]
        E22AssistanceCurrencyُSelling = 22,
        [Description("مشارکت در قاچاق کالاي ورودي")]
        E23participationIncomingGoods = 23,
        [Description("مشارکت در قاچاق کالاي خروجي")]
        E24participationOutgoingGoods = 24,
        [Description("مشارکت در حمل کالاي قاچاق")]
        E25participationGoodsTranspotation = 25,
        [Description("مشارکت در نگهداري کالاي قاچاق")]
        E26participationGoodsKeeping = 26,
        [Description("مشارکت در ارتکاب تخلفات موضوع تبصره 4 ماده 18 قانون مبارزه با قاچاق کالا و ارز(خريد،فروش،حمل، نگهداري کالاهاي موضوع قاچاق)")]
        E27participationGoodsArticle18 = 27,
        [Description("مشارکت در نگهداري،عرضه يا فروش کالا و ارز قاچاق توسط واحدهاي صنفي يا صرافي ها")]
        E28participationGoodsExchange = 28,
        [Description("مشارکت در قاچاق ارز ورودي")]
        E29participationIncomingCurrency = 29,
        [Description("مشارکت در قاچاق ارز خروجي")]
        E30participationOutgoingCurrency = 30,
        [Description("مشارکت در حمل ارز قاچاق")]
        E31participationCurrencyTranspotation = 31,
        [Description("مشارکت در نگهداري ارز قاچاق")]
        E32participationCurrencyKeeping = 32,
        [Description("مشارکت در خريد،فروش، حواله ارز")]
        E33participationCurrencyُSelling = 33,
        [Description("ساير")]
        E34Others = 34,
        [Description("")]
        None = 0
    }
    [Description("EnmDatapreparationStatus")]
    public enum DatapreparationStatus
    {
        [Description("داده آمايي شده")]
        Dataprepared = 1,
        [Description("نيمه داده آمايي شده")]
        HalfDataPrepared = 3,
        [Description("داده آمايي نشده")]
        UnDataprepared = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmDayNight")]
    public enum DayNight
    {
        [Description("روز")]
        Day = 1,
        [Description("شب")]
        Night = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmDeclarationPost")]
    public enum DeclarationPost
    {
        [Description("مخاطب")]
        Addressed = 2,
        [Description("نماينده اظهارکننده")]
        Agent = 3,
        [Description("اظهارکننده")]
        Utterer = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmDisplayMode")]
    public enum DisplayMode
    {
        [Description("محاسباتي فقط خواندني")]
        CalcReadOnly = 4,
        [Description("قابل ويرايش")]
        Editable = 1,
        [Description("غير قابل رويت")]
        Hidden = 3,
        [Description("فقط خواندني")]
        Readonly = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmDocumentType")]
    public enum DocumentType
    {
        [Description("مكانيزه")]
        Mechanize = 1,
        [Description("پويشي")]
        Scan = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmDrawing")]
    public enum Drawing
    {
        [Description("انجام شود")]
        Do = 1,
        [Description("انجام نــشود")]
        DoNot = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmDueDateStatus")]
    public enum DueDateStatus
    {
        [Description("انجام شده")]
        Done = 2,
        [Description("انجام نشده")]
        NotDone = 1,
        [Description("تجديد شده")]
        Repeated = 3,
        [Description("ابطال شده")]
        Revocation = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmECMAccessType")]
    public enum ECMAccessType
    {
        [Description("هم خواندن هم نگارش جديد گذاشتن")]
        ChangeVersion = 2,
        [Description("فقط خواندني")]
        ReadOnly = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmECMFileType")]
    public enum ECMFileType
    {
        [Description("Excel")]
        Excel = 3,
        [Description("فيلم")]
        Film = 4,
        [Description("تصوير")]
        Image = 1,
        [Description("ساير")]
        OtherType = 99,
        [Description("Word")]
        Word = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmECMFItemType")]
    public enum ECMFItemType
    {
        [Description("زمان")]
        DateTimeType = 5,
        [Description("تاريخ")]
        DateType = 3,
        [Description("عددي")]
        NumberType = 2,
        [Description("رشته اي")]
        StringType = 1,
        [Description("ساعت")]
        TimeType = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmECMSecurityType")]
    public enum ECMSecurityType
    {
        [Description("محتواي اختصاصي")]
        PrivateContent = 1,
        [Description("محتواي عمومي")]
        PublicContent = 3,
        [Description("محتواي اشتراکي")]
        ShareContent = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmERequestManType")]
    public enum ERequestManType
    {
        [Description("نماينده")]
        Agent = 4,
        [Description("قيم")]
        Ghayyem = 2,
        [Description("وکيل")]
        Lawyer = 3,
        [Description("وصي")]
        Vasi = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmErrorRelatedGroup")]
    public enum ErrorRelatedGroup
    {
        [Description("تحليل گر")]
        Analyst = 2,
        [Description("طراح")]
        Designer = 3,
        [Description("برنامه نويس")]
        Programmer = 4,
        [Description("آموزش")]
        Tutorial = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmErrorState")]
    public enum ErrorState
    {
        [Description("انجام شد   ")]
        IsDone = 1,
        [Description("خطا وارد نيست")]
        NotAcceptedError = 4,
        [Description("انجام نشد  ")]
        NotDone = 2,
        [Description("در حال انجام  ")]
        UnderDevelope = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmEstateInputOutput")]
    public enum EstateInputOutput
    {
        [Description("وارده")]
        Input = 1,
        [Description("صادره")]
        Output = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmEventAction")]
    public enum EventAction
    {
        [Description("توقف فرآيند ")]
        Close = 4,
        [Description("انجام  ")]
        Done = 2,
        [Description("هيچكدام      ")]
        NoEvent = 5,
        [Description("تعليق فرآيند ")]
        Pause = 3,
        [Description("ادامه فرآيند   ")]
        Resume = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmEventRegisterationEffect")]
    public enum EventRegisterationEffect
    {
        [Description("عدم توقف و منتظر رخداد")]
        ProcessWait = 2,
        [Description("توقف و منتظر رخداد")]
        StopWait = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmEventState")]
    public enum EventState
    {
        [Description("واقع شده")]
        Done = 1,
        [Description("برگشت داده شده")]
        StepBacked = 3,
        [Description(" منتظر رخداد")]
        Wait = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmExpEmployeeType")]
    public enum ExpEmployeeType
    {
        [Description("کارشناس مرکز مشاورين قوه قضاييه")]
        AdvisorJudiciary = 3,
        [Description("مامور اجرا")]
        ExecutiveAgent = 4,
        [Description("خبره محلي-غيررسمي")]
        LocalExpert = 2,
        [Description("رسمي ")]
        Official = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmExperisionRunType")]
    public enum ExperisionRunType
    {
        [Description("تابع محاسبه کننده")]
        DLLType = 2,
        [Description("عبارت رياضي محاسبه ستون")]
        ExperisionType = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmExpertState")]
    public enum ExpertState
    {
        [Description("مشغول به كار")]
        Busy = 3,
        [Description("اتمام كار")]
        FinishJob = 4,
        [Description("مرخصي ")]
        Leave = 1,
        [Description("تعليق ")]
        Suspend = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmFichePaymentForType")]
    public enum FichePaymentForType
    {
        [Description("هزينه کارشناسي")]
        ExpertCost = 1,
        [Description("هزينه دادرسي")]
        JudgmentCost = 2,
        [Description("خسارت احتمالي")]
        LikelyDamage = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmFichePersonType")]
    public enum FichePersonType
    {
        [Description("شخص دخيل در پرونده")]
        CasePerson = 1,
        [Description("شخص دخيل در دادخواست  ")]
        PetitionPerson = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmFieldDataType")]
    public enum FieldDataType
    {
        [Description("متني")]
        Char = 1,
        [Description("عدد صحيح")]
        Integer = 2,
        [Description("عدد اعشاري")]
        Number = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmFileExtension")]
    public enum FileExtension
    {
        [Description("بي ام پي")]
        BMP = 12,
        [Description("ورد")]
        DOC = 5,
        [Description("ورد دوهزاروهفت به بالا")]
        DOCX = 6,
        [Description("گيف")]
        GIF = 10,
        [Description("جي پي اي چي")]
        JPEG = 11,
        [Description("جي پي  جي")]
        JPG = 3,
        [Description("پي دي اف")]
        PDF = 1,
        [Description("پي ان جي")]
        PNG = 4,
        [Description("فشرده يک")]
        RAR = 13,
        [Description("تيف")]
        TIF = 9,
        [Description("تيفف")]
        TIFF = 2,
        [Description("اکسل")]
        XLS = 7,
        [Description("اکسل دوهزاروهفت به بالا")]
        XLSX = 8,
        [Description("فشرده دو")]
        ZIP = 14,
        [Description("")]
        None = 0
    }
    [Description("EnmFinger")]
    public enum Finger
    {
        [Description("انگشت شست دست راست")]
        Finger1 = 1,
        [Description("انگشت كوچك دست چپ")]
        Finger10 = 10,
        [Description("انگشت اشاره دست راست")]
        Finger2 = 2,
        [Description("انگشت وسط دست راست")]
        Finger3 = 3,
        [Description("انگشت انگشتري دست راست")]
        Finger4 = 4,
        [Description("انگشت كوچك دست راست")]
        Finger5 = 5,
        [Description("انگشت شست دست چپ")]
        Finger6 = 6,
        [Description("انگشت اشاره دست چپ")]
        Finger7 = 7,
        [Description("انگشت وسط دست چپ")]
        Finger8 = 8,
        [Description("انگشت انگشتري دست چپ")]
        Finger9 = 9,
        [Description("")]
        None = 0
    }
    [Description("EnmFrmBudgetType")]
    public enum FrmBudgetType
    {
        [Description("محاسباتي")]
        CalculationForm = 2,
        [Description("وروداطلاعات توسط کاربر")]
        DataEntryForm = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmGeneralOrganizationType")]
    public enum GeneralOrganizationType
    {
        [Description("شعب دادگاه")]
        JudiciaryUnit = 2,
        [Description("شعب ناجا")]
        NAJAUnit = 3,
        [Description("ساير سازمانها")]
        OtherOrganization = 4,
        [Description("واحدهاي سازمان ثبت")]
        SSAAOrganization = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmGroupControlType")]
    public enum GroupControlType
    {
        [Description("گروه فيلد")]
        GroupBoxControl = 2,
        [Description("زبونه")]
        PageControl = 1,
        [Description("جدول")]
        TableSheet = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmHaveAttachment")]
    public enum HaveAttachment
    {
        [Description("پيوست مي باشد")]
        HaveAttachment = 1,
        [Description("پيوست نمي باشد")]
        HaveNotAttachment = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmHaveNoHave")]
    public enum HaveNoHave
    {
        [Description("دارد")]
        Have = 2,
        [Description("ندارد")]
        NotHave = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmHistoryType")]
    public enum HistoryType
    {
        [Description("غير كامپيوتري")]
        Manual = 1,
        [Description("كامپيوتري")]
        Systematic = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmHolidayKind")]
    public enum HolidayKind
    {
        [Description("تعطيل رسمي")]
        Holiday = 2,
        [Description("تعطيل غيررسمي")]
        UnFormalHoliday = 3,
        [Description("روز کاري")]
        Work = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmHowCalcItem")]
    public enum HowCalcItem
    {
        [Description("محاسبه با شرط از طريق ساير اقلام رکورد جاري")]
        CalcWithCond = 3,
        [Description("محاسبه بدون شرط از طريق ساير اقلام رکورد جاري")]
        CalcWithoutCond = 2,
        [Description("محاسبه از طريق تابع محاسبه کننده")]
        FunctionCalc = 4,
        [Description("محاسبه از طريق توابع محاسبه کننده در هنگام بارگزاري و ذخيره سازي")]
        LoadSaveFunctionCalc = 5,
        [Description("ورود اطلاعات توسط کاربر")]
        UserInput = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmHowNotified")]
    public enum HowNotified
    {
        [Description("توسط اداره پست")]
        ByPost = 1,
        [Description("بوسيله رايانامه")]
        EMail = 4,
        [Description("به وسيله آگهي در روزنامه")]
        NewspaperNotice = 3,
        [Description("توسط مامور ابلاغ")]
        OfficerNotified = 10,
        [Description("")]
        None = 0
    }
    [Description("EnmHowToMakeEvent")]
    public enum HowToMakeEvent
    {
        [Description("دستي")]
        Manual = 2,
        [Description("مکانيزه")]
        Mechanize = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmHstInsertState")]
    public enum HstInsertState
    {
        [Description("گزارش بر اساس سوابق داده آمايي شده")]
        DataPreparationState = 1,
        [Description("گزارش بر اساس سوابق مکانيزه")]
        MechanizeState = 2,
        [Description("گزارش کلي سوابق")]
        TotalState = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmIncomingLetterState")]
    public enum IncomingLetterState
    {
        [Description("ارجاع/ارسال شده به کاربر")]
        ReferByMngSecret = 4,
        [Description("ثبت شده")]
        Registered = 1,
        [Description("برگشت داده شده به ثبت کننده")]
        Return = 3,
        [Description("برگشت داده شده به مدير")]
        ReturnToMng = 5,
        [Description("رويت شده")]
        View = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmIncommingLetterSenderType")]
    public enum IncommingLetterSenderType
    {
        [Description("شخص پرونده")]
        CasePerson = 1,
        [Description("واحد ثبتي")]
        SabtUnit = 2,
        [Description("از فهرست فرستنده ها")]
        SendersInList = 3,
        [Description("تايپ نام فرستنده")]
        SendersNotInList = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmIndividualPersonType")]
    public enum IndividualPersonType
    {
        [Description("وكيل")]
        Lawyer = 3,
        [Description("حقوقي           ")]
        Legal = 2,
        [Description("حقيقي بجز وكيل")]
        NaturalPerson = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmInvisibleDisable")]
    public enum InvisibleDisable
    {
        [Description("غير فعال")]
        Disable = 1,
        [Description("غير قابل رويت")]
        Invisible = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmIsBaseRole")]
    public enum IsBaseRole
    {
        [Description("نقش پايه اي")]
        Base = 1,
        [Description("نقش پستي")]
        Post = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmIsDone")]
    public enum IsDone
    {
        [Description("انجام شد")]
        Done = 1,
        [Description("انجام نشد")]
        NotDone = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmIsReplay")]
    public enum IsReplay
    {
        [Description("دارد ")]
        Have = 1,
        [Description("ندارد ")]
        NotHave = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmIssueDocTime")]
    public enum IssueDocTime
    {
        [Description("بعد از دريافت وجه از شخص")]
        AfterGetMoney = 2,
        [Description("قبل از دريافت وجه از شخص")]
        BeforeGetMoney = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmJOperandType")]
    public enum JOperandType
    {
        [Description("عملوند مروبط به ستون اطلاعات پايه")]
        BaseInfoColumn = 4,
        [Description("عدد ثابت")]
        NumericalConstant = 2,
        [Description("عملوند عددي از جنس قلم اطلاعاتي فرم")]
        NumericalField = 1,
        [Description("عملوند عددي از جنس جمع ستون عددي")]
        SumNumericColumn = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmJudgementType")]
    public enum JudgementType
    {
        [Description("محکوميت")]
        Condemnation = 1,
        [Description("برائت")]
        Innocence = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmJudgeScriptoriumActivityReport")]
    public enum JudgeScriptoriumActivityReport
    {
        [Description("اسناد رسمي")]
        AsnadRasmi = 4,
        [Description("ازدواج")]
        Ezdevaj = 6,
        [Description("ازدواج و طلاق")]
        EzdevajTalag = 5,
        [Description("اداره کل")]
        HighOffice = 1,
        [Description("تعداد کل")]
        Jam = 3,
        [Description("موضوع راي/قرارنهايي")]
        JudgeType = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmJudgeScriptoriumPostTypeReport")]
    public enum JudgeScriptoriumPostTypeReport
    {
        [Description("دفتريار اول")]
        DaftarYarAval = 5,
        [Description("دفتريار دوم")]
        DaftarYarDovom = 6,
        [Description("اداره کل")]
        HighOffice = 1,
        [Description("تعداد کل")]
        Jam = 3,
        [Description("موضوع راي/قرارنهايي")]
        JudgeType = 2,
        [Description("کفيل دفتريار")]
        KafilDaftarYar = 7,
        [Description("کفيل سردفتر")]
        KafilSardaftar = 8,
        [Description("سردفتر")]
        Sardaftar = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmJudiciaryUnitType")]
    public enum JudiciaryUnitType
    {
        [Description("شعبه")]
        Court = 3,
        [Description("دادگاه عمومي و انقلاب")]
        Dadgah = 8,
        [Description("دادسراي عمومي و انقلاب")]
        Dadsara = 7,
        [Description("اداره كل دادگستري استان")]
        HeadOffice = 20,
        [Description("مجتمع قضايي")]
        JudicialComplex = 5,
        [Description("حوزه قضايي")]
        JuratoryArea = 9,
        [Description("سازمان قضايي")]
        OrganizationJudge = 30,
        [Description("شوراي حل اختلاف")]
        Shora = 6,
        [Description("")]
        None = 0
    }
    [Description("EnmKeepPricePeriod")]
    public enum KeepPricePeriod
    {
        [Description("روزانه")]
        Daily = 2,
        [Description("ماهانه")]
        Monthly = 4,
        [Description("بطور يکجا")]
        OverAll = 1,
        [Description("هفتگي")]
        Weekly = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmKindsOfNoticePeople")]
    public enum KindsOfNoticePeople
    {
        [Description("ورثه")]
        Heirs = 3,
        [Description("حقوقي")]
        Legal = 2,
        [Description("حقيقي")]
        Natural = 1,
        [Description("حقيقي/حقوقي")]
        NaturalOrLegal = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmLAdductor")]
    public enum LAdductor
    {
        [Description("شرکت")]
        Company = 3,
        [Description("طرف مقابل")]
        OtherPerson = 2,
        [Description("سازمان")]
        OurOrg = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmLargeFieldTextSaveType")]
    public enum LargeFieldTextSaveType
    {
        [Description("Html")]
        HtmlType = 1,
        [Description("RTF")]
        RTFType = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmLastExecuteStatus")]
    public enum LastExecuteStatus
    {
        [Description("اجرا شده")]
        Executed = 3,
        [Description("در حين اجرا به خطا برخورده كرده")]
        Failed = 2,
        [Description("اجرا نشده")]
        NotExecuted = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmLawyerDegree")]
    public enum LawyerDegree
    {
        [Description("مشاور درجه 1")]
        FirstClassConcultant = 2,
        [Description("وكيل پايه 1 دادگستري")]
        FirstClassLawyer = 1,
        [Description("كارآموز وكالت")]
        LearningClassConcultant = 4,
        [Description("مشاور درجه 2")]
        SecondClassConcultant = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmLawyerState")]
    public enum LawyerState
    {
        [Description("فوت شده")]
        Dead = 5,
        [Description("ابطال پروانه")]
        DisproofLicense = 2,
        [Description("توديع پروانه")]
        GiveBackLicense = 6,
        [Description("بازنشسته شده")]
        Retired = 4,
        [Description("معلق شده")]
        Suspension = 3,
        [Description("مشغول به كار")]
        Work = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmLawyerTypeLicense")]
    public enum LawyerTypeLicense
    {
        [Description("مركز مشاورين قوه قضاييه")]
        AdvisorJudicature = 2,
        [Description("كانون وكلاء دادگستري")]
        LawyerBand = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmLegalPersonType")]
    public enum LegalPersonType
    {
        [Description("حكومتي")]
        Government = 2,
        [Description("غيردولتي(خصوصي/تعاوني(")]
        NonState = 4,
        [Description("عمومي غير دولتي")]
        Public = 3,
        [Description("دولتي")]
        State = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmLetterAttachmentType")]
    public enum LetterAttachmentType
    {
        [Description("مدرک مکانيزه")]
        Mechanize = 1,
        [Description("سند يا پيوست غيرمکانيزه")]
        NonMechanize = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmLetterBetweenOrgState")]
    public enum LetterBetweenOrgState
    {
        [Description("ارسال نشده")]
        NotSend = 1,
        [Description("دريافت شده")]
        Receive = 3,
        [Description("ارجاع داده شده")]
        Refer = 5,
        [Description("برگشت داده شده")]
        Return = 6,
        [Description("ارسال شده")]
        Sended = 2,
        [Description("رويت شده")]
        View = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmLetterType")]
    public enum LetterType
    {
        [Description("رونوشت نامه")]
        Copy = 2,
        [Description("اصل نامه   ")]
        Letter = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmLNationality")]
    public enum LNationality
    {
        [Description("غير ايراني")]
        Foreign = 2,
        [Description("ايراني")]
        Iranian = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmLOBFieldType")]
    public enum LOBFieldType
    {
        [Description("BLOB RTF")]
        BLOB_RTFType = 5,
        [Description("BLOB SimpleText")]
        BLOB_SimpleText = 4,
        [Description("CLOB RTF")]
        CLOB_RTFType = 2,
        [Description("CLOB SimpleText")]
        CLOB_SimpleText = 1,
        [Description("Image")]
        ImageType = 3,
        [Description("ساير")]
        OtherBLOBType = 6,
        [Description("")]
        None = 0
    }
    [Description("EnmLocationType")]
    public enum LocationType
    {
        [Description("شهر")]
        City = 5,
        [Description("كشور")]
        Country = 1,
        [Description("دهستان")]
        Part = 6,
        [Description("شهرستان")]
        Province = 3,
        [Description("بخش")]
        Section = 4,
        [Description("استان_ايالت")]
        State = 2,
        [Description("ده")]
        Village = 7,
        [Description("")]
        None = 0
    }
    [Description("EnmLookupShowType")]
    public enum LookupShowType
    {
        [Description("کد و عنوان با هم")]
        CodeAndTitle = 1,
        [Description("فقط کد")]
        CodeOnly = 3,
        [Description("فقط عنوان")]
        TitleOnly = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmLpmsNCodeInquiryType")]
    public enum LpmsNCodeInquiryType
    {
        [Description("استعلام بر اساس نام فعال")]
        InquiryByActiveFullName = 2,
        [Description("استعلام بر اساس سوابق نام")]
        InquiryByArchiveFullName = 3,
        [Description("استعلام بر اساس شناسه ملي")]
        InquiryByNationalCode = 1,
        [Description("استعلام صحت شناسه ملي")]
        InquiryValidateNationalCode = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmLReligion")]
    public enum LReligion
    {
        [Description("اسلام")]
        Muslim = 1,
        [Description("غير اسلام")]
        NonMuslim = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmMainMinorTemplate")]
    public enum MainMinorTemplate
    {
        [Description("کليشه اصلي")]
        Main = 1,
        [Description("کليشه فرعي")]
        Miror = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmMarriageState")]
    public enum MarriageState
    {
        [Description("معيل")]
        HasWifeChild = 3,
        [Description("متاهل")]
        Married = 2,
        [Description("مجرد")]
        Single = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmMathOperator")]
    public enum MathOperator
    {
        [Description("تقسيم")]
        Division = 4,
        [Description("منها")]
        Minus = 2,
        [Description("ضرب")]
        Multiplication = 3,
        [Description("جمع")]
        Sum = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmMeasurementUnitType")]
    public enum MeasurementUnitType
    {
        [Description("مساحت")]
        Area = 2,
        [Description("طول")]
        Length = 1,
        [Description("پول")]
        Money = 3,
        [Description("ساير")]
        Other = 30,
        [Description("زمان")]
        Time = 4,
        [Description("حجم")]
        Voluminosity = 6,
        [Description("وزن")]
        Weight = 5,
        [Description("")]
        None = 0
    }
    [Description("EnmMechanizedFieldType")]
    public enum MechanizedFieldType
    {
        [Description("آبجکت جيسوني مدرک مکانيزه مربوطه که مدرک توسط کاربر مشخص مي شود")]
        JSON4Doc = 5,
        [Description("قلم اطلاعاتي که از مدرک مکانيزه مربوطه بصورت اتوماتيک مقداردهي مي شود بجز فايل چاپي مدرک")]
        MechanizedField = 4,
        [Description("فايل مدرک غيرمکانيزه")]
        NonMechanizedDocFile = 1,
        [Description("قلم اطلاعاتي غيرمکانيزه که بصورت دستي وارد مي شود بجز تصاوير و فايل ها")]
        NonMechanizedField = 3,
        [Description("فايل چاپي يک مدرک مکانيزه ذيل پرونده(يا مدرک اصلي مشابه آن) که مدرک توسط کاربر مشخص مي شود")]
        PrintFile4Doc = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmMechanizedLetterCaseLocation")]
    public enum MechanizedLetterCaseLocation
    {
        [Description("مقصد")]
        Destination = 2,
        [Description("مبداء")]
        Source = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmMechanizedLetterMainRcvOrTranscriptRcv")]
    public enum MechanizedLetterMainRcvOrTranscriptRcv
    {
        [Description("گيرنده اصل نامه")]
        MainReceiver = 1,
        [Description("رونوشت گيرنده")]
        TranscriptReceiver = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmMechanizedLetterOrgTypeReceiver")]
    public enum MechanizedLetterOrgTypeReceiver
    {
        [Description("هم درون سازماني هم برون سازماني")]
        InnerAndOuterOrg = 3,
        [Description("مخصوص درون سازماني")]
        InnerOrg = 1,
        [Description("مخصوص برون سازماني")]
        OuterOrg = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmMechanizedLetterReceiverType")]
    public enum MechanizedLetterReceiverType
    {
        [Description("درون سازماني")]
        InnerOrg = 1,
        [Description("برون سازماني")]
        OutterOrg = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmMechanizedLetterRelLetterGetType")]
    public enum MechanizedLetterRelLetterGetType
    {
        [Description("مکانيزه")]
        Mechanize = 2,
        [Description("دستي")]
        NonMechanize = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmMechanizedLetterRelType")]
    public enum MechanizedLetterRelType
    {
        [Description("بازگشت")]
        Comeback = 1,
        [Description("پيرو")]
        Follower = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmMechanizeLetterActionLevel")]
    public enum MechanizeLetterActionLevel
    {
        [Description("تأييد کننده")]
        Confimer = 3,
        [Description("تهيه کننده")]
        Creator = 1,
        [Description("ارجاع کننده")]
        Refferer = 4,
        [Description("ارسال کننده")]
        Sender = 2,
        [Description("رويت کننده")]
        Viewer = 5,
        [Description("")]
        None = 0
    }
    [Description("EnmMechanizeRefererType")]
    public enum MechanizeRefererType
    {
        [Description("سمت")]
        PostRole = 3,
        [Description("واحد سازماني")]
        Unit = 1,
        [Description("کاربر سامانه")]
        UserPost = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmMenuItemState")]
    public enum MenuItemState
    {
        [Description("غيرفعال")]
        Disable = 2,
        [Description("فعال")]
        Enable = 1,
        [Description("پنهان")]
        Hide = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmMessageForceType")]
    public enum MessageForceType
    {
        [Description("عادي")]
        Normal = 3,
        [Description("فوري")]
        Urgent = 2,
        [Description("خيلي فوري")]
        VeryUrgent = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmMessageRecieverType")]
    public enum MessageRecieverType
    {
        [Description("كاربر")]
        Employee = 1,
        [Description("واحد ثبتي ")]
        Unit = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmMessageSecurityType")]
    public enum MessageSecurityType
    {
        [Description("رييس واحد يا ناظر")]
        Boss = 2,
        [Description("مدير سيستم")]
        SystemManager = 3,
        [Description("ساير افراد")]
        Normal = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmMessageState")]
    public enum MessageState
    {
        [Description("ارسال نشده")]
        NotSend = 1,
        [Description("ارسال شده")]
        Sended = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmMethodType")]
    public enum MethodType
    {
        [Description("چک کننده")]
        CheckerType = 1,
        [Description("مقدار اوليه ده به جداول بودجه")]
        InitializationValueType = 2,
        [Description("چاپ کننده فرم بودجه اي")]
        PrintForm = 3,
        [Description("فقط خواندني کننده گروه")]
        ReadOnlyGroup = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmMilitaryState")]
    public enum MilitaryState
    {
        [Description("معافيت کفالت")]
        BailmentExemption = 3,
        [Description("خريد خدمت")]
        Buying = 5,
        [Description("معافيت تحصيلي")]
        EducationalExepmtion = 2,
        [Description("پايان خدمت")]
        Finished = 1,
        [Description("معافيت پزشکي")]
        MedicalExepmtion = 4,
        [Description("معافيت رهبري")]
        Rahbar = 6,
        [Description("")]
        None = 0
    }
    [Description("EnmMLetterSendTYpe")]
    public enum MLetterSendTYpe
    {
        [Description("ارجاع")]
        Refer = 1,
        [Description("بازگشت")]
        Return = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmMultiSessionPolicy")]
    public enum MultiSessionPolicy
    {
        [Description("شناسه کاربري با اين نوع نقش بتواند روي چند کامپيوتر بطور همزمان وصل شود")]
        Optimistic = 1,
        [Description("با اتصال يک شناسه کاربري با اين نوع نقش، ابتدا همه اتصالات قبلي روي ساير کامپيوترها قطع شده، سپس اين اتصال برقرار شود")]
        Pessimistic = 3,
        [Description("با اتصال يک شناسه کاربري با اين نوع نقش، پس از هشدار، همه اتصالات قبلي روي ساير کامپيوترها قطع شده، سپس اين اتصال برقرار شود")]
        SemiPessimistic = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmNAJAUnitType")]
    public enum NAJAUnitType
    {
        [Description("اداره صدور گذرنامه")]
        PassportOffice = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmNameSearchType")]
    public enum NameSearchType
    {
        [Description("ترکيب تمامي کلمات")]
        AndSearch = 2,
        [Description("مطابق عبارت وارد شده")]
        EqualSearch = 1,
        [Description("ترکيب تک تک کلمات")]
        OrSearch = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmNameState")]
    public enum NameState
    {
        [Description("تأييد ")]
        Confirm = 1,
        [Description("رد")]
        Reject = 2,
        [Description("رد نام به دليل رد درخواست تغيير/تاسيس")]
        RejectByRejectReq = 4,
        [Description("در انتظار بررسي")]
        WateingForCheking = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmNationalityType")]
    public enum NationalityType
    {
        [Description("اتباع بيگانه")]
        Foreign = 2,
        [Description("ايراني")]
        Iranian = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmNeedFollowUp")]
    public enum NeedFollowUp
    {
        [Description(" دارد ")]
        Have = 1,
        [Description(" ندارد ")]
        NoHave = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmNewspaperCertificateType")]
    public enum NewspaperCertificateType
    {
        [Description("الکترونيک - غيربرخط")]
        Offline = 3,
        [Description("الکترونيک - برخط")]
        Online = 2,
        [Description("چاپي")]
        Printed = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmNewspaperGroupLevel")]
    public enum NewspaperGroupLevel
    {
        [Description("گروه پرهزينه")]
        HighCostCategory = 2,
        [Description("گروه کم هزينه")]
        LowCostCategory = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmNewspaperPeriod")]
    public enum NewspaperPeriod
    {
        [Description("سالانه")]
        Annually = 9,
        [Description("روزنامه")]
        Daily = 1,
        [Description("ماهنامه")]
        Monthly = 5,
        [Description("پايگاه خبري")]
        NewsSite = 11,
        [Description("خبرگزاري")]
        Press = 10,
        [Description("فصلنامه")]
        Quarterly = 7,
        [Description("دو شماره در هفته")]
        TwoInWeek = 2,
        [Description("دو ماهنامه")]
        TwoMonthly = 6,
        [Description("دو فصلنامه")]
        TwoQuarterly = 8,
        [Description("دو هفته نامه")]
        TwoWeekly = 4,
        [Description("هفته نامه")]
        Weekly = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmNewspaperPrintArea")]
    public enum NewspaperPrintArea
    {
        [Description("سراسري")]
        InCountry = 1,
        [Description("استاني")]
        InOstan = 2,
        [Description("محلي")]
        Local = 4,
        [Description("منطقه اي")]
        Regional = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmNotaryActivityType")]
    public enum NotaryActivityType
    {
        [Description("ازدواج و طلاق")]
        Divorce = 2,
        [Description("اسناد رسمي")]
        Documents = 3,
        [Description("ازدواج")]
        Marriage = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmNotaryOccupationState")]
    public enum NotaryOccupationState
    {
        [Description("فوت")]
        Dead = 16,
        [Description("انفصال موقت")]
        Discharge = 2,
        [Description("انفصال دائم")]
        DischargeContinual = 12,
        [Description("سلب صلاحيت")]
        Disqualification = 11,
        [Description("مرخصي تحصيلي")]
        Education = 6,
        [Description("معذوريت از حضور در محل دفترخانه")]
        Excuse = 8,
        [Description("معافيت از اشتغال")]
        ExemptionWorking = 13,
        [Description("معلق")]
        Floating = 3,
        [Description("مرخصي استحقاقي خروج از کشور")]
        LeaveAbroad = 7,
        [Description("مرخصي استعلاجي")]
        LeaveSick = 5,
        [Description("مرخصي استحقاقي")]
        LeavrJustly = 4,
        [Description("لغو ابلاغ ماده 13")]
        LiftNotification13 = 16,
        [Description("لغو ابلاغ ماده 74")]
        LiftNotification74 = 14,
        [Description("مستعفي")]
        Resigned = 10,
        [Description("بازنشسته")]
        Retirement = 9,
        [Description("شاغل")]
        Working = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmNoticeFinalResult")]
    public enum NoticeFinalResult
    {
        [Description("ابلاغ حضوري")]
        DeliverdInPerson = 3,
        [Description("عودت از مرجع ابلاغ")]
        DoNotice = 1,
        [Description("مجهول است")]
        DonotNotice = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmNoticeResultType")]
    public enum NoticeResultType
    {
        [Description("قانوني")]
        LawNotice = 2,
        [Description("انجام نشده است")]
        NotDone = 9,
        [Description("واقعي")]
        RealNotice = 1,
        [Description("استنکاف")]
        Refusal = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmNotificationFieldBasicType")]
    public enum NotificationFieldBasicType
    {
        [Description("تاريخي")]
        DateType = 3,
        [Description("عددي")]
        NumberType = 1,
        [Description("رشته اي")]
        StringType = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmNotificationTypePersmission")]
    public enum NotificationTypePersmission
    {
        [Description("استان")]
        Province = 1,
        [Description("ستاد")]
        headquarters = 2,
        [Description("واحد ثبتي")]
        Unit = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmObjectSendState")]
    public enum ObjectSendState
    {
        [Description("ارسال نشده")]
        NotSend = 1,
        [Description("ارسال شده")]
        Sended = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmOperandType")]
    public enum OperandType
    {
        [Description(" ثابت")]
        ConstantValue = 2,
        [Description("قلم اطلاعاتي و متغيرهاي محيطي")]
        DataItem = 1,
        [Description("پارامتر")]
        Parameter = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmOperatorType")]
    public enum OperatorType
    {
        [Description("مساوي")]
        Equal = 4,
        [Description("بزرگتر")]
        Greater = 1,
        [Description("بزرگتر يا مساوي")]
        GreaterOrEqual = 2,
        [Description("پس شباهت")]
        LastWordLike = 8,
        [Description("کوچکتر")]
        LessThan = 5,
        [Description("کوچکتر يا مساوي")]
        LessThanOrEqual = 6,
        [Description("حاوي")]
        Like = 9,
        [Description("مخالف")]
        NotEqual = 3,
        [Description("پيش شباهت")]
        PreWordLike = 7,
        [Description("")]
        None = 0
    }
    [Description("EnmOprationSelectedState")]
    public enum OprationSelectedState
    {
        [Description("پيش نويس")]
        Preview = 1,
        [Description("تاييد شده")]
        Publishable = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmOrg4ExchangeData")]
    public enum Org4ExchangeData
    {
        [Description("دادگستري")]
        Judiciary = 1,
        [Description("روزنامه رسمي")]
        LagalNewspaper = 3,
        [Description("ناجا")]
        NAJA = 2,
        [Description("سازمان ثبت احوال کشور")]
        PersonEventRegisterationOrg = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmOrgSenderType")]
    public enum OrgSenderType
    {
        [Description("هر دو")]
        BothOfThem = 3,
        [Description("سازمان مربوطه")]
        OtherOrg = 2,
        [Description("سازمان ثبت")]
        Sabt = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmOtherAction")]
    public enum OtherAction
    {
        [Description("اقدام ها بابت اظهارنامه صادره")]
        Declaration = 2,
        [Description("موضوع کارشناسي، بجز موضوعات جلسه دادرسي، نيازمند به اقدام")]
        ExpertReportSubjectType = 4,
        [Description("وصول نامه وارده با موضوع خاص")]
        InputLetter = 1,
        [Description("اقدام ها بابت طرح دعواي صادره سازمان با موضوع خاص")]
        Petition = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmOutgoingLetterRecieverType")]
    public enum OutgoingLetterRecieverType
    {
        [Description("شخص پرونده ")]
        CasePerson = 1,
        [Description("از فهرست گيرندگان")]
        RecieversInList = 3,
        [Description("تايپ گيرنده")]
        RecieversNotInList = 4,
        [Description("واحد ثبتي")]
        SabtUnit = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmOutgoingLetterState")]
    public enum OutgoingLetterState
    {
        [Description("تاييد شده")]
        Confirmed = 2,
        [Description("پيش نويس شده")]
        PreSend = 6,
        [Description("ثبت شده جهت تاييد")]
        Registered = 1,
        [Description("برگشت داده شده")]
        Return = 4,
        [Description("ارسال شده")]
        Sended = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmOverallBranchType")]
    public enum OverallBranchType
    {
        [Description("دادگاه")]
        Court = 1,
        [Description("دادسرا")]
        Prosecuter = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmPArticle50ChiefOrder")]
    public enum PArticle50ChiefOrder
    {
        [Description("قبول ايراد و ارجاع پرونده به شعبه تجديد نظر")]
        Accept = 1,
        [Description("رد درخواست و دستور اعاده پرونده به استان")]
        Reject = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmPArticleChekingResult")]
    public enum PArticleChekingResult
    {
        [Description("قبول ايراد")]
        Accept = 1,
        [Description("رد ايراد")]
        Reject = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmPaymentMediaType")]
    public enum PaymentMediaType
    {
        [Description("فيش بانکي")]
        ViaFiche = 3,
        [Description("اينترنتي")]
        ViaInternet = 1,
        [Description("پايانه فروش")]
        ViaPos = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmPaymentRecieptType")]
    public enum PaymentRecieptType
    {
        [Description("پرداخت به شخص")]
        Payment = 2,
        [Description("دريافت از شخص")]
        Reciept = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmPenaltyType")]
    public enum PenaltyType
    {
        [Description("محکوميت مدني")]
        CivilPenalty = 1,
        [Description("مجازات کيفري")]
        CriminalPenalty = 2,
        [Description("دستور قضايي")]
        JudgeOrder = 4,
        [Description("قرار")]
        Writ = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmPerformerType")]
    public enum PerformerType
    {
        [Description("ساير")]
        Other = 2,
        [Description("فرم")]
        SystemForm = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmPermissionType")]
    public enum PermissionType
    {
        [Description("قابل رويت")]
        Visible = 1,
        [Description("قابل رويت و قابل ويرايش")]
        VisibleEditable = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmPersonGeneralType")]
    public enum PersonGeneralType
    {
        [Description("حقيقي-قاضي")]
        Judge = 3,
        [Description("حقيقي-وکيل دادگستري")]
        LawyerPerson = 4,
        [Description("حقوقي-شخص سمت دار")]
        LegalPerson = 2,
        [Description("حقوقي-شرکت يا سازمان")]
        LegalUnit = 1,
        [Description("حقيقي-ساير")]
        OtherRealPerson = 6,
        [Description("حقيقي-نظامي")]
        SoldierPerson = 5,
        [Description("")]
        None = 0
    }
    [Description("EnmPersonType")]
    public enum PersonType
    {
        [Description("حقوقي")]
        Legal = 2,
        [Description("حقيقي")]
        NaturalPerson = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmPlannedObjection")]
    public enum PlannedObjection
    {
        [Description("عدم تناسب جريمه")]
        Fine = 1,
        [Description("عدم انطباق راي با قانون")]
        Law = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmPlaqueScript")]
    public enum PlaqueScript
    {
        [Description("ع")]
        Ain = 10,
        [Description("الف")]
        Alef = 1,
        [Description("ب")]
        B = 2,
        [Description("چ-ژ")]
        ChJh = 5,
        [Description("D")]
        D = 19,
        [Description("د")]
        Dal = 6,
        [Description("گ")]
        Gav = 12,
        [Description("ق")]
        Ghaf = 11,
        [Description("ه")]
        He = 17,
        [Description("ج")]
        J = 4,
        [Description("ل")]
        L = 13,
        [Description("م")]
        Mim = 14,
        [Description("ن")]
        Non = 15,
        [Description("S")]
        S = 20,
        [Description("ص")]
        Sad = 8,
        [Description("س")]
        Sin = 7,
        [Description("ت")]
        T = 3,
        [Description("ط")]
        Ta = 9,
        [Description("و")]
        Vav = 16,
        [Description("ي")]
        Ye = 18,
        [Description("")]
        None = 0
    }
    [Description("EnmPlaqueType")]
    public enum PlaqueType
    {
        [Description("ايران")]
        Iran = 1,
        [Description("گذر موقت")]
        PassTemporary = 3,
        [Description("TIR")]
        TIR = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmPoliceType")]
    public enum PoliceType
    {
        [Description("مراكز نظامي")]
        MilitaryService = 6,
        [Description("اداره ابلاغ ")]
        NotifiedOffice = 1,
        [Description("ساير  ")]
        Other = 10,
        [Description("ساير مراكز انتظامي")]
        OtherPolice = 5,
        [Description("كلانتري")]
        Police = 2,
        [Description("زندان")]
        Prison = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmPostType")]
    public enum PostType
    {
        [Description("مدير كلان سيستم")]
        HighManager = 300,
        [Description("اطلاع رسان")]
        Information = 290,
        [Description("سابقه ياب")]
        inveterate = 260,
        [Description("گزارش ساز")]
        ReportBuilder = 460,
        [Description("مدير سيستم ")]
        SystemManager = 137,
        [Description("")]
        None = 0
    }
    [Description("EnmProcedureCostState")]
    public enum ProcedureCostState
    {
        [Description("پرداخت نشده")]
        NotPayed = 2,
        [Description("پرداختي طرف مقابل")]
        OtherSidePayed = 1,
        [Description("پرداخت شده")]
        Payed = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmProceedingCostType")]
    public enum ProceedingCostType
    {
        [Description("نيم عشر")]
        FivePercent = 1,
        [Description("ربع عشر")]
        HalfFivePercent = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmProcessServerType")]
    public enum ProcessServerType
    {
        [Description("كارمند")]
        Employee = 1,
        [Description("غير كارمند")]
        UnEmployee = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmProductOrService")]
    public enum ProductOrService
    {
        [Description("کالا")]
        Product = 1,
        [Description("خدمت")]
        Service = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmProtester")]
    public enum Protester
    {
        [Description("متعهد له")]
        Creditor = 2,
        [Description("متعهد")]
        Debtor = 1,
        [Description("کار گروه بررسي آراء هياتهاي نظارت استانها")]
        GroupTeam = 4,
        [Description("شخص ثالث")]
        ThirdPerson = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmReceiverServerType")]
    public enum ReceiverServerType
    {
        [Description("خادم سازمان ثبت")]
        CMSServer = 1,
        [Description("قوه قضاييه")]
        Judiciary = 2,
        [Description("روزنامه رسمي")]
        LagalNewspaper = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmRefrenceType")]
    public enum RefrenceType
    {
        [Description("مرجع قضايي مكانيزه")]
        JudicialMechanize = 1,
        [Description("مرجع قضايي غير مكانيزه")]
        JudicialNonMechanize = 3,
        [Description("مرجع غير قضايي")]
        NonJudicial = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmRegInTabletState")]
    public enum RegInTabletState
    {
        [Description("روي تبلت بماند")]
        ActiveInTablet = 1,
        [Description("از روي تبلت حذف شود")]
        DeleteFromTablet = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmRelatedFormAffect")]
    public enum RelatedFormAffect
    {
        [Description("بطور کلي")]
        GeneralBase = 2,
        [Description("بر اساس دستگاه تابعه")]
        SubOrgBased = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmRelatedOtherOrg")]
    public enum RelatedOtherOrg
    {
        [Description("سيستم بانکي کشور")]
        BankSystem = 9,
        [Description("مراجع دولتي")]
        GovermentAuthorities = 10,
        [Description("سازمان بازرسي و نظارت")]
        InspectionMonitoring = 7,
        [Description("مراجع قضايي")]
        Jurisdictions = 11,
        [Description("روزنامه رسمي")]
        LagalNewspaper = 3,
        [Description("مراجع نظامي و انتظامي")]
        MilitaryAuthorities = 12,
        [Description("وزارت صنعت، معدن و تجارت")]
        MinistryTradeMiningIndustry = 13,
        [Description("ناجا")]
        NAJA = 2,
        [Description("سازمان ثبت احوال کشور")]
        PersonEventRegisterationOrg = 4,
        [Description("سازمان زندان ها و زندان")]
        Prison = 14,
        [Description("مراجع وابسته به سازمان تعزيرات حکومتي")]
        PunishmentRelatedOrg = 8,
        [Description("انجمن حمايت از حقوق مصرف كنندگان")]
        SocietyProtectionConsumersRights = 6,
        [Description("سازمان امور مالياتي")]
        TaxOrg = 5,
        [Description("")]
        None = 0
    }
    [Description("EnmReleifAccuse")]
    public enum ReleifAccuse
    {
        [Description("اتهام")]
        Accuse = 2,
        [Description("خواسته")]
        Relief = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmReligion")]
    public enum Religion
    {
        [Description("مسيحي")]
        Christian = 5,
        [Description("كليمي")]
        Jew = 3,
        [Description("مسلمان-شيعه")]
        Shia = 1,
        [Description("مسلمان-سني")]
        Sunni = 2,
        [Description("زرتشتي")]
        Zoroastrian = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmReplyState")]
    public enum ReplyState
    {
        [Description("جواب داده نشد")]
        NonReplied = 2,
        [Description("جواب داده شده")]
        Replied = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmReportAccessDataType")]
    public enum ReportAccessDataType
    {
        [Description("قابل رويت و ويرايش")]
        EditableAndRead = 1,
        [Description("صرفا قابل رويت")]
        ReadOnly = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmRequestType")]
    public enum RequestType
    {
        [Description("درخواست انحلال")]
        BreakUpRequest = 5,
        [Description("درخواست اصلاح")]
        EditRequest = 2,
        [Description("درخواست لغو اعتبار")]
        InvalidationRequest = 3,
        [Description("درخواست صدور")]
        IssuingRequest = 1,
        [Description("درخواست ادغام")]
        MergRequest = 6,
        [Description("درخواست ختم تصفيه")]
        SettleRequest = 7,
        [Description("درخواست اعتبار")]
        ValidationRequest = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmResultType")]
    public enum ResultType
    {
        [Description("انجام شد  ")]
        Done = 1,
        [Description("انجام نشد ")]
        NotDone = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmRunState")]
    public enum RunState
    {
        [Description("اعمال شده")]
        Applied = 3,
        [Description("به خطا برخورد كرده")]
        Fail = 2,
        [Description("اعمال نشده")]
        NotApplied = 1,
        [Description("نياز به بررسي دارد")]
        Recheck = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmSaveAttachmentType")]
    public enum SaveAttachmentType
    {
        [Description("در پايگاه داده")]
        SaveInDataBase = 1,
        [Description("ذخيره در نرم افزار مديريت سند")]
        SaveInDocumentManager = 3,
        [Description("ذخيره بصورت فايل عادي")]
        SaveInFile = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmScriptoriumEmployeePosition")]
    public enum ScriptoriumEmployeePosition
    {
        [Description("سردفتر")]
        Notary = 1,
        [Description("دفتر يار اول")]
        NotaryFirstAssistant = 2,
        [Description("دفتر يار دوم")]
        NotarySecondAssistant = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmScriptoriumEmployeePositionType")]
    public enum ScriptoriumEmployeePositionType
    {
        [Description("کفيل")]
        Bailment = 2,
        [Description("اصيل")]
        Originality = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmScriptoriumPostType")]
    public enum ScriptoriumPostType
    {
        [Description("کفيل دفتريار")]
        ActingAssistantOffice = 4,
        [Description("کفيل سردفتر")]
        ActingNotary = 5,
        [Description("دفتريار اول")]
        FirstOfficeAssistant = 2,
        [Description("سر دفتر")]
        Notary = 1,
        [Description("دفتريار دوم")]
        SecendOfficeAssistant = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmSecurityType")]
    public enum SecurityType
    {
        [Description("فعاليت حوزه قضايي")]
        ActivityArea = 10,
        [Description("فعاليت شعبه")]
        ActivityCourt = 6,
        [Description("فعاليت مجتمع")]
        ActivityDepartman = 7,
        [Description("فعاليت نقش")]
        ActivityRole = 9,
        [Description("فعاليت كاربر")]
        ActivityUser = 8,
        [Description("فرآيند حوزه قضايي")]
        WorkFlowArea = 5,
        [Description("فرآيند شعبه")]
        WorkFlowCourt = 1,
        [Description("فرآيند مجتمع")]
        WorkFlowDepartman = 2,
        [Description("فرآيند نقش")]
        WorkFlowRole = 4,
        [Description("فرآيند كاربر")]
        WorkFlowUser = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmSendDataState")]
    public enum SendDataState
    {
        [Description("ارسال نشده       ")]
        NotSended = 1,
        [Description("ارسال شده       ")]
        Sended = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmSenderType")]
    public enum SenderType
    {
        [Description("منو")]
        Menu = 1,
        [Description(" گردش كار ")]
        Workflow = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmSendSecurityType")]
    public enum SendSecurityType
    {
        [Description("جهت ملاحظه")]
        ReadOnly = 1,
        [Description("جهت رسيدگي")]
        ReadWrite = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmSequenceNum")]
    public enum SequenceNum
    {
        [Description("يكبار")]
        Ones = 1,
        [Description("سه بار")]
        ThreeTime = 3,
        [Description("دو بار")]
        Twice = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmSequenceType")]
    public enum SequenceType
    {
        [Description("اول")]
        First = 1,
        [Description("دوم")]
        Second = 2,
        [Description("سوم")]
        Third = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmServerType")]
    public enum ServerType
    {
        [Description("دستگاه خادم پشتيبان خادم مركزي")]
        BackupCenteralServer = 15,
        [Description("دستگاه خادم پايگاه داده و برنامه کاربردي مرکزي")]
        CentralApplicationAndDataBaseServer = 8,
        [Description("دستگاه خادم برنامه کاربردي مرکزي")]
        CentralApplicationServer = 2,
        [Description("دستگاه خادم پايگاه داده مرکزي")]
        CentralDataBaseServer = 5,
        [Description("دستگاه خادم پايگاه داده و برنامه کاربردي اينترنت")]
        InternetApplicationAndDataBaseServer = 9,
        [Description("دستگاه خادم برنامه کاربردي اينترنت")]
        InternetApplicationServer = 3,
        [Description("دستگاه خادم پايگاه داده اينترنت")]
        InternetDataBaseServer = 6,
        [Description("دستگاه خادم پايگاه داده و برنامه کاربردي محلي")]
        LocalApplicationAndDataBaseServer = 7,
        [Description("دستگاه خادم برنامه کاربردي محلي")]
        LocalApplicationServer = 1,
        [Description("دستگاه خادم پايگاه داده محلي")]
        LocalDataBaseServer = 4,
        [Description("دستگاه خادم سرويس ها")]
        ServiceServer = 12,
        [Description("")]
        None = 0
    }
    [Description("EnmSexType")]
    public enum SexType
    {
        [Description("زن")]
        Female = 1,
        [Description("مرد")]
        Male = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmShareState")]
    public enum ShareState
    {
        [Description("سهم نمي برد")]
        HasNoShare = 2,
        [Description("سهم مي برد")]
        HasShare = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmSMSEmailSendSuccess")]
    public enum SMSEmailSendSuccess
    {
        [Description("تکراري. قبلا در صف قرار گرفته بود")]
        DublicateInQueue = 2,
        [Description("ناموفق")]
        NotSuccessfull = 3,
        [Description("با موفقيت در صف ارسال قرار گرفت")]
        SucessQueued = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmSMSPersonType")]
    public enum SMSPersonType
    {
        [Description("شخص پرونده                           ")]
        CasePerson = 1,
        [Description("كارشناس                       ")]
        ExpertMan = 2,
        [Description("ساير اشخاص")]
        Individual = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmSortType")]
    public enum SortType
    {
        [Description("افزاينده")]
        Asc = 1,
        [Description("کاهنده")]
        Desc = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmSpecialProfessional")]
    public enum SpecialProfessional
    {
        [Description("تخصصي")]
        Professional = 2,
        [Description("اختصاصي")]
        Special = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmState")]
    public enum State
    {
        [Description("غير فعال")]
        Invalid = 2,
        [Description("فعال")]
        Valid = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmStateOfSuspend")]
    public enum StateOfSuspend
    {
        [Description("معلق است")]
        IsSuspended = 1,
        [Description("معلق نيست")]
        NotSuspended = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmStateType")]
    public enum StateType
    {
        [Description("پس از وضعيت نهايي مثبت")]
        AfterEndState = 4,
        [Description("وضعيت نهايي منفي")]
        FinalNegativeState = 3,
        [Description("وضعيت نهايي مثبت")]
        FinalPositiveState = 2,
        [Description("وضعيت مياني")]
        MiddleState = 1,
        [Description("چاپ مدرک")]
        PrintDoc = 5,
        [Description("")]
        None = 0
    }
    [Description("EnmStaticReportRowType")]
    public enum StaticReportRowType
    {
        [Description("ستون   ")]
        ColumnRow = 2,
        [Description("فيلد")]
        FieldRow = 1,
        [Description("سطر خالي")]
        NullRow = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmStaticReportType")]
    public enum StaticReportType
    {
        [Description("گزارش تفصيلي بانکها")]
        BankCompanyDetailed = 5,
        [Description("گزارش تفصيلي شرکتهاي بيمه")]
        InsurCompanyDetailed = 4,
        [Description("گزارش تفصيلي ساير شرکتها")]
        OtherCompanyDetailed = 1,
        [Description("گزارش تفصيلي شرکتهاي برق")]
        PowerCompanyDetailed = 3,
        [Description("گزارش تفصيلي ساير شرکتهاي آب")]
        WaterCompanyDetailed = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmSubsystems")]
    public enum Subsystems
    {
        [Description("هيات رسيدگي به تخلفات اداري")]
        AdministrativeViolation = 31,
        [Description("سايت هنري-ديباچه")]
        ArtLand = 35,
        [Description("سامانه جامع بودجه سازمان برنامه")]
        Budget = 33,
        [Description("ثبت شرکت ها")]
        Company = 4,
        [Description("اداره امور حقوقي پيش فرض")]
        DefaultOLA = 32,
        [Description("اداره امور حقوقي پيش فرض 2")]
        DefaultOLA2 = 36,
        [Description("طرح ها و برنامه ها")]
        DetailValueBudget = 12,
        [Description("ملک")]
        Estate = 2,
        [Description("اجرا")]
        Executive = 1,
        [Description("ثبت شرکتهاي مناطق آزاد")]
        FTACompany = 34,
        [Description("عمومي")]
        General = 30,
        [Description("هلال احمر")]
        HelaleAhmar = 25,
        [Description("مالکيت")]
        IndustrialOwnership = 3,
        [Description("ازدواج وطلاق")]
        Marriage = 13,
        [Description("ماده147")]
        N147 = 5,
        [Description("ارسال آگهي به روزنامه هاي کثيرالانتشار")]
        Newspaper = 15,
        [Description("ابلاغ سردفتران")]
        Notary = 6,
        [Description("اداره امور حقوقي دو")]
        OfficeLegalAffairs = 9,
        [Description("ثبت الکترونيکي اسناد")]
        OnlineReg = 7,
        [Description("پلمب دفاتر تجاري")]
        Polomb = 14,
        [Description("دادسرا و دادگاه انتظامي سردفتران و دفترياران")]
        ProsectursAndCourt = 8,
        [Description("سازمان تعزيرات")]
        PunishmentOrg = 29,
        [Description("مديريت پرونده شوراي عالي ثبت و هيات نظارت استان")]
        RegistrationCouncil = 11,
        [Description("ارايه گزارش بر روي تبلت و گوشي هوشمند")]
        TabletReport = 10,
        [Description("")]
        None = 0
    }
    [Description("EnmSyncProcessed")]
    public enum SyncProcessed
    {
        [Description("پردازش نشده")]
        NonProcessed = 1,
        [Description("پردازش شده")]
        Processed = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmSystemExistanceState")]
    public enum SystemExistanceState
    {
        [Description("موجود")]
        Exist = 2,
        [Description("غيرموجود")]
        NotExist = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmSystemMessageTypeType")]
    public enum SystemMessageTypeType
    {
        [Description("خطاي حذف در FK")]
        FKConstraintDelete = 3,
        [Description("خطاي درج در Fk")]
        FKConstraintInsert = 4,
        [Description("ساير")]
        Other = 5,
        [Description("خطاي Pk")]
        PkConstraint = 1,
        [Description("خطاي Uk")]
        UniqueConstraint = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmSystemObjectType")]
    public enum SystemObjectType
    {
        [Description("پايه اي")]
        Base = 1,
        [Description("غير پايه اي")]
        NonBase = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmTableScopeAffect")]
    public enum TableScopeAffect
    {
        [Description("کل جدول")]
        TableFull = 1,
        [Description("سطر جدول")]
        TableRow = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmTBFileType")]
    public enum TBFileType
    {
        [Description("Excel File")]
        ExcelFile = 2,
        [Description("Film File")]
        FilmFile = 4,
        [Description("Image File")]
        ImageFile = 5,
        [Description("PDF File")]
        PDFFile = 1,
        [Description("Word File")]
        WordFile = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmTBMenuStatus")]
    public enum TBMenuStatus
    {
        [Description("فعال")]
        Active = 1,
        [Description("پنهان")]
        Hidden = 3,
        [Description("غيرفعال")]
        Passive = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmTBMenuType")]
    public enum TBMenuType
    {
        [Description("آيتم برگ يا انتهايي")]
        LeafItem = 3,
        [Description("آيتم مياني")]
        MiddleItem = 2,
        [Description("آيتم ريشه")]
        RootItem = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmTBRecordState")]
    public enum TBRecordState
    {
        [Description("قابل حذف از روي تبلت")]
        MustBeDeletedTablet = 3,
        [Description("غير قابل انتشار")]
        NonPublishable = 1,
        [Description("قابل انتشار")]
        Publishable = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmTimeState")]
    public enum TimeState
    {
        [Description("ابطال شده")]
        Cancel = 3,
        [Description("اقدام شده")]
        Done = 2,
        [Description("اقدام نشده")]
        NotDone = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmTranscriptSendType")]
    public enum TranscriptSendType
    {
        [Description("بوسيله ابلاغ")]
        ByNotice = 2,
        [Description("بوسيله نامه صادره")]
        ByOutgoingLetter = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmTransferObjectState")]
    public enum TransferObjectState
    {
        [Description("اطلاعات ارسال نشده")]
        Notsended = 1,
        [Description("اطلاعات ارسال شده")]
        Sended = 2,
        [Description("ارشال شده و پذيرفته شده")]
        SendedAndAccepted = 3,
        [Description("ارسال شده و پذيرفته نشده")]
        SendedAndRejected = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmTrueFalse")]
    public enum TrueFalse
    {
        [Description("غلط")]
        False = 2,
        [Description("درست")]
        True = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmTypeValue")]
    public enum TypeValue
    {
        [Description("جدول اطلاعات پايه")]
        BaseInfoTable = 6,
        [Description("دکمه")]
        Button = 13,
        [Description("داده مشخص")]
        ConstantData = 4,
        [Description("تاريخ")]
        Date = 3,
        [Description("فايل")]
        FileType = 18,
        [Description("عددي")]
        NumericNonCalculate = 1,
        [Description("متني پيشرفته")]
        RichTextBoxType = 7,
        [Description("رشته ايي")]
        String = 2,
        [Description("رشته اي شناسه دار")]
        StringId = 14,
        [Description("")]
        None = 0
    }
    [Description("EnmUnitExchangeAttachmentType")]
    public enum UnitExchangeAttachmentType
    {
        [Description("قابل تغيير")]
        Editable = 1,
        [Description("فقط مطالعه")]
        ReadOnly = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmUnitExchangeLetter")]
    public enum UnitExchangeLetter
    {
        [Description("ارسال نشده")]
        NotSend = 1,
        [Description("رويت شده توسط واحد ثبتي گيرنده")]
        Receive = 3,
        [Description("ارجاع داده شده")]
        Refer = 4,
        [Description("برگشت داده شده")]
        Return = 5,
        [Description("ارسال شده")]
        Send = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmUnitParameter")]
    public enum UnitParameter
    {
        [Description("بازه زماني تغيير رمز عبور به روز")]
        ChangePasswordPeriod = 14,
        [Description("مکانيزه شدن شعبه")]
        CourtCMSState = 8,
        [Description("شروع ساعت دفتر اوقات")]
        DailyBeginTime = 3,
        [Description("پايان ساعت دفتر اوقات")]
        DailyEndTime = 4,
        [Description("تعداد كارمند")]
        EmployeeCount = 11,
        [Description("تعداد قاضي")]
        JudgeCount = 12,
        [Description("حداکثر زمان ثبت در دفاتر مکانيزه")]
        MaxDelaySaveData = 9,
        [Description("تاريخ شروع به روز شدن اطلاعات و جمع آوري دفاتر")]
        RemoveBooks = 10,
        [Description("استاندارد حداقل تعداد وقت رسيدگي در روز")]
        SessionNumberPerDay = 5,
        [Description("استاندارد حداقل تعداد وقت احتياطي در روز")]
        TemporaryNumberPerDay = 6,
        [Description("حداقل زمان وقت دهي شعبه")]
        UnitTimePeriod = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmUnitType")]
    public enum UnitType
    {
        [Description("سازمان مستقل ثبتي")]
        OrganizationRegistration = 30,
        [Description("اداره كل ثبت اسناد و املاک استان")]
        ProvinceRegistration = 20,
        [Description("واحد ثبتي")]
        RegistrationUnit = 9,
        [Description("")]
        None = 0
    }
    [Description("EnmUrgencyLetter")]
    public enum UrgencyLetter
    {
        [Description("عادي")]
        Normal = 1,
        [Description("فوري")]
        Urgent = 2,
        [Description("خيلي فوري")]
        VeryUrgent = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmUsersPost")]
    public enum UsersPost
    {
        [Description("دادورز  ")]
        Bailiff = 10,
        [Description("منشي  ")]
        CourtClerk = 4,
        [Description("بايگان     ")]
        FileKeeper = 8,
        [Description("متصدي شعبه ")]
        Judge = 7,
        [Description("مدير دفتر   ")]
        OfficeAdministrator = 1,
        [Description("متصدي امور دفتري  ")]
        OfficeIncumbent = 3,
        [Description("دادرس  ")]
        Proceeder = 9,
        [Description("دادستان  ")]
        Prosecutor = 5,
        [Description("معاون ارجاع  ")]
        RefferingAssistant = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmUserType")]
    public enum UserType
    {
        [Description("كارمند ")]
        Emp = 1,
        [Description("غير كارمند ")]
        NonEmp = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmVerdictType")]
    public enum VerdictType
    {
        [Description("راي")]
        Judge = 1,
        [Description("قرار نهايي")]
        Writ = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmViewType")]
    public enum ViewType
    {
        [Description("General View")]
        GeneralView = 1,
        [Description("Materialized View")]
        MatView = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmWealthType")]
    public enum WealthType
    {
        [Description("منقول")]
        Linkages = 1,
        [Description("غير منقول")]
        Immovable = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmWeekDay")]
    public enum WeekDay
    {
        [Description("جمعه")]
        Friday = 7,
        [Description("دوشنبه")]
        Monday = 3,
        [Description("شنبه")]
        Saturday = 1,
        [Description("يکشنبه")]
        Sunday = 2,
        [Description("پنج شنبه")]
        Thursday = 6,
        [Description("سه شنبه")]
        Tuesday = 4,
        [Description("چهارشنبه")]
        Wednesday = 5,
        [Description("")]
        None = 0
    }
    [Description("EnmWFDefinitionState")]
    public enum WFDefinitionState
    {
        [Description("نامعتبر")]
        Invalid = 9,
        [Description("پيش نويس")]
        PreDefine = 1,
        [Description("معتبر-اجرايي شده")]
        Valid = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmWFParameterType")]
    public enum WFParameterType
    {
        [Description("شيء اصلي فعاليت")]
        ActivityBaseObject = 2,
        [Description("BLOB")]
        BLOBType = 6,
        [Description("CLOB")]
        CLOBType = 5,
        [Description("شيء پايگاه دادهاي بجز شيء اصلي فعاليت")]
        DBObject = 4,
        [Description("عدد   ")]
        NumberType = 3,
        [Description("رشته   ")]
        StringType = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmWorkFlowActionTime")]
    public enum WorkFlowActionTime
    {
        [Description("موقع حذف")]
        OnDelete = 5,
        [Description("موقع ايجاد")]
        OnEntry = 1,
        [Description("موقع اتمام")]
        OnExit = 2,
        [Description("موقع برگشت")]
        OnStepBack = 4,
        [Description("موقع اصلاح")]
        OnUpdate = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmWorkFlowActionType")]
    public enum WorkFlowActionType
    {
        [Description("اجراي دستورالعمل")]
        ActionScript = 4,
        [Description("فراخواني متد")]
        MethodCall = 2,
        [Description("تغيير وضعيت متغير")]
        SetState = 3,
        [Description("رخداد روي تغيير متغير")]
        VariableChangeEvent = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmWorkFlowActivityInstanceState")]
    public enum WorkFlowActivityInstanceState
    {
        [Description("خاتمه يافته  ")]
        Done = 1,
        [Description("متوقف")]
        Pause = 3,
        [Description("در حال اجرا ")]
        Processing = 2,
        [Description("برگشت به عقب داده شده")]
        StepBacked = 6,
        [Description("منتظر")]
        Wait = 4,
        [Description("منتظر رخداد")]
        WaitOnEvent = 5,
        [Description("")]
        None = 0
    }
    [Description("EnmWorkFlowActivityType")]
    public enum WorkFlowActivityType
    {
        [Description("حاشيه اي")]
        AnnotationType = 4,
        [Description("پايان")]
        EndType = 2,
        [Description("آغاز توازي")]
        ForkType = 1,
        [Description("پايان توازي")]
        JoinType = 3,
        [Description("انتقالي")]
        RouterType = 8,
        [Description("ساده")]
        SimpleActivityType = 5,
        [Description("شروع")]
        StartType = 6,
        [Description("فراخوان گردش کار")]
        SubWorkflowType = 7,
        [Description("")]
        None = 0
    }
    [Description("EnmWorkFlowCartable")]
    public enum WorkFlowCartable
    {
        [Description("به تاخير انداخته شده")]
        Delay = 3,
        [Description("انجام شده")]
        Done = 1,
        [Description("انجام نشده")]
        Processing = 2,
        [Description("برگشت پذير")]
        StepBack = 5,
        [Description("در انتظار رخداد")]
        Wait = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmWorkFlowDataType")]
    public enum WorkFlowDataType
    {
        [Description("عددي")]
        IntegerType = 2,
        [Description("رشته اي")]
        StringType = 1,
        [Description("شيء سيستم")]
        SystemObject = 3,
        [Description("ليستي از شيء سيستم")]
        SystemObjectCollection = 4,
        [Description("")]
        None = 0
    }
    [Description("EnmWorkFlowDisplayType")]
    public enum WorkFlowDisplayType
    {
        [Description("در سطح زير گردشها")]
        AllSubWorkFlow = 3,
        [Description("در سطح فرم")]
        FormWorkFlow = 1,
        [Description("در سطح گردش")]
        OneWorkFlow = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmWorkFlowElementType")]
    public enum WorkFlowElementType
    {
        [Description("فعاليت")]
        Activity = 1,
        [Description("گردش كار")]
        WorkFlow = 2,
        [Description("")]
        None = 0
    }
    [Description("EnmWorkFlowInstanceState")]
    public enum WorkFlowInstanceState
    {
        [Description("خاتمه يافته")]
        Done = 2,
        [Description("متوقف شده")]
        Paused = 4,
        [Description("در حال اجرا")]
        Processing = 1,
        [Description("در حال انتظار")]
        Wait = 3,
        [Description("")]
        None = 0
    }
    [Description("EnmWorkFlowTargetType")]
    public enum WorkFlowTargetType
    {
        [Description("متغير فعاليت")]
        ActivityContextVariable = 2,
        [Description("متغير خارجي")]
        ExternalVariable = 3,
        [Description("متغير گردش كار")]
        WorkFlowContextVariable = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmWorkFlowVariableEventTime")]
    public enum WorkFlowVariableEventTime
    {
        [Description("ايجاد")]
        OnCreate = 2,
        [Description("موقع اصلاح")]
        OnUpdate = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmWorkFlowVariableSource")]
    public enum WorkFlowVariableSource
    {
        [Description("محاسباتي")]
        Computed = 2,
        [Description("ورودي")]
        InputParameter = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmWorkFlowWorkItemType")]
    public enum WorkFlowWorkItemType
    {
        [Description("مستقل از فرآيند")]
        NonWorkFlow = 2,
        [Description("صرفا جهت رويت-رونوشت")]
        Transcript = 9,
        [Description("فرآيندي")]
        WorkFlow = 1,
        [Description("")]
        None = 0
    }
    [Description("EnmYesNo")]
    public enum YesNo
    {
        [Description("خير")]
        No = 2,
        [Description("بلي")]
        Yes = 1,
        [Description("")]
        None = 0
    }
}
