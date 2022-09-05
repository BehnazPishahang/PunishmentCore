
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("GetCountOfUnSeenPNoticeByUserResponse")]
    public class GetCountOfUnSeenPNoticeByUserResponse : IResponseMessage
    {
        public GetCountOfUnSeenPNoticeByUserResponse()
        {
            Result = new Result();
            TheGetCountOfUnSeenPNoticeByUserContract = new GetCountOfUnSeenPNoticeByUserContract();
        }

        public Result Result { get; set; }

        public Anu.PunishmentOrg.ServiceModel.Notice.GetCountOfUnSeenPNoticeByUserContract TheGetCountOfUnSeenPNoticeByUserContract { get; set; }


    }
}
