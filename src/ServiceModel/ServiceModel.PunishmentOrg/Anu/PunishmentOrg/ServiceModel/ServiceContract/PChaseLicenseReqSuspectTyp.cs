
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع مجوز شخص مورد تعقيب درخواست مجوز تعقيب/بازرسي")]
    public class PChaseLicenseReqSuspectTyp
    {
        public PChaseLicenseReqSuspectTyp()
        {
        }
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
            public Anu.PunishmentOrg.Enumerations.PUConclusion ConclusionRequest { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع مجوز در مورد شخص")]
            public Anu.PunishmentOrg.Enumerations.LicensePersonType LicensePersonType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اشخاص مورد تعقيب درخواست مجوز تعقيب/بازرسي در سرويس")]
            public PChaseLicenseReqSuspect ThePChaseLicenseReqSuspect { get; set ;} 
            

    }
    }
