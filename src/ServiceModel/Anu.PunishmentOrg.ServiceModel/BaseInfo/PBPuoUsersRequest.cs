using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    public class PBPuoUsersRequest 
    {
        public PBPuoUsersInputContract PBPuoUsersInputContract { get; set; }

        public PBPuoUsersRequest()
        {
            PBPuoUsersInputContract = new PBPuoUsersInputContract();
        }
    }
}
