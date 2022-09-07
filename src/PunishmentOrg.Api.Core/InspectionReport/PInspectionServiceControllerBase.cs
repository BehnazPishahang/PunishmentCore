
using Anu.PunishmentOrg.ServiceModel.InspectionReport;

namespace Anu.PunishmentOrg.Api.InspectionReport
{
    public abstract class PInspectionServiceControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
    public PInspectionServiceControllerBase()
    {
    }
        [Microsoft.AspNetCore.Mvc.HttpPost]
            [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]/[action]")]
        public abstract Task<PInspectionReportStateResponse> SendPInspectionReportState([Microsoft.AspNetCore.Mvc.FromBody] PInspectionReportStateRequest request);

    }
    }
