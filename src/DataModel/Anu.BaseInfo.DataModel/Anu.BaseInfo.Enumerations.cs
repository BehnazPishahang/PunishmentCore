

using System.ComponentModel;

namespace Anu.BaseInfo.Enumerations
{
    [Description("AddressType")]
    public enum AddressType
    {
        [Description("")]
        None = 0,
        [Description("متن سند")]
        DocAddress = 1,
        [Description("اعلامي متعهد له")]
        Creditor = 2,
        [Description("اعلامي متعهد")]
        Debtor = 3,
    } 

    [Description("AdvertisingState")]
    public enum AdvertisingState
    {
        [Description("")]
        None = 0,
        [Description("ثبت شده جهت تاييد")]
        Registered = 1,
        [Description("تاييد شده")]
        Confirmed = 2,
        [Description("ارسال شده")]
        Sended = 3,
        [Description("برگشت داده شده")]
        Return = 4,
        [Description("پيش نويس شده")]
        PreSend = 6,
        [Description("ابطال شده")]
        Disproofed = 7,
    } 

    [Description("AgentedPerson")]
    public enum AgentedPerson
    {
        [Description("")]
        None = 0,
        [Description("متعهد")]
        AgentDebtor = 1,
        [Description("متعهد له")]
        AgentCreditor = 2,
    } 

    [Description("AlarmType")]
    public enum AlarmType
    {
        [Description("")]
        None = 0,
        [Description("خطا و توقف")]
        ErrorAlarm = 1,
        [Description("هشدار و اخذ اجازه")]
        WarningAlarm = 2,
    } 

    [Description("AlarmViewerType")]
    public enum AlarmViewerType
    {
        [Description("")]
        None = 0,
        [Description("درون سازماني")]
        InnerOrg = 1,
        [Description("برون سازماني")]
        OutterOrg = 2,
    } 

    [Description("AndOr")]
    public enum AndOr
    {
        [Description("")]
        None = 0,
        [Description("يا")]
        OrOperand = 1,
        [Description("و")]
        AndOperand = 2,
    } 

    [Description("ApplicantFunctionType")]
    public enum ApplicantFunctionType
    {
        [Description("")]
        None = 0,
        [Description("اعتبارات")]
        BudgetForm = 1,
        [Description("ابلاغ   ")]
        Notice = 2,
        [Description("موافقتنامه")]
        Agreement = 3,
        [Description("تخصيص")]
        Allocation = 4,
        [Description("صورتجلسه")]
        Minutes = 5,
        [Description("عملکرد")]
        Proceeds = 6,
        [Description("رابت")]
        RABeT = 21,
        [Description("ساير")]
        Other = 99,
    } 

    [Description("ApplicantType")]
    public enum ApplicantType
    {
        [Description("")]
        None = 0,
        [Description("جهت محاسبه کردن مقدار ستون")]
        CalcCol = 1,
        [Description("جهت شرط براي فقط خواندني کردن کل سطر")]
        CondCol = 2,
    } 

    [Description("ArchiveStatus")]
    public enum ArchiveStatus
    {
        [Description("")]
        None = 0,
        [Description("داخل بايگاني")]
        InArchive = 1,
        [Description("خارج از بايگاني")]
        OutOfArchive = 2,
        [Description("مفقود شده")]
        Lost = 3,
    } 

    [Description("AssetOrRight")]
    public enum AssetOrRight
    {
        [Description("")]
        None = 0,
        [Description("اموال غيرمنقول")]
        ImmovableAsset = 1,
        [Description("اموال منقول")]
        LinkageAsset = 2,
        [Description("حق و امتياز")]
        Right = 3,
    } 

    [Description("AsyncType")]
    public enum AsyncType
    {
        [Description("")]
        None = 0,
        [Description("جهت حذف")]
        ToDelete = 1,
        [Description("جهت به روز رساني")]
        ToCommit = 2,
    } 

    [Description("AttachmentProcessState")]
    public enum AttachmentProcessState
    {
        [Description("")]
        None = 0,
        [Description("پيوست به درستي پردازش شده")]
        ProcessedSuccessfully = 1,
        [Description(" حجم پيوست از اندازه استادارد بزرگتر است")]
        FileSizeInvalid = 2,
        [Description("پيوست پيدا نشد")]
        FileNotFound = 3,
        [Description("مسير ذخيره سازي فايل نامعتبر است")]
        PathAndFileNameIsInvalid = 4,
        [Description("پرونده مربوطه درج شده است")]
        CaseInserted = 5,
    } 

    [Description("AttachmentType")]
    public enum AttachmentType
    {
        [Description("")]
        None = 0,
        [Description("تصوير")]
        Image = 1,
        [Description("فايل اتوکد")]
        Autocad = 2,
        [Description("فيلم")]
        Video = 3,
        [Description("فايل آفيس")]
        Office = 4,
        [Description("ساير")]
        Other = 9,
    } 

    [Description("BankType")]
    public enum BankType
    {
        [Description("")]
        None = 0,
        [Description("خصوصي")]
        Private = 1,
        [Description("دولتي")]
        Governmental = 2,
        [Description("موسسه مالي و اعتباري")]
        FinanceAndCreditInstitute = 3,
        [Description("قرض الحسنه")]
        GharzAlHasaneh = 4,
    } 

    [Description("BaseInfoChangeType")]
    public enum BaseInfoChangeType
    {
        [Description("")]
        None = 0,
        [Description("ادغام")]
        Merger = 1,
        [Description("تفکيک")]
        Breaking = 2,
        [Description("تبديل")]
        ChangeName = 3,
    } 

    [Description("CalcFuncType")]
    public enum CalcFuncType
    {
        [Description("")]
        None = 0,
        [Description("تابع محاسبه کننده فقط يک قلم/ستون")]
        CalcOneFieldColumn = 1,
        [Description("تابع محاسبه کننده چند قلم/ستون")]
        CalcMultiFieldColumn = 2,
    } 

    [Description("CartableActivationMethod")]
    public enum CartableActivationMethod
    {
        [Description("")]
        None = 0,
        [Description("عادي")]
        Normal = 1,
        [Description("رخدادي")]
        Event = 2,
    } 

    [Description("CartableCategory")]
    public enum CartableCategory
    {
        [Description("")]
        None = 0,
        [Description("اقدامي")]
        Perform = 1,
        [Description("اطلاعي")]
        Notify = 2,
    } 

    [Description("CaseMechanizeState")]
    public enum CaseMechanizeState
    {
        [Description("")]
        None = 0,
        [Description("مکانيزه")]
        Mechanize = 1,
        [Description("غير مکانيزه")]
        NonMechanize = 2,
    } 

    [Description("CaseOwner")]
    public enum CaseOwner
    {
        [Description("")]
        None = 0,
        [Description("متعلق به همين پرونده")]
        OwnerThisCase = 1,
        [Description("متعلق به پرونده ديگر")]
        OwnerOtherCase = 2,
    } 

    [Description("CasePersonOtherDataType")]
    public enum CasePersonOtherDataType
    {
        [Description("")]
        None = 0,
        [Description("داراي مقادير پيش فرض")]
        HaveLookup = 1,
        [Description("بدون مقادير پيش فرض")]
        HaveNotLookup = 2,
    } 

    [Description("CaseStatisticState")]
    public enum CaseStatisticState
    {
        [Description("")]
        None = 0,
        [Description("جاري")]
        Active = 1,
        [Description("توقف از طرف بستانکار")]
        StopByCreditor = 5,
        [Description("توقف عمليات اجرايي از طرف واحد قضايي")]
        StopByJudge = 7,
        [Description("مختومه")]
        Dismantled = 9,
    } 

    [Description("CaseSubject")]
    public enum CaseSubject
    {
        [Description("")]
        None = 0,
        [Description("جرائم عمومي کيفري")]
        GeneralAccuse = 1,
        [Description("دعاوي عمومي حقوقي")]
        GeneralCivil = 2,
        [Description("دعاوي خانواده")]
        FamilyPetition = 3,
        [Description("جرائم اطفال")]
        BabyAccuse = 4,
        [Description("جرائم موضوع صلاحيت دادگاه انقلاب")]
        EnghelabAccuse = 5,
        [Description("جرائم موضوع صلاحيت دادگاه کيفري استان")]
        OstanAccuse = 6,
        [Description("دعاوي ديوان عدالت اداري")]
        DivanEdalatPetition = 7,
        [Description("جرائم نظامي")]
        MilitaryAccuse = 8,
        [Description("تخلفات انتظامي قضات")]
        JudgeAccuse = 9,
    } 

    [Description("CaseWealthChangeState")]
    public enum CaseWealthChangeState
    {
        [Description("")]
        None = 0,
        [Description("تاييد شده")]
        Confirmed = 1,
        [Description("تاييد نشده")]
        NotConfirmed = 2,
    } 

    [Description("CaseWealthState")]
    public enum CaseWealthState
    {
        [Description("")]
        None = 0,
        [Description("معرفي شده ولي تاييد نشده")]
        IntroducedNotConfirm = 1,
        [Description("وجود مال متعلق به بدهکار تاييد شده")]
        Confirm = 2,
        [Description("مال بازداشت شده")]
        Detention = 3,
        [Description("مال به فروش رفته به نفع بستانکار")]
        GoingToSell = 4,
        [Description("مال بابت طلب به نفع بستانکار ضبط شده")]
        Concede = 5,
        [Description("رفع بازداشت مال به دليل تسويه حساب بدهکار")]
        ReleasePony = 6,
        [Description("توقف عمليات در مورد مال به حکم دادگاه")]
        StopByJudge = 7,
        [Description("مال به خريدار تحويل داده شد")]
        Deliver2Buyer = 12,
        [Description("مال به بدهکار تحويل داده شد")]
        Deliver2Debtor = 13,
        [Description("مال به بستانکار تحويل داده شد")]
        DeliverCreditor = 14,
        [Description("رفع بازداشت به تقاضاي بستانکار")]
        ReleaseByCreditorDemands = 15,
        [Description("رفع بازداشت با دستور تمام قضايي")]
        ReleaseByCourtOrders = 16,
        [Description("مال به موجر تحويل داده شد")]
        Deliver2Lessor = 17,
    } 

    [Description("CertificateType")]
    public enum CertificateType
    {
        [Description("")]
        None = 0,
        [Description("گواهي اقامه دعوا در دادگاه صالحه")]
        ProceedingsCertificate = 1,
        [Description("گواهي قطعيت دادنامه")]
        JudgmentFinalCertificate = 2,
        [Description("گواهي ماده 212 قانون آيين دادرسي مدني")]
        Law212Certificate = 3,
    } 

    [Description("Certification")]
    public enum Certification
    {
        [Description("")]
        None = 0,
        [Description("گواهي مي شود")]
        Certification = 1,
        [Description("گواهي نمي شود")]
        NonCertification = 2,
    } 

    [Description("ChangedFiledDataType")]
    public enum ChangedFiledDataType
    {
        [Description("")]
        None = 0,
        [Description("عددي")]
        Numerical = 1,
        [Description("متني ساده")]
        SimpleText = 2,
        [Description("تصوير")]
        ImageField = 3,
        [Description("WordFile")]
        WordFile = 4,
        [Description("ExcelFIle")]
        ExcelFile = 5,
        [Description("MHTFile")]
        MHTFile = 6,
        [Description("PDFFile")]
        PDFFile = 7,
        [Description("RARFile")]
        RARFile = 8,
        [Description("ZIPFile")]
        ZIPFile = 9,
    } 

    [Description("CheckNatinalityStatus")]
    public enum CheckNatinalityStatus
    {
        [Description("")]
        None = 0,
        [Description("اطلاعات با ثبت احوال چک شد و معتبر بود")]
        Confirm = 1,
        [Description("اطلاعات با ثبت احوال راستي آزمايي نشده است")]
        NotChecked = 2,
        [Description("اطلاعات مورد تاييد ثبت احوال نبود")]
        Refuse = 3,
        [Description("منتظر بررسي مدير سيستم")]
        Wait4Check = 4,
    } 

    [Description("CLPUserState")]
    public enum CLPUserState
    {
        [Description("")]
        None = 0,
        [Description("تعريف شده و تاييد نشده")]
        NotConfirm = 1,
        [Description("تاييد شده و فعال")]
        Active = 2,
        [Description("غير فعال")]
        InActive = 3,
    } 

    [Description("CMSEMailStatus")]
    public enum CMSEMailStatus
    {
        [Description("")]
        None = 0,
        [Description("ارسال نشده")]
        NotSended = 1,
        [Description("به مقصد رسيده")]
        Receive = 3,
        [Description("منتظر مانده")]
        Wait = 4,
        [Description("عدم توانايي براي رساندن به مقصد")]
        CanNotReceive = 5,
        [Description("ارسال شده و منتظر اولين پاسخ")]
        Sended = 5,
    } 

    [Description("CMSSMSStatus")]
    public enum CMSSMSStatus
    {
        [Description("")]
        None = 0,
        [Description("ارسال نشده")]
        NotSended = 1,
        [Description("ارسال شده")]
        Sended = 2,
        [Description("به مقصد رسيده")]
        Receive = 3,
        [Description("منتظر مانده")]
        Wait = 4,
        [Description("عدم توانايي براي رساندن به مقصد")]
        CanNotReceive = 5,
    } 

