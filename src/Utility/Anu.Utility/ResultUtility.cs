using Anu.Commons.ServiceModel.ServiceResponse;
using System.ComponentModel;
using System.Text;

namespace Utility
{
    public static class ResultUtility
    {
        public static Result GetResult(this Enum type)
        {
            return new Result { Code = (int)Convert.ChangeType(type, type.GetTypeCode()), Message = Anu.PunishmentOrg.Resources.Common.Resources_ResultType.ResourceManager.GetString(type.ToString()) };
        }

        public static Result GetResult(this Enum type, Exception e)
        {
            //Called Logger in Stored e
            return new Result { Code = (int)Convert.ChangeType(type, type.GetTypeCode()), Message = Anu.PunishmentOrg.Resources.Common.Resources_ResultType.ResourceManager.GetString(type.ToString()) };
        }
        public static Result GetResult(this Enum type, string args)
        {
            return new Result { Code = (int)Convert.ChangeType(type, type.GetTypeCode()), Message = string.Format(Anu.PunishmentOrg.Resources.Common.Resources_ResultType.ResourceManager.GetString(type.ToString()), args) };
        }

    }
}
