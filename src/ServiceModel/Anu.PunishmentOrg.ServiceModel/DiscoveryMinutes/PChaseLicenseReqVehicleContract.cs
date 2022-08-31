
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("وسيله نقليه مورد بازرسي درخواست مجوز تعقيب بازرسي در سرویس")]
    public class PChaseLicenseReqVehicleContract
    {
        public PChaseLicenseReqVehicleContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("رنگ")]
        public string? Color { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي راننده وسيله نقليه")]
        public string? DriverFamily { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام راننده وسيله نقليه")]
        public string? DriverName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName(" رديف")]
        public string? Id { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد پلاک")]
        public string? IranNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مدل")]
        public string? Model { get; set; }

            
            
            [System.ComponentModel.DisplayName("ساير مشخصات")]
        public string? OtherInfo { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي مالک وسيله نقليه")]
        public string? OwnerFamily { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام مالک وسيله نقليه")]
        public string? OwnerName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره انتظامي(پلاک)")]
        public string? PlaqueNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("حروف پلاک")]
        public Anu.BaseInfo.Enumerations.PlaqueScript? PlaqueScript { get; set; }

            
            
            [System.ComponentModel.DisplayName("پلاک سه رقم")]
        public string? PlaqueThreeDigit { get; set; }

            
            
            [System.ComponentModel.DisplayName("پلاک دو رقم")]
        public string? PlaqueTwoDigit { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع پلاک")]
        public Anu.BaseInfo.Enumerations.PlaqueType? PlaqueType { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("درخواست مجوز تعقيب/بازرسي و پاسخ آن در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqContract? ThePChaseLicenseReqContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع وسيله نقليه")]
        public Anu.PunishmentOrg.Enumerations.VehicleType? VehicleType { get; set; }

            

    }
    }
