﻿
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("وسيله هاي نقليه حامل کالا و ارز قاچاق صورتجلسه/گزارش کشف قاچاق در قاچاق در سرويس")]
    public class PDiscoveryMinutesVehicle
    {
        public PDiscoveryMinutesVehicle()
        {
        }
            
            
            [System.ComponentModel.DisplayName("وسيله نقليه توقيف و تحويل پارکينگ شده است")]
            public Anu.BaseInfo.Enumerations.YesNo ArrestedVehicle { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره شاسي")]
            public string? ChassisNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره شاسي")]
            public string? ChassisNumberRN { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("رنگ")]
            public string? Color { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي راننده وسيله نقليه")]
            public string? DriverFamily { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نام و نام خانوادگي راننده وسيله نقليه")]
            public Anu.PunishmentOrg.Enumerations.DriverFullName DriverFullNameRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام راننده وسيله نقليه")]
            public string? DriverName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد پلاک")]
            public string? IranNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("آيا قبض پارکينگ صادر شده است")]
            public Anu.BaseInfo.Enumerations.YesNo IssueParkBillReg { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("مدل")]
            public string? Model { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره موتور")]
            public string? MotorNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره موتور")]
            public string? MotorNumberRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساير مشخصات")]
            public string? OtherInfo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن ساير مشخصات")]
            public Anu.PunishmentOrg.Enumerations.OtherInfo OtherInfoRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي مالک وسيله نقليه")]
            public string? OwnerFamily { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نام و نام خانوادگي مالک وسيله نقليه")]
            public string? OwnerFullNameRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام مالک وسيله نقليه")]
            public string? OwnerName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره قبض پارکينگ")]
            public string? ParkFicheNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام پارکينگ")]
            public string? ParkingName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره انتظامي(پلاک)")]
            public string? PlaqueNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره انتظامي(پلاک)")]
            public Anu.PunishmentOrg.Enumerations.PlaqueNumber PlaqueNumberRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("حروف پلاک")]
            public Anu.BaseInfo.Enumerations.PlaqueScript PlaqueScript { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پلاک سه رقم")]
            public string? PlaqueThreeDigit { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پلاک دو رقم")]
            public string? PlaqueTwoDigit { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع پلاک")]
            public Anu.BaseInfo.Enumerations.PlaqueType PlaqueType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ثبت در سامانه بارنامه")]
            public Anu.BaseInfo.Enumerations.YesNo RegInWaybill { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن ثبت در سامانه بارنامه")]
            public Anu.PunishmentOrg.Enumerations.RegInWaybill RegInWaybillRN { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع وسيله نقليه")]
            public Anu.PunishmentOrg.Enumerations.VehicleType VehicleType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره بارنامه ")]
            public string? WayBillNO { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره بارنامه ")]
            public Anu.PunishmentOrg.Enumerations.WayBillNO WayBillNORN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("سريال بارنامه")]
            public string? WayBillSerial { get; set ;} 
            

    }
    }