    [Description("CommandType")]
    public enum CommandType
    {
        [Description("")]
        None = 0,
        [Description("درج")]
        Insert = 1,
        [Description("به روز رساني")]
        Update = 2,
        [Description("حذف")]
        Delete = 3,
        [Description("درج در ساير نرم افزارها")]
        OtherSoftwareInsert = 4,
        [Description("به روزرساني در ساير نرم افزارها")]
        OtherSoftwareUpdate = 5,
        [Description("حذف در ساير نرم افزارها")]
        OtherSoftwareDelete = 6,
    } 

    [Description("CompetentAuthority")]
    public enum CompetentAuthority
    {
        [Description("")]
        None = 0,
        [Description("قضايي مكانيزه")]
        Justic = 1,
        [Description("غيرقضايي ")]
        NonJustic = 2,
        [Description("قضايي غير مكانيزه")]
        NonMechanizeJustic = 3,
    } 

    [Description("ConditionAffect")]
    public enum ConditionAffect
    {
        [Description("")]
        None = 0,
        [Description("فقط خواندني")]
        ReadOnly = 1,
        [Description("غيرقابل رويت")]
        UnVisible = 2,
    } 

    [Description("ConditionParameterType")]
    public enum ConditionParameterType
    {
        [Description("")]
        None = 0,
    } 

    [Description("ConfirmerNoticeState")]
    public enum ConfirmerNoticeState
    {
        [Description("")]
        None = 0,
        [Description("صحت عمليات ابلاغ تاييد شده است")]
        Confirm = 1,
        [Description("صحت عمليات ابلاغ تاييد نشده است")]
        Refuse = 2,
        [Description("هنوز نظري داده نشده است")]
        NoOpinion = 3,
    } 

    [Description("ContextVariableType")]
    public enum ContextVariableType
    {
        [Description("")]
        None = 0,
        [Description("واحد جاري")]
        CurrentUnit = 1,
        [Description("سال بودجه اي جاري")]
        CurrentBudgetYear = 2,
        [Description("لايه بودجه اي جاري")]
        CurrentBudgetPhase = 3,
        [Description("کاربر بهمراه سمت جاري")]
        CurrentRegisterUser = 4,
    } 

    [Description("ConvictionState")]
    public enum ConvictionState
    {
        [Description("")]
        None = 0,
        [Description("در حال انجام")]
        Active = 1,
        [Description("خاتمه يافته")]
        Passive = 2,
    } 

    [Description("CourtType")]
    public enum CourtType
    {
        [Description("")]
        None = 0,
        [Description("واحد اجراي احكام كيفري")]
        ExecutorCriminal = 1,
        [Description("واحد اظهار نظر")]
        CriminalRemark = 2,
        [Description("بازپرسي")]
        Bazpors = 3,
        [Description("دادستاني")]
        Dadsetan = 4,
        [Description("دادگاه حقوقي")]
        LegalCourt = 5,
        [Description("دادگاه كيفري")]
        CriminalCourt = 6,
        [Description("دادياري تحقيق")]
        Dadyar = 7,
        [Description("دادگاه تجديد نظر")]
        AmendmentCourt = 8,
        [Description("شعبه ديوانعالي كشور")]
        SupremeCourt = 9,
        [Description("شوراي حل اختلاف")]
        DiscordCouncilResolve = 10,
        [Description("واحد اجراي احكام مدني")]
        ExecutorCivil = 11,
        [Description("دادياري سرپرستي")]
        DadyariSarparsti = 12,
        [Description("دادگاه عمومي بخش")]
        BakhshCourt = 13,
        [Description("دادگاه كيفري استان")]
        OstanCriminal = 14,
        [Description("اجراي احکام شورا")]
        ExecuteDiscordCouncilResolve = 15,
        [Description("کشيک دادسرا")]
        KeskikDadsara = 16,
        [Description("کشيک دادگاه")]
        KeskikDadgah = 17,
    } 

    [Description("Crimes")]
    public enum Crimes
    {
        [Description("")]
        None = 0,
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
    } 

    [Description("DatapreparationStatus")]
    public enum DatapreparationStatus
    {
        [Description("")]
        None = 0,
        [Description("داده آمايي شده")]
        Dataprepared = 1,
        [Description("داده آمايي نشده")]
        UnDataprepared = 2,
        [Description("نيمه داده آمايي شده")]
        HalfDataPrepared = 3,
    } 

    [Description("DayNight")]
    public enum DayNight
    {
        [Description("")]
        None = 0,
        [Description("روز")]
        Day = 1,
        [Description("شب")]
        Night = 2,
    } 

    [Description("DeclarationPost")]
    public enum DeclarationPost
    {
        [Description("")]
        None = 0,
        [Description("اظهارکننده")]
        Utterer = 1,
        [Description("مخاطب")]
        Addressed = 2,
        [Description("نماينده اظهارکننده")]
        Agent = 3,
    } 

    [Description("DisplayMode")]
    public enum DisplayMode
    {
        [Description("")]
        None = 0,
        [Description("قابل ويرايش")]
        Editable = 1,
        [Description("فقط خواندني")]
        Readonly = 2,
        [Description("غير قابل رويت")]
        Hidden = 3,
        [Description("محاسباتي فقط خواندني")]
        CalcReadOnly = 4,
    } 

    [Description("DocumentType")]
    public enum DocumentType
    {
        [Description("")]
        None = 0,
        [Description("مكانيزه")]
        Mechanize = 1,
        [Description("پويشي")]
        Scan = 2,
    } 

    [Description("Drawing")]
    public enum Drawing
    {
        [Description("")]
        None = 0,
        [Description("انجام شود")]
        Do = 1,
        [Description("انجام نــشود")]
        DoNot = 2,
    } 

    [Description("DueDateStatus")]
    public enum DueDateStatus
    {
        [Description("")]
        None = 0,
        [Description("انجام نشده")]
        NotDone = 1,
        [Description("انجام شده")]
        Done = 2,
        [Description("تجديد شده")]
        Repeated = 3,
        [Description("ابطال شده")]
        Revocation = 4,
    } 

    [Description("ECMAccessType")]
    public enum ECMAccessType
    {
        [Description("")]
        None = 0,
        [Description("فقط خواندني")]
        ReadOnly = 1,
        [Description("هم خواندن هم نگارش جديد گذاشتن")]
        ChangeVersion = 2,
    } 

    [Description("ECMFileType")]
    public enum ECMFileType
    {
        [Description("")]
        None = 0,
        [Description("تصوير")]
        Image = 1,
        [Description("Word")]
        Word = 2,
        [Description("Excel")]
        Excel = 3,
        [Description("فيلم")]
        Film = 4,
        [Description("ساير")]
        OtherType = 99,
    } 

    [Description("ECMFItemType")]
    public enum ECMFItemType
    {
        [Description("")]
        None = 0,
        [Description("رشته اي")]
        StringType = 1,
        [Description("عددي")]
        NumberType = 2,
        [Description("تاريخ")]
        DateType = 3,
        [Description("ساعت")]
        TimeType = 4,
        [Description("زمان")]
        DateTimeType = 5,
    } 

    [Description("ECMSecurityType")]
    public enum ECMSecurityType
    {
        [Description("")]
        None = 0,
        [Description("محتواي اختصاصي")]
        PrivateContent = 1,
        [Description("محتواي اشتراکي")]
        ShareContent = 2,
        [Description("محتواي عمومي")]
        PublicContent = 3,
    } 

    [Description("EducationDegree")]
    public enum EducationDegree
    {
        [Description("")]
        None = 0,
        [Description("بيسواد")]
        BiSavad = 1,
        [Description("سيكل")]
        Cycle = 2,
        [Description("پيش دانشگاهي")]
        PishDaneshgahi = 3,
        [Description("ديپلم")]
        Diploma = 4,
        [Description("ديپلم فني وحرفه اي آزاد")]
        DiplomFanyHerfei = 5,
        [Description("ديپلم كار و دانش")]
        DiplomKarODanesh = 6,
        [Description("فوق ديپلم")]
        FoghDiplom = 7,
        [Description("گواهينامه")]
        Govahinameh = 8,
        [Description("گواهينامه دو ساله")]
        Govahinameh2Saleh = 9,
        [Description("کارشناسي")]
        BS = 10,
        [Description("حوزه علميه")]
        Hozeh = 11,
        [Description("حوزوي سطح دو")]
        HozaviSathe2 = 12,
        [Description("کارشناسي ارشد")]
        MS = 13,
        [Description("دانشنامه علمي سطح سه")]
        Daneshnameh = 14,
        [Description("دكتري")]
        Dr = 15,
        [Description("دكتراي تخصصي")]
        DrTakhasosi = 16,
        [Description("پزشكي")]
        Pezeshki = 17,
    } 

    [Description("ERequestManType")]
    public enum ERequestManType
    {
        [Description("")]
        None = 0,
        [Description("وصي")]
        Vasi = 1,
        [Description("قيم")]
        Ghayyem = 2,
        [Description("وکيل")]
        Lawyer = 3,
        [Description("نماينده")]
        Agent = 4,
    } 

    [Description("ErrorRelatedGroup")]
    public enum ErrorRelatedGroup
    {
        [Description("")]
        None = 0,
        [Description("آموزش")]
        Tutorial = 1,
        [Description("تحليل گر")]
        Analyst = 2,
        [Description("طراح")]
        Designer = 3,
        [Description("برنامه نويس")]
        Programmer = 4,
    } 

    [Description("ErrorState")]
    public enum ErrorState
    {
        [Description("")]
        None = 0,
        [Description("انجام شد   ")]
        IsDone = 1,
        [Description("انجام نشد  ")]
        NotDone = 2,
        [Description("در حال انجام  ")]
        UnderDevelope = 3,
        [Description("خطا وارد نيست")]
        NotAcceptedError = 4,
    } 

    [Description("EstateInputOutput")]
    public enum EstateInputOutput
    {
        [Description("")]
        None = 0,
        [Description("وارده")]
        Input = 1,
        [Description("صادره")]
        Output = 2,
    } 

    [Description("EventAction")]
    public enum EventAction
    {
        [Description("")]
        None = 0,
        [Description("ادامه فرآيند   ")]
        Resume = 1,
        [Description("انجام  ")]
        Done = 2,
        [Description("تعليق فرآيند ")]
        Pause = 3,
        [Description("توقف فرآيند ")]
        Close = 4,
        [Description("هيچكدام      ")]
        NoEvent = 5,
    } 

    [Description("EventRegisterationEffect")]
    public enum EventRegisterationEffect
    {
        [Description("")]
        None = 0,
        [Description("توقف و منتظر رخداد")]
        StopWait = 1,
        [Description("عدم توقف و منتظر رخداد")]
        ProcessWait = 2,
    } 

    [Description("EventState")]
    public enum EventState
    {
        [Description("")]
        None = 0,
        [Description("واقع شده")]
        Done = 1,
        [Description(" منتظر رخداد")]
        Wait = 2,
        [Description("برگشت داده شده")]
        StepBacked = 3,
    } 

    [Description("ExordiumState")]
    public enum ExordiumState
    {
        [Description("")]
        None = 0,
        [Description("شـاغل")]
        Employed = 1,
        [Description("بـازنشسته")]
        Retired = 2,
        [Description("مستعفي")]
        Resigned = 3,
        [Description("از کار افتاده")]
        OutOfService = 4,
        [Description("متوفي")]
        Dead = 5,
        [Description("منفصل دائم")]
        DismissedForEver = 6,
        [Description("منفصل موقت با حق ثبت سند")]
        DismissedTemporaryWithDocument = 7,
        [Description("منفصل موقت بدون حق ثبت سند")]
        DismissedTemporaryWithoutDocument = 8,
    } 

    [Description("ExordiumType")]
    public enum ExordiumType
    {
        [Description("")]
        None = 0,
        [Description("سردفتـر")]
        Sardaftar = 1,
        [Description("دفتريار")]
        Daftaryar = 2,
    } 

    [Description("ExpEmployeeType")]
    public enum ExpEmployeeType
    {
        [Description("")]
        None = 0,
        [Description("رسمي ")]
        Official = 1,
        [Description("خبره محلي-غيررسمي")]
        LocalExpert = 2,
        [Description("کارشناس مرکز مشاورين قوه قضاييه")]
        AdvisorJudiciary = 3,
        [Description("مامور اجرا")]
        ExecutiveAgent = 4,
    } 

    [Description("ExperisionRunType")]
    public enum ExperisionRunType
    {
        [Description("")]
        None = 0,
        [Description("عبارت رياضي محاسبه ستون")]
        ExperisionType = 1,
        [Description("تابع محاسبه کننده")]
        DLLType = 2,
    } 

    [Description("ExpertState")]
    public enum ExpertState
    {
        [Description("")]
        None = 0,
        [Description("مرخصي ")]
        Leave = 1,
        [Description("تعليق ")]
        Suspend = 2,
        [Description("مشغول به كار")]
        Busy = 3,
        [Description("اتمام كار")]
        FinishJob = 4,
    } 

