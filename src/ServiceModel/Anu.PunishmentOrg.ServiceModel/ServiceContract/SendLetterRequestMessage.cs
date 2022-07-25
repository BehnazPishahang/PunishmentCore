
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("ورودي سرويس دريافت مکاتبه مکانيزه از ساير سازمانها")]
    public class SendLetterRequestMessage
    {
        public SendLetterRequestMessage()
        {
        }
            
            
            [System.ComponentModel.DisplayName("شماره مکانيزه")]
            public string? No { get; set ;} 
            

    }
    }
