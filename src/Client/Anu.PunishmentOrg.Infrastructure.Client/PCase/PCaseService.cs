﻿using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
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


        
 
       

        public string  GetNoticePDF(String baseURl, string serviceName, string no , string accessToken)
        {
            ExportPNoticeRequest req = new();

            req.ThePNoticeNoInputContract.No = no;

             var client = new HttpClient();
                client.BaseAddress = new Uri(baseURl);

            client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(
                   "Bearer", accessToken);

            var response = client.PostAsJsonAsync(serviceName, req).Result;
              ExportPNoticeResponse result = response.Content.ReadAsAsync<ExportPNoticeResponse>().Result;
                return PDFconvertor.ConvertToPdfContent(result.ThePNoticeExportContract.Pdf);
            
        }

        public ChangePNoticeViewByUserStatusResponse ChangePNoticeViewByUserStatus(string baseURl, string serviceName, string no , string accessToken)
        {
            ChangePNoticeViewByUserStatusRequest req = new();   

            req.ThePNoticeNoInputContract.No=no;
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(
                   "Bearer", accessToken);

            var response = client.PostAsJsonAsync(serviceName, req).Result;

            ChangePNoticeViewByUserStatusResponse result = response.Content.ReadAsAsync<ChangePNoticeViewByUserStatusResponse>().Result;
            return result;
        }

        public GetCountOfUnSeenPNoticeByUserResponse GetCountOfUnSeenPNoticeByUser(string baseURl, string serviceName, string nationalCode , string accessToken)
        {
            GetCountOfUnSeenPNoticeByUserRequest req = new();

            req.ThePNoticePersonContract.NationalityCode = nationalCode;
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);

            client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(
                   "Bearer", accessToken);
            var response = client.PostAsJsonAsync(serviceName, req).Result;

            GetCountOfUnSeenPNoticeByUserResponse result = response.Content.ReadAsAsync<GetCountOfUnSeenPNoticeByUserResponse>().Result;
            return result;
        }

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
