using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Utility;

namespace Anu.PunishmentOrg.Api.Authentication.Utility
{
    public static class SabteahvalAuthentication
    {
        public static async Task<Result> SabteahvalAuthenticate<T>(this T request)
        {



            return AnuResult.Successful.GetResult();
        }
    }
}
