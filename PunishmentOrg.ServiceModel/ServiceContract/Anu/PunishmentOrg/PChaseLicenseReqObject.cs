
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("شيء مورد تعقيب/بازرسي")]
    public class PChaseLicenseReqObject
    {
        public PChaseLicenseReqObject()
        {
        }
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
            public Anu.Enumerations.PunishmentOrg.PUConclusion ConclusionRequest { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            

    }
    }