    [Description("FichePaymentForType")]
    public enum FichePaymentForType
    {
        [Description("")]
        None = 0,
        [Description("هزينه کارشناسي")]
        ExpertCost = 1,
        [Description("هزينه دادرسي")]
        JudgmentCost = 2,
        [Description("خسارت احتمالي")]
        LikelyDamage = 3,
    } 

    [Description("FichePersonType")]
    public enum FichePersonType
    {
        [Description("")]
        None = 0,
        [Description("شخص دخيل در پرونده")]
        CasePerson = 1,
        [Description("شخص دخيل در دادخواست  ")]
        PetitionPerson = 2,
    } 

    [Description("FieldDataType")]
    public enum FieldDataType
    {
        [Description("")]
        None = 0,
        [Description("متني")]
        Char = 1,
        [Description("عدد صحيح")]
        Integer = 2,
        [Description("عدد اعشاري")]
        Number = 3,
    } 

    [Description("FileExtension")]
    public enum FileExtension
    {
        [Description("")]
        None = 0,
        [Description("پي دي اف")]
        PDF = 1,
        [Description("تيفف")]
        TIFF = 2,
        [Description("جي پي  جي")]
        JPG = 3,
        [Description("پي ان جي")]
        PNG = 4,
        [Description("ورد")]
        DOC = 5,
        [Description("ورد دوهزاروهفت به بالا")]
        DOCX = 6,
        [Description("اکسل")]
        XLS = 7,
        [Description("اکسل دوهزاروهفت به بالا")]
        XLSX = 8,
        [Description("تيف")]
        TIF = 9,
        [Description("گيف")]
        GIF = 10,
        [Description("جي پي اي چي")]
        JPEG = 11,
        [Description("بي ام پي")]
        BMP = 12,
        [Description("فشرده يک")]
        RAR = 13,
        [Description("فشرده دو")]
        ZIP = 14,
    } 

    [Description("Finger")]
    public enum Finger
    {
        [Description("")]
        None = 0,
        [Description("انگشت شست دست راست")]
        Finger1 = 1,
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
        [Description("انگشت كوچك دست چپ")]
        Finger10 = 10,
    } 

    [Description("FrmBudgetType")]
    public enum FrmBudgetType
    {
        [Description("")]
        None = 0,
        [Description("وروداطلاعات توسط کاربر")]
        DataEntryForm = 1,
        [Description("محاسباتي")]
        CalculationForm = 2,
    } 

    [Description("GeneralOrganizationType")]
    public enum GeneralOrganizationType
    {
        [Description("")]
        None = 0,
        [Description("واحدهاي سازمان ثبت")]
        SSAAOrganization = 1,
        [Description("شعب دادگاه")]
        JudiciaryUnit = 2,
        [Description("شعب ناجا")]
        NAJAUnit = 3,
        [Description("ساير سازمانها")]
        OtherOrganization = 4,
    } 

    [Description("GroupControlType")]
    public enum GroupControlType
    {
        [Description("")]
        None = 0,
        [Description("زبونه")]
        PageControl = 1,
        [Description("گروه فيلد")]
        GroupBoxControl = 2,
        [Description("جدول")]
        TableSheet = 3,
    } 

    [Description("HaveAttachment")]
    public enum HaveAttachment
    {
        [Description("")]
        None = 0,
        [Description("پيوست مي باشد")]
        HaveAttachment = 1,
        [Description("پيوست نمي باشد")]
        HaveNotAttachment = 2,
    } 

    [Description("HaveNoHave")]
    public enum HaveNoHave
    {
        [Description("")]
        None = 0,
        [Description("ندارد")]
        NotHave = 1,
        [Description("دارد")]
        Have = 2,
    } 

    [Description("HistoryType")]
    public enum HistoryType
    {
        [Description("")]
        None = 0,
        [Description("غير كامپيوتري")]
        Manual = 1,
        [Description("كامپيوتري")]
        Systematic = 2,
    } 

    [Description("HolidayKind")]
    public enum HolidayKind
    {
        [Description("")]
        None = 0,
        [Description("روز کاري")]
        Work = 1,
        [Description("تعطيل رسمي")]
        Holiday = 2,
        [Description("تعطيل غيررسمي")]
        UnFormalHoliday = 3,
    } 

    [Description("HowCalcItem")]
    public enum HowCalcItem
    {
        [Description("")]
        None = 0,
        [Description("ورود اطلاعات توسط کاربر")]
        UserInput = 1,
        [Description("محاسبه بدون شرط از طريق ساير اقلام رکورد جاري")]
        CalcWithoutCond = 2,
        [Description("محاسبه با شرط از طريق ساير اقلام رکورد جاري")]
        CalcWithCond = 3,
        [Description("محاسبه از طريق تابع محاسبه کننده")]
        FunctionCalc = 4,
        [Description("محاسبه از طريق توابع محاسبه کننده در هنگام بارگزاري و ذخيره سازي")]
        LoadSaveFunctionCalc = 5,
    } 

    [Description("HowNotified")]
    public enum HowNotified
    {
        [Description("")]
        None = 0,
        [Description("توسط اداره پست")]
        ByPost = 1,
        [Description("به وسيله آگهي در روزنامه")]
        NewspaperNotice = 3,
        [Description("بوسيله رايانامه")]
        EMail = 4,
        [Description("توسط مامور ابلاغ")]
        OfficerNotified = 10,
    } 

    [Description("HowToMakeEvent")]
    public enum HowToMakeEvent
    {
        [Description("")]
        None = 0,
        [Description("مکانيزه")]
        Mechanize = 1,
        [Description("دستي")]
        Manual = 2,
    } 

    [Description("HstInsertState")]
    public enum HstInsertState
    {
        [Description("")]
        None = 0,
        [Description("گزارش بر اساس سوابق داده آمايي شده")]
        DataPreparationState = 1,
        [Description("گزارش بر اساس سوابق مکانيزه")]
        MechanizeState = 2,
        [Description("گزارش کلي سوابق")]
        TotalState = 3,
    } 

    [Description("IncomingLetterState")]
    public enum IncomingLetterState
    {
        [Description("")]
        None = 0,
        [Description("ثبت شده")]
        Registered = 1,
        [Description("رويت شده")]
        View = 2,
        [Description("برگشت داده شده به ثبت کننده")]
        Return = 3,
        [Description("ارجاع/ارسال شده به کاربر")]
        ReferByMngSecret = 4,
        [Description("برگشت داده شده به مدير")]
        ReturnToMng = 5,
    } 

    [Description("IncommingLetterSenderType")]
    public enum IncommingLetterSenderType
    {
        [Description("")]
        None = 0,
        [Description("شخص پرونده")]
        CasePerson = 1,
        [Description("واحد ثبتي")]
        SabtUnit = 2,
        [Description("از فهرست فرستنده ها")]
        SendersInList = 3,
        [Description("تايپ نام فرستنده")]
        SendersNotInList = 4,
    } 

    [Description("IndividualPersonType")]
    public enum IndividualPersonType
    {
        [Description("")]
        None = 0,
        [Description("حقيقي بجز وكيل")]
        NaturalPerson = 1,
        [Description("حقوقي           ")]
        Legal = 2,
        [Description("وكيل")]
        Lawyer = 3,
    } 

    [Description("InvisibleDisable")]
    public enum InvisibleDisable
    {
        [Description("")]
        None = 0,
        [Description("غير فعال")]
        Disable = 1,
        [Description("غير قابل رويت")]
        Invisible = 2,
    } 

    [Description("IsBaseRole")]
    public enum IsBaseRole
    {
        [Description("")]
        None = 0,
        [Description("نقش پايه اي")]
        Base = 1,
        [Description("نقش پستي")]
        Post = 2,
    } 

    [Description("IsDone")]
    public enum IsDone
    {
        [Description("")]
        None = 0,
        [Description("انجام شد")]
        Done = 1,
        [Description("انجام نشد")]
        NotDone = 2,
    } 

    [Description("IsReplay")]
    public enum IsReplay
    {
        [Description("")]
        None = 0,
        [Description("دارد ")]
        Have = 1,
        [Description("ندارد ")]
        NotHave = 2,
    } 

    [Description("IssueDocTime")]
    public enum IssueDocTime
    {
        [Description("")]
        None = 0,
        [Description("قبل از دريافت وجه از شخص")]
        BeforeGetMoney = 1,
        [Description("بعد از دريافت وجه از شخص")]
        AfterGetMoney = 2,
    } 

    [Description("JOperandType")]
    public enum JOperandType
    {
        [Description("")]
        None = 0,
        [Description("عملوند عددي از جنس قلم اطلاعاتي فرم")]
        NumericalField = 1,
        [Description("عدد ثابت")]
        NumericalConstant = 2,
        [Description("عملوند عددي از جنس جمع ستون عددي")]
        SumNumericColumn = 3,
        [Description("عملوند مروبط به ستون اطلاعات پايه")]
        BaseInfoColumn = 4,
    } 

    [Description("JudgementType")]
    public enum JudgementType
    {
        [Description("")]
        None = 0,
        [Description("محکوميت")]
        Condemnation = 1,
        [Description("برائت")]
        Innocence = 2,
    } 

    [Description("JudgeScriptoriumActivityReport")]
    public enum JudgeScriptoriumActivityReport
    {
        [Description("")]
        None = 0,
        [Description("اداره کل")]
        HighOffice = 1,
        [Description("موضوع راي/قرارنهايي")]
        JudgeType = 2,
        [Description("تعداد کل")]
        Jam = 3,
        [Description("اسناد رسمي")]
        AsnadRasmi = 4,
        [Description("ازدواج و طلاق")]
        EzdevajTalag = 5,
        [Description("ازدواج")]
        Ezdevaj = 6,
    } 

    [Description("JudgeScriptoriumPostTypeReport")]
    public enum JudgeScriptoriumPostTypeReport
    {
        [Description("")]
        None = 0,
        [Description("اداره کل")]
        HighOffice = 1,
        [Description("موضوع راي/قرارنهايي")]
        JudgeType = 2,
        [Description("تعداد کل")]
        Jam = 3,
        [Description("سردفتر")]
        Sardaftar = 4,
        [Description("دفتريار اول")]
        DaftarYarAval = 5,
        [Description("دفتريار دوم")]
        DaftarYarDovom = 6,
        [Description("کفيل دفتريار")]
        KafilDaftarYar = 7,
        [Description("کفيل سردفتر")]
        KafilSardaftar = 8,
    } 

    [Description("JudiciaryUnitType")]
    public enum JudiciaryUnitType
    {
        [Description("")]
        None = 0,
        [Description("شعبه")]
        Court = 3,
        [Description("مجتمع قضايي")]
        JudicialComplex = 5,
        [Description("شوراي حل اختلاف")]
        Shora = 6,
        [Description("دادسراي عمومي و انقلاب")]
        Dadsara = 7,
        [Description("دادگاه عمومي و انقلاب")]
        Dadgah = 8,
        [Description("حوزه قضايي")]
        JuratoryArea = 9,
        [Description("اداره كل دادگستري استان")]
        HeadOffice = 20,
        [Description("سازمان قضايي")]
        OrganizationJudge = 30,
    } 

    [Description("KeepPricePeriod")]
    public enum KeepPricePeriod
    {
        [Description("")]
        None = 0,
        [Description("بطور يکجا")]
        OverAll = 1,
        [Description("روزانه")]
        Daily = 2,
        [Description("هفتگي")]
        Weekly = 3,
        [Description("ماهانه")]
        Monthly = 4,
    } 

    [Description("KindsOfNoticePeople")]
    public enum KindsOfNoticePeople
    {
        [Description("")]
        None = 0,
        [Description("حقيقي")]
        Natural = 1,
        [Description("حقوقي")]
        Legal = 2,
        [Description("ورثه")]
        Heirs = 3,
        [Description("حقيقي/حقوقي")]
        NaturalOrLegal = 4,
    } 

    [Description("LAdductor")]
    public enum LAdductor
    {
        [Description("")]
        None = 0,
        [Description("سازمان")]
        OurOrg = 1,
        [Description("طرف مقابل")]
        OtherPerson = 2,
        [Description("شرکت")]
        Company = 3,
    } 

    [Description("LargeFieldTextSaveType")]
    public enum LargeFieldTextSaveType
    {
        [Description("")]
        None = 0,
        [Description("Html")]
        HtmlType = 1,
        [Description("RTF")]
        RTFType = 2,
    } 

    [Description("LastExecuteStatus")]
    public enum LastExecuteStatus
    {
        [Description("")]
        None = 0,
        [Description("اجرا نشده")]
        NotExecuted = 1,
        [Description("در حين اجرا به خطا برخورده كرده")]
        Failed = 2,
        [Description("اجرا شده")]
        Executed = 3,
    } 

    [Description("LawyerDegree")]
    public enum LawyerDegree
    {
        [Description("")]
        None = 0,
        [Description("وكيل پايه 1 دادگستري")]
        FirstClassLawyer = 1,
        [Description("مشاور درجه 1")]
        FirstClassConcultant = 2,
        [Description("مشاور درجه 2")]
        SecondClassConcultant = 3,
        [Description("كارآموز وكالت")]
        LearningClassConcultant = 4,
    } 

