using Anu.Commons.ServiceModel.ServiceExportResponse;
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Case
{
    public class ExportInqueryPCaseResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public ExportInqueryPCaseContract ExportInqueryPCaseContract { get; set; }

        public ExportInqueryPCaseResponse()
        {
            Result = new Result();
            ExportInqueryPCaseContract = new ExportInqueryPCaseContract();
        }
    }
}
