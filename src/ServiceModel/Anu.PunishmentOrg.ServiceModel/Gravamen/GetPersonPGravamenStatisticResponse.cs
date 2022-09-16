
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("GetPersonPGravamenStatisticResponse")]
    public class GetPersonPGravamenStatisticResponse : IResponseMessage
    {
        public GetPersonPGravamenStatisticResponse()
        {
            Result = new Result();
            TheGetPersonPGravamenStatisticContract = new GetPersonPGravamenStatisticContract();
        }

        public Result Result { get; set; }

        public Anu.PunishmentOrg.ServiceModel.Gravamen.GetPersonPGravamenStatisticContract TheGetPersonPGravamenStatisticContract { get; set; }


    }
}
