using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Utility;

namespace Anu.PunishmentOrg.Api.Authentication.Utility
{
    public static class ShahkarAuthentication
    {

        public static async Task<Result> ShahkarAuthenticate<T>(this T request)
        {

            

            return AnuResult.Successful.GetResult();
        }
    }
}
