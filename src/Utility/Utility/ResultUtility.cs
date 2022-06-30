using Anu.Commons.ServiceModel.ServiceResponse;
using System.Text;

namespace Utility
{
    public static class ResultUtility
    {
        public static Result getResult(ResultType type)
        {
            return new Result { Code = type.ToString(), Message = Anu.PunishmentOrg.Resources.Common.Resources_ResultType.ResourceManager.GetString(type.ToString()) };
        }

        public static Result getResult(ResultType type, Exception e)
        {
            //Called Logger in Stored e
            return new Result { Code = type.ToString(), Message = Anu.PunishmentOrg.Resources.Common.Resources_ResultType.ResourceManager.GetString(type.ToString()) };
        }
        public static Result getResult(ResultType type, string args)
        {
            return new Result { Code = type.ToString(), Message = string.Format(Anu.PunishmentOrg.Resources.Common.Resources_ResultType.ResourceManager.GetString(type.ToString()), args) };
        }

    }
}
