﻿
using Anu.Commons.ServiceModel.ServiceAuthentication;

using Anu.PunishmentOrg.Client.Infrastructure.Contracts.Authorization;
using Anu.PunishmentOrg.ServiceModel.BaseInfo;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Anu.PunishmentOrg.Client.Infrastructure.Authorization
{
    public class AnuAuthorizationService : IAnuAuthorizationService
    {
       

        public async Task<PBPuoUsersResponse> GetProfile(string baseURl, string serviceName, PBPuoUsersRequest request, string accessToken)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            string jsonString = JsonSerializer.Serialize(request);
            client.DefaultRequestHeaders.Authorization =
                 new AuthenticationHeaderValue(
                "Bearer", accessToken);
            //client.DefaultRequestHeaders.Add("Bearer Token", accessToken);

            var response = client.PostAsJsonAsync(serviceName, request).Result;
            PBPuoUsersResponse result =await response.Content.ReadAsAsync<PBPuoUsersResponse>();
            return result;
        }

        public AuthResult RegisterUser(String baseURl, string serviceName, UserRegisterRequest UserRegisterinfo)
        {


            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            string jsonString = JsonSerializer.Serialize(UserRegisterinfo);

            var response = client.PostAsJsonAsync(serviceName, UserRegisterinfo).Result;
            AuthResult result = response.Content.ReadAsAsync<AuthResult>().Result;
            return result;

        }

        public async Task<FirstStepAuthResult> SendSmsAuth(string baseURl, string serviceName, FirstStepUserLoginRequest loginInfo)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);
            var response = await client.PostAsJsonAsync(serviceName, loginInfo);

            FirstStepAuthResult result = response.Content.ReadAsAsync<FirstStepAuthResult>().Result;
            return result;
        }

        public  async Task<AuthResult> V2Login(string baseURl, string serviceName, SecondStepUserLoginRequest request)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURl);

            string jsonString = JsonSerializer.Serialize(request);
            var response = client.PostAsJsonAsync(serviceName, request).Result;

            AuthResult result = response.Content.ReadAsAsync<AuthResult>().Result;
            return result;
        }
    }
    
}
