
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع درخواست مجوز تعقيب/بازرسي و پاسخ آن")]
    public class PChaseLicenseReqType
    {
        public PChaseLicenseReqType()
        {
        }
            
            
            [System.ComponentModel.DisplayName("نوع مجوز تعقيب/بازرسي")]
            public Anu.PunishmentOrg.Enumerations.PUChaseLicenseType ChaseLicenseType { get; set ;} 
            

    }
    }
