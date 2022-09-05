using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    public class PunishmentOrg135UsersResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public PunishmentOrg135UsersContract PunishmentOrg135UsersContract { get; set; }

        public PunishmentOrg135UsersResponse()
        {
            Result = new Result();
            PunishmentOrg135UsersContract = new PunishmentOrg135UsersContract();
        }

    }
}

