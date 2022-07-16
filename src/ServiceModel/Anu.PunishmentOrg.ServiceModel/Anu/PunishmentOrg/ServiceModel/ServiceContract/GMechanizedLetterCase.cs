
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("پرونده(يا مدرک اصلي مشابه) مربوطه نامه مکانيزه در سرويس دريافت مکاتبات مکانيزه")]
    public class GMechanizedLetterCase
    {
        public GMechanizedLetterCase()
        {
        }
            
            
            [System.ComponentModel.DisplayName("پرونده(يا مدرک اصلي مشابه) مبداء/مقصد")]
            public Anu.BaseInfo.Enumerations.MechanizedLetterCaseLocation CaseLocation { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شناسه پرونده(يا مدرک اصلي مشابه) مربوطه")]
            public string? RelatedCaseID { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شماره پرونده(يا مدرک اصلي مشابه) نامه")]
            public string? RelatedCaseNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("عنوان/شرح پرونده(يا مدرک اصلي مشابه) نامه")]
            public string? RelatedCaseTitle { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس دريافت مکاتبات مکانيزه")]
            public GMechanizedLetter TheGMechanizedLetter { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("اشياء سيستم در وب سرويس")]
            public SystemObject TheRelatedCaseClass { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("فرم هاي سيستم در وب سرويس")]
            public SystemForm TheRelatedCaseForm { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("واحد ثبتي در سرويس")]
            public Unit TheUnit { get; set ;} 
            

    }
    }
