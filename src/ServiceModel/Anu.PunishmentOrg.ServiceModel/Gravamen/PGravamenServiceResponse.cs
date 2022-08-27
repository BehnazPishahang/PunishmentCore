using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    //! کل من علیها fun
    [System.ComponentModel.DisplayName("خروجی سرویس شکوائیه")]
    public class PGravamenServiceResponse : PGravamenResponseContract, IResponseMessage
    {
        public Result Result { get; set; }

        public PGravamenServiceResponse()
        {
            Result = new Result();
        }

    }
}
