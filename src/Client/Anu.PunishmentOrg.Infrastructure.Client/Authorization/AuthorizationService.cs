
using Anu.Commons.ServiceModel.ServiceAuthentication;

using Anu.PunishmentOrg.Client.Infrastructure.Contracts.Authorization;

namespace Anu.PunishmentOrg.Client.Infrastructure.Authorization
{
    public class AnuAuthorizationService : IAnuAuthorizationService
    {

     
        public AuthResult RegisterUser(String baseURl, string serviceName, UserRegisterRequest UserRegisterinfo)
        {


            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            var response = client.PostAsJsonAsync(serviceName, UserRegisterinfo).Result;

            AuthResult result = response.Content.ReadAsAsync<AuthResult>().Result;
            return result;

        }

        public AuthResult LoginUser(String baseURl, string serviceName, FirstStepUserLoginRequest firstStepUserLoginRequest)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            var response = client.PostAsJsonAsync(serviceName, firstStepUserLoginRequest).Result;

            AuthResult result = response.Content.ReadAsAsync<AuthResult>().Result;
            return result;
        }

        public AuthResult SecondStepLogin(string baseURl, string serviceName, SecondStepUserLoginRequest secondStepUserLoginRequest)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            var response = client.PostAsJsonAsync(serviceName, secondStepUserLoginRequest).Result;

            AuthResult result = response.Content.ReadAsAsync<AuthResult>().Result;
            return result;
        }
    }
}