    [Description("LawyerState")]
    public enum LawyerState
    {
        [Description("")]
        None = 0,
        [Description("مشغول به كار")]
        Work = 1,
        [Description("ابطال پروانه")]
        DisproofLicense = 2,
        [Description("معلق شده")]
        Suspension = 3,
        [Description("بازنشسته شده")]
        Retired = 4,
        [Description("فوت شده")]
        Dead = 5,
        [Description("توديع پروانه")]
        GiveBackLicense = 6,
    } 

    [Description("LawyerTypeLicense")]
    public enum LawyerTypeLicense
    {
        [Description("")]
        None = 0,
        [Description("كانون وكلاء دادگستري")]
        LawyerBand = 1,
        [Description("مركز مشاورين قوه قضاييه")]
        AdvisorJudicature = 2,
    } 

    [Description("LegalPersonType")]
    public enum LegalPersonType
    {
        [Description("")]
        None = 0,
        [Description("دولتي")]
        State = 1,
        [Description("حكومتي")]
        Government = 2,
        [Description("عمومي غير دولتي")]
        Public = 3,
        [Description("غيردولتي(خصوصي/تعاوني(")]
        NonState = 4,
    } 

    [Description("LetterAttachmentType")]
    public enum LetterAttachmentType
    {
        [Description("")]
        None = 0,
        [Description("مدرک مکانيزه")]
        Mechanize = 1,
        [Description("سند يا پيوست غيرمکانيزه")]
        NonMechanize = 2,
    } 

    [Description("LetterBetweenOrgState")]
    public enum LetterBetweenOrgState
    {
        [Description("")]
        None = 0,
        [Description("ارسال نشده")]
        NotSend = 1,
        [Description("ارسال شده")]
        Sended = 2,
        [Description("دريافت شده")]
        Receive = 3,
        [Description("رويت شده")]
        View = 4,
        [Description("ارجاع داده شده")]
        Refer = 5,
        [Description("برگشت داده شده")]
        Return = 6,
    } 

    [Description("LetterType")]
    public enum LetterType
    {
        [Description("")]
        None = 0,
        [Description("اصل نامه   ")]
        Letter = 1,
        [Description("رونوشت نامه")]
        Copy = 2,
    } 

    [Description("LifeState")]
    public enum LifeState
    {
        [Description("")]
        None = 0,
        [Description("زنده")]
        Alive = 1,
        [Description("متوفي")]
        Dead = 2,
    } 

    [Description("LNationality")]
    public enum LNationality
    {
        [Description("")]
        None = 0,
        [Description("ايراني")]
        Iranian = 1,
        [Description("غير ايراني")]
        Foreign = 2,
    } 

    [Description("LOBFieldType")]
    public enum LOBFieldType
    {
        [Description("")]
        None = 0,
        [Description("CLOB SimpleText")]
        CLOB_SimpleText = 1,
        [Description("CLOB RTF")]
        CLOB_RTFType = 2,
        [Description("Image")]
        ImageType = 3,
        [Description("BLOB SimpleText")]
        BLOB_SimpleText = 4,
        [Description("BLOB RTF")]
        BLOB_RTFType = 5,
        [Description("ساير")]
        OtherBLOBType = 6,
    } 

    [Description("LocationType")]
    public enum LocationType
    {
        [Description("")]
        None = 0,
        [Description("كشور")]
        Country = 1,
        [Description("استان_ايالت")]
        State = 2,
        [Description("شهرستان")]
        Province = 3,
        [Description("بخش")]
        Section = 4,
        [Description("شهر")]
        City = 5,
        [Description("دهستان")]
        Part = 6,
        [Description("ده")]
        Village = 7,
    } 

    [Description("LookupShowType")]
    public enum LookupShowType
    {
        [Description("")]
        None = 0,
        [Description("کد و عنوان با هم")]
        CodeAndTitle = 1,
        [Description("فقط عنوان")]
        TitleOnly = 2,
        [Description("فقط کد")]
        CodeOnly = 3,
    } 

    [Description("LpmsNCodeInquiryType")]
    public enum LpmsNCodeInquiryType
    {
        [Description("")]
        None = 0,
        [Description("استعلام بر اساس شناسه ملي")]
        InquiryByNationalCode = 1,
        [Description("استعلام بر اساس نام فعال")]
        InquiryByActiveFullName = 2,
        [Description("استعلام بر اساس سوابق نام")]
        InquiryByArchiveFullName = 3,
        [Description("استعلام صحت شناسه ملي")]
        InquiryValidateNationalCode = 4,
    } 

    [Description("LReligion")]
    public enum LReligion
    {
        [Description("")]
        None = 0,
        [Description("اسلام")]
        Muslim = 1,
        [Description("غير اسلام")]
        NonMuslim = 2,
    } 

    [Description("MainMinorTemplate")]
    public enum MainMinorTemplate
    {
        [Description("")]
        None = 0,
        [Description("کليشه اصلي")]
        Main = 1,
        [Description("کليشه فرعي")]
        Miror = 2,
    } 

    [Description("MarriageState")]
    public enum MarriageState
    {
        [Description("")]
        None = 0,
        [Description("مجرد")]
        Single = 1,
        [Description("متاهل")]
        Married = 2,
        [Description("معيل")]
        HasWifeChild = 3,
    } 

    [Description("MathOperator")]
    public enum MathOperator
    {
        [Description("")]
        None = 0,
        [Description("جمع")]
        Sum = 1,
        [Description("منها")]
        Minus = 2,
        [Description("ضرب")]
        Multiplication = 3,
        [Description("تقسيم")]
        Division = 4,
    } 

    [Description("MeasurementUnitType")]
    public enum MeasurementUnitType
    {
        [Description("")]
        None = 0,
        [Description("طول")]
        Length = 1,
        [Description("مساحت")]
        Area = 2,
        [Description("پول")]
        Money = 3,
        [Description("زمان")]
        Time = 4,
        [Description("وزن")]
        Weight = 5,
        [Description("حجم")]
        Voluminosity = 6,
        [Description("ساير")]
        Other = 30,
    } 

    [Description("MechanizedFieldType")]
    public enum MechanizedFieldType
    {
        [Description("")]
        None = 0,
        [Description("فايل مدرک غيرمکانيزه")]
        NonMechanizedDocFile = 1,
        [Description("فايل چاپي يک مدرک مکانيزه ذيل پرونده(يا مدرک اصلي مشابه آن) که مدرک توسط کاربر مشخص مي شود")]
        PrintFile4Doc = 2,
        [Description("قلم اطلاعاتي غيرمکانيزه که بصورت دستي وارد مي شود بجز تصاوير و فايل ها")]
        NonMechanizedField = 3,
        [Description("قلم اطلاعاتي که از مدرک مکانيزه مربوطه بصورت اتوماتيک مقداردهي مي شود بجز فايل چاپي مدرک")]
        MechanizedField = 4,
        [Description("آبجکت جيسوني مدرک مکانيزه مربوطه که مدرک توسط کاربر مشخص مي شود")]
        JSON4Doc = 5,
    } 

    [Description("MechanizedLetterCaseLocation")]
    public enum MechanizedLetterCaseLocation
    {
        [Description("")]
        None = 0,
        [Description("مبداء")]
        Source = 1,
        [Description("مقصد")]
        Destination = 2,
    } 

    [Description("MechanizedLetterMainRcvOrTranscriptRcv")]
    public enum MechanizedLetterMainRcvOrTranscriptRcv
    {
        [Description("")]
        None = 0,
        [Description("گيرنده اصل نامه")]
        MainReceiver = 1,
        [Description("رونوشت گيرنده")]
        TranscriptReceiver = 2,
    } 

    [Description("MechanizedLetterOrgTypeReceiver")]
    public enum MechanizedLetterOrgTypeReceiver
    {
        [Description("")]
        None = 0,
        [Description("مخصوص درون سازماني")]
        InnerOrg = 1,
        [Description("مخصوص برون سازماني")]
        OuterOrg = 2,
        [Description("هم درون سازماني هم برون سازماني")]
        InnerAndOuterOrg = 3,
    } 

    [Description("MechanizedLetterReceiverType")]
    public enum MechanizedLetterReceiverType
    {
        [Description("")]
        None = 0,
        [Description("درون سازماني")]
        InnerOrg = 1,
        [Description("برون سازماني")]
        OutterOrg = 2,
    } 

    [Description("MechanizedLetterRelLetterGetType")]
    public enum MechanizedLetterRelLetterGetType
    {
        [Description("")]
        None = 0,
        [Description("دستي")]
        NonMechanize = 1,
        [Description("مکانيزه")]
        Mechanize = 2,
    } 

    [Description("MechanizedLetterRelType")]
    public enum MechanizedLetterRelType
    {
        [Description("")]
        None = 0,
        [Description("بازگشت")]
        Comeback = 1,
        [Description("پيرو")]
        Follower = 2,
    } 

    [Description("MechanizeLetterActionLevel")]
    public enum MechanizeLetterActionLevel
    {
        [Description("")]
        None = 0,
        [Description("تهيه کننده")]
        Creator = 1,
        [Description("ارسال کننده")]
        Sender = 2,
        [Description("تأييد کننده")]
        Confimer = 3,
        [Description("ارجاع کننده")]
        Refferer = 4,
        [Description("رويت کننده")]
        Viewer = 5,
    } 

    [Description("MechanizeRefererType")]
    public enum MechanizeRefererType
    {
        [Description("")]
        None = 0,
        [Description("واحد سازماني")]
        Unit = 1,
        [Description("کاربر سامانه")]
        UserPost = 2,
        [Description("سمت")]
        PostRole = 3,
    } 

    [Description("MenuItemState")]
    public enum MenuItemState
    {
        [Description("")]
        None = 0,
        [Description("فعال")]
        Enable = 1,
        [Description("غيرفعال")]
        Disable = 2,
        [Description("پنهان")]
        Hide = 3,
    } 

    [Description("MessageForceType")]
    public enum MessageForceType
    {
        [Description("")]
        None = 0,
        [Description("خيلي فوري")]
        VeryUrgent = 1,
        [Description("فوري")]
        Urgent = 2,
        [Description("عادي")]
        Normal = 3,
    } 

    [Description("MessageRecieverType")]
    public enum MessageRecieverType
    {
        [Description("")]
        None = 0,
        [Description("كاربر")]
        Employee = 1,
        [Description("واحد ثبتي ")]
        Unit = 2,
    } 

    [Description("MessageSecurityType")]
    public enum MessageSecurityType
    {
        [Description("")]
        None = 0,
        [Description("ساير افراد")]
        Normal = 1,
        [Description("رييس واحد يا ناظر")]
        Boss = 2,
        [Description("مدير سيستم")]
        SystemManager = 3,
    } 

    [Description("MessageState")]
    public enum MessageState
    {
        [Description("")]
        None = 0,
        [Description("ارسال نشده")]
        NotSend = 1,
        [Description("ارسال شده")]
        Sended = 2,
    } 

    [Description("MethodType")]
    public enum MethodType
    {
        [Description("")]
        None = 0,
        [Description("چک کننده")]
        CheckerType = 1,
        [Description("مقدار اوليه ده به جداول بودجه")]
        InitializationValueType = 2,
        [Description("چاپ کننده فرم بودجه اي")]
        PrintForm = 3,
        [Description("فقط خواندني کننده گروه")]
        ReadOnlyGroup = 4,
    } 

    [Description("MilitaryState")]
    public enum MilitaryState
    {
        [Description("")]
        None = 0,
        [Description("پايان خدمت")]
        Finished = 1,
        [Description("معافيت تحصيلي")]
        EducationalExepmtion = 2,
        [Description("معافيت کفالت")]
        BailmentExemption = 3,
        [Description("معافيت پزشکي")]
        MedicalExepmtion = 4,
        [Description("خريد خدمت")]
        Buying = 5,
        [Description("معافيت رهبري")]
        Rahbar = 6,
    } 

    [Description("MLetterSendTYpe")]
    public enum MLetterSendTYpe
    {
        [Description("")]
        None = 0,
        [Description("ارجاع")]
        Refer = 1,
        [Description("بازگشت")]
        Return = 2,
    } 

    [Description("Month")]
    public enum Month
    {
        [Description("")]
        None = 0,
        [Description("فروردين")]
        Farvardin = 1,
        [Description("ارديبهشت")]
        Ordibehesht = 2,
        [Description("خرداد")]
        Khordad = 3,
        [Description("تير")]
        Tir = 4,
        [Description("مرداد")]
        Mordad = 5,
        [Description("شهريور")]
        Shahrivar = 6,
        [Description("مهر")]
        Mehr = 7,
        [Description("آبان")]
        Aban = 8,
        [Description("آذر")]
        Azar = 9,
        [Description("دي")]
        Day = 10,
        [Description("بهمن")]
        Bahman = 11,
        [Description("اسفند")]
        Esfand = 12,
    } 

