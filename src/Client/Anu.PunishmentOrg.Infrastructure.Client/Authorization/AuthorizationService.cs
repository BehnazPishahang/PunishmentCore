
using Anu.Commons.ServiceModel.ServiceAuthentication;

using Anu.PunishmentOrg.Client.Infrastructure.Contracts.Authorization;
using System.Text.Json;

namespace Anu.PunishmentOrg.Client.Infrastructure.Authorization
{
    public class AnuAuthorizationService : IAnuAuthorizationService
    {

     
        public AuthResult RegisterUser(String baseURl, string serviceName, UserRegisterRequest UserRegisterinfo)
        {


            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            string jsonString = JsonSerializer.Serialize(UserRegisterinfo);

            var response = client.PostAsJsonAsync(serviceName, UserRegisterinfo).Result;


            AuthResult result = response.Content.ReadAsAsync<AuthResult>().Result;
            return result;

        }

       
        public AuthResult SecondStepLogin(string baseURl, string serviceName, SecondStepUserLoginRequest secondStepUserLoginRequest)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);

            string jsonString = JsonSerializer.Serialize(secondStepUserLoginRequest);
            var response = client.PostAsJsonAsync(serviceName, secondStepUserLoginRequest).Result;

            AuthResult result = response.Content.ReadAsAsync<AuthResult>().Result;
            return result;
        }

        public async Task<AuthResult> LoginUser(string baseURl, string serviceName, FirstStepUserLoginRequest loginInfo)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            var response = await client.PostAsJsonAsync(serviceName, loginInfo);

            AuthResult result = response.Content.ReadAsAsync<AuthResult>().Result;
            return result;
        }
    }
}
