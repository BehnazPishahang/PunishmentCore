using Anu.Commons.ServiceModel.ServiceLogin;

namespace Anu.PunishmentOrg.Client.Infrastructure.Contracts.Authorization
{
    public interface IAnuAuthorizationService
    {
        public AuthResult RegisterUser(String baseURl, string serviceName, UserRegisterRequest UserRegisterinfo);

        public AuthResult LoginUser(String baseURl, string serviceName,UserLoginRequest loginInfo);

    }
}