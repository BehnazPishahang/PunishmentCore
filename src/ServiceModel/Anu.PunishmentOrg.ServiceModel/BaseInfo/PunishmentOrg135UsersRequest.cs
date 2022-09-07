using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    public class PunishmentOrg135UsersRequest : IRequestMessage
    {
        public Request Request { get; set; }
        public PunishmentOrg135UsersInputContract PunishmentOrg135UsersInputContract { get; set; }

        public PunishmentOrg135UsersRequest()
        {
            Request = new Request();
            PunishmentOrg135UsersInputContract = new PunishmentOrg135UsersInputContract();
        }
    }
}
