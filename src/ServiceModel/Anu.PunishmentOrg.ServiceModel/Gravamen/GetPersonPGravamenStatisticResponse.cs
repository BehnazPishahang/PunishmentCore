
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

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("اطلاعات شکوائیه/گزارش در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Gravamen.GetPersonPGravamenStatisticContract? TheGetPersonPGravamenStatisticContract { get; set; }


    }
}
