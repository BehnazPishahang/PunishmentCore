using Anu.PunishmentOrg.ServiceModel.Case;
using Anu.PunishmentOrg.ServiceModel.Notice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.Client.Infrastructure.Contracts.PCase
{
    public interface IPCaseService
    {
       
        public IEnumerable<GetAllPCaseContract> getPCaseList(String baseURl, string serviceName, string nationalCode , string accessToken);
       
        public  Task<ExportInqueryPCaseResponse> ExportInqueryPCase(String baseURl, string serviceName, string nationalCode, string no, string accessToken);
        public Task<GetStatisticPCaseResponse> GetPCaseStatistic(String baseURl, string serviceName, string nationalCode, string accessToken);



    }

}
