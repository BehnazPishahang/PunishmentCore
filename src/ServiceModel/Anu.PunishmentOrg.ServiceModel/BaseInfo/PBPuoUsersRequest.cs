using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    public class PBPuoUsersRequest : IRequestMessage
    {
        public Request Request { get; set; }
        public PBPuoUsersInputContract PBPuoUsersInputContract { get; set; }

        public PBPuoUsersRequest()
        {
            Request = new Request();
            PBPuoUsersInputContract = new PBPuoUsersInputContract();
        }
    }
}
