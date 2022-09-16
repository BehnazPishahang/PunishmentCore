using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.Gravamen;

namespace Anu.PunishmentOrg.Api.Gravamen
{
    [System.ComponentModel.DisplayName("GetPGravamenByIdResponse")]
    public class GetPGravamenByIdResponse : IResponseMessage
    {
        public GetPGravamenByIdResponse()
        {
            Result = new Result();
            ThePGravamenContract = new PGravamenContract();
        }
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شکوائیه/گزارش در سرویس")]
        public PGravamenContract? ThePGravamenContract { get; set; }
        public Result Result { get; set; }
    }
}