    [Description("MultiSessionPolicy")]
    public enum MultiSessionPolicy
    {
        [Description("")]
        None = 0,
        [Description("شناسه کاربري با اين نوع نقش بتواند روي چند کامپيوتر بطور همزمان وصل شود")]
        Optimistic = 1,
        [Description("با اتصال يک شناسه کاربري با اين نوع نقش، پس از هشدار، همه اتصالات قبلي روي ساير کامپيوترها قطع شده، سپس اين اتصال برقرار شود")]
        SemiPessimistic = 2,
        [Description("با اتصال يک شناسه کاربري با اين نوع نقش، ابتدا همه اتصالات قبلي روي ساير کامپيوترها قطع شده، سپس اين اتصال برقرار شود")]
        Pessimistic = 3,
    } 

    [Description("NAJAUnitType")]
    public enum NAJAUnitType
    {
        [Description("")]
        None = 0,
        [Description("اداره صدور گذرنامه")]
        PassportOffice = 1,
    } 

    [Description("NameSearchType")]
    public enum NameSearchType
    {
        [Description("")]
        None = 0,
        [Description("مطابق عبارت وارد شده")]
        EqualSearch = 1,
        [Description("ترکيب تمامي کلمات")]
        AndSearch = 2,
        [Description("ترکيب تک تک کلمات")]
        OrSearch = 3,
    } 

    [Description("NameState")]
    public enum NameState
    {
        [Description("")]
        None = 0,
        [Description("تأييد ")]
        Confirm = 1,
        [Description("رد")]
        Reject = 2,
        [Description("در انتظار بررسي")]
        WateingForCheking = 3,
        [Description("رد نام به دليل رد درخواست تغيير/تاسيس")]
        RejectByRejectReq = 4,
    } 

    [Description("NationalityType")]
    public enum NationalityType
    {
        [Description("")]
        None = 0,
        [Description("ايراني")]
        Iranian = 1,
        [Description("اتباع بيگانه")]
        Foreign = 2,
    } 

    [Description("NeedFollowUp")]
    public enum NeedFollowUp
    {
        [Description("")]
        None = 0,
        [Description(" دارد ")]
        Have = 1,
        [Description(" ندارد ")]
        NoHave = 2,
    } 

    [Description("NewspaperCertificateType")]
    public enum NewspaperCertificateType
    {
        [Description("")]
        None = 0,
        [Description("چاپي")]
        Printed = 1,
        [Description("الکترونيک - برخط")]
        Online = 2,
        [Description("الکترونيک - غيربرخط")]
        Offline = 3,
    } 

    [Description("NewspaperGroupLevel")]
    public enum NewspaperGroupLevel
    {
        [Description("")]
        None = 0,
        [Description("گروه کم هزينه")]
        LowCostCategory = 1,
        [Description("گروه پرهزينه")]
        HighCostCategory = 2,
    } 

    [Description("NewspaperPeriod")]
    public enum NewspaperPeriod
    {
        [Description("")]
        None = 0,
        [Description("روزنامه")]
        Daily = 1,
        [Description("دو شماره در هفته")]
        TwoInWeek = 2,
        [Description("هفته نامه")]
        Weekly = 3,
        [Description("دو هفته نامه")]
        TwoWeekly = 4,
        [Description("ماهنامه")]
        Monthly = 5,
        [Description("دو ماهنامه")]
        TwoMonthly = 6,
        [Description("فصلنامه")]
        Quarterly = 7,
        [Description("دو فصلنامه")]
        TwoQuarterly = 8,
        [Description("سالانه")]
        Annually = 9,
        [Description("خبرگزاري")]
        Press = 10,
        [Description("پايگاه خبري")]
        NewsSite = 11,
    } 

    [Description("NewspaperPrintArea")]
    public enum NewspaperPrintArea
    {
        [Description("")]
        None = 0,
        [Description("سراسري")]
        InCountry = 1,
        [Description("استاني")]
        InOstan = 2,
        [Description("منطقه اي")]
        Regional = 3,
        [Description("محلي")]
        Local = 4,
    } 

    [Description("NotaryActivityType")]
    public enum NotaryActivityType
    {
        [Description("")]
        None = 0,
        [Description("ازدواج")]
        Marriage = 1,
        [Description("ازدواج و طلاق")]
        Divorce = 2,
        [Description("اسناد رسمي")]
        Documents = 3,
    } 

    [Description("NotaryCardCreditDurationScale")]
    public enum NotaryCardCreditDurationScale
    {
        [Description("")]
        None = 0,
        [Description("سـال")]
        Year = 1,
        [Description("ماه")]
        Month = 2,
    } 

    [Description("NotaryCardRequesterPost")]
    public enum NotaryCardRequesterPost
    {
        [Description("")]
        None = 0,
        [Description("سـردفتر")]
        Sardaftar = 1,
        [Description("دفتريار")]
        Daftaryar = 2,
        [Description("کـارمند")]
        Employee = 3,
        [Description("بازنـشسته")]
        Retired = 4,
    } 

    [Description("NotaryCardState")]
    public enum NotaryCardState
    {
        [Description("")]
        None = 0,
        [Description("تنظيم شده")]
        Created = 1,
        [Description("چاپ شده")]
        Printed = 2,
    } 

    [Description("NotaryCardType")]
    public enum NotaryCardType
    {
        [Description("")]
        None = 0,
        [Description("اصلي")]
        Asli = 1,
        [Description("المثني")]
        Almosana = 2,
    } 

    [Description("NotaryOccupationState")]
    public enum NotaryOccupationState
    {
        [Description("")]
        None = 0,
        [Description("شاغل")]
        Working = 1,
        [Description("انفصال موقت")]
        Discharge = 2,
        [Description("معلق")]
        Floating = 3,
        [Description("مرخصي استحقاقي")]
        LeavrJustly = 4,
        [Description("مرخصي استعلاجي")]
        LeaveSick = 5,
        [Description("مرخصي تحصيلي")]
        Education = 6,
        [Description("مرخصي استحقاقي خروج از کشور")]
        LeaveAbroad = 7,
        [Description("معذوريت از حضور در محل دفترخانه")]
        Excuse = 8,
        [Description("بازنشسته")]
        Retirement = 9,
        [Description("مستعفي")]
        Resigned = 10,
        [Description("سلب صلاحيت")]
        Disqualification = 11,
        [Description("انفصال دائم")]
        DischargeContinual = 12,
        [Description("معافيت از اشتغال")]
        ExemptionWorking = 13,
        [Description("لغو ابلاغ ماده 74")]
        LiftNotification74 = 14,
        [Description("فوت")]
        Dead = 16,
        [Description("لغو ابلاغ ماده 13")]
        LiftNotification13 = 16,
    } 

    [Description("NotaryRelatedPersonEndReason")]
    public enum NotaryRelatedPersonEndReason
    {
        [Description("")]
        None = 0,
        [Description("ا زدواج")]
        Marriage = 1,
        [Description("طلاق")]
        Divorce = 2,
        [Description("اشتغال به کار")]
        Work = 3,
        [Description("فـوت")]
        Death = 4,
        [Description("استعفا")]
        Resign = 5,
        [Description("انفصال دائـم")]
        Separation = 6,
        [Description("اولاد ارشد")]
        FirstChild = 8,
        [Description("مصوبه هيأت مديره")]
        Approved = 9,
        [Description("ساير")]
        OtherReasons = 10,
        [Description("حکم دادگاه")]
        JudgeHokm = 11,
    } 

    [Description("NotarySmsState")]
    public enum NotarySmsState
    {
        [Description("")]
        None = 0,
        [Description("تنظيم شده")]
        Created = 1,
        [Description("کد ارسال شده و منتظر تأييد است")]
        CodeSent = 2,
        [Description("ارسـال شده")]
        Sent = 3,
    } 

    [Description("NoticeFinalResult")]
    public enum NoticeFinalResult
    {
        [Description("")]
        None = 0,
        [Description("عودت از مرجع ابلاغ")]
        DoNotice = 1,
        [Description("مجهول است")]
        DonotNotice = 2,
        [Description("ابلاغ حضوري")]
        DeliverdInPerson = 3,
    } 

    [Description("NoticeResultType")]
    public enum NoticeResultType
    {
        [Description("")]
        None = 0,
        [Description("واقعي")]
        RealNotice = 1,
        [Description("قانوني")]
        LawNotice = 2,
        [Description("استنکاف")]
        Refusal = 3,
        [Description("انجام نشده است")]
        NotDone = 9,
    } 

    [Description("NotificationFieldBasicType")]
    public enum NotificationFieldBasicType
    {
        [Description("")]
        None = 0,
        [Description("عددي")]
        NumberType = 1,
        [Description("رشته اي")]
        StringType = 2,
        [Description("تاريخي")]
        DateType = 3,
    } 

    [Description("NotificationTypePersmission")]
    public enum NotificationTypePersmission
    {
        [Description("")]
        None = 0,
        [Description("استان")]
        Province = 1,
        [Description("ستاد")]
        headquarters = 2,
        [Description("واحد ثبتي")]
        Unit = 3,
    } 

    [Description("ObjectSendState")]
    public enum ObjectSendState
    {
        [Description("")]
        None = 0,
        [Description("ارسال نشده")]
        NotSend = 1,
        [Description("ارسال شده")]
        Sended = 2,
    } 

    [Description("OperandType")]
    public enum OperandType
    {
        [Description("")]
        None = 0,
        [Description("قلم اطلاعاتي و متغيرهاي محيطي")]
        DataItem = 1,
        [Description(" ثابت")]
        ConstantValue = 2,
        [Description("پارامتر")]
        Parameter = 3,
    } 

    [Description("OperatorType")]
    public enum OperatorType
    {
        [Description("")]
        None = 0,
        [Description("بزرگتر")]
        Greater = 1,
        [Description("بزرگتر يا مساوي")]
        GreaterOrEqual = 2,
        [Description("مخالف")]
        NotEqual = 3,
        [Description("مساوي")]
        Equal = 4,
        [Description("کوچکتر")]
        LessThan = 5,
        [Description("کوچکتر يا مساوي")]
        LessThanOrEqual = 6,
        [Description("پيش شباهت")]
        PreWordLike = 7,
        [Description("پس شباهت")]
        LastWordLike = 8,
        [Description("حاوي")]
        Like = 9,
    } 

    [Description("OprationSelectedState")]
    public enum OprationSelectedState
    {
        [Description("")]
        None = 0,
        [Description("پيش نويس")]
        Preview = 1,
        [Description("تاييد شده")]
        Publishable = 2,
    } 

    [Description("Org4ExchangeData")]
    public enum Org4ExchangeData
    {
        [Description("")]
        None = 0,
        [Description("دادگستري")]
        Judiciary = 1,
        [Description("ناجا")]
        NAJA = 2,
        [Description("روزنامه رسمي")]
        LagalNewspaper = 3,
        [Description("سازمان ثبت احوال کشور")]
        PersonEventRegisterationOrg = 4,
    } 

    [Description("OrgSenderType")]
    public enum OrgSenderType
    {
        [Description("")]
        None = 0,
        [Description("سازمان ثبت")]
        Sabt = 1,
        [Description("سازمان مربوطه")]
        OtherOrg = 2,
        [Description("هر دو")]
        BothOfThem = 3,
    } 

    [Description("OtherAction")]
    public enum OtherAction
    {
        [Description("")]
        None = 0,
        [Description("وصول نامه وارده با موضوع خاص")]
        InputLetter = 1,
        [Description("اقدام ها بابت اظهارنامه صادره")]
        Declaration = 2,
        [Description("اقدام ها بابت طرح دعواي صادره سازمان با موضوع خاص")]
        Petition = 3,
        [Description("موضوع کارشناسي، بجز موضوعات جلسه دادرسي، نيازمند به اقدام")]
        ExpertReportSubjectType = 4,
    } 

    [Description("OutgoingLetterRecieverType")]
    public enum OutgoingLetterRecieverType
    {
        [Description("")]
        None = 0,
        [Description("شخص پرونده ")]
        CasePerson = 1,
        [Description("واحد ثبتي")]
        SabtUnit = 2,
        [Description("از فهرست گيرندگان")]
        RecieversInList = 3,
        [Description("تايپ گيرنده")]
        RecieversNotInList = 4,
    } 

    [Description("OutgoingLetterState")]
    public enum OutgoingLetterState
    {
        [Description("")]
        None = 0,
        [Description("ثبت شده جهت تاييد")]
        Registered = 1,
        [Description("تاييد شده")]
        Confirmed = 2,
        [Description("ارسال شده")]
        Sended = 3,
        [Description("برگشت داده شده")]
        Return = 4,
        [Description("پيش نويس شده")]
        PreSend = 6,
    } 

    [Description("OverallBranchType")]
    public enum OverallBranchType
    {
        [Description("")]
        None = 0,
        [Description("دادگاه")]
        Court = 1,
        [Description("دادسرا")]
        Prosecuter = 2,
    } 

    [Description("PArticle50ChiefOrder")]
    public enum PArticle50ChiefOrder
    {
        [Description("")]
        None = 0,
        [Description("قبول ايراد و ارجاع پرونده به شعبه تجديد نظر")]
        Accept = 1,
        [Description("رد درخواست و دستور اعاده پرونده به استان")]
        Reject = 2,
    } 

