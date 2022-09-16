using Anu.PunishmentOrg.ServiceModel.Notice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Utility;
using Anu.PunishmentOrg.Client.Infrastructure.Contracts.Notice;
using Anu.PunishmentOrg.Client.Infrastructure.Utitlities;
using System.Text.Json;

namespace Anu.PunishmentOrg.Client.Infrastructure.Notice
{

    public   class NoticeService: INoticeService
    {


        
 
        public  IEnumerable<PNoticeContract> getPNoticeList(String baseURl, string serviceName, string nationalCode , string accessToken)
        {



            PNoticeInqueryRequest inputData = new PNoticeInqueryRequest();
            inputData.PNoticePersonContract.NationalityCode = nationalCode;
            inputData.Page = new Commons.ServiceModel.ServicePaging.Page();
            inputData.Page.TotallPage = 3000000;
            inputData.Page.RowCountPerPage = 3000000;
            inputData.Page.PageNumber = 0;
            inputData.Page.TotalResult = 0;
            inputData.Page.OrderPage = new Commons.ServiceModel.ServicePaging.OrderPage() { Property = "NoticeDate", Ascending = true };


            string jsonString = JsonSerializer.Serialize(inputData);

            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            client.DefaultRequestHeaders.Authorization =
                     new AuthenticationHeaderValue(
                    "Bearer", accessToken);
            var response = client.PostAsJsonAsync(serviceName, inputData).Result;

            PNoticeInqueryResponse result = response.Content.ReadAsAsync<PNoticeInqueryResponse>().Result;
            if (result == null)
                return null;

            if (result.Result == AnuResult.Successful.GetResult())
            {
                return result.PNotice.Data.AsEnumerable();

            }
            else
            {
                return result.PNotice.Data.AsEnumerable();

            }

        }

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
    }
}
