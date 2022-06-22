
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("جرم ها / تخلفات مورد تعقيب بازرسي")]
    public class PChaseLicenseReqCrim
    {
        public PChaseLicenseReqCrim()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اتهام")]
            public DataModel.BaseInfo.Anu.Enumerations.Crimes Crimes { get; set ;} 
            

    }
    }
