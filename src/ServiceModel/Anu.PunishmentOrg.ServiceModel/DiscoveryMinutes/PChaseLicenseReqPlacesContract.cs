
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("محل هاي، درخواست 4گانه در سرویس")]
    public class PChaseLicenseReqPlacesContract
    {
        public PChaseLicenseReqPlacesContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شماره پروانه بهره برداری")]
        public string? BeneficiaryNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("شهرستان")]
        public string? CityId { get; set; }

            
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
        public Anu.PunishmentOrg.Enumerations.PUConclusion? ConclusionRequest { get; set; }

            
            
            [System.ComponentModel.DisplayName("مالک محل")]
        public string? DiscoveryPlaceOwner { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع مالکيت محل")]
        public string? OwnershipType { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع محل و مکان")]
        public string? PBDiscoveryMinuteType { get; set; }

            
            
            [System.ComponentModel.DisplayName("نشاني محل ")]
        public string? PlaceAddress { get; set; }

            
            
            [System.ComponentModel.DisplayName("بهره بردار محل")]
        public string? PlaceBeneficiary { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه یکتای محل")]
        public long? placeId { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پروانه/مجوز محل")]
        public string? PlacelicenseNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگی مالک محل")]
        public string? PlaceOwnerFamily { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام مالک حقیقی/حقوقی محل")]
        public string? PlaceOwnerName { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد ملی/کد اقتصادی مالک محل")]
        public string? PlaceOwnerNCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع شخص مالک محل")]
        public string? PlaceOwnerPersonType { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره تلفن محل")]
        public string? PlacePhoneNum { get; set; }

            
            
            [System.ComponentModel.DisplayName("پلاک محل")]
        public string? PlacePlaque { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد پستي محل")]
        public string? PlacePostCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("ارزش تخمینی ملک")]
        public long? PlacePrice { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام واحد صنفي")]
        public string? PlaceUnitName { get; set; }

            
            
            [System.ComponentModel.DisplayName("استان")]
        public string? ProvinceId { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتیب")]
        public long? RowNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("درخواست 4گانه(مجوز بازرسی-تکمیل تحقیقات-اعلام تخلف-تایید مجوز شفاهی) و پاسخ آن در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqContract? ThePChaseLicenseReqContract { get; set; }

            
            
            [System.ComponentModel.DisplayName("شهر")]
        public string? TownshipId { get; set; }

            

    }
    }
