
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("خروجی سرویس شکوائیه")]
    public class PGravamenServiceResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public PGravamenServiceResponse()
        {
            Result = new Result();
        }

    }
}
