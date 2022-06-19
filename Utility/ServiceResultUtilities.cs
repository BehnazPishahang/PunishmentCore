using ServiceModel.Commons.ServiceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class ServiceResultUtilities
    {
        public static Result getResult(ResultType type)
        {
            return new Result { Code = type.ToString(), Message = Resources.PunishmentOrg.Common.Resources_ResultType.ResourceManager.GetString(type.ToString()) };
        }

        public static Result getResult(ResultType type, Exception e)
        {
            //Called Logger in Stored e
            return new Result { Code = type.ToString(), Message = Resources.PunishmentOrg.Common.Resources_ResultType.ResourceManager.GetString(type.ToString()) };
        }
        public static Result getResult(ResultType type, string args)
        {
            return new Result { Code = type.ToString(), Message = string.Format(Resources.PunishmentOrg.Common.Resources_ResultType.ResourceManager.GetString(type.ToString()), args) };
        }

    }
}
