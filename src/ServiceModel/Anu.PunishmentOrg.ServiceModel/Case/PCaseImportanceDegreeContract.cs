
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("تشخيص مهم و ملي بودن پرونده در سرویس")]
    public class PCaseImportanceDegreeContract
    {
        public PCaseImportanceDegreeContract()
        {
        }
            
            [System.ComponentModel.DisplayName("آيا پرونده در شعبه اجراي احکام داراي حبس است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? ExecutePrison { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده داراي محکوميت هاي تبديل جزاي نقدي به حبس است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? ExecutePrisonChange { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده راجع به اشخاص مشهور کشوري يا مقامات موضوع ماده 307 قانون آيين دادرسي کيفري است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? FamousPerson { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده با موضوع الزام به جمع آوري کالا با ارزش بيش از يک ميليارد ريال است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? GuildCaseCollecting { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده با موضوع محکوميت به اعاده عين است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? GuildCaseConviction { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده با موضوع تفاوت نرخ ارز است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? GuildCaseCurrency { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده با موضوع واريز نامه هاي دريافتي با ارزش بيش از يک ميليارد ريال است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? GuildCasedeposit { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده مربوط به کارخانجات با تخلف در زمينه کالا و خدمات است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? GuildCaseFactory { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده با موضوع کالاهاي ويژه(اساسي يا ضروري يا يارانه اي با اعلام مراجع دولتي)با ارزش حداقل پنج میلیارد  ريال است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? GuildCaseFundamental { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده مربوط به شرکت دولتي با تخلف در زمينه کالا و خدمات است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? GuildCaseGovermental { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده با موضوع گزارش يا شکايت اعلامي با ارزش بيش از يک ميليارد ريال است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? GuildCaseGravamen { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده مربوط به موسسات عمومي غيردولتي با تخلف در زمينه کالا و خدمات است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? GuildCasePrivate { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده با موضوع الزام به عرضه يا فروش کالا است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? GuildCaseSelling { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده با موضوع ارائه خدمات يا الزام فروشنده به قبول کالا است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? GuildCaseService { get; set; }

            
            
            [System.ComponentModel.DisplayName("شرح")]
        public string? ImportanceDescription { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده داراي مجازات قانوني لغو پروانه تاسيس است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? MedicineCaseCancellation { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده داراي مجازات قانوني تعطيلي موسسه پزشکي است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? MedicineCaseClosing { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده داراي مجازات قانوني الزام به جمع آوري کالا در زمينه بهداشت،دارو و درمان با ارزش بيش از يک ميليارد ريال است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? MedicineCaseCollecting { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده داراي مجازات قانوني معدوم نمودن کالا در زمينه بهداشت،دارو و درمان است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? MedicineCaseExtinction { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده مربوط به کارخانجات توليدي مواد خوراکي،بهداشتي و دارويي با تخلف در زمينه بهداشت،دارو و درمان است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? MedicineCaseFactory { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده مربوط به شرکت هاي دولتي با تخلف در زمينه بهداشت،دارو و درمان است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? MedicineCaseGovermental { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده داراي مجازات قانوني ضبط کالا و اموال به نفع دولت در زمينه بهداشت،دارو و درمان است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? MedicineCaseGovExtinction { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده مربوط به بيمارستان ها با تخلف در زمينه بهداشت،دارو و درمان است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? MedicineCaseHospital { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده داراي مجازات قانوني انجام تعهديا جبران خسارت در حق اشخاص در زمينه بهداشت،دارو و درمان با ارزش بيش از يک ميليارد ريال است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? MedicineCasePerson { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده با موضوع بهداشت،دارو و درمان با ارزش بيش از يک ميليارد است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? MedicineCasePrice { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده مربوط به موسسات عمومي غير دولتي با تخلف در زمينه بهداشت،دارو و درمان است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? MedicineCasePrivate { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده با موضوع استيفاي حقوق ملي است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? NationalRights { get; set; }

            
            
            [System.ComponentModel.DisplayName("آیا پرونده قاچاق دارای موضوعات لازم الاجرا کدهای 008 و 111 و 115 و 152 و 176 و ارزش بیش از ده میلیارد ریال است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? SmugglingBindingSpcPrice { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده داراي کالاي يارانه اي در زمينه قاچاق کالا و ارز با ارزش حداقل يک ميليارد ريال است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? SmugglingCaseGoods { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده داراي ارز ورودي در زمينه قاچاق کالا و ارز با ارزش حداقل 5 ميليارد ريال است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? SmugglingCaseInCurrency { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده داراي کالاهاي موضوع تبصره 4 ماده 18 قانون مبارزه با قاچاق کالا و ارز با ارزش حداقل يک ميليارد ريال است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? SmugglingCaseLaw18 { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده داراي ارز خروجي در زمينه قاچاق کالا و ارز با ارزش حداقل 5 ميليارد ريال است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? SmugglingCaseOutCurrency { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده داراي کالاهاي مجاز در زمينه قاچاق کالا و ارز با ارزش حداقل 2 ميليارد ريال است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? SmugglingCasePrice2 { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا پرونده داراي کالاهاي مجاز در زمينه قاچاق کالا و ارز با ارزش حداقل 3 ميليارد ريال است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? SmugglingCasePrice3 { get; set; }

            

    }
    }
