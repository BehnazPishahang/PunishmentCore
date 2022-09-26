using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.PunishmentOrg.Client.Infrastructure.Contracts.PCase;
using Anu.PunishmentOrg.Client.Infrastructure.Utitlities;
using Anu.PunishmentOrg.ServiceModel.Case;
using Anu.PunishmentOrg.ServiceModel.Notice;
using System.Net.Http.Headers;
using System.Text.Json;
using Utility;

namespace Anu.PunishmentOrg.Client.Infrastructure.Pcase
{

    public   class PCaseService: IPCaseService
    {

        public IEnumerable<GetAllPCaseContract> getPCaseList(string baseURl, string serviceName, string nationalCode, string accessToken)
        {
            GetAllPCaseRequest inputData = new();
            inputData.GetAllPCaseInputContract.NationalCode = nationalCode;
            
            string jsonString = JsonSerializer.Serialize(inputData);

            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            client.DefaultRequestHeaders.Authorization =
                     new AuthenticationHeaderValue(
                    "Bearer", accessToken);
            var response = client.PostAsJsonAsync(serviceName, inputData).Result;

            GetAllPCaseResponse result = response.Content.ReadAsAsync<GetAllPCaseResponse>().Result;
            if (result == null)
                return null;

            if (result.Result == AnuResult.Successful.GetResult())
            {
                return result.GetAllPCaseContract.AsEnumerable();

            }
            else
            {
                return result.GetAllPCaseContract.AsEnumerable();

            }
        }

        public async  Task<ExportInqueryPCaseResponse> ExportInqueryPCase(string baseURl, string serviceName, string nationalCode, string no, string accessToken)
        {
            ExportInqueryPCaseRequest req = new();

            req.ExportInqueryPCaseInputContract.NationalCode = nationalCode;
            req.ExportInqueryPCaseInputContract.No = no;
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);

            client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(
                   "Bearer", accessToken);
            var response = client.PostAsJsonAsync(serviceName, req).Result;

            ExportInqueryPCaseResponse result = await response.Content.ReadAsAsync<ExportInqueryPCaseResponse>();
            return result;
        }

        public async Task<GetStatisticPCaseResponse> GetPCaseStatistic(string baseURl, string serviceName, string nationalCode, string accessToken)
        {
            GetStatisticPCaseRequest req = new();
                                               
            req.GetStatisticPCaseInputContract.NationalCode = nationalCode;
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);

            client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(
                   "Bearer", accessToken);
            var response = client.PostAsJsonAsync(serviceName, req).Result;

            GetStatisticPCaseResponse result =await response.Content.ReadAsAsync<GetStatisticPCaseResponse>();
            return result;
        }
    }
}
