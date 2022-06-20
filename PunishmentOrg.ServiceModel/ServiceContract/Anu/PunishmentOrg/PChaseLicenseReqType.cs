
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع درخواست مجوز تعقيب/بازرسي و پاسخ آن")]
    public class PChaseLicenseReqType
    {
        public PChaseLicenseReqType()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع مجوز تعقيب/بازرسي")]
            public Anu.Enumerations.PunishmentOrg.PUChaseLicenseType ChaseLicenseType { get; set ;} 
            

    }
    }
