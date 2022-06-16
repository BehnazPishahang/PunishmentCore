
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("وسيله نقليه مورد بازرسي درخواست مجوز تعقيب بازرسي در سرويس در سرويس")]
    public class PChaseLicenseReqVehicle
    {
        public PChaseLicenseReqVehicle()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("رنگ")]
            public string Color { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
            public Anu.Enumerations.PunishmentOrg.PUConclusion ConclusionRequest { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي راننده وسيله نقليه")]
            public string DriverFamily { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام راننده وسيله نقليه")]
            public string DriverName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد پلاک")]
            public string IranNumber { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مدل")]
            public string Model { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساير مشخصات")]
            public string OtherInfo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي مالک وسيله نقليه")]
            public string OwnerFamily { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام مالک وسيله نقليه")]
            public string OwnerName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره انتظامي(پلاک)")]
            public string PlaqueNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("حروف پلاک")]
            public Anu.Enumerations.PlaqueScript PlaqueScript { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پلاک سه رقم")]
            public string PlaqueThreeDigit { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پلاک دو رقم")]
            public string PlaqueTwoDigit { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع پلاک")]
            public Anu.Enumerations.PlaqueType PlaqueType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس درخواست مجوز تعقيب/بازرسي")]
            public Anu.PunishmentOrg.ServiceContract.PChaseLicenseReq ThePChaseLicenseReq { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع وسيله نقليه")]
            public Anu.Enumerations.PunishmentOrg.VehicleType VehicleType { get; set ;} 
            

    }
    }
