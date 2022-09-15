using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.Commons.ServiceModel.ServiceStatisticResponse;

namespace Anu.PunishmentOrg.ServiceModel.Case
{
    public class GetStatisticPCaseResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public StatisticContract StatisticContract { get; set; }

        public GetStatisticPCaseResponse()
        {
            Result = new Result();
            StatisticContract = new StatisticContract();
        }
    }
}
