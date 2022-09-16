using Anu.PunishmentOrg.ServiceModel.Case;
using Microsoft.AspNetCore.Mvc;

namespace Anu.PunishmentOrg.Api.Case
{

    public abstract class PCaseServiceControllerBase : ControllerBase
    {
        public PCaseServiceControllerBase()
        {
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]/[action]")]
        public abstract Task<GetStatisticPCaseResponse> GetStatisticPCase([Microsoft.AspNetCore.Mvc.FromBody] GetStatisticPCaseRequest request);

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]/[action]")]
        public abstract Task<GetAllPCaseResponse> GetAllPCase([Microsoft.AspNetCore.Mvc.FromBody] GetAllPCaseRequest request);

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]/[action]")]
        public abstract Task<ExportInqueryPCaseResponse> ExportInqueryPCase([Microsoft.AspNetCore.Mvc.FromBody] ExportInqueryPCaseRequest request);
    }
}
