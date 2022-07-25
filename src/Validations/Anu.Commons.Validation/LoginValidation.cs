using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Commons.ServiceModel.SeviceRequest;
using Utility.Guard;

namespace Anu.Commons.Validations
{
    public static class LoginValidation
    {

        public static async Task<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess> ValidateLoginAsync(Request request, string GFESUserAccessType, Anu.DataAccess.IUnitOfWork unitOfWork)
        {

            request.UserName.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);
            request.PassWord.NullOrWhiteSpace(AnuResult.UserName_Or_PassWord_Is_Not_Entered);

            string hashPass = MD5Core.GetHashString(request.PassWord);
            var userAccess = await unitOfWork.GFESUserAccess.ValidateUserAndPassword(request.UserName, hashPass, GFESUserAccessType);
            userAccess.Null(AnuResult.UserName_Or_PassWord_Is_Not_Valid);

            return userAccess.FirstOrDefault();

        }

    }
}