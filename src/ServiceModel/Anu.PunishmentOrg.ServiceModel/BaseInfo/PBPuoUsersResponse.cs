using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    public class PBPuoUsersResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public PBPuoUsersContract PBPuoUsersContract { get; set; }

        public PBPuoUsersResponse()
        {
            Result = new Result();
            PBPuoUsersContract = new PBPuoUsersContract();
        }

    }
}

