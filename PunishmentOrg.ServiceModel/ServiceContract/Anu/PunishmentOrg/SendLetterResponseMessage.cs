
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("خروجي سرويس دريافت مکاتبه مکانيزه از ساير سازمانها")]
    public class SendLetterResponseMessage
    {
        public SendLetterResponseMessage()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره مکانيزه")]
            public string No { get; set ;} 
            

    }
    }
