
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("پرونده(يا مدرک اصلي مشابه) مربوطه نامه مکانيزه در سرويس دريافت مکاتبات مکانيزه")]
    public class GMechanizedLetterCase
    {
        public GMechanizedLetterCase()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("پرونده(يا مدرک اصلي مشابه) مبداء/مقصد")]
            public DataModel.BaseInfo.Anu.Enumerations.MechanizedLetterCaseLocation CaseLocation { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه پرونده(يا مدرک اصلي مشابه) مربوطه")]
            public string RelatedCaseID { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره پرونده(يا مدرک اصلي مشابه) نامه")]
            public string RelatedCaseNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("عنوان/شرح پرونده(يا مدرک اصلي مشابه) نامه")]
            public string RelatedCaseTitle { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس دريافت مکاتبات مکانيزه")]
            public Anu.PunishmentOrg.ServiceContract.GMechanizedLetter TheGMechanizedLetter { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اشياء سيستم در وب سرويس")]
            public Anu.PunishmentOrg.ServiceContract.SystemObject TheRelatedCaseClass { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("فرم هاي سيستم در وب سرويس")]
            public Anu.PunishmentOrg.ServiceContract.SystemForm TheRelatedCaseForm { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("واحد ثبتي در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.Unit TheUnit { get; set ;} 
            

    }
    }
