
namespace Anu.PunishmentOrg.ServiceModel.BillStore
{
    [System.ComponentModel.DisplayName("کالا/ارز قبض/رسيد کالا/ارز صادر شده توسط سازمان مسئول نگه داري کالا/ارز در سرویس")]
    public class PBillStoreProductContract
    {
        public PBillStoreProductContract()
        {
        }
            
            [System.ComponentModel.DisplayName("ماده 21 در فرآورده نفتي")]
        public string? Article21 { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام تجاري(برند)")]
        public string? BrandName { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-تعداد محور")]
        public string? CarAxle { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-شماره بدنه")]
        public string? CarBodyNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-ظرفيت")]
        public string? CarCapacity { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-شماره شاسي")]
        public string? CarChassisNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-رنگ")]
        public string? CarColor { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-تعداد سيلندر")]
        public string? CarCylinder { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-تعداد درب")]
        public string? CarDoorNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-حجم موتور")]
        public string? CarEngineVolume { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-شماره موتور")]
        public string? CarEnginNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-نوع سوخت")]
        public string? CarFuel { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-نوع گيربکس")]
        public string? CarGearboxType { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-وضعيت اوراقي")]
        public Anu.BaseInfo.Enumerations.YesNo? CarMalfunctionStatus { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-مدل")]
        public string? CarModel { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-شماره پلاک")]
        public string? CarPlaque { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-تاريخ نصب پلاک")]
        public string? CarPlaqueDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-تيپ")]
        public string? CarStyle { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-سيستم")]
        public string? CarSystem { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-نوع خودرو")]
        public string? CarType { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-نوع کاربري")]
        public string? CarUsage { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماشين-تعداد چرخ")]
        public string? CarWheel { get; set; }

            
            
            [System.ComponentModel.DisplayName("کشور سازنده")]
        public string? CountryCreate { get; set; }

            
            
            [System.ComponentModel.DisplayName("واحد قطعات ارز")]
        public string? CurrencyUnit { get; set; }

            
            
            [System.ComponentModel.DisplayName("ميزان ارز")]
        public long? CurrencyValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ترتيب هاي کالاها در صورتجلسه کشف")]
        public string? DiscoveryRowNumbers { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ارزش تخميني/کارشناسي")]
        public decimal? EstimatedValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ انقضا")]
        public string? ExpireDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه کالا")]
        public string? IDNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا چوب بعنوان هيزم استفاده ميشود؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsFireWood { get; set; }

            
            
            [System.ComponentModel.DisplayName("طلاوجواهر-درشتي")]
        public string? JewelryCoarse { get; set; }

            
            
            [System.ComponentModel.DisplayName("طلاوجواهر-عيار")]
        public string? JewelryCut { get; set; }

            
            
            [System.ComponentModel.DisplayName("طلاوجواهر-تراش")]
        public string? JewelryCutting { get; set; }

            
            
            [System.ComponentModel.DisplayName("طلاوجواهر-نوع جنس")]
        public string? JewelryMaterial { get; set; }

            
            
            [System.ComponentModel.DisplayName("طلاوجواهر-وزن")]
        public string? JewelryWeight { get; set; }

            
            
            [System.ComponentModel.DisplayName("فرآورده نفتي غير اصلي")]
        public string? NonEssentialPetroleumProduct { get; set; }

            
            
            [System.ComponentModel.DisplayName("قدمت شيء به سال")]
        public long? ObjectArchaism { get; set; }

            
            
            [System.ComponentModel.DisplayName("ارزش فرهنگي تاريخي شيء")]
        public string? ObjectCulturalValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("توضيح در مورد شيء/کالا")]
        public string? ObjectDesc { get; set; }

            
            
            [System.ComponentModel.DisplayName("جنس شيء/چوب آلات")]
        public string? ObjectGender { get; set; }

            
            
            [System.ComponentModel.DisplayName("ارتفاع شيء/چوب به سانتيمتر")]
        public long? ObjectHeight { get; set; }

            
            
            [System.ComponentModel.DisplayName("تصوير شيء")]
        public byte[]? ObjectImage { get; set; }

            
            
            [System.ComponentModel.DisplayName("طول شيء/چوب به سانتيمتر")]
        public long? ObjectLength { get; set; }

            
            
            [System.ComponentModel.DisplayName("اصالت شيء")]
        public Anu.PunishmentOrg.Enumerations.ObjectOriginality? ObjectOriginality { get; set; }

            
            
            [System.ComponentModel.DisplayName("عرض شيء/چوب به سانتيمتر")]
        public long? ObjectWidth { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع بسته بندي")]
        public string? PackingType { get; set; }

            
            
            [System.ComponentModel.DisplayName("نفت-ناحیه")]
        public string? PetrolArea { get; set; }



        [System.ComponentModel.DisplayName("نفت - فرآورده های اصلی")]
        public Anu.PunishmentOrg.Enumerations.PetroleumType? PetroleumType { get; set; }



        [System.ComponentModel.DisplayName("نفت - تاریخ تحویل")]
        public string? PetrolGivenDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("نفت - تاریخ مرجع قضایی")]
        public string? PetrolJudgmentDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("نفت - شماره حکم یا دستور مرجع قضایی")]
        public string? PetrolJudgmentNumber { get; set; }



        [System.ComponentModel.DisplayName("نفت - روش تخلف")]
        public Anu.PunishmentOrg.Enumerations.MethodViolation? PetrolMethodViolation { get; set; }



        [System.ComponentModel.DisplayName("نفت - کد رهگیری")]
        public string? PetrolTrackingCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("ارزش اوليه/ارزش ريالي شيء")]
        public decimal? PrimeryValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("مشخصات کالا")]
        public string? ProductDesc { get; set; }

            
            
            [System.ComponentModel.DisplayName("طبقه اصلي کالا")]
        public string? ProductMainGrade { get; set; }

            
            
            [System.ComponentModel.DisplayName("ماهيت کالاي مکشوفه")]
        public string? ProductNature { get; set; }

            
            
            [System.ComponentModel.DisplayName("کالا/ارز کشف شده")]
        public Anu.PunishmentOrg.Enumerations.PProductOrCurrency? ProductOrCurrency { get; set; }

            
            
            [System.ComponentModel.DisplayName("مقدار اوليه کالا/ارز(ادعايي)")]
        public decimal? ProductPrimValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام زيرگروه/طبقه فرعي کالا")]
        public string? ProductSubsidiaryGrade { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام/شرح کالا/شيء")]
        public string? ProductTitle { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع کالاي تحويل شده")]
        public Anu.PunishmentOrg.Enumerations.PProductType? ProductType { get; set; }

            
            
            [System.ComponentModel.DisplayName("تعداد/مقدار کالا/ارز/شيء/چوب/مقدار فرآورده نفتي(واقعي)")]
        public decimal? RemindValue { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره سريال ساخت")]
        public string? SerialNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ توليد")]
        public string? StartDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("قبض/رسيد کالا/ارز صادر شده توسط سازمان مسئول نگه داري کالا/ارز در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.BillStore.PBillStoreContract? ThePBillStoreContract { get; set; }

            
            
            [System.ComponentModel.DisplayName("حجم بر حسب يک استر")]
        public long? VolumeInDonkey { get; set; }

            
            
            [System.ComponentModel.DisplayName("وزن کالا/شيء")]
        public decimal? WeightProduct { get; set; }

            
            
            [System.ComponentModel.DisplayName("قطر چوب به سانتيمتر")]
        public long? WoodDiameter { get; set; }

            
            
            [System.ComponentModel.DisplayName("حجم کل چوب")]
        public long? WoodTotalVolume { get; set; }

            

    }
    }
