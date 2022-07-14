
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("جرم ها / تخلفات مورد تعقيب بازرسي")]
    public class PChaseLicenseReqCrim
    {
        public PChaseLicenseReqCrim()
        {
        }
            
            
            [System.ComponentModel.DisplayName("اتهام")]
            public Anu.BaseInfo.Enumerations.Crimes Crimes { get; set ;} 
            

    }
    }
