using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.PunishmentOrg.Client.Infrastructure.Contracts.Granovment;
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Utility;

namespace Anu.PunishmentOrg.Client.Infrastructure.Granovment
{
    public class PGravamenService : IPGravamenService
    {
        public GetPGravamenByIdResponse GetGravamenByFollowingNo(string baseURl, string serviceName, GetPGravamenByIdRequest request)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            var response = client.PostAsJsonAsync(serviceName, request).Result;

            GetPGravamenByIdResponse result = response.Content.ReadAsAsync<GetPGravamenByIdResponse>().Result;
            return result;
        }

        public IEnumerable<PGravamenInfoContract> GetGravamenListByNationalNo(string baseURl, string serviceName, string nationalCode, string accessToken)
        {

            GetPersonPGravamensInfoRequest inputData = new();
            inputData.TheGetPersonPGravamenInfoContract.NationalityCode = nationalCode;
            inputData.Page = new Commons.ServiceModel.ServicePaging.Page();
            inputData.Page.TotallPage = 3000000;
            inputData.Page.RowCountPerPage = 3000000;
            inputData.Page.PageNumber = 0;
            inputData.Page.TotalResult = 0;
            inputData.Page.OrderPage = new Commons.ServiceModel.ServicePaging.OrderPage() { Property = "", Ascending = true };

            string jsonString = JsonSerializer.Serialize(inputData);

            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            client.DefaultRequestHeaders.Authorization =
                     new AuthenticationHeaderValue(
                    "Bearer", accessToken);
            var response = client.PostAsJsonAsync(serviceName, inputData).Result;

            GetPersonPGravamensInfoResponse result = response.Content.ReadAsAsync<GetPersonPGravamensInfoResponse>().Result;
            if (result == null)
                return null;

            if (result.Result == AnuResult.Successful.GetResult())
            {
                return result.ThePGravamenInfoContractList.Data.AsEnumerable();

            }
            else
            {
                return result.ThePGravamenInfoContractList.Data.AsEnumerable();

            }
        }

        public async Task<GetPersonPGravamenStatisticContract> GetPersonPGravamenStatistic(string baseURl, string serviceName, string nationalCode, string accessToken)
        {
            GetPersonPGravamenStatisticRequest req = new();

            req.TheGetPersonPGravamenInfoContract.NationalityCode = nationalCode;

            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);

            client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(
                   "Bearer", accessToken);

            var response = client.PostAsJsonAsync(serviceName, req).Result;
            GetPersonPGravamenStatisticResponse result = response.Content.ReadAsAsync<GetPersonPGravamenStatisticResponse>().Result;
            return result.TheGetPersonPGravamenStatisticContract;

          
        }

        public PGravamenServiceResponse RecieveGravamen(string baseURl, string serviceName, PGravamenServiceRequest request)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            var response = client.PostAsJsonAsync(serviceName, request).Result;

            PGravamenServiceResponse result = response.Content.ReadAsAsync<PGravamenServiceResponse>().Result;
            return result;
        }
    }
}
