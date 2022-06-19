using ServiceModel.Commons.ServiceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Guard;

namespace Validations.Commons
{
    public static class Login
    {

        public static Result ValidateLogin(ServiceModel.Commons.ServiceRequest.RequestMessage request)
        {
            try
            {
                request.UserName.NullOrWhiteSpace(ResultType.UserName_Or_PassWord_Is_Not_Valid);
                request.PassWord.NullOrWhiteSpace(ResultType.UserName_Or_PassWord_Is_Not_Valid);
            }
            catch (Utility.Exceptions.AnuExceptions ex)
            {
                return ex.result;
            }



            return null;
        } 

    }
}
