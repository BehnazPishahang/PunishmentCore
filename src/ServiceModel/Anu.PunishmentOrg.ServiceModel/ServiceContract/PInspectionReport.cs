﻿
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("ورودي سرويس گزارش بازرسي")]
    public class PInspectionReport
    {
        public PInspectionReport()
        {
            this.ThePInspectionReportAttachmentList = new List<PInspectionReportAttachment>(); 
            this.ThePInspectionReportDirectorsList = new List<PInspectionReportDirectors>(); 
            this.ThePInspectionReportInspectorList = new List<PInspectionReportInspector>(); 
            this.ThePInspectionReportPersonList = new List<PInspectionReportPerson>(); 
            this.ThePinspectionReportTradeList = new List<PinspectionReportTrade>(); 
        }
            
            
            [System.ComponentModel.DisplayName("زمان ثبت در سامانه تعزيرات")]
            public string? CreateDateTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نشاني اداره کننده در زمان بازرسي")]
            public string? DirectorAddress { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ تولد اداره کننده در زمان بازرسي")]
            public string? DirectorBirthDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي اداره کننده در زمان بازرسي")]
            public string? DirectorFamily { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام پدر اداره کننده در زمان بازرسي")]
            public string? DirectorFatherName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره شناسنامه اداره کننده در زمان بازرسي")]
            public string? DirectorIdentityNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تلفن همراه اداره کننده در زمان بازرسي")]
            public string? DirectorMobilNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام اداره کننده در زمان بازرسي")]
            public string? DirectorName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ملي اداره کننده در زمان بازرسي")]
            public string? DirectorNationalCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("وضعيت تابعيت اداره کننده در زمان بازرسي")]
            public Anu.BaseInfo.Enumerations.LNationality DirectorNationality { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کشور تابعيت غيرايراني اداره کننده در زمان بازرسي")]
            public string? DirectorNonIranianCnt { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره گذرنامه اداره کننده در زمان بازرسي")]
            public string? DirectorPassportNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("سمت اداره کننده در زمان بازرسي")]
            public Anu.PunishmentOrg.Enumerations.PSuspectPostType DirectorPostType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("جنسيت اداره کننده در زمان بازرسي")]
            public Anu.BaseInfo.Enumerations.SexType DirectorSex { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد اقتصادي")]
            public string? EconomicCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("عنوان سازمان دولتي مالک واحد صنفي")]
            public string? GovOrgOwner { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ شکايت مردمي اساس بازرسي")]
            public string? GravamenDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره شکايت مردمي اساس بازرسي")]
            public string? GravamenNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("آيا واحد صنفي سابقه تخلف دارد")]
            public Anu.BaseInfo.Enumerations.YesNo HasViolation { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نحوه اخذ اطلاعات")]
            public Anu.PunishmentOrg.Enumerations.HowGetDataInspectionReport HowDataType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("زمان بازرسي")]
            public string? InspectionDateTime { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شماره گزارش بازرسي")]
            public string? InspectionReportNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ تکميل گزارش بازرسي")]
            public string? InspectionRptCompleteDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("وضعيت ثبت محل نگهداري کالا در سامانه جامع انبارها و مراکز نگهداري کالا")]
            public Anu.PunishmentOrg.Enumerations.PURegister KeepPlaceState { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نشاني صاحب پروانه/مجوز کسب واحد صنفي")]
            public string? LicenseOwnerAddress { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ تولد صاحب پروانه/مجوز کسب واحد صنفي")]
            public string? LicenseOwnerBirthDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي صاحب پروانه/مجوز کسب واحد صنفي")]
            public string? LicenseOwnerFamily { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام پدر صاحب پروانه/مجوز کسب واحد صنفي")]
            public string? LicenseOwnerFatherName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره شناسنامه صاحب پروانه/مجوز کسب واحد صنفي")]
            public string? LicenseOwnerIdentityNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تلفن همراه صاحب پروانه/مجوز کسب واحد صنفي")]
            public string? LicenseOwnerMobilNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام صاحب پروانه/مجوز کسب واحد صنفي")]
            public string? LicenseOwnerName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ملي صاحب پروانه/مجوز کسب واحد صنفي")]
            public string? LicenseOwnerNationalCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("وضعيت تابعيت صاحب پروانه/مجوز کسب واحد صنفي")]
            public Anu.BaseInfo.Enumerations.LNationality LicenseOwnerNationality { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کشور تابعيت غيرايراني صاحب پروانه/مجوز کسب واحد صنفي")]
            public string? LicenseOwnerNonIraniaCnt { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره گذرنامه صاحب پروانه/مجوز کسب واحد صنفي")]
            public string? LicenseOwnerPassportNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("سمت صاحب پروانه/مجوز کسب واحد صنفي")]
            public Anu.PunishmentOrg.Enumerations.PSuspectPostType LicenseOwnerPostType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساير سمت صاحب پروانه/مجوز کسب واحد صنفي")]
            public string? LicenseOwnerResponsibility { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("جنسيت صاحب پروانه/مجوز کسب واحد صنفي")]
            public Anu.BaseInfo.Enumerations.SexType LicenseOwnerSex { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع پروانه کسب")]
            public Anu.PunishmentOrg.Enumerations.PULicenseType LicenseType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("صادر کننده پروانه/مجوز")]
            public string? LicensingName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("عنوان طرح نظارتي اساس يازرسي")]
            public string? MonitoringPlanTitle { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شماره مکانيزه تعزيراتي گزارش")]
            public string? No { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع مالکيت محل واحد صنفي")]
            public Anu.PunishmentOrg.Enumerations.OwnerEstateType OwnerEstateType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع مالکيت")]
            public Anu.PunishmentOrg.Enumerations.PUOwnershipType OwnershipType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("کلمه عبور")]
            public string? PassWord { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پلاک")]
            public string? Plaque { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ ثبت واحد صنفي")]
            public string? RegDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("منطقه")]
            public string? Region { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ثبت واحد صنفي")]
            public string? RegNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت بازرسي")]
            public Anu.PunishmentOrg.Enumerations.PUInspectionReportBase ReportBase { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساير علت بازرسي")]
            public string? ReportBaseOther { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("آيا گزارش بازرسي از طريق وب سرويس ايجاد شده است؟")]
            public Anu.BaseInfo.Enumerations.YesNo SaveType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("مکان جغرافيايي درسرويس")]
            public PBBillGeoLocation ThePBBillGeoLocation { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("اتحاديه صنفي در سرويس")]
            public PBTradeUnions ThePBTradeUnions { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع واحد صنفي در سرويس")]
            public PBTradeUnitType ThePBTradeUnitType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("پيوست هاي گزارش بازرسي در سرويس")]
            public List<PInspectionReportAttachment> ThePInspectionReportAttachmentList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("اداره کننده/صاحب پروانه در سرويس")]
            public List<PInspectionReportDirectors> ThePInspectionReportDirectorsList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("بازرسان گزارش بازرسي در سرويس")]
            public List<PInspectionReportInspector> ThePInspectionReportInspectorList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شاکي هاي گزارش بازرسي در سرويس")]
            public List<PInspectionReportPerson> ThePInspectionReportPersonList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع واحد صنفي گزارش بازرسي در سرويس")]
            public List<PinspectionReportTrade> ThePinspectionReportTradeList { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ميزان کل خسارت وارده به شاکي")]
            public long? TotalDamages { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("جمع کل ارزش ريالي تخلف")]
            public long? TotalViolationPrice { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("فاقد پروانه کسب/مجوز")]
            public Anu.PunishmentOrg.Enumerations.LicenseType TradeLicense { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ صدور پروانه/مجوز کسب واحد صنفي")]
            public string? TradeLicenseDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره پروانه/مجوز کسب واحد صنفي")]
            public string? TradeLicenseNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نشاني واحد صنفي")]
            public string? TradeUnitAddress { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شناسه يکتاي واحد صنفي مربوطه")]
            public string? TradeUnitIdentityNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام واحد صنفي مربوطه")]
            public string? TradeUnitName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد پستي واحد صنفي")]
            public string? TradeUnitPostCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره تلفن واحد صنفي")]
            public string? TradeUnitTelNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساير انواع واحد صنفي")]
            public string? TradeUnitTypeOther { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام کاربري")]
            public string? UserName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تعداد سابقه تخلف قبلي واحد صنفي")]
            public long? ViolationCount { get; set ;} 
            

    }
    }
