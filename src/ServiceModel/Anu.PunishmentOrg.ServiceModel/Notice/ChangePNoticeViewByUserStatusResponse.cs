
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("ChangePNoticeViewByUserStatusResponse")]
    public class ChangePNoticeViewByUserStatusResponse : IResponseMessage
    {
        public ChangePNoticeViewByUserStatusResponse()
        {
            Result = new Result();
        }

        public Result Result { get; set; }


    }
}
