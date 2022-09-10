using Anu.Commons.ServiceModel.ServiceAuthentication;

namespace Anu.PunishmentOrg.Client.Infrastructure.Contracts.Authorization
{
    public interface IAnuAuthorizationService
    {
        public AuthResult RegisterUser(String baseURl, string serviceName, UserRegisterRequest UserRegisterinfo);

       public  Task<AuthResult> LoginUser(String baseURl, string serviceName, FirstStepUserLoginRequest loginInfo);

        public AuthResult SecondStepLogin(String baseURl, string serviceName, SecondStepUserLoginRequest secondStepUserLoginRequest);


       

    }
}