    [Description("PArticleChekingResult")]
    public enum PArticleChekingResult
    {
        [Description("")]
        None = 0,
        [Description("قبول ايراد")]
        Accept = 1,
        [Description("رد ايراد")]
        Reject = 2,
    } 

    [Description("PaymentMediaType")]
    public enum PaymentMediaType
    {
        [Description("")]
        None = 0,
        [Description("اينترنتي")]
        ViaInternet = 1,
        [Description("پايانه فروش")]
        ViaPos = 2,
        [Description("فيش بانکي")]
        ViaFiche = 3,
    } 

    [Description("PaymentRecieptType")]
    public enum PaymentRecieptType
    {
        [Description("")]
        None = 0,
        [Description("دريافت از شخص")]
        Reciept = 1,
        [Description("پرداخت به شخص")]
        Payment = 2,
    } 

    [Description("PenaltyType")]
    public enum PenaltyType
    {
        [Description("")]
        None = 0,
        [Description("محکوميت مدني")]
        CivilPenalty = 1,
        [Description("مجازات کيفري")]
        CriminalPenalty = 2,
        [Description("قرار")]
        Writ = 3,
        [Description("دستور قضايي")]
        JudgeOrder = 4,
    } 

    [Description("PerformerType")]
    public enum PerformerType
    {
        [Description("")]
        None = 0,
        [Description("فرم")]
        SystemForm = 1,
        [Description("ساير")]
        Other = 2,
    } 

    [Description("PermissionType")]
    public enum PermissionType
    {
        [Description("")]
        None = 0,
        [Description("قابل رويت")]
        Visible = 1,
        [Description("قابل رويت و قابل ويرايش")]
        VisibleEditable = 2,
    } 

    [Description("PersonGeneralType")]
    public enum PersonGeneralType
    {
        [Description("")]
        None = 0,
        [Description("حقوقي-شرکت يا سازمان")]
        LegalUnit = 1,
        [Description("حقوقي-شخص سمت دار")]
        LegalPerson = 2,
        [Description("حقيقي-قاضي")]
        Judge = 3,
        [Description("حقيقي-وکيل دادگستري")]
        LawyerPerson = 4,
        [Description("حقيقي-نظامي")]
        SoldierPerson = 5,
        [Description("حقيقي-ساير")]
        OtherRealPerson = 6,
    } 

    [Description("PersonType")]
    public enum PersonType
    {
        [Description("")]
        None = 0,
        [Description("حقيقي")]
        NaturalPerson = 1,
        [Description("حقوقي")]
        Legal = 2,
    } 

    [Description("PlannedObjection")]
    public enum PlannedObjection
    {
        [Description("")]
        None = 0,
        [Description("عدم تناسب جريمه")]
        Fine = 1,
        [Description("عدم انطباق راي با قانون")]
        Law = 2,
    } 

    [Description("PlaqueScript")]
    public enum PlaqueScript
    {
        [Description("")]
        None = 0,
        [Description("الف")]
        Alef = 1,
        [Description("ب")]
        B = 2,
        [Description("ت")]
        T = 3,
        [Description("ج")]
        J = 4,
        [Description("چ-ژ")]
        ChJh = 5,
        [Description("د")]
        Dal = 6,
        [Description("س")]
        Sin = 7,
        [Description("ص")]
        Sad = 8,
        [Description("ط")]
        Ta = 9,
        [Description("ع")]
        Ain = 10,
        [Description("ق")]
        Ghaf = 11,
        [Description("گ")]
        Gav = 12,
        [Description("ل")]
        L = 13,
        [Description("م")]
        Mim = 14,
        [Description("ن")]
        Non = 15,
        [Description("و")]
        Vav = 16,
        [Description("ه")]
        He = 17,
        [Description("ي")]
        Ye = 18,
        [Description("D")]
        D = 19,
        [Description("S")]
        S = 20,
    } 

    [Description("PlaqueType")]
    public enum PlaqueType
    {
        [Description("")]
        None = 0,
        [Description("ايران")]
        Iran = 1,
        [Description("TIR")]
        TIR = 2,
        [Description("گذر موقت")]
        PassTemporary = 3,
    } 

    [Description("PoliceType")]
    public enum PoliceType
    {
        [Description("")]
        None = 0,
        [Description("اداره ابلاغ ")]
        NotifiedOffice = 1,
        [Description("كلانتري")]
        Police = 2,
        [Description("زندان")]
        Prison = 3,
        [Description("ساير مراكز انتظامي")]
        OtherPolice = 5,
        [Description("مراكز نظامي")]
        MilitaryService = 6,
        [Description("ساير  ")]
        Other = 10,
    } 

    [Description("PostType")]
    public enum PostType
    {
        [Description("")]
        None = 0,
        [Description("مدير سيستم ")]
        SystemManager = 137,
        [Description("سابقه ياب")]
        inveterate = 260,
        [Description("اطلاع رسان")]
        Information = 290,
        [Description("مدير كلان سيستم")]
        HighManager = 300,
        [Description("گزارش ساز")]
        ReportBuilder = 460,
    } 

    [Description("ProcedureCostState")]
    public enum ProcedureCostState
    {
        [Description("")]
        None = 0,
        [Description("پرداختي طرف مقابل")]
        OtherSidePayed = 1,
        [Description("پرداخت نشده")]
        NotPayed = 2,
        [Description("پرداخت شده")]
        Payed = 3,
    } 

    [Description("ProceedingCostType")]
    public enum ProceedingCostType
    {
        [Description("")]
        None = 0,
        [Description("نيم عشر")]
        FivePercent = 1,
        [Description("ربع عشر")]
        HalfFivePercent = 2,
    } 

    [Description("ProcessServerType")]
    public enum ProcessServerType
    {
        [Description("")]
        None = 0,
        [Description("كارمند")]
        Employee = 1,
        [Description("غير كارمند")]
        UnEmployee = 2,
    } 

    [Description("ProductOrService")]
    public enum ProductOrService
    {
        [Description("")]
        None = 0,
        [Description("کالا")]
        Product = 1,
        [Description("خدمت")]
        Service = 2,
    } 

    [Description("Protester")]
    public enum Protester
    {
        [Description("")]
        None = 0,
        [Description("متعهد")]
        Debtor = 1,
        [Description("متعهد له")]
        Creditor = 2,
        [Description("شخص ثالث")]
        ThirdPerson = 3,
        [Description("کار گروه بررسي آراء هياتهاي نظارت استانها")]
        GroupTeam = 4,
    } 

    [Description("ReceiverServerType")]
    public enum ReceiverServerType
    {
        [Description("")]
        None = 0,
        [Description("خادم سازمان ثبت")]
        CMSServer = 1,
        [Description("قوه قضاييه")]
        Judiciary = 2,
        [Description("روزنامه رسمي")]
        LagalNewspaper = 3,
    } 

    [Description("RefrenceType")]
    public enum RefrenceType
    {
        [Description("")]
        None = 0,
        [Description("مرجع قضايي مكانيزه")]
        JudicialMechanize = 1,
        [Description("مرجع غير قضايي")]
        NonJudicial = 2,
        [Description("مرجع قضايي غير مكانيزه")]
        JudicialNonMechanize = 3,
    } 

    [Description("RegInTabletState")]
    public enum RegInTabletState
    {
        [Description("")]
        None = 0,
        [Description("روي تبلت بماند")]
        ActiveInTablet = 1,
        [Description("از روي تبلت حذف شود")]
        DeleteFromTablet = 2,
    } 

    [Description("RelatedFormAffect")]
    public enum RelatedFormAffect
    {
        [Description("")]
        None = 0,
        [Description("بر اساس دستگاه تابعه")]
        SubOrgBased = 1,
        [Description("بطور کلي")]
        GeneralBase = 2,
    } 

    [Description("RelatedOtherOrg")]
    public enum RelatedOtherOrg
    {
        [Description("")]
        None = 0,
        [Description("ناجا")]
        NAJA = 2,
        [Description("روزنامه رسمي")]
        LagalNewspaper = 3,
        [Description("سازمان ثبت احوال کشور")]
        PersonEventRegisterationOrg = 4,
        [Description("سازمان امور مالياتي")]
        TaxOrg = 5,
        [Description("انجمن حمايت از حقوق مصرف كنندگان")]
        SocietyProtectionConsumersRights = 6,
        [Description("سازمان بازرسي و نظارت")]
        InspectionMonitoring = 7,
        [Description("مراجع وابسته به سازمان تعزيرات حکومتي")]
        PunishmentRelatedOrg = 8,
        [Description("سيستم بانکي کشور")]
        BankSystem = 9,
        [Description("مراجع دولتي")]
        GovermentAuthorities = 10,
        [Description("مراجع قضايي")]
        Jurisdictions = 11,
        [Description("مراجع نظامي و انتظامي")]
        MilitaryAuthorities = 12,
        [Description("وزارت صنعت، معدن و تجارت")]
        MinistryTradeMiningIndustry = 13,
        [Description("سازمان زندان ها و زندان")]
        Prison = 14,
    } 

    [Description("RelatedPersonState")]
    public enum RelatedPersonState
    {
        [Description("")]
        None = 0,
        [Description("تحت پوشش")]
        Supported = 1,
        [Description("عدم تحت پوشش")]
        NotSupported = 2,
    } 

    [Description("RelationshipType")]
    public enum RelationshipType
    {
        [Description("")]
        None = 0,
        [Description("همسر")]
        Partner = 1,
        [Description("پدر")]
        Father = 2,
        [Description("مادر")]
        Mother = 3,
        [Description("پسر")]
        Son = 4,
        [Description("دختر")]
        Dauther = 5,
        [Description("برادر")]
        Brother = 6,
        [Description("خواهر")]
        Sister = 7,
    } 

    [Description("ReleifAccuse")]
    public enum ReleifAccuse
    {
        [Description("")]
        None = 0,
        [Description("خواسته")]
        Relief = 1,
        [Description("اتهام")]
        Accuse = 2,
    } 

    [Description("Religion")]
    public enum Religion
    {
        [Description("")]
        None = 0,
        [Description("مسلمان-شيعه")]
        Shia = 1,
        [Description("مسلمان-سني")]
        Sunni = 2,
        [Description("كليمي")]
        Jew = 3,
        [Description("زرتشتي")]
        Zoroastrian = 4,
        [Description("مسيحي")]
        Christian = 5,
    } 

    [Description("ReplyState")]
    public enum ReplyState
    {
        [Description("")]
        None = 0,
        [Description("جواب داده شده")]
        Replied = 1,
        [Description("جواب داده نشد")]
        NonReplied = 2,
    } 

    [Description("ReportAccessDataType")]
    public enum ReportAccessDataType
    {
        [Description("")]
        None = 0,
        [Description("قابل رويت و ويرايش")]
        EditableAndRead = 1,
        [Description("صرفا قابل رويت")]
        ReadOnly = 2,
    } 

    [Description("RequestType")]
    public enum RequestType
    {
        [Description("")]
        None = 0,
        [Description("درخواست صدور")]
        IssuingRequest = 1,
        [Description("درخواست اصلاح")]
        EditRequest = 2,
        [Description("درخواست لغو اعتبار")]
        InvalidationRequest = 3,
        [Description("درخواست اعتبار")]
        ValidationRequest = 4,
        [Description("درخواست انحلال")]
        BreakUpRequest = 5,
        [Description("درخواست ادغام")]
        MergRequest = 6,
        [Description("درخواست ختم تصفيه")]
        SettleRequest = 7,
    } 

    [Description("ResultType")]
    public enum ResultType
    {
        [Description("")]
        None = 0,
        [Description("انجام شد  ")]
        Done = 1,
        [Description("انجام نشد ")]
        NotDone = 2,
    } 

    [Description("RunState")]
    public enum RunState
    {
        [Description("")]
        None = 0,
        [Description("اعمال نشده")]
        NotApplied = 1,
        [Description("به خطا برخورد كرده")]
        Fail = 2,
        [Description("اعمال شده")]
        Applied = 3,
        [Description("نياز به بررسي دارد")]
        Recheck = 4,
    } 

    [Description("SalaryAdditionSubject")]
    public enum SalaryAdditionSubject
    {
        [Description("")]
        None = 0,
        [Description("عيدي")]
        Reward = 1,
        [Description("معوقات")]
        DelayedPay = 2,
        [Description("واريز مبلغ بلوکه شده")]
        BlockedPay = 3,
        [Description("متفرقه")]
        Others = 9,
    } 

    [Description("SalaryDeductionSubject")]
    public enum SalaryDeductionSubject
    {
        [Description("")]
        None = 0,
        [Description("بدهي صندوق تعاون")]
        Loan = 1,
        [Description("بدهي اجرايي")]
        Ejraee = 2,
        [Description("بدهي گواهي امضاء")]
        GovahiEmza = 3,
        [Description("بدهي مالياتي")]
        Tax = 4,
        [Description("بدهي ده درصد کسر پرداخت درآمد صدي ده")]
        TenPercent = 5,
        [Description("اضافه واريزي پس از فوت")]
        AdditionAfterDeath = 6,
        [Description("علي الحساب")]
        AlalHesab = 7,
        [Description("اضافه واريزي پس از شروع به کار")]
        AdditionAfterStartWork = 8,
        [Description("بدهي متفرقه")]
        Others = 9,
    } 

