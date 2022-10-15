
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("وسيله نقليه، درخواست 4گانه در سرویس")]
    public class PChaseLicenseReqVehicleContract
    {
        public PChaseLicenseReqVehicleContract()
        {
        }
            
            [System.ComponentModel.DisplayName("آیا وسیله نقلیه توقیف شده است")]
        public Anu.BaseInfo.Enumerations.YesNo? ArrestedVehicle { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پلاک کفی")]
        public string? AutomotiveNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره شاسی")]
        public string? ChassisNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("رنگ")]
        public string? Color { get; set; }

            
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
        public Anu.PunishmentOrg.Enumerations.PUConclusion? ConclusionRequest { get; set; }

            
            
            [System.ComponentModel.DisplayName("سال تولید")]
        public string? CreateDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي راننده وسيله نقليه")]
        public string? DriverFamily { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام راننده وسيله نقليه")]
        public string? DriverName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره شناسایی ناوگان")]
        public string? FleetNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد پلاک")]
        public string? IranNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا قبض پارکينگ صادر شده است")]
        public Anu.BaseInfo.Enumerations.YesNo? IssueParkBillReg { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مدل")]
        public string? Model { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره موتور")]
        public string? MotorNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("ساير مشخصات")]
        public string? OtherInfo { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي مالک وسيله نقليه")]
        public string? OwnerFamily { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام مالک وسيله نقليه")]
        public string? OwnerName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره قبض پارکينگ")]
        public string? ParkFicheNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره انتظامي(پلاک)")]
        public string? PlaqueNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("حروف پلاک")]
        public Anu.BaseInfo.Enumerations.PlaqueScript? PlaqueScript { get; set; }

            
            
            [System.ComponentModel.DisplayName("سریال پلاک کفی")]
        public string? Plaqueserial { get; set; }

            
            
            [System.ComponentModel.DisplayName("پلاک سه رقم")]
        public string? PlaqueThreeDigit { get; set; }

            
            
            [System.ComponentModel.DisplayName("پلاک دو رقم")]
        public string? PlaqueTwoDigit { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع پلاک")]
        public Anu.BaseInfo.Enumerations.PlaqueType? PlaqueType { get; set; }

            
            
            [System.ComponentModel.DisplayName("تحويل گيرنده قبض پارکينگ")]
        public string? RecieverParkingBill { get; set; }

            
            
            [System.ComponentModel.DisplayName("ثبت در سامانه بارنامه")]
        public Anu.BaseInfo.Enumerations.HaveNoHave? RegInWaybill { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتیب")]
        public long? RowNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("درخواست 4گانه(مجوز بازرسی-تکمیل تحقیقات-اعلام تخلف-تایید مجوز شفاهی) و پاسخ آن در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqContract? ThePChaseLicenseReqContract { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه یکتای وسیله نقلیه")]
        public long? VehicleId { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع وسيله نقليه")]
        public Anu.PunishmentOrg.Enumerations.VehicleType? VehicleType { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام وسیله نقلیه")]
        public string? VihecleName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره بارنامه ")]
        public string? WayBillNO { get; set; }

            

    }
    }
