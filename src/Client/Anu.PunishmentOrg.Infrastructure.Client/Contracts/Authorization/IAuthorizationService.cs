using Anu.Commons.ServiceModel.ServiceAuthentication;
using Anu.PunishmentOrg.ServiceModel.BaseInfo;

namespace Anu.PunishmentOrg.Client.Infrastructure.Contracts.Authorization
{
    public interface IAnuAuthorizationService
    {
        public AuthResult RegisterUser(String baseURl, string serviceName, UserRegisterRequest UserRegisterinfo);

        //public  Task<AuthResult> LoginUser(String baseURl, string serviceName, FirstStepUserLoginRequest loginInfo);

        public Task<FirstStepAuthResult> SendSmsAuth(String baseURl, string serviceName, FirstStepUserLoginRequest loginInfo);


        //public AuthResult SecondStepLogin(String baseURl, string serviceName, SecondStepUserLoginRequest secondStepUserLoginRequest);
        public Task<AuthResult> V2Login(String baseURl, string serviceName, SecondStepUserLoginRequest request);

        public Task<PBPuoUsersResponse> GetProfile(String baseURl, string serviceName, PBPuoUsersRequest request, string accessToken);

    }
}
    