    [Description("SaveAttachmentType")]
    public enum SaveAttachmentType
    {
        [Description("")]
        None = 0,
        [Description("در پايگاه داده")]
        SaveInDataBase = 1,
        [Description("ذخيره بصورت فايل عادي")]
        SaveInFile = 2,
        [Description("ذخيره در نرم افزار مديريت سند")]
        SaveInDocumentManager = 3,
    } 

    [Description("ScriptoriumEmployeePosition")]
    public enum ScriptoriumEmployeePosition
    {
        [Description("")]
        None = 0,
        [Description("سردفتر")]
        Notary = 1,
        [Description("دفتر يار اول")]
        NotaryFirstAssistant = 2,
        [Description("دفتر يار دوم")]
        NotarySecondAssistant = 3,
    } 

    [Description("ScriptoriumEmployeePositionType")]
    public enum ScriptoriumEmployeePositionType
    {
        [Description("")]
        None = 0,
        [Description("اصيل")]
        Originality = 1,
        [Description("کفيل")]
        Bailment = 2,
    } 

    [Description("ScriptoriumPostType")]
    public enum ScriptoriumPostType
    {
        [Description("")]
        None = 0,
        [Description("سر دفتر")]
        Notary = 1,
        [Description("دفتريار اول")]
        FirstOfficeAssistant = 2,
        [Description("دفتريار دوم")]
        SecendOfficeAssistant = 3,
        [Description("کفيل دفتريار")]
        ActingAssistantOffice = 4,
        [Description("کفيل سردفتر")]
        ActingNotary = 5,
    } 

    [Description("SecurityType")]
    public enum SecurityType
    {
        [Description("")]
        None = 0,
        [Description("فرآيند شعبه")]
        WorkFlowCourt = 1,
        [Description("فرآيند مجتمع")]
        WorkFlowDepartman = 2,
        [Description("فرآيند كاربر")]
        WorkFlowUser = 3,
        [Description("فرآيند نقش")]
        WorkFlowRole = 4,
        [Description("فرآيند حوزه قضايي")]
        WorkFlowArea = 5,
        [Description("فعاليت شعبه")]
        ActivityCourt = 6,
        [Description("فعاليت مجتمع")]
        ActivityDepartman = 7,
        [Description("فعاليت كاربر")]
        ActivityUser = 8,
        [Description("فعاليت نقش")]
        ActivityRole = 9,
        [Description("فعاليت حوزه قضايي")]
        ActivityArea = 10,
    } 

    [Description("SendDataState")]
    public enum SendDataState
    {
        [Description("")]
        None = 0,
        [Description("ارسال نشده       ")]
        NotSended = 1,
        [Description("ارسال شده       ")]
        Sended = 2,
    } 

    [Description("SenderType")]
    public enum SenderType
    {
        [Description("")]
        None = 0,
        [Description("منو")]
        Menu = 1,
        [Description(" گردش كار ")]
        Workflow = 2,
    } 

    [Description("SendSecurityType")]
    public enum SendSecurityType
    {
        [Description("")]
        None = 0,
        [Description("جهت ملاحظه")]
        ReadOnly = 1,
        [Description("جهت رسيدگي")]
        ReadWrite = 2,
    } 

    [Description("SequenceNum")]
    public enum SequenceNum
    {
        [Description("")]
        None = 0,
        [Description("يكبار")]
        Ones = 1,
        [Description("دو بار")]
        Twice = 2,
        [Description("سه بار")]
        ThreeTime = 3,
    } 

    [Description("SequenceType")]
    public enum SequenceType
    {
        [Description("")]
        None = 0,
        [Description("اول")]
        First = 1,
        [Description("دوم")]
        Second = 2,
        [Description("سوم")]
        Third = 3,
    } 

    [Description("ServerType")]
    public enum ServerType
    {
        [Description("")]
        None = 0,
        [Description("دستگاه خادم برنامه کاربردي محلي")]
        LocalApplicationServer = 1,
        [Description("دستگاه خادم برنامه کاربردي مرکزي")]
        CentralApplicationServer = 2,
        [Description("دستگاه خادم برنامه کاربردي اينترنت")]
        InternetApplicationServer = 3,
        [Description("دستگاه خادم پايگاه داده محلي")]
        LocalDataBaseServer = 4,
        [Description("دستگاه خادم پايگاه داده مرکزي")]
        CentralDataBaseServer = 5,
        [Description("دستگاه خادم پايگاه داده اينترنت")]
        InternetDataBaseServer = 6,
        [Description("دستگاه خادم پايگاه داده و برنامه کاربردي محلي")]
        LocalApplicationAndDataBaseServer = 7,
        [Description("دستگاه خادم پايگاه داده و برنامه کاربردي مرکزي")]
        CentralApplicationAndDataBaseServer = 8,
        [Description("دستگاه خادم پايگاه داده و برنامه کاربردي اينترنت")]
        InternetApplicationAndDataBaseServer = 9,
        [Description("دستگاه خادم سرويس ها")]
        ServiceServer = 12,
        [Description("دستگاه خادم پشتيبان خادم مركزي")]
        BackupCenteralServer = 15,
    } 

    [Description("SexType")]
    public enum SexType
    {
        [Description("")]
        None = 0,
        [Description("زن")]
        Female = 1,
        [Description("مرد")]
        Male = 2,
    } 

    [Description("ShareState")]
    public enum ShareState
    {
        [Description("")]
        None = 0,
        [Description("سهم مي برد")]
        HasShare = 1,
        [Description("سهم نمي برد")]
        HasNoShare = 2,
    } 

    [Description("SMSEmailSendSuccess")]
    public enum SMSEmailSendSuccess
    {
        [Description("")]
        None = 0,
        [Description("با موفقيت در صف ارسال قرار گرفت")]
        SucessQueued = 1,
        [Description("تکراري. قبلا در صف قرار گرفته بود")]
        DublicateInQueue = 2,
        [Description("ناموفق")]
        NotSuccessfull = 3,
    } 

    [Description("SMSPersonType")]
    public enum SMSPersonType
    {
        [Description("")]
        None = 0,
        [Description("شخص پرونده                           ")]
        CasePerson = 1,
        [Description("كارشناس                       ")]
        ExpertMan = 2,
        [Description("ساير اشخاص")]
        Individual = 3,
    } 

    [Description("SortType")]
    public enum SortType
    {
        [Description("")]
        None = 0,
        [Description("افزاينده")]
        Asc = 1,
        [Description("کاهنده")]
        Desc = 2,
    } 

    [Description("SpecialProfessional")]
    public enum SpecialProfessional
    {
        [Description("")]
        None = 0,
        [Description("اختصاصي")]
        Special = 1,
        [Description("تخصصي")]
        Professional = 2,
    } 

    [Description("State")]
    public enum State
    {
        [Description("")]
        None = 0,
        [Description("فعال")]
        Valid = 1,
        [Description("غير فعال")]
        Invalid = 2,
    } 

    [Description("StateOfSuspend")]
    public enum StateOfSuspend
    {
        [Description("")]
        None = 0,
        [Description("معلق است")]
        IsSuspended = 1,
        [Description("معلق نيست")]
        NotSuspended = 2,
    } 

    [Description("StateType")]
    public enum StateType
    {
        [Description("")]
        None = 0,
        [Description("وضعيت مياني")]
        MiddleState = 1,
        [Description("وضعيت نهايي مثبت")]
        FinalPositiveState = 2,
        [Description("وضعيت نهايي منفي")]
        FinalNegativeState = 3,
        [Description("پس از وضعيت نهايي مثبت")]
        AfterEndState = 4,
        [Description("چاپ مدرک")]
        PrintDoc = 5,
    } 

    [Description("StaticReportRowType")]
    public enum StaticReportRowType
    {
        [Description("")]
        None = 0,
        [Description("فيلد")]
        FieldRow = 1,
        [Description("ستون   ")]
        ColumnRow = 2,
        [Description("سطر خالي")]
        NullRow = 3,
    } 

    [Description("StaticReportType")]
    public enum StaticReportType
    {
        [Description("")]
        None = 0,
        [Description("گزارش تفصيلي ساير شرکتها")]
        OtherCompanyDetailed = 1,
        [Description("گزارش تفصيلي ساير شرکتهاي آب")]
        WaterCompanyDetailed = 2,
        [Description("گزارش تفصيلي شرکتهاي برق")]
        PowerCompanyDetailed = 3,
        [Description("گزارش تفصيلي شرکتهاي بيمه")]
        InsurCompanyDetailed = 4,
        [Description("گزارش تفصيلي بانکها")]
        BankCompanyDetailed = 5,
    } 

    [Description("Subsystems")]
    public enum Subsystems
    {
        [Description("")]
        None = 0,
        [Description("اجرا")]
        Executive = 1,
        [Description("ملک")]
        Estate = 2,
        [Description("مالکيت")]
        IndustrialOwnership = 3,
        [Description("ثبت شرکت ها")]
        Company = 4,
        [Description("ماده147")]
        N147 = 5,
        [Description("ابلاغ سردفتران")]
        Notary = 6,
        [Description("ثبت الکترونيکي اسناد")]
        OnlineReg = 7,
        [Description("دادسرا و دادگاه انتظامي سردفتران و دفترياران")]
        ProsectursAndCourt = 8,
        [Description("اداره امور حقوقي دو")]
        OfficeLegalAffairs = 9,
        [Description("ارايه گزارش بر روي تبلت و گوشي هوشمند")]
        TabletReport = 10,
        [Description("مديريت پرونده شوراي عالي ثبت و هيات نظارت استان")]
        RegistrationCouncil = 11,
        [Description("طرح ها و برنامه ها")]
        DetailValueBudget = 12,
        [Description("ازدواج وطلاق")]
        Marriage = 13,
        [Description("پلمب دفاتر تجاري")]
        Polomb = 14,
        [Description("ارسال آگهي به روزنامه هاي کثيرالانتشار")]
        Newspaper = 15,
        [Description("هلال احمر")]
        HelaleAhmar = 25,
        [Description("سازمان تعزيرات")]
        PunishmentOrg = 29,
        [Description("عمومي")]
        General = 30,
        [Description("هيات رسيدگي به تخلفات اداري")]
        AdministrativeViolation = 31,
        [Description("اداره امور حقوقي پيش فرض")]
        DefaultOLA = 32,
        [Description("سامانه جامع بودجه سازمان برنامه")]
        Budget = 33,
        [Description("ثبت شرکتهاي مناطق آزاد")]
        FTACompany = 34,
        [Description("سايت هنري-ديباچه")]
        ArtLand = 35,
        [Description("اداره امور حقوقي پيش فرض 2")]
        DefaultOLA2 = 36,
    } 

    [Description("SyncProcessed")]
    public enum SyncProcessed
    {
        [Description("")]
        None = 0,
        [Description("پردازش نشده")]
        NonProcessed = 1,
        [Description("پردازش شده")]
        Processed = 2,
    } 

    [Description("SystemExistanceState")]
    public enum SystemExistanceState
    {
        [Description("")]
        None = 0,
        [Description("غيرموجود")]
        NotExist = 1,
        [Description("موجود")]
        Exist = 2,
    } 

    [Description("SystemMessageTypeType")]
    public enum SystemMessageTypeType
    {
        [Description("")]
        None = 0,
        [Description("خطاي Pk")]
        PkConstraint = 1,
        [Description("خطاي Uk")]
        UniqueConstraint = 2,
        [Description("خطاي حذف در FK")]
        FKConstraintDelete = 3,
        [Description("خطاي درج در Fk")]
        FKConstraintInsert = 4,
        [Description("ساير")]
        Other = 5,
    } 

    [Description("SystemObjectType")]
    public enum SystemObjectType
    {
        [Description("")]
        None = 0,
        [Description("پايه اي")]
        Base = 1,
        [Description("غير پايه اي")]
        NonBase = 2,
    } 

    [Description("TableScopeAffect")]
    public enum TableScopeAffect
    {
        [Description("")]
        None = 0,
        [Description("کل جدول")]
        TableFull = 1,
        [Description("سطر جدول")]
        TableRow = 2,
    } 

    [Description("TBFileType")]
    public enum TBFileType
    {
        [Description("")]
        None = 0,
        [Description("PDF File")]
        PDFFile = 1,
        [Description("Excel File")]
        ExcelFile = 2,
        [Description("Word File")]
        WordFile = 3,
        [Description("Film File")]
        FilmFile = 4,
        [Description("Image File")]
        ImageFile = 5,
    } 

    [Description("TBMenuStatus")]
    public enum TBMenuStatus
    {
        [Description("")]
        None = 0,
        [Description("فعال")]
        Active = 1,
        [Description("غيرفعال")]
        Passive = 2,
        [Description("پنهان")]
        Hidden = 3,
    } 

    [Description("TBMenuType")]
    public enum TBMenuType
    {
        [Description("")]
        None = 0,
        [Description("آيتم ريشه")]
        RootItem = 1,
        [Description("آيتم مياني")]
        MiddleItem = 2,
        [Description("آيتم برگ يا انتهايي")]
        LeafItem = 3,
    } 

