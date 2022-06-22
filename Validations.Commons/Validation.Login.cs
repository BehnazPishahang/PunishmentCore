using DataModel.BaseInfo.Anu.BaseInfo.FrontEndSecurity;
using PunishmentOrg.Domain.Interface;
using ServiceModel.Commons.ServiceResponse;
using Utility.Guard;

namespace Validations.Commons
{
    public static class Login
    {

        public static async Task<GFESUserAccess> ValidateLoginAsync(ServiceModel.Commons.ServiceRequest.Request request, string GFESUserAccessType, IUnitOfWork unitOfWork)
        {

            request.UserName.NullOrWhiteSpace(ResultType.UserName_Or_PassWord_Is_Not_Entered);
            request.PassWord.NullOrWhiteSpace(ResultType.UserName_Or_PassWord_Is_Not_Entered);

            string hashPass = MD5Core.GetHashString(request.PassWord);
            var userAccess = await unitOfWork.GFESUserAccess.ValidateUserAndPassword(request.UserName, request.PassWord, GFESUserAccessType);
            userAccess.Null(ResultType.UserName_Or_PassWord_Is_Not_Valid);

            return userAccess.FirstOrDefault();

        }

    }
}
