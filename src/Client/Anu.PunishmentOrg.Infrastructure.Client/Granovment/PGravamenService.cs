using Anu.PunishmentOrg.Client.Infrastructure.Contracts.Granovment;
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.Client.Infrastructure.Granovment
{
    public class PGravamenService : IPGravamenService
    {
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