    [Description("TBRecordState")]
    public enum TBRecordState
    {
        [Description("")]
        None = 0,
        [Description("غير قابل انتشار")]
        NonPublishable = 1,
        [Description("قابل انتشار")]
        Publishable = 2,
        [Description("قابل حذف از روي تبلت")]
        MustBeDeletedTablet = 3,
    } 

    [Description("TimeState")]
    public enum TimeState
    {
        [Description("")]
        None = 0,
        [Description("اقدام نشده")]
        NotDone = 1,
        [Description("اقدام شده")]
        Done = 2,
        [Description("ابطال شده")]
        Cancel = 3,
    } 

    [Description("TranscriptSendType")]
    public enum TranscriptSendType
    {
        [Description("")]
        None = 0,
        [Description("بوسيله نامه صادره")]
        ByOutgoingLetter = 1,
        [Description("بوسيله ابلاغ")]
        ByNotice = 2,
    } 

    [Description("TransferObjectState")]
    public enum TransferObjectState
    {
        [Description("")]
        None = 0,
        [Description("اطلاعات ارسال نشده")]
        Notsended = 1,
        [Description("اطلاعات ارسال شده")]
        Sended = 2,
        [Description("ارشال شده و پذيرفته شده")]
        SendedAndAccepted = 3,
        [Description("ارسال شده و پذيرفته نشده")]
        SendedAndRejected = 4,
    } 

    [Description("TrueFalse")]
    public enum TrueFalse
    {
        [Description("")]
        None = 0,
        [Description("درست")]
        True = 1,
        [Description("غلط")]
        False = 2,
    } 

    [Description("TypeValue")]
    public enum TypeValue
    {
        [Description("")]
        None = 0,
        [Description("عددي")]
        NumericNonCalculate = 1,
        [Description("رشته ايي")]
        String = 2,
        [Description("تاريخ")]
        Date = 3,
        [Description("داده مشخص")]
        ConstantData = 4,
        [Description("جدول اطلاعات پايه")]
        BaseInfoTable = 6,
        [Description("متني پيشرفته")]
        RichTextBoxType = 7,
        [Description("دکمه")]
        Button = 13,
        [Description("رشته اي شناسه دار")]
        StringId = 14,
        [Description("فايل")]
        FileType = 18,
    } 

    [Description("UnitExchangeAttachmentType")]
    public enum UnitExchangeAttachmentType
    {
        [Description("")]
        None = 0,
        [Description("قابل تغيير")]
        Editable = 1,
        [Description("فقط مطالعه")]
        ReadOnly = 2,
    } 

    [Description("UnitExchangeLetter")]
    public enum UnitExchangeLetter
    {
        [Description("")]
        None = 0,
        [Description("ارسال نشده")]
        NotSend = 1,
        [Description("ارسال شده")]
        Send = 2,
        [Description("رويت شده توسط واحد ثبتي گيرنده")]
        Receive = 3,
        [Description("ارجاع داده شده")]
        Refer = 4,
        [Description("برگشت داده شده")]
        Return = 5,
    } 

    [Description("UnitParameter")]
    public enum UnitParameter
    {
        [Description("")]
        None = 0,
        [Description("حداقل زمان وقت دهي شعبه")]
        UnitTimePeriod = 1,
        [Description("شروع ساعت دفتر اوقات")]
        DailyBeginTime = 3,
        [Description("پايان ساعت دفتر اوقات")]
        DailyEndTime = 4,
        [Description("استاندارد حداقل تعداد وقت رسيدگي در روز")]
        SessionNumberPerDay = 5,
        [Description("استاندارد حداقل تعداد وقت احتياطي در روز")]
        TemporaryNumberPerDay = 6,
        [Description("مکانيزه شدن شعبه")]
        CourtCMSState = 8,
        [Description("حداکثر زمان ثبت در دفاتر مکانيزه")]
        MaxDelaySaveData = 9,
        [Description("تاريخ شروع به روز شدن اطلاعات و جمع آوري دفاتر")]
        RemoveBooks = 10,
        [Description("تعداد كارمند")]
        EmployeeCount = 11,
        [Description("تعداد قاضي")]
        JudgeCount = 12,
        [Description("بازه زماني تغيير رمز عبور به روز")]
        ChangePasswordPeriod = 14,
    } 

    [Description("UnitType")]
    public enum UnitType
    {
        [Description("")]
        None = 0,
        [Description("واحد ثبتي")]
        RegistrationUnit = 9,
        [Description("اداره كل ثبت اسناد و املاک استان")]
        ProvinceRegistration = 20,
        [Description("سازمان مستقل ثبتي")]
        OrganizationRegistration = 30,
    } 

    [Description("UrgencyLetter")]
    public enum UrgencyLetter
    {
        [Description("")]
        None = 0,
        [Description("عادي")]
        Normal = 1,
        [Description("فوري")]
        Urgent = 2,
        [Description("خيلي فوري")]
        VeryUrgent = 3,
    } 

    [Description("UsersPost")]
    public enum UsersPost
    {
        [Description("")]
        None = 0,
        [Description("مدير دفتر   ")]
        OfficeAdministrator = 1,
        [Description("معاون ارجاع  ")]
        RefferingAssistant = 2,
        [Description("متصدي امور دفتري  ")]
        OfficeIncumbent = 3,
        [Description("منشي  ")]
        CourtClerk = 4,
        [Description("دادستان  ")]
        Prosecutor = 5,
        [Description("متصدي شعبه ")]
        Judge = 7,
        [Description("بايگان     ")]
        FileKeeper = 8,
        [Description("دادرس  ")]
        Proceeder = 9,
        [Description("دادورز  ")]
        Bailiff = 10,
    } 

    [Description("UserType")]
    public enum UserType
    {
        [Description("")]
        None = 0,
        [Description("كارمند ")]
        Emp = 1,
        [Description("غير كارمند ")]
        NonEmp = 2,
    } 

    [Description("VerdictType")]
    public enum VerdictType
    {
        [Description("")]
        None = 0,
        [Description("راي")]
        Judge = 1,
        [Description("قرار نهايي")]
        Writ = 2,
    } 

    [Description("ViewType")]
    public enum ViewType
    {
        [Description("")]
        None = 0,
        [Description("General View")]
        GeneralView = 1,
        [Description("Materialized View")]
        MatView = 2,
    } 

    [Description("WealthType")]
    public enum WealthType
    {
        [Description("")]
        None = 0,
        [Description("منقول")]
        Linkages = 1,
        [Description("غير منقول")]
        Immovable = 2,
    } 

    [Description("WeekDay")]
    public enum WeekDay
    {
        [Description("")]
        None = 0,
        [Description("شنبه")]
        Saturday = 1,
        [Description("يکشنبه")]
        Sunday = 2,
        [Description("دوشنبه")]
        Monday = 3,
        [Description("سه شنبه")]
        Tuesday = 4,
        [Description("چهارشنبه")]
        Wednesday = 5,
        [Description("پنج شنبه")]
        Thursday = 6,
        [Description("جمعه")]
        Friday = 7,
    } 

    [Description("WFDefinitionState")]
    public enum WFDefinitionState
    {
        [Description("")]
        None = 0,
        [Description("پيش نويس")]
        PreDefine = 1,
        [Description("معتبر-اجرايي شده")]
        Valid = 2,
        [Description("نامعتبر")]
        Invalid = 9,
    } 

    [Description("WFParameterType")]
    public enum WFParameterType
    {
        [Description("")]
        None = 0,
        [Description("رشته   ")]
        StringType = 1,
        [Description("شيء اصلي فعاليت")]
        ActivityBaseObject = 2,
        [Description("عدد   ")]
        NumberType = 3,
        [Description("شيء پايگاه دادهاي بجز شيء اصلي فعاليت")]
        DBObject = 4,
        [Description("CLOB")]
        CLOBType = 5,
        [Description("BLOB")]
        BLOBType = 6,
    } 

    [Description("WorkFlowActionTime")]
    public enum WorkFlowActionTime
    {
        [Description("")]
        None = 0,
        [Description("موقع ايجاد")]
        OnEntry = 1,
        [Description("موقع اتمام")]
        OnExit = 2,
        [Description("موقع اصلاح")]
        OnUpdate = 3,
        [Description("موقع برگشت")]
        OnStepBack = 4,
        [Description("موقع حذف")]
        OnDelete = 5,
    } 

    [Description("WorkFlowActionType")]
    public enum WorkFlowActionType
    {
        [Description("")]
        None = 0,
        [Description("رخداد روي تغيير متغير")]
        VariableChangeEvent = 1,
        [Description("فراخواني متد")]
        MethodCall = 2,
        [Description("تغيير وضعيت متغير")]
        SetState = 3,
        [Description("اجراي دستورالعمل")]
        ActionScript = 4,
    } 

    [Description("WorkFlowActivityInstanceState")]
    public enum WorkFlowActivityInstanceState
    {
        [Description("")]
        None = 0,
        [Description("خاتمه يافته  ")]
        Done = 1,
        [Description("در حال اجرا ")]
        Processing = 2,
        [Description("متوقف")]
        Pause = 3,
        [Description("منتظر")]
        Wait = 4,
        [Description("منتظر رخداد")]
        WaitOnEvent = 5,
        [Description("برگشت به عقب داده شده")]
        StepBacked = 6,
    } 

    [Description("WorkFlowActivityType")]
    public enum WorkFlowActivityType
    {
        [Description("")]
        None = 0,
        [Description("آغاز توازي")]
        ForkType = 1,
        [Description("پايان")]
        EndType = 2,
        [Description("پايان توازي")]
        JoinType = 3,
        [Description("حاشيه اي")]
        AnnotationType = 4,
        [Description("ساده")]
        SimpleActivityType = 5,
        [Description("شروع")]
        StartType = 6,
        [Description("فراخوان گردش کار")]
        SubWorkflowType = 7,
        [Description("انتقالي")]
        RouterType = 8,
    } 

    [Description("WorkFlowCartable")]
    public enum WorkFlowCartable
    {
        [Description("")]
        None = 0,
        [Description("انجام شده")]
        Done = 1,
        [Description("انجام نشده")]
        Processing = 2,
        [Description("به تاخير انداخته شده")]
        Delay = 3,
        [Description("در انتظار رخداد")]
        Wait = 4,
        [Description("برگشت پذير")]
        StepBack = 5,
    } 

    [Description("WorkFlowDataType")]
    public enum WorkFlowDataType
    {
        [Description("")]
        None = 0,
        [Description("رشته اي")]
        StringType = 1,
        [Description("عددي")]
        IntegerType = 2,
        [Description("شيء سيستم")]
        SystemObject = 3,
        [Description("ليستي از شيء سيستم")]
        SystemObjectCollection = 4,
    } 

    [Description("WorkFlowDisplayType")]
    public enum WorkFlowDisplayType
    {
        [Description("")]
        None = 0,
        [Description("در سطح فرم")]
        FormWorkFlow = 1,
        [Description("در سطح گردش")]
        OneWorkFlow = 2,
        [Description("در سطح زير گردشها")]
        AllSubWorkFlow = 3,
    } 

    [Description("WorkFlowElementType")]
    public enum WorkFlowElementType
    {
        [Description("")]
        None = 0,
        [Description("فعاليت")]
        Activity = 1,
        [Description("گردش كار")]
        WorkFlow = 2,
    } 

    [Description("WorkFlowInstanceState")]
    public enum WorkFlowInstanceState
    {
        [Description("")]
        None = 0,
        [Description("در حال اجرا")]
        Processing = 1,
        [Description("خاتمه يافته")]
        Done = 2,
        [Description("در حال انتظار")]
        Wait = 3,
        [Description("متوقف شده")]
        Paused = 4,
    } 

    [Description("WorkFlowTargetType")]
    public enum WorkFlowTargetType
    {
        [Description("")]
        None = 0,
        [Description("متغير گردش كار")]
        WorkFlowContextVariable = 1,
        [Description("متغير فعاليت")]
        ActivityContextVariable = 2,
        [Description("متغير خارجي")]
        ExternalVariable = 3,
    } 

    [Description("WorkFlowVariableEventTime")]
    public enum WorkFlowVariableEventTime
    {
        [Description("")]
        None = 0,
        [Description("موقع اصلاح")]
        OnUpdate = 1,
        [Description("ايجاد")]
        OnCreate = 2,
    } 

    [Description("WorkFlowVariableSource")]
    public enum WorkFlowVariableSource
    {
        [Description("")]
        None = 0,
        [Description("ورودي")]
        InputParameter = 1,
        [Description("محاسباتي")]
        Computed = 2,
    } 

    [Description("WorkFlowWorkItemType")]
    public enum WorkFlowWorkItemType
    {
        [Description("")]
        None = 0,
        [Description("فرآيندي")]
        WorkFlow = 1,
        [Description("مستقل از فرآيند")]
        NonWorkFlow = 2,
        [Description("صرفا جهت رويت-رونوشت")]
        Transcript = 9,
    } 

    [Description("YesNo")]
    public enum YesNo
    {
        [Description("")]
        None = 0,
        [Description("بلي")]
        Yes = 1,
        [Description("خير")]
        No = 2,
    } 

}