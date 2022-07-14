
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("خروجي سرويس دريافت مکاتبه مکانيزه از ساير سازمانها")]
    public class SendLetterResponseMessage
    {
        public SendLetterResponseMessage()
        {
        }
            
            
            [System.ComponentModel.DisplayName("شماره مکانيزه")]
            public string? No { get; set ;} 
            

    }
    }
