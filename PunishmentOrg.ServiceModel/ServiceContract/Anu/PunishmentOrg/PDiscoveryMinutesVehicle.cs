
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("وسيله هاي نقليه حامل کالا و ارز قاچاق صورتجلسه/گزارش کشف قاچاق در قاچاق در سرويس")]
    public class PDiscoveryMinutesVehicle
    {
        public PDiscoveryMinutesVehicle()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وسيله نقليه توقيف و تحويل پارکينگ شده است")]
            public DataModel.BaseInfo.Anu.Enumerations.YesNo ArrestedVehicle { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره شاسي")]
            public string ChassisNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره شاسي")]
            public string ChassisNumberRN { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("رنگ")]
            public string Color { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي راننده وسيله نقليه")]
            public string DriverFamily { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نام و نام خانوادگي راننده وسيله نقليه")]
            public DataModel.Anu.Enumerations.PunishmentOrg.DriverFullName DriverFullNameRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام راننده وسيله نقليه")]
            public string DriverName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد پلاک")]
            public string IranNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("آيا قبض پارکينگ صادر شده است")]
            public DataModel.BaseInfo.Anu.Enumerations.YesNo IssueParkBillReg { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مدل")]
            public string Model { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره موتور")]
            public string MotorNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره موتور")]
            public string MotorNumberRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساير مشخصات")]
            public string OtherInfo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن ساير مشخصات")]
            public DataModel.Anu.Enumerations.PunishmentOrg.OtherInfo OtherInfoRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي مالک وسيله نقليه")]
            public string OwnerFamily { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نام و نام خانوادگي مالک وسيله نقليه")]
            public string OwnerFullNameRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام مالک وسيله نقليه")]
            public string OwnerName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره قبض پارکينگ")]
            public string ParkFicheNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام پارکينگ")]
            public string ParkingName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره انتظامي(پلاک)")]
            public string PlaqueNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره انتظامي(پلاک)")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PlaqueNumber PlaqueNumberRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("حروف پلاک")]
            public DataModel.BaseInfo.Anu.Enumerations.PlaqueScript PlaqueScript { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پلاک سه رقم")]
            public string PlaqueThreeDigit { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پلاک دو رقم")]
            public string PlaqueTwoDigit { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع پلاک")]
            public DataModel.BaseInfo.Anu.Enumerations.PlaqueType PlaqueType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ثبت در سامانه بارنامه")]
            public DataModel.BaseInfo.Anu.Enumerations.YesNo RegInWaybill { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن ثبت در سامانه بارنامه")]
            public DataModel.Anu.Enumerations.PunishmentOrg.RegInWaybill RegInWaybillRN { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع وسيله نقليه")]
            public DataModel.Anu.Enumerations.PunishmentOrg.VehicleType VehicleType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره بارنامه ")]
            public string WayBillNO { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره بارنامه ")]
            public DataModel.Anu.Enumerations.PunishmentOrg.WayBillNO WayBillNORN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("سريال بارنامه")]
            public string WayBillSerial { get; set ;} 
            

    }
    }
