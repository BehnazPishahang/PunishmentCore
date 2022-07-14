using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.Resources.Anu.PunishmentOrg.Resources.Common;
using System.Text;

namespace Utility
{
    public static class ResultUtility
    {
        public static Result getResult(ResultType type)
        {
            return new Result { Code = ((int)type).ToString(), Message = Resources_ResultType.ResourceManager.GetString(type.ToString()) };
        }

        public static Result getResult(ResultType type, Exception e)
        {
            //Called Logger in Stored e
            return new Result { Code = ((int)type).ToString(), Message = Resources_ResultType.ResourceManager.GetString(type.ToString()) };
        }
        public static Result getResult(ResultType type, string args)
        {
            return new Result { Code = ((int)type).ToString(), Message = string.Format(Resources_ResultType.ResourceManager.GetString(type.ToString()), args) };
        }

    }
}
