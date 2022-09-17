using Anu.Commons.ServiceModel.ServiceExportResponse;
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Case
{
    public class ExportInqueryPCaseResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public ExportContract ExportContract { get; set; }

        public ExportInqueryPCaseResponse()
        {
            Result = new Result();
            ExportContract = new ExportContract();
        }
    }
}
