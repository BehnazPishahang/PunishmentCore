
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("محل هاي مورد بازرسي درخواست مجوز تعقيب/بازرسي در سرویس")]
    public class PChaseLicenseReqPlacesContract
    {
        public PChaseLicenseReqPlacesContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName(" رديف")]
        public string? Id { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع مالکيت محل")]
        public Anu.PunishmentOrg.Enumerations.OwnershipType? OwnershipType { get; set; }

            
            
            [System.ComponentModel.DisplayName("نشاني محل ")]
        public string? PlaceAddress { get; set; }

            
            
            [System.ComponentModel.DisplayName("بهره بردار محل")]
        public string? PlaceBeneficiary { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پروانه/مجوز محل")]
        public string? PlacelicenseNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("مالک محل")]
        public string? PlaceOwner { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره تلفن محل")]
        public string? PlacePhoneNum { get; set; }

            
            
            [System.ComponentModel.DisplayName("پلاک محل")]
        public string? PlacePlaque { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد پستي محل")]
        public string? PlacePostCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام واحد صنفي")]
        public string? PlaceUnitName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("درخواست مجوز تعقيب/بازرسي و پاسخ آن در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqContract? ThePChaseLicenseReqContract { get; set; }

            
            
            [System.ComponentModel.DisplayName("کاربري محل")]
        public string? UserLocation { get; set; }

            

    }
    }
