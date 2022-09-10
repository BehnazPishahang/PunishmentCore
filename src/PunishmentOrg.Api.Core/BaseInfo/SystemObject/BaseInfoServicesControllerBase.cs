
using Anu.BaseInfo.ServiceModel.SystemObject;
using Anu.BaseInfo.ServiceModel.SystemObject;

namespace Anu.BaseInfo.Api.SystemObject
{
    public abstract class BaseInfoServicesControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public BaseInfoServicesControllerBase()
        {
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/BaseInfo/SendBaseInfo")]
        public abstract Task<SendBaseInfoResponse> SendBaseInfo([Microsoft.AspNetCore.Mvc.FromBody] SendBaseInfoRequest request);

    }
}
