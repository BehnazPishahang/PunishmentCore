
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("PChaseLicenseReqResponse")]
    public class PChaseLicenseReqResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public PChaseLicenseReqResponse()
        {
            Result = new Result();
        }

        [System.ComponentModel.DisplayName("درخواست مجوز تعقيب/بازرسي و پاسخ آن در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqContract? ThePChaseLicenseReqContract { get; set; }

            

    }
    }
