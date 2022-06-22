
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("ورودي سرويس دريافت مکاتبه مکانيزه از ساير سازمانها")]
    public class SendLetterRequestMessage
    {
        public SendLetterRequestMessage()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره مکانيزه")]
            public string No { get; set ;} 
            

    }
    }
