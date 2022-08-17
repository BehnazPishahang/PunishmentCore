
using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.ServiceContract;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("خروجی سرویس شکوائیه")]
    public class PGravamenServiceResponse : PGravamenResponse, IResponseMessage
    {
        public Result Result { get; set; }
        public PGravamenServiceResponse()
        {
            Result = new Result();
        }

    }
}
