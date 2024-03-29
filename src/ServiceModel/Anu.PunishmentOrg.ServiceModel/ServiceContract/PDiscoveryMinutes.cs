﻿
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
    public class PDiscoveryMinutes
    {
        public PDiscoveryMinutes()
        {
            this.ThePBillStoreList = new List<PBillStore>(); 
            this.ThePDiscoveryMinutesAttachList = new List<PDiscoveryMinutesAttach>(); 
            this.ThePDiscoveryMinutesDcTypeList = new List<PDiscoveryMinutesDcType>(); 
            this.ThePDiscoveryMinutesDocFoundList = new List<PDiscoveryMinutesDocFound>(); 
            this.ThePDiscoveryMinutesOfficerList = new List<PDiscoveryMinutesOfficer>(); 
            this.ThePDiscoveryMinutesProductFoundList = new List<PDiscoveryMinutesProductFound>(); 
            this.ThePDiscoveryMinutesSmugTypeList = new List<PDiscoveryMinutesSmugType>(); 
            this.ThePDiscoveryMinutesSuspectList = new List<PDiscoveryMinutesSuspect>(); 
            this.ThePDiscoveryMinutesTypeList = new List<PDiscoveryMinutesType>(); 
            this.ThePDiscoveryMinutesVehicleList = new List<PDiscoveryMinutesVehicle>(); 
        }
            
            [System.ComponentModel.DisplayName("شماره رسيد/قبض سازمان تحويل گيرنده کالا/ارز")]
            public string? BillNoProductOrDocFound { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره پرونده در تعزيرات/دادگاه انقلاب")]
            public string? CaseNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره فرعي پرونده در تعزيرات/دادگاه انقلاب")]
            public long? CaseSubNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع مرجع صلاحيت دارجهت رسيدگي به پرونده")]
            public Anu.PunishmentOrg.Enumerations.DiscoveryMinutesCompetenceReference CompetenceReference { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("زمان ثبت")]
            public string? CreateDateTime { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("تاريخ کشف")]
            public string? DiscoveryDate { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع مدرک")]
            public Anu.PunishmentOrg.Enumerations.DiscoveryDocType DiscoveryDocType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شماره صورتجلسه/گزارش")]
            public string? DiscoveryNO { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("واحد (يگان) کاشف")]
            public string? DiscoveryOfficerUnit { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("آدرس محل کشف")]
            public string? DiscoveryPlaceAddress { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("بهره بردار محل کشف")]
            public string? DiscoveryPlaceBeneficiary { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن بهره بردار محل کشف")]
            public string? DiscoveryPlaceBeneficiaryRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره پروانه/مجوز محل کشف")]
            public string? DiscoveryPlacelicenseNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("مالک محل کشف")]
            public string? DiscoveryPlaceOwner { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن مالک محل کشف")]
            public string? DiscoveryPlaceOwnerRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره تلفن محل کشف")]
            public string? DiscoveryPlacePhoneNum { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره تلفن محل کشف")]
            public Anu.PunishmentOrg.Enumerations.DiscoveryPlacePhoneNum DiscoveryPlacePhoneNumRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پلاک محل کشف")]
            public string? DiscoveryPlacePlaque { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن پلاک محل کشف")]
            public Anu.PunishmentOrg.Enumerations.DiscoveryPlacePlaque DiscoveryPlacePlaqueRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد پستي محل کشف")]
            public string? DiscoveryPlacePostalCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن کد پستي محل کشف")]
            public Anu.PunishmentOrg.Enumerations.DiscoveryPlacePostalCode DiscoveryPlacePostalCodeRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام واحد محل کشف")]
            public string? DiscoveryPlaceUnitName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نام واحد محل کشف")]
            public Anu.PunishmentOrg.Enumerations.DiscoveryPlaceUnitName DiscoveryPlaceUnitNameRN { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ساعت کشف")]
            public string? DiscoveryTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساير انواع محل و مکان کشف")]
            public string? DiscoveryTypeOtherPlace { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره شعبه دادگاه انقلاب که به پرونده رسيدگي ميکند")]
            public long? EnghelabCourtNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شواهد,قرائن و اماراتي مبني بر احتمال وقوع سازمان يافته قاچاق")]
            public string? EvidencePossibility { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("وضعيت شماره پروانه/مجوز صنفي محل کشف")]
            public Anu.BaseInfo.Enumerations.HaveNoHave HavePlacelicenseNumber { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شرح چگونگي کشف قاچاق و دستگيري")]
            public string? HowFindArrest { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("دلايل عدم دسترسي ويا احراز متهم")]
            public string? InaccessAccuseReason { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("دلايل عدم وجود کالا در جريان کشف و يا از بين رفتن کالا")]
            public string? InaccessProductReason { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("آيا کالا يا ارز قاچاق کشف شده است(مخصوص گزارش کشف)؟")]
            public Anu.BaseInfo.Enumerations.YesNo IsDiscoverSmuggling { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("وضعيت ثبت محل نگهداري کالا در سامانه جامع انبارها و مراکز نگهداري کالا")]
            public Anu.PunishmentOrg.Enumerations.PURegister KeepPlaceState { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("دلايل عدم احراز مالکيت کالا و ارز,وسيله نقليه و محل نگهداري آنها")]
            public string? LackOfOwnershipReason { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("اطلاع از طريق مخبر")]
            public Anu.BaseInfo.Enumerations.YesNo NotifyOfAware { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کلمه عبور")]
            public string? PassWord { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("توضيحات ارز/کالاي مکشوفه")]
            public string? ProductFoundDesc { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن توضيحات ارز/کالاي مکشوفه")]
            public Anu.PunishmentOrg.Enumerations.ProductFoundDesc ProductFoundDescRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("موارد مطابق قانون تعيين دليل انتخاب مرجع")]
            public Anu.PunishmentOrg.Enumerations.PReasonChoiceCasesAccordanceWithLaw ReasonChoiceAccordanceLaw { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تعيين دليل انتخاب مرجع")]
            public Anu.PunishmentOrg.Enumerations.PReferenceSelectReason ReasonChoiceRefrence { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شگرد ارتکاب جرم يا تخلف")]
            public string? SmugglingTrick { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع جرم يا تخلف ساير")]
            public string? SmugglingTypeOthers { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("جزئيات ارتکاب قاچاق همراه با جرايم ديگر")]
            public string? SmugglingWithCrimes { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("وضعيت وجود مظنون/مظنونان کشف ")]
            public Anu.PunishmentOrg.Enumerations.SuspectState SuspectState { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("مکان جغرافيايي درسرويس")]
            public PBBillGeoLocation ThePBBillGeoLocation { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("دستگاه کاشف")]
            public PBExchangeUnit ThePBExchangeUnit { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس قبض/رسيد انبار")]
            public PBillStore ThePBillStore { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس قبض/رسيد انبار")]
            public List<PBillStore> ThePBillStoreList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("سايرضمائم و مدارک صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<PDiscoveryMinutesAttach> ThePDiscoveryMinutesAttachList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("انواع کشف صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<PDiscoveryMinutesDcType> ThePDiscoveryMinutesDcTypeList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("اسناد،اوراق و وسايل کشف شده صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<PDiscoveryMinutesDocFound> ThePDiscoveryMinutesDocFoundList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("مامورين کشف صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<PDiscoveryMinutesOfficer> ThePDiscoveryMinutesOfficerList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ارز/کالاهاي مکشوفه صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<PDiscoveryMinutesProductFound> ThePDiscoveryMinutesProductFoundList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع جرم يا تخلف صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<PDiscoveryMinutesSmugType> ThePDiscoveryMinutesSmugTypeList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<PDiscoveryMinutesSuspect> ThePDiscoveryMinutesSuspectList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع محل و مکان محل کشف صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<PDiscoveryMinutesType> ThePDiscoveryMinutesTypeList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("وسيله هاي نقليه حامل کالا و ارز قاچاق صورتجلسه/گزارش کشف قاچاق در قاچاق در سرويس")]
            public List<PDiscoveryMinutesVehicle> ThePDiscoveryMinutesVehicleList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("مجموع مکشوفه ده ميليون ريال يا کمتر ارزش دارد")]
            public Anu.BaseInfo.Enumerations.YesNo TotalArtifactsValue { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("جمع کل ارزش تخميني ارز/کالاي مکشوفه")]
            public decimal? TotalProductFound { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شناسه سامانه جامع انبارها")]
            public string? TrackingCodeStores { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شناسه يکتا")]
            public string? UniqueNo { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام کاربري")]
            public string? UserName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("دستگاه کاشف")]
            public string? ZoneName { get; set ;} 
            

    }
    }
