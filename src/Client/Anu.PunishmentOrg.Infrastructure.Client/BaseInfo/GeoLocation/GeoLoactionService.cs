using Anu.BaseInfo.ServiceModel.GeoInfo;
using Anu.PunishmentOrg.Client.Infrastructure.Contracts.BaseInfo.GeoLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.Client.Infrastructure.BaseInfo.GeoLocation
{
    public class GeoLoactionService : IGeoLoactionService
    {
        public List<Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract> GetCitiesList(string baseURl, string serviceName, GeoLocationRequest request)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            var response = client.PostAsJsonAsync(serviceName, request).Result;

            GeoLocationResponse result = response.Content.ReadAsAsync<GeoLocationResponse>().Result;

            return result.TheGeoLocationContractList;
        }


        public List<Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract> GetProvicesList(string baseURl, string serviceName, GeoLocationRequest request)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            var response = client.PostAsJsonAsync(serviceName, request).Result;

            GeoLocationResponse result = response.Content.ReadAsAsync<GeoLocationResponse>().Result;

            return  result.TheGeoLocationContractList;
        }
    }
}
