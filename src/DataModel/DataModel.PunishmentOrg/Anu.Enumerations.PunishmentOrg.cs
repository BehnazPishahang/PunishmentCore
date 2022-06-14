    using System;
	using System.ComponentModel;

	namespace Anu.Enumerations.PunishmentOrg
	{
		[Description("EnmAccountType")]
		public enum AccountType
		{
			[Description("پيش فرض")]
			defaultAccount = 1,			
			[Description("غير پيش فرض")]
			NonDefaultAccount = 19,			
			[Description("")]
			None = 0
		}
		[Description("EnmArticle23Demandant")]
		public enum Article23Demandant
		{
			[Description("محکوم عليه")]
			Condemned = 1,			
			[Description("اعضاء کميسيون هماهنگي استان و شهرستان مربوطه")]
			CoordinationManager = 6,			
			[Description("رئيس بازرسي و نظارت")]
			InspectionBoss = 3,			
			[Description("رئيس سازمان")]
			OrgBoss = 2,			
			[Description("شاکي")]
			Plaintiff = 4,			
			[Description("مديرکل استان")]
			ProvinceManager = 5,			
			[Description("")]
			None = 0
		}
		[Description("EnmArticle23FinalState")]
		public enum Article23FinalState
		{
			[Description("درخواست تاييد شد و پرونده جهت رسيدگي مجدد به شعبه عالي ارجاع شد")]
			Accept = 3,			
			[Description("درخواست در حال بررسي است")]
			Pending = 1,			
			[Description("درخواست رد شد")]
			Reject = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmArticle23RequestType")]
		public enum Article23RequestType
		{
			[Description("درخواست اعمال تبصره ماده 23 آيين نامه سازمان")]
			Article23 = 1,			
			[Description("درخواست تجديدنظرخواهي موض وع تبصره 4 ماده 50 قانون قاچاق کالا و ارز")]
			Article50 = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmArticle23UnitType")]
		public enum Article23UnitType
		{
			[Description("تجديدنظر")]
			AppealCourt = 2,			
			[Description("بدوي")]
			PrimaryCourt = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmBill4PaidType")]
		public enum Bill4PaidType
		{
			[Description("پرداخت از طريق کارت خوان سيار")]
			PaidByPOS = 3,			
			[Description("صدور قبض بدون موضوع لازم الاجرا")]
			WithoutSubject = 2,			
			[Description("صدور قبض با موضوع لازم الاجرا")]
			WithSubject = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmBrandName")]
		public enum BrandName
		{
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("قابل تشخيص نيست")]
			NotRecognizable = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmCaseSendType")]
		public enum CaseSendType
		{
			[Description("دستي")]
			Manual = 1,			
			[Description("مکانيزه")]
			Mechanize = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmCharacteristicDoc")]
		public enum CharacteristicDoc
		{
			[Description("مخدوش شده است")]
			Corrupted = 2,			
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmConfirmerExecutionDocsType")]
		public enum ConfirmerExecutionDocsType
		{
			[Description("رييس شعبه صادر کننده راي")]
			CourtJudge = 1,			
			[Description("رييس اجراي احکام")]
			ExecutionJudge = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmContrabandProductType")]
		public enum ContrabandProductType
		{
			[Description("مجاز")]
			Allowed = 1,			
			[Description("مجاز مشروط")]
			ConditionalAllowed = 4,			
			[Description("ممنوع")]
			Forbidden = 2,			
			[Description("يارانه اي")]
			Subsidy = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmCountryCreate")]
		public enum CountryCreate
		{
			[Description("قابل تشخيص نيست")]
			NotRecognizable = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmDegreeOfficer")]
		public enum DegreeOfficer
		{
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmDescriptionDoc")]
		public enum DescriptionDoc
		{
			[Description("ندارد")]
			HaverNot = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmDestroyedCaseStep")]
		public enum DestroyedCaseStep
		{
			[Description("طبقه يک")]
			Step1 = 1,			
			[Description("طبقه دو")]
			Step2 = 2,			
			[Description("طبقه سه")]
			Step3 = 3,			
			[Description("طبقه چهار")]
			Step4 = 4,			
			[Description("")]
			None = 0
		}
		[Description("EnmDestroyedMinuteCouncil")]
		public enum DestroyedMinuteCouncil
		{
			[Description("مدير کل فنآوري اطلاعات سازمان")]
			ComputerBoss = 5,			
			[Description("مدير کل نظارت بر اجراي احکام سازمان")]
			ExecutiveBoss = 6,			
			[Description("معاون توسعه مديريت و منابع سازمان")]
			HRSBoss = 3,			
			[Description("معاون حقوقي و امور مجلس سازمان")]
			LawBoss = 2,			
			[Description("نماينده سازمان اسناد و کتابخانه ملي")]
			NationalBookOrg = 7,			
			[Description("رئيس سازمان تعزيرات حکومتي")]
			OrgBoss = 1,			
			[Description("مدير کل دفتر مرکزي حراست سازمان")]
			ProtectionBoss = 4,			
			[Description("")]
			None = 0
		}
		[Description("EnmDestroyedMinutePresent")]
		public enum DestroyedMinutePresent
		{
			[Description("مدير کل تعزيرات حکومتي استان(رييس کميته)")]
			CommitteeBoss = 1,			
			[Description("معاون اجرايي اداره کل(دبير کميته)")]
			CommitteeSecretary = 2,			
			[Description("رييس اداره آمار و فنآوري اطلاعات تعزيرات حکومتي استان")]
			ComputerBoss = 5,			
			[Description("معاون يا رييس اداره اجراي احکام تعزيرات حکومتي استان")]
			ExecutiveBoss = 3,			
			[Description("نماينده سازمان اسناد و کتابخانه ملي")]
			NationalBookOrg = 7,			
			[Description("رييس اداره حراست تعزيرات حکومتي استان")]
			ProtectionBoss = 4,			
			[Description("")]
			None = 0
		}
		[Description("EnmDiscoveryDocType")]
		public enum DiscoveryDocType
		{
			[Description("صورتجلسه کشف قاچاق")]
			Minutes = 1,			
			[Description("گزارش کشف اسنادي")]
			Report = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmDiscoveryMinutesCompetenceReference")]
		public enum DiscoveryMinutesCompetenceReference
		{
			[Description("قوه قضائيه")]
			EnghelabCourtDadgah = 2,			
			[Description("سازمان تعزيرات حکومتي")]
			PunishmentOrg = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmDiscoveryPlacelicenseNumber")]
		public enum DiscoveryPlacelicenseNumber
		{
			[Description("فاقد پروانه/مجوز")]
			HaveNot = 1,			
			[Description("قابل دسترسي نيست")]
			NotAccess = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmDiscoveryPlacePhoneNum")]
		public enum DiscoveryPlacePhoneNum
		{
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("قابل دسترسي نيست")]
			NotAccess = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmDiscoveryPlacePlaque")]
		public enum DiscoveryPlacePlaque
		{
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("رويت نشد")]
			NotSee = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmDiscoveryPlacePostalCode")]
		public enum DiscoveryPlacePostalCode
		{
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("رويت نشد")]
			NotSee = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmDiscoveryPlaceUnitName")]
		public enum DiscoveryPlaceUnitName
		{
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmDiscoveryUnitType")]
		public enum DiscoveryUnitType
		{
			[Description("کاشف ضابط")]
			DiscoveryOfficer = 2,			
			[Description("واحد کاشف نيست")]
			NormalUnit = 1,			
			[Description("کاشف غيرضابط")]
			UnsecuredDiscoverer = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmDocIssueType")]
		public enum DocIssueType
		{
			[Description("رسمي")]
			OfficialDocument = 2,			
			[Description("عادي")]
			OrdinaryDocument = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmDriverFullName")]
		public enum DriverFullName
		{
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmEvaluator")]
		public enum Evaluator
		{
			[Description("مشاور")]
			Consultant = 2,			
			[Description("کارشناس")]
			Expert = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmExceptionType")]
		public enum ExceptionType
		{
			[Description("استثناء محاسبه کف و سقف مجاز است")]
			AllowedExceptions = 1,			
			[Description("استثناء ورود مجدد بدون درخواس رسيدگي مجدد")]
			InputAgain = 3,			
			[Description("استثناء صدور راي تجديدنظر/عالي بدون راي اوليه")]
			IssueJudgeWithoutPrimaryJudge = 4,			
			[Description("استثناء ورود مبلغ وصولي بيشتر از مبلغ محکوميت")]
			PaidPenaltyExceptions = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmExecutionProceedRptType")]
		public enum ExecutionProceedRptType
		{
			[Description("اجرا")]
			Execution = 2,			
			[Description("ساير")]
			Other = 3,			
			[Description("رسيدگي")]
			Proceeding = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmForgivenessRepType")]
		public enum ForgivenessRepType
		{
			[Description("زنداني ندارد")]
			NonPrisoner = 1,			
			[Description("زنداني دارد و هنوز آزاد نشده است")]
			Prisoner = 2,			
			[Description("زنداني داشته است و آزاد شده است")]
			PrisonerAndFree = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmForm5Images")]
		public enum Form5Images
		{
			[Description("تصوير فرم 5")]
			Form5 = 1,			
			[Description("تصوير فرم 6")]
			Form6 = 2,			
			[Description("تصوير فرم 7")]
			Form7 = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmGravamenNoticeType")]
		public enum GravamenNoticeType
		{
			[Description("تشکيل پرونده بر اساس شکوائيه و آغاز رسيدگي")]
			CreateCase = 2,			
			[Description("ارجاع شکوائيه به شعبه جهت بررسي آن")]
			ReferGravamen = 1,			
			[Description("رد شکوائيه")]
			RefuseGravamen = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmGravamenOrReport")]
		public enum GravamenOrReport
		{
			[Description("شکوائيه")]
			Gravamen = 1,			
			[Description("گزارش مردمي")]
			Report = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmHowGetDataInspectionReport")]
		public enum HowGetDataInspectionReport
		{
			[Description("ثبت شده توسط کاربر اتاق اصناف")]
			SaveAsnafExternally = 6,			
			[Description("ثبت شده توسط کاربر وزارت بهداشت")]
			SaveHealthMinistary = 7,			
			[Description("ثبت شده توسط کاربر سازمان حمايت")]
			SaveHemayatExternally = 2,			
			[Description("ثبت شده توسط کاربر داخلي سازمان")]
			SaveInternally = 1,			
			[Description("ارسال شده توسط سازمان گزارش دهنده از طريق سرويس الکترونيکي")]
			SaveWebService = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmIDNumber")]
		public enum IDNumber
		{
			[Description("مخدوش شده است")]
			Corrupted = 2,			
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmInspectionCodeOfficer")]
		public enum InspectionCodeOfficer
		{
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmInspectionReportReturnReason")]
		public enum InspectionReportReturnReason
		{
			[Description("عدم تطابق اوراق پيوست با اطلاعات شخص يا واحد صنفي ارسال شده")]
			AttachmentDefect = 5,			
			[Description("ناقص بودن مشخصات متهم، متصدي، مالک يا صاحب پروانه")]
			DefendentDefect = 1,			
			[Description("نقص در مدرک گزارش")]
			DocDefect = 3,			
			[Description("ساير")]
			Other = 99,			
			[Description("ناقص بودن مشخصات شاکي")]
			PlaintiffDefect = 2,			
			[Description("نقص در اطلاعات کالاي موضوع گزارش")]
			SubjectDefect = 4,			
			[Description("")]
			None = 0
		}
		[Description("EnmInspectionReportType")]
		public enum InspectionReportType
		{
			[Description("اصلاحي")]
			Corrective = 2,			
			[Description("جديد")]
			NewReport = 1,			
			[Description("تکميلي")]
			Supplementary = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmIssuingDateDoc")]
		public enum IssuingDateDoc
		{
			[Description("مخدوش شده است")]
			Corrupted = 2,			
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmLicensePersonType")]
		public enum LicensePersonType
		{
			[Description("جلب")]
			Attracted = 2,			
			[Description("تعقيب")]
			Chase = 1,			
			[Description("ممنوع الخروجي")]
			ExitBan = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmLicenseType")]
		public enum LicenseType
		{
			[Description("داشتن مجوز")]
			LicenseHaving = 1,			
			[Description("فاقد مجوز")]
			WithoutLicenseHaving = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmMechanizeLetterReportType")]
		public enum MechanizeLetterReportType
		{
			[Description("گزارش ارجاع نامه هاي مکانيزه به تفکيک موضوع نامه")]
			MoveReport = 3,			
			[Description("گزارش دريافت مکاتبات مکانيزه به تفکيک موضوع نامه")]
			ReceiveReport = 2,			
			[Description("گزارش ارسال مکاتبات مکانيزه به تفکيک موضوع نامه")]
			SendReport = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmObjectOriginality")]
		public enum ObjectOriginality
		{
			[Description("خارجي")]
			Foreign = 2,			
			[Description("ايراني")]
			Iranian = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmOffenderInvolvedType")]
		public enum OffenderInvolvedType
		{
			[Description("معاونت")]
			Assistance = 2,			
			[Description("مشارکت")]
			Partnership = 3,			
			[Description("مباشرت")]
			Stewardship = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmOtherInfo")]
		public enum OtherInfo
		{
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmOwnerDoc")]
		public enum OwnerDoc
		{
			[Description("قابل تشخيص نيست")]
			NotRecognizable = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmOwnerEstateType")]
		public enum OwnerEstateType
		{
			[Description("ساير موارد")]
			EtcType = 15,			
			[Description("استيجاري")]
			Leased = 1,			
			[Description("شخصي")]
			Personal = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmOwnershipType")]
		public enum OwnershipType
		{
			[Description("عمومي")]
			GeneralDoc = 2,			
			[Description("خصوصي")]
			PrivateDoc = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPBDiscoveryMinutesType")]
		public enum PBDiscoveryMinutesType
		{
			[Description("صرافي مجاز")]
			AllowCurrencyExchange = 11,			
			[Description("توزيعي")]
			Distributive = 5,			
			[Description("صرافي غير مجاز")]
			NotAllowCurrencyExchange = 12,			
			[Description("اداري")]
			Official = 9,			
			[Description("ساير")]
			Others = 13,			
			[Description("توليدي صنفي")]
			ProductiveGuild = 2,			
			[Description("توليدي صنعتي")]
			ProductiveIndustrial = 3,			
			[Description("سردخانه")]
			Refrigerator = 4,			
			[Description("مسکوني")]
			Residential = 8,			
			[Description("خرده فروشي")]
			Retail = 7,			
			[Description("انبار")]
			StoreRoom = 1,			
			[Description("وسيله نقليه")]
			Vehicle = 10,			
			[Description("عمده فروشي")]
			Wholesale = 6,			
			[Description("")]
			None = 0
		}
		[Description("EnmPChaseResult")]
		public enum PChaseResult
		{
			[Description("دستور و انجام تحقيقات تکميلي")]
			CompletedResearch = 4,			
			[Description("عدم کشف قاچاق/تخلف")]
			NonOfThem = 3,			
			[Description("کشف کالا/ارز قاچاق")]
			SmugglingDiscover = 1,			
			[Description("کشف وقوع تخلف/جرم")]
			ViolationDiscover = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPDiscoveryType")]
		public enum PDiscoveryType
		{
			[Description("بررسي اسناد")]
			CheckDocuments = 5,			
			[Description("اقرار")]
			Confession = 4,			
			[Description("بازرسي")]
			Inspection = 2,			
			[Description("بررسي گردش مالي")]
			InvestigateTurnover = 6,			
			[Description("عادي")]
			Normal = 3,			
			[Description("عمليات")]
			Operation = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPenaltyGetType")]
		public enum PenaltyGetType
		{
			[Description("متضامنا")]
			Constantly = 2,			
			[Description("متساويا")]
			Equivalence = 3,			
			[Description("منفردا")]
			Individually = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPerformancestatisticsbyNajaType")]
		public enum PerformancestatisticsbyNajaType
		{
			[Description("گزارش عملکرد شعب به تفکيک مرجع اعلام کننده")]
			Branch = 1,			
			[Description("گزارش عملکرد شعب به تفکيک مرجع اعلام کننده و نوع کالا يا ارز")]
			BranchWithStuff = 2,			
			[Description("گزارش عملکرد شعب به تفکيک مرجع اعلام کننده و راي صادره")]
			NajaJudgement = 3,			
			[Description("گزارش عملکرد شعب به تفکيک مرجع اعلام کننده و موضوعات لازم الاجرا")]
			PCaseBindingSubject = 4,			
			[Description("")]
			None = 0
		}
		[Description("EnmPlaqueNumber")]
		public enum PlaqueNumber
		{
			[Description("مخدوش شده است")]
			Corrupted = 2,			
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPLegalDoc4Debt")]
		public enum PLegalDoc4Debt
		{
			[Description("ماده529")]
			Matter529 = 1,			
			[Description("ساير")]
			Other = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPOutLetterCaseSendType")]
		public enum POutLetterCaseSendType
		{
			[Description("ارسال پرونده ها جهت اجرا به اجراي احکام")]
			Execution = 2,			
			[Description("ارسال پرونده ها جهت بايگاني به بايگاني راکد")]
			Morgue = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPProductOrCurrency")]
		public enum PProductOrCurrency
		{
			[Description("ارز")]
			Currency = 2,			
			[Description("کالا")]
			Product = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPProductType")]
		public enum PProductType
		{
			[Description("طيور")]
			Birds = 4,			
			[Description("سريع الاشتعال")]
			FastIgnition = 2,			
			[Description("احشام")]
			LiveStock = 3,			
			[Description("ساير")]
			OtherType = 9,			
			[Description("سريع الفساد")]
			QuickSpoil = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPReasonChoiceCasesAccordanceWithLaw")]
		public enum PReasonChoiceCasesAccordanceWithLaw
		{
			[Description("قاچاق سازمان يافته جرمي است با برنامه ريزي و هدايت گروهي و تقسيم کار توسط گروه نسبتاً منسجم متشکل از سه نفر يا بيشتر که براي ارتکاب جرم قاچاق ، تشکيل يا پس از تشکيل ، هدف آن براي ارتکاب جرم قاچاق منحرف شده است صورت مي گيرد.")]
			Organized = 1,			
			[Description("قاچاقچي حرفه اي شخصي است که بيش از سه بار مرتکب قاچاق شود و ارزش کالا يا ارز قاچاق در هر مرتبه بيش از ده ميليون ريال باشد.")]
			Professional = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPReferenceSelectReason")]
		public enum PReferenceSelectReason
		{
			[Description("قاچاق کالا و ارز سازمان يافته و حرفه اي")]
			OrganizedAndProfessional = 1,			
			[Description("قاچاق کالاهاي ممنوع")]
			ProhibitedGoods = 2,			
			[Description("قاچاق کالا و ارز مستلزم حبس و يا انفصال از خدمات دولتي")]
			RequirPrisonOrDisConnectOfGovService = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmPRelatedPunishOrg")]
		public enum PRelatedPunishOrg
		{
			[Description("ستاد مبارزه با قاچاق کالا و ارز")]
			CenterCombatSmuggling = 16,			
			[Description("گمرک")]
			Customs = 19,			
			[Description("شيلات")]
			Fisheries = 20,			
			[Description("صنوف")]
			Guilds = 18,			
			[Description("مراجع قضايي")]
			Jurisdictions = 11,			
			[Description("وزارت بهداشت")]
			MinistryOfHealth = 21,			
			[Description("ناجا")]
			Naja = 2,			
			[Description("سازمان اموال تمليکي")]
			PropertiManageOrg = 15,			
			[Description("سازمان حمايت")]
			SupportOrg = 17,			
			[Description("")]
			None = 0
		}
		[Description("EnmProductFoundDesc")]
		public enum ProductFoundDesc
		{
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmProductJudgeDecision")]
		public enum ProductJudgeDecision
		{
			[Description("ضبط")]
			Confiscation = 1,			
			[Description("معدوم")]
			Exterminated = 4,			
			[Description("استرداد")]
			Refund = 2,			
			[Description("مصادره")]
			Usurpation = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmPSmuggling")]
		public enum PSmuggling
		{
			[Description("ورودي")]
			Arrival = 1,			
			[Description("خريد")]
			Buy = 6,			
			[Description("حمل")]
			Carry = 4,			
			[Description("حواله")]
			Draft = 8,			
			[Description("عبور خارجي ")]
			ExternalPass = 14,			
			[Description("عبور داخلي ")]
			InternalPass = 13,			
			[Description("ساير")]
			Others = 9,			
			[Description("خروجي")]
			OutPut = 2,			
			[Description("نگهداري")]
			Preserve = 5,			
			[Description("فروش")]
			Sell = 7,			
			[Description("قاچاق ورودي ")]
			SmugEntrance = 12,			
			[Description("قاچاق خروج موقت ")]
			SmugExitTemporar = 11,			
			[Description("قاچاق صادراتي ")]
			SmugExported = 10,			
			[Description("ترانزيت")]
			Transit = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmPSmugglingOthers")]
		public enum PSmugglingOthers
		{
			[Description("عبور خارجي")]
			ExternalPass = 1,			
			[Description("عبور داخلي")]
			InternalPass = 2,			
			[Description("قاچاق ورودي")]
			SmugEntrance = 3,			
			[Description("قاچاق خروج موقت")]
			SmugExitTemporar = 4,			
			[Description("قاچاق صادراتي")]
			SmugExported = 5,			
			[Description("")]
			None = 0
		}
		[Description("EnmPSuspectPostType")]
		public enum PSuspectPostType
		{
			[Description("کارگزار گمرکي(حق العملکار)")]
			BrokerCustoms = 7,			
			[Description("ناخدا")]
			Captain = 13,			
			[Description("حامل")]
			Carrier = 3,			
			[Description("حامل و مالک")]
			CarrierAndOwner = 6,			
			[Description("راننده")]
			Driver = 9,			
			[Description("صاحب پروانه")]
			LicenseOwner = 15,			
			[Description("ساير")]
			Other = 16,			
			[Description("رابط مالک")]
			OwnerConnector = 8,			
			[Description("راننده مالک")]
			OwnerDriver = 10,			
			[Description("مالک محل")]
			OwnerPlace = 2,			
			[Description("صاحب کالا")]
			ProductOwner = 1,			
			[Description("ملوان")]
			Seafarer = 12,			
			[Description("انبار دار")]
			StoreKeeper = 14,			
			[Description("متصدي واحد")]
			UnitOperator = 4,			
			[Description("")]
			None = 0
		}
		[Description("EnmPTravelBanEndTime")]
		public enum PTravelBanEndTime
		{
			[Description("1سال پس از تاييد قرار")]
			OneYearAfterConfirm = 2,			
			[Description("6ماه پس از تاييد قرار")]
			SixMonthAfterConfirm = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPU135OrWebSite")]
		public enum PU135OrWebSite
		{
			[Description("ثبت شده توسط کاربر داخلي سازمان")]
			SaveInternally = 3,			
			[Description("سامانه 135")]
			System135 = 2,			
			[Description("وب سايت")]
			WebSite = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUAccountPersonType")]
		public enum PUAccountPersonType
		{
			[Description("شخص پرونده")]
			CasePerson = 1,			
			[Description("شخص خارج از پرونده")]
			OuterCasePerson = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUBankProceeds")]
		public enum PUBankProceeds
		{
			[Description("ريز وصولي بانک")]
			BankProceedsDetail = 1,			
			[Description("خلاصه وصولي بانک")]
			BankProceedsSummary = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUCaseArchiveState")]
		public enum PUCaseArchiveState
		{
			[Description("جاري")]
			Active = 1,			
			[Description("مختومه")]
			Closed = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUCaseCopyDocBase")]
		public enum PUCaseCopyDocBase
		{
			[Description("پرونده جهت انجام امور نيابت")]
			CourtCase = 6,			
			[Description("درخواست واخواهي/تجديدنظرخواهي/تجديدنظرخواهي عالي")]
			RevisionRequest = 2,			
			[Description("ساير تصميمات مختومه کننده")]
			TerminateOrder = 3,			
			[Description("راي")]
			Verdict = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUCaseSearchBase")]
		public enum PUCaseSearchBase
		{
			[Description("نام واحد صنفي يا شماره تلفن ثابت واحد صنفي")]
			EnameTradeNameOrTelephone = 4,			
			[Description("ترکيب تمام شرايط به شرط موجود بودن اطلاعات در شخص مورد جستجو")]
			AllCase = 10,			
			[Description("شماره پروانه و تاريخ صدور")]
			License = 6,			
			[Description("نام و نام خانوادگي")]
			NameFamily = 1,			
			[Description("نام و نام خانوادگي و نام پدر")]
			NameFamilyFatherName = 2,			
			[Description("شماره ملي/شناسه ملي/شماره فراگير اتباع خارجي")]
			NationalityCode = 3,			
			[Description("شناسه يکتاي واحد صنفي")]
			TradeUnitIdentityNumber = 5,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUCaseSecurityType")]
		public enum PUCaseSecurityType
		{
			[Description("عادي")]
			Normal = 1,			
			[Description("محرمانه")]
			Secure = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUCaseType")]
		public enum PUCaseType
		{
			[Description("اصلي")]
			MainCase = 1,			
			[Description("نيابتي")]
			Vicarious = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUChartType")]
		public enum PUChartType
		{
			[Description("حبابي")]
			Bubble = 8,			
			[Description("دايره اي")]
			Circular = 4,			
			[Description("ميله اي افقي")]
			HorizontalBar = 3,			
			[Description("خطي")]
			Linear = 1,			
			[Description("حلقه اي")]
			Loop = 5,			
			[Description("رادار")]
			Radar = 6,			
			[Description("سطحي")]
			Superficial = 7,			
			[Description("ميله اي عمودي")]
			VerticalBar = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUChaseLicenseType")]
		public enum PUChaseLicenseType
		{
			[Description("مجوز بازرسي سند")]
			ChaseLicenseDoc = 5,			
			[Description("مجوز تعقيب شخص")]
			ChaseLicensePerson = 1,			
			[Description("مجوز بازرسي محل")]
			ChaseLicensePlace = 2,			
			[Description("مجوز بازرسي وسيله نقليه")]
			ChaseLicenseVehicle = 4,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUConclusion")]
		public enum PUConclusion
		{
			[Description("بخشي قبول شده و بخشي نياز به تکميل تحقيقات دارد")]
			AcceptCompleteResearch = 14,			
			[Description("بخشي قبول شده و بخشي عدم صلاحيت زده شده")]
			AcceptIncompetence = 13,			
			[Description("بخشي قبول شده، بخشي عدم صلاحيت زده شده و بخشي نياز به تکميل تحقيقات دارد")]
			AcceptIncompetenceCompleteResearch = 134,			
			[Description("بخشي قبول شده و بخشي رد شده")]
			AcceptReject = 12,			
			[Description("بخشي قبول شده، بخشي رد شده و بخشي نياز به تکميل تحقيقات دارد")]
			AcceptRejectCompleteResearch = 124,			
			[Description("بخشي قبول شده، بخشي رد شده و بخشي عدم صلاحيت زده شده")]
			AcceptRejectIncompetence = 123,			
			[Description("بخشي قبول شده، بخشي رد شده، بخشي عدم صلاحيت زده شده و بخشي نياز به تکميل تحقيقات دارد")]
			AcceptRejectIncompetenceCompleteResearch = 999,			
			[Description("قبول درخواست")]
			AcceptRequest = 1,			
			[Description("تکميل تحقيقات")]
			CompleteResearch = 4,			
			[Description("عدم صلاحيت")]
			Incompetence = 3,			
			[Description("بخشي عدم صلاحيت زده شده و بخشي نياز به تکميل تحقيقات دارد")]
			IncompetenceCompleteResearch = 34,			
			[Description("بخشي رد شده و بخشي نياز به تکميل تحقيقات دارد")]
			RejectCompleteResearch = 24,			
			[Description("بخشي رد شده و بخشي عدم صلاحيت زده شده")]
			RejectIncompetence = 23,			
			[Description("بخشي رد شده، بخشي عدم صلاحيت زده شده و بخشي نياز به تکميل تحقيقات دارد")]
			RejectIncompetenceCompleteResearch = 234,			
			[Description("رد درخواست")]
			RejectRequest = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUContrabandOpinion")]
		public enum PUContrabandOpinion
		{
			[Description("با بررسي درخواست در شعبه موافق است")]
			Accept = 1,			
			[Description("با بررسي بخشي از درخواست در شعبه موافق است")]
			PartialAccept = 3,			
			[Description("درخواست وارد نيست")]
			Refuse = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUCreateCaseType")]
		public enum PUCreateCaseType
		{
			[Description("شکايت مردمي")]
			Gravamen = 5,			
			[Description("گشت سيار/مشترک")]
			MobilePatrols = 2,			
			[Description("عادي/بازرسي نوبه اي")]
			Normal = 1,			
			[Description("طرح نظارتي")]
			Regulatory = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUDashboardOrderType")]
		public enum PUDashboardOrderType
		{
			[Description("براساس شاخص")]
			Field = 1,			
			[Description("براساس مقدار شاخص")]
			FieldValue = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUEnumerationWritType")]
		public enum PUEnumerationWritType
		{
			[Description("قرار کارشناسي")]
			ExpertWrit = 1,			
			[Description("قرار رفع نقص")]
			lackWrit = 4,			
			[Description("قرار معاينه محل/تحقيق محلي")]
			LocalWrit = 2,			
			[Description("قرار رسيدگي توامان")]
			TogetherWrit = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUExecutionWritType")]
		public enum PUExecutionWritType
		{
			[Description("مسدود الحسابي")]
			BlockedAccount = 2,			
			[Description("موقوفي اجرا بواسطه اعتبار امر مختومه")]
			ClosedOrder = 10,			
			[Description("موقوفي اجرا بواسطه فوت متخلف")]
			Death = 7,			
			[Description("کاهش بدهي")]
			DebtReduction = 5,			
			[Description("قطع خدمات عمومي")]
			FinishGeneralService = 4,			
			[Description("موقوفي اجرا بواسطه عفو")]
			Forgiveness = 6,			
			[Description("موقوفي اجرا بواسطه نسخ مجازات قانوني")]
			OutOf = 9,			
			[Description("ممنوع المعامله")]
			ProhibitedTransactions = 3,			
			[Description("موقوفي اجرا بواسطه توبه متخلف")]
			Repentance = 11,			
			[Description("موقوفي اجرا بواسطه مرور زمان")]
			TimeLapse = 8,			
			[Description("ممنوع الخروجي")]
			TravelBan = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUExecutiveStatus")]
		public enum PUExecutiveStatus
		{
			[Description("مختومه شده")]
			EndExecutive = 2,			
			[Description("در حال اجرا  ")]
			InProgress = 1,			
			[Description("مختومه شدن به دليل نقض راي در ديوان عدالت اداري")]
			RejectDivan = 5,			
			[Description("مخنومه شدن به دليل نقض راي در شعبه عالي سازمان")]
			RejectSupremeCourt = 6,			
			[Description("توقف موقت عمليات اجرايي به دليل عدم شناسايي متخلف")]
			Suspention4UnknownViolator = 4,			
			[Description("توقف موقت عمليات اجرايي به دليل عدم وصول محکوميت مالي متخلف")]
			SuspentionReceivedNoClaim = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUFormTemplateType")]
		public enum PUFormTemplateType
		{
			[Description("راي")]
			Judge = 1,			
			[Description("صورتجلسه")]
			Minutes = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUGuild")]
		public enum PUGuild
		{
			[Description("صنفي")]
			Guild = 1,			
			[Description("غيرصنفي")]
			NonGuild = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUHasArrested")]
		public enum PUHasArrested
		{
			[Description("انهايي که هنوز در بازداشت هستند")]
			HasArrested = 1,			
			[Description("انهايي که بازداشتشان تمام شده است")]
			NotArrested = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUHasPrisoner")]
		public enum PUHasPrisoner
		{
			[Description("اشخاصي که هنوز در زندان هستند")]
			HasPrisoner = 1,			
			[Description("اشخاصي که زندانشان تمام شده است")]
			NotPrisoner = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUHowToMakeEvent")]
		public enum PUHowToMakeEvent
		{
			[Description("دستي")]
			Manual = 2,			
			[Description("مکانيزه")]
			Mechanize = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUImportanceDegree")]
		public enum PUImportanceDegree
		{
			[Description("مهم")]
			Important = 2,			
			[Description("ملي")]
			National = 3,			
			[Description("عادي")]
			Normal = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUInspectionReportBase")]
		public enum PUInspectionReportBase
		{
			[Description("شکايت مردمي")]
			Gravamen = 2,			
			[Description("بازرسي نوبه اي")]
			Intermittent = 3,			
			[Description("طرح نظارتي")]
			MonitoringPlan = 4,			
			[Description("گزارش/گشت مشترک")]
			Report = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUInspectorPost")]
		public enum PUInspectorPost
		{
			[Description("بازرس 1")]
			Inspector1 = 1,			
			[Description("بازرس 2")]
			Inspector2 = 2,			
			[Description("مامور ساير دستگاه ها")]
			OtherOrgInspector = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUJudgementViolatorP")]
		public enum PUJudgementViolatorP
		{
			[Description("متخلف غايب بود")]
			Absent = 2,			
			[Description("نماينده متخلف حضور داشت")]
			AgentPresent = 3,			
			[Description("متخلف حاضر بود")]
			Present = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUJudgeType")]
		public enum PUJudgeType
		{
			[Description("راي اصلاحي")]
			CorrectiveJudge = 2,			
			[Description("راي ديوان عدالت اداري")]
			DivanJudge = 4,			
			[Description("راي اصلي بدون اصلاحي")]
			MainJudge = 1,			
			[Description("راي اصلي داراي اصلاحي")]
			MainJudgeHasCorrective = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmPULegalPersonState")]
		public enum PULegalPersonState
		{
			[Description("فعال")]
			active = 1,			
			[Description("ورشکسته شده")]
			Broked = 5,			
			[Description("ختم تصفيه شده")]
			FiltrationTermination = 3,			
			[Description("غير فعال")]
			InActive = 2,			
			[Description("منحل شده")]
			Liquidated = 4,			
			[Description("")]
			None = 0
		}
		[Description("EnmPULicenseType")]
		public enum PULicenseType
		{
			[Description("موقت")]
			Interim = 2,			
			[Description("فاقد شماره پروانه کسب/مجوز")]
			NoLicense = 9,			
			[Description("دائم")]
			Permanent = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPULifeState")]
		public enum PULifeState
		{
			[Description("فوت شده")]
			Dead = 2,			
			[Description("زنده")]
			Live = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUMemberType")]
		public enum PUMemberType
		{
			[Description("سازمان صنعت، معدن و تجارت")]
			Mineral = 2,			
			[Description("اتاق اصناف")]
			NGO = 1,			
			[Description("سازمان تعزيرات")]
			PUO = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUMobilePatrolsResult")]
		public enum PUMobilePatrolsResult
		{
			[Description("تخلف دارد")]
			HasViolation = 1,			
			[Description("تذکر")]
			Hint = 3,			
			[Description("تخلف ندارد")]
			NoAbuse = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUMonth")]
		public enum PUMonth
		{
			[Description("آبان")]
			Aban = 8,			
			[Description("آذر")]
			Azar = 9,			
			[Description("بهمن")]
			Bahman = 11,			
			[Description("دي")]
			Day = 10,			
			[Description("اسفند")]
			Esfand = 12,			
			[Description("فروردين")]
			Farvardin = 1,			
			[Description("خرداد")]
			Khordad = 3,			
			[Description("مهر")]
			Mehr = 7,			
			[Description("مرداد")]
			Mordad = 5,			
			[Description("ارديبهشت")]
			Ordibehesht = 2,			
			[Description("شهريور")]
			Shahrivar = 6,			
			[Description("تير")]
			Tir = 4,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUNationality")]
		public enum PUNationality
		{
			[Description("غير ايراني")]
			Foreign = 2,			
			[Description("ايراني")]
			Iranian = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUnitType")]
		public enum PUnitType
		{
			[Description("شهر جاري")]
			CurrentCity = 3,			
			[Description("استان جاري")]
			CurrentProvince = 2,			
			[Description("سراسر کشور")]
			Nationally = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUOwnershipType")]
		public enum PUOwnershipType
		{
			[Description("تعاوني")]
			Cooperation = 6,			
			[Description("دولتي")]
			Governmental = 1,			
			[Description("نهادها و موسسات غيردولتي")]
			NonGovernmental = 2,			
			[Description("خصوصي")]
			PrivateOrg = 5,			
			[Description("خصوصي با حساسيت وپژه")]
			PrivateSpecial = 7,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUParameter")]
		public enum PUParameter
		{
			[Description("تاريخ شروع منطق چک کف و سقف مجازات")]
			PenaltyCheckStartDate = 3,			
			[Description("ميزان ريالي بابت هر روز حبس بدل از جزاي نقدي")]
			Prison = 1,			
			[Description("ميزان ريالي بابت هر ساعت انجام امور عام المنفعه بدل از جزاي نقدي")]
			PublicWorksExec = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUPenaltyType")]
		public enum PUPenaltyType
		{
			[Description("محکوميت کيفري-جزاي نقدي")]
			Fine = 1,			
			[Description("دستور قضايي")]
			JudicialOrder = 5,			
			[Description("محکوميت مالي ناشي از ضرر و زيان به شاکي")]
			Losses = 4,			
			[Description("محکوميت کيفري-جريمه بدل از مجازات")]
			PenaltyInsteadOfPunishment = 2,			
			[Description("محکوميت کيفري-مجازات بجز جزاي نقدي")]
			PunishmentExpFine = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUPersonStartPost")]
		public enum PUPersonStartPost
		{
			[Description("نماينده")]
			AgentPerson = 3,			
			[Description("مطلع")]
			AwarePerson = 5,			
			[Description("متخلف")]
			OffendingPerson = 2,			
			[Description("شاکي")]
			PlaintiffPerson = 1,			
			[Description("تامين گذار")]
			TransitionSupplyPerson = 4,			
			[Description("گواه")]
			WitnessPerson = 6,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUPledgeType")]
		public enum PUPledgeType
		{
			[Description("ضمانتنامه بانکي")]
			BankGuarantee = 3,			
			[Description("سپرده بانکي")]
			Deposit = 2,			
			[Description("ملک")]
			Estate = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUProductCurrency")]
		public enum PUProductCurrency
		{
			[Description("ارز")]
			Currency = 2,			
			[Description("کالا")]
			Product = 1,			
			[Description("خدمات")]
			ServicesType = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUPublicWorkTime")]
		public enum PUPublicWorkTime
		{
			[Description("تمام وقت")]
			FullTime = 1,			
			[Description("پاره وقت")]
			PartTime = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPURegister")]
		public enum PURegister
		{
			[Description("ثبت نشده است")]
			NotRegistered = 2,			
			[Description("ثبت شده است")]
			Registered = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPURegisterTimeStatus")]
		public enum PURegisterTimeStatus
		{
			[Description("وقت اقدام شده")]
			IsAct = 1,			
			[Description("وقت اقدام نشده")]
			IsNotAct = 2,			
			[Description("وقت تجديد شده")]
			Repeated = 3,			
			[Description("وقت ابطال شده")]
			Revocation = 4,			
			[Description("")]
			None = 0
		}
		[Description("EnmPURegisterTimeType")]
		public enum PURegisterTimeType
		{
			[Description("رسيدگي")]
			Disposition = 1,			
			[Description("نظارت / احتياطي")]
			Regulation = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUReligion")]
		public enum PUReligion
		{
			[Description("اسلام")]
			Muslim = 1,			
			[Description("غير اسلام")]
			NonMuslim = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPURevisionRequestAskerType")]
		public enum PURevisionRequestAskerType
		{
			[Description("ذينفع")]
			Beneficiary = 2,			
			[Description("شخص پرونده")]
			CasePerson = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPURevisionRequestHighRevisionPost")]
		public enum PURevisionRequestHighRevisionPost
		{
			[Description("محکوم عليه")]
			Defendant = 1,			
			[Description("شاکي خصوصي")]
			PrivatePlaintiff = 2,			
			[Description("رئيس سازمان حمايت")]
			ProtectionOrgBoss = 3,			
			[Description("رياست سازمان تعزيرات")]
			PunishmentOrgBoss = 4,			
			[Description("")]
			None = 0
		}
		[Description("EnmPURevisionRequestRevisionPost")]
		public enum PURevisionRequestRevisionPost
		{
			[Description("اعضاي کميسيون هماهنگي")]
			CoordinationCommission = 4,			
			[Description("محکوم عليه")]
			Defendant = 1,			
			[Description("مدير کل")]
			GeneralManager = 5,			
			[Description("شاکي خصوصي")]
			PrivatePlaintiff = 2,			
			[Description("مرجع اعلام کننده")]
			ReferenceHanger = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmPURevisionRequestSubject")]
		public enum PURevisionRequestSubject
		{
			[Description("درخواست اعمال ماده 10 قانون مجازات اسلامي")]
			Article10 = 5,			
			[Description("درخواست اعمال ماده 442 قانون آيين دادرسي كيفري")]
			Article442 = 4,			
			[Description("درخواست اعمال ماده 483 قانون آيين دادرسي كيفري")]
			Article483 = 6,			
			[Description("درخواست رسيدگي در مرحله عالي")]
			HighRevision = 3,			
			[Description("درخواست رسيدگي در مرحله واخواهي")]
			Protestation = 1,			
			[Description("درخواست رسيدگي در مرحله تجديدنظر خواهي ")]
			Revision = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUSaftyWritAcceptTransitionPersonType")]
		public enum PUSaftyWritAcceptTransitionPersonType
		{
			[Description("شخص پرونده")]
			CasePerson = 1,			
			[Description("شخص خارج از پرونده")]
			OuterCasePerson = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUSaftyWritType")]
		public enum PUSaftyWritType
		{
			[Description("بازداشت")]
			Arrest = 5,			
			[Description("کفالت")]
			Bail = 2,			
			[Description("الزام به حضور با تعيين وجه التزام")]
			Obligation = 3,			
			[Description("الزام به حضور با قول شرف")]
			Parole = 4,			
			[Description("وثيقه")]
			Pledge = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUSaftyWritValueType")]
		public enum PUSaftyWritValueType
		{
			[Description("تبديل")]
			Convert = 2,			
			[Description("تمديد")]
			Extension = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUSenderCaseType")]
		public enum PUSenderCaseType
		{
			[Description("تعزيراتي")]
			InnerUnit = 1,			
			[Description("واحد سازماني خارج از تعزيرات")]
			OuterUnit = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUStatisticStatus")]
		public enum PUStatisticStatus
		{
			[Description("آمار نشده")]
			NonStatistic = 2,			
			[Description("آمار شده")]
			Statisticed = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUSubjectTYpe")]
		public enum PUSubjectTYpe
		{
			[Description("اتهام")]
			Accusation = 2,			
			[Description("خواسته")]
			Relief = 3,			
			[Description("تخلف  ")]
			Violation = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUTimeDuration")]
		public enum PUTimeDuration
		{
			[Description("ماهانه")]
			Monthly = 8,			
			[Description("شش ماهه اول")]
			SixMonthly1 = 13,			
			[Description("شش ماهه دوم")]
			SixMonthly2 = 14,			
			[Description("ماه جاري")]
			ThisMonth = 4,			
			[Description("شش ماهه جاري")]
			ThisSixMonth = 6,			
			[Description("سه ماهه جاري")]
			ThisThreeMonth = 5,			
			[Description("هفته جاري")]
			ThisWeek = 3,			
			[Description("سال جاري")]
			ThisYear = 7,			
			[Description("سه ماهه اول")]
			ThreeMonthly1 = 9,			
			[Description("سه ماهه دوم")]
			ThreeMonthly2 = 10,			
			[Description("سه ماهه سوم")]
			ThreeMonthly3 = 11,			
			[Description("سه ماهه چهارم")]
			ThreeMonthly4 = 12,			
			[Description("روز جاري")]
			Today = 2,			
			[Description("سالانه")]
			Yearly = 15,			
			[Description("ديروز")]
			Yesterday = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUTripAdvisorOpinion")]
		public enum PUTripAdvisorOpinion
		{
			[Description("با بررسي درخواست در شعبه موافق است")]
			Accept = 1,			
			[Description("با بررسي بخشي از درخواست در شعبه موافق است")]
			PartialAccept = 3,			
			[Description("درخواست وارد نيست")]
			Refuse = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPUViolationType")]
		public enum PUViolationType
		{
			[Description("کالا و خدمات")]
			GuildCase = 1,			
			[Description("پرونده ويژه بهداشت، دارو و درمان")]
			HealthMedicineCase = 3,			
			[Description("پرونده قاچاق کالا و ارز")]
			SmugglingCase = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmPViolationsProductType")]
		public enum PViolationsProductType
		{
			[Description("آمار تخلفات به تفکيک واحد تعزيراتي و موضوع")]
			ViolationsProductWithoutViolate = 2,			
			[Description("آمار تخلفات به تفکيک واحد تعزيراتي ، موضوع و تخلف")]
			ViolationsProductWithViolate = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmPWarningReportsType")]
		public enum PWarningReportsType
		{
			[Description("گزارش پرونده هايي که بيش از مدت خاص سه گانه ندارند")]
			CaseDontHaveTriple = 4,			
			[Description("گزارش پرونده هايي که بيش از يک بار در شعبه کپي شده اند")]
			CaseHaveMoreThanOneCopy = 5,			
			[Description("گزارش پرونده هايي که بيش از مدت خاص به اجرا نرفته اند")]
			CaseNotSentToExecute = 3,			
			[Description("گزارش پرونده هايي که بيش از مدت خاص در شعب رسيدگي باز مانده اند")]
			CaseOpenInBranch = 1,			
			[Description(" گزارش پرونده هايي که بيش از مدت خاص درشعب اجرا باز مانده اند")]
			CaseOpenInExecute = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmRefuse")]
		public enum Refuse
		{
			[Description("امتناع از اعلام")]
			RefuseOfAnnounce = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmRegInWaybill")]
		public enum RegInWaybill
		{
			[Description("امکان استعلام وجود ندارد")]
			CanNotInquery = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmRejectOrDefect")]
		public enum RejectOrDefect
		{
			[Description("نقص")]
			DefectType = 2,			
			[Description("رد")]
			RejectType = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmReportTypeInductive")]
		public enum ReportTypeInductive
		{
			[Description("گزارش به تفکيک موضوع لازم الاجراي بدوي")]
			PrimByBindSubjType = 5,			
			[Description("گزارش به تفکيک موضوع دادنامه بدوي")]
			PrimByJudgType = 1,			
			[Description("گزارش به تفکيک موضوع دانامه و موضوع لازم الاجراي بدوي")]
			PrimByJudgTypeANDBindSujType = 3,			
			[Description("گزارش به تفکيک موضوع لازم الاجراي تجديد نظر")]
			ReviByBindSubjType = 6,			
			[Description("گزارش به تفکيک موضوع دادنامه تجديد نظر")]
			ReviByJudgType = 2,			
			[Description("گزارش به تفکيک موضوع دادنامه و موضوع لازم الاجراي تجديد نظر")]
			ReviByJudgTypeANDBindSujType = 4,			
			[Description("")]
			None = 0
		}
		[Description("EnmSerialNumber")]
		public enum SerialNumber
		{
			[Description("مخدوش شده است")]
			Corrupted = 2,			
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmSmugglingOrNonSmuggling")]
		public enum SmugglingOrNonSmuggling
		{
			[Description("کالاي غير قاچاق")]
			NonSmuggling = 2,			
			[Description("کالاي قاچاق")]
			Smuggling = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmSupremeCourtType")]
		public enum SupremeCourtType
		{
			[Description("شعبه بدوي ديوان عدالت اداري")]
			OfficeCourt = 3,			
			[Description("شعبه تجديدنظر ديوان عدالت اداري")]
			OfficeSupremeCourt = 4,			
			[Description("شعبه تجديدنظر")]
			RevisionCourt = 1,			
			[Description("شعبه عالي")]
			SupremeCourt = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmSuspectState")]
		public enum SuspectState
		{
			[Description("مظنون/مظنونان دارد")]
			HaveOwner = 1,			
			[Description("شناسايي نشد")]
			UnknownOwner = 2,			
			[Description("")]
			None = 0
		}
		[Description("EnmVehicleState")]
		public enum VehicleState
		{
			[Description("مشمول توقيف است")]
			Detention = 3,			
			[Description("مشمول ضبط است")]
			GetForce = 2,			
			[Description("بايد به مالک عودت داده شود")]
			ReturnToOwner = 4,			
			[Description("نامشخص")]
			UnknownState = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmVehicleType")]
		public enum VehicleType
		{
			[Description("سنگين زميني")]
			HeavyGround = 4,			
			[Description("سنگين هوايي و دريايي")]
			HeavyMarineAir = 5,			
			[Description("سبک")]
			Light = 1,			
			[Description("نيمه سنگين زميني")]
			SemiHeavyGround = 2,			
			[Description("نيمه سنگين هوايي و دريايي")]
			SemiHeavyMarineAir = 3,			
			[Description("")]
			None = 0
		}
		[Description("EnmWayBillNO")]
		public enum WayBillNO
		{
			[Description("ندارد")]
			HaveNot = 1,			
			[Description("")]
			None = 0
		}
		[Description("EnmWrittenOrOral")]
		public enum WrittenOrOral
		{
			[Description("کتبي مسبوق به درخواست شفاهي")]
			Oral = 1,			
			[Description("کتبي")]
			Written = 2,			
			[Description("")]
			None = 0
		}
	}
