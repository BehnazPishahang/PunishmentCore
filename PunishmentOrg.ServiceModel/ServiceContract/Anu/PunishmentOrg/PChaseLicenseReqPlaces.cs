
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("محل هاي مورد بازرسي درخواست مجوز تعقيب/بازرسي در سرويس")]
    public class PChaseLicenseReqPlaces
    {
        public PChaseLicenseReqPlaces()
        {
        }
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
            public Anu.Enumerations.PunishmentOrg.PUConclusion ConclusionRequest { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع مالکيت محل")]
            public Anu.Enumerations.PunishmentOrg.OwnershipType OwnershipType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نشاني محل ")]
            public string PlaceAddress { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("بهره بردار محل")]
            public string PlaceBeneficiary { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره پروانه/مجوز محل")]
            public string PlacelicenseNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("مالک محل")]
            public string PlaceOwner { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره تلفن محل")]
            public string PlacePhoneNum { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پلاک محل")]
            public string PlacePlaque { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد پستي محل")]
            public string PlacePostCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام واحد صنفي")]
            public string PlaceUnitName { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس درخواست مجوز تعقيب/بازرسي")]
            public Anu.PunishmentOrg.ServiceContract.PChaseLicenseReq ThePChaseLicenseReq { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کاربري محل")]
            public string UserLocation { get; set ;} 
            

    }
    }
