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
using Anu.Commons.ServiceModel.ServiceLogin;

namespace Anu.PunishmentOrg.Client.Infrastructure.Notice
{
    public  static class AuthorizationService
    {

       static string BaseUrl = "http://192.168.1.62:83/";

        static string RegisterAddress = "api/v1/Register";
        static string LoginAddress = "api/v1/Login";
        public static AuthResult RegisterUser(UserRegisterRequest UserRegisterinfo)
        {


            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var response = client.PostAsJsonAsync(RegisterAddress, UserRegisterinfo).Result;

            AuthResult result = response.Content.ReadAsAsync<AuthResult>().Result;
            return  result;

        }

        public static AuthResult LoginUser(UserLoginRequest loginInfo)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var response = client.PostAsJsonAsync(LoginAddress, loginInfo).Result;

            AuthResult result = response.Content.ReadAsAsync<AuthResult>().Result;
            return result;

           


        }
    }
}
