using Anu.PunishmentOrg.ServiceModel.Notice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace Anu.PunishmentOrg.Client.Infrastructure.Notice
{
    public  static class NoticeService
    {

      static string Baseurl = "http://192.168.1.14:94/";

      static string ServiceAdderss = "api/v2/BillStore/InqueryPNoticeList";
        public static IEnumerable<PNoticeContract> getPNoticeList(string nationalCode)
        {

            PNoticeInqueryRequest inputData = new PNoticeInqueryRequest();
            inputData.PNoticePersonContract.NationalityCode = nationalCode;
            inputData.Page = new Commons.ServiceModel.ServicePaging.Page();
            inputData.Page.TotallPage = 15;
            inputData.Page.RowCountPerPage = 20;
            inputData.Page.PageNumber = 0;
            inputData.Page.TotalResult = 0;
            inputData.Page.OrderPage = new Commons.ServiceModel.ServicePaging.OrderPage() { Property="",Ascending=true};

            var client = new HttpClient();
            client.BaseAddress = new Uri(Baseurl);
          
            var response =  client.PostAsJsonAsync(ServiceAdderss, inputData).Result;

            PNoticeInqueryResponse result = response.Content.ReadAsAsync<PNoticeInqueryResponse>().Result;
           
            return result.PNotice.Data.AsEnumerable();


        }
    }
}
