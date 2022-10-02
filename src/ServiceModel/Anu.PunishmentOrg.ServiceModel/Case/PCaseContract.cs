
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("پرونده سازمان تعزيرات در سرویس")]
    public class PCaseContract
    {
        public PCaseContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره بايگاني پرونده در شعبه")]
        public string? ArchiveNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره قبض/رسيد کالا/ارز مشکوفه")]
        public string? BillNoInWarehouse { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت عدم ورود شماره قبض/رسيد کالا/ارز مکشوفه")]
        public string? BillNoInWarehouseRN { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت آماري پرونده")]
        public Anu.PunishmentOrg.Enumerations.PUCaseArchiveState? CaseArchiveState { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("رمز پرونده")]
        public string? CasePassword { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نحوه ارسال پرونده")]
        public Anu.PunishmentOrg.Enumerations.CaseSendType? CaseSendType { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پرونده در انبار بايگاني راکد")]
        public string? CaseStoreNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان پرونده")]
        public string? CaseTitle { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع پرونده اصلي/نيابتي")]
        public Anu.PunishmentOrg.Enumerations.PUCaseType? CaseType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نحوه تشکيل پرونده")]
        public Anu.PunishmentOrg.Enumerations.PUCreateCaseType? CreateCaseType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره مکانيزه مدرک عامل ايجاد پرونده")]
        public string? CreatedCaseDocNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("آخرين زمان مختومه شدن پرونده")]
        public string? EndDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع پرونده از نظر صنفي/غيرصنفي")]
        public Anu.PunishmentOrg.Enumerations.PUGuild? Guild { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("درجه اهميت پرونده")]
        public Anu.PunishmentOrg.Enumerations.PUImportanceDegree? ImportanceDegree { get; set; }

            
            
            [System.ComponentModel.DisplayName("کلاسه دستي پرونده يا شماره در سامانه قديمي")]
        public string? ManualNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("خلاصه اطلاع رساني مکانيزه")]
        public string? MechanizeInfo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره پرونده")]
        public string? No { get; set; }

            
            
            [System.ComponentModel.DisplayName("شرح شکوائيه")]
        public string? PetitionDescription { get; set; }

            
            
            [System.ComponentModel.DisplayName("مدارک و مستندات")]
        public string? PetitionReasons { get; set; }

            
            
            [System.ComponentModel.DisplayName("موضوع شکايت")]
        public string? PetitionSubject { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پيش قبض/رسيد کالا/ارز مشکوفه")]
        public string? PreBillNoInWarehouse { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه پرونده مبدا")]
        public string? SourceObjectId { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره فرعي پرونده")]
        public long? SubNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("جمع ارزش مالي تخلف از نظر کاشف")]
        public long? TotalViolationPrice { get; set; }

            
            
            [System.ComponentModel.DisplayName("جمع ارزش مالي تخلف از نظر شعبه")]
        public long? TotalViolationPriceByCourt { get; set; }

            
            
            [System.ComponentModel.DisplayName("جمع ارزش مالي تخلف از نظر کارشناس")]
        public long? TotalViolationPriceByExpert { get; set; }

            
            
            [System.ComponentModel.DisplayName("زمان آخرين راستي آزمايي")]
        public string? VerificationDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("نتيجه راستي آزمايي اطلاعات")]
        public string? VerificationResult { get; set; }

            

    }
    }
