using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.Commons.ServiceModel.SeviceRequest;
using Utility.Guard;

namespace Anu.Commons.Validations
{
    public static class Login
    {

        public static async Task<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess> ValidateLoginAsync(Request request, string GFESUserAccessType, Anu.DataAccess.IUnitOfWork unitOfWork)
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