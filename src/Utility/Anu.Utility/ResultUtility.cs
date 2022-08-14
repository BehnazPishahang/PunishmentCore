using Anu.Commons.ServiceModel.ServiceResponse;
using System.ComponentModel;
using System.Text;

namespace Utility
{
    public static class ResultUtility
    {
        public static Result GetResult(this Enum type, string description = null)
        {
            return new Result
            {
                Code = (int)Convert.ChangeType(type, type.GetTypeCode()),
                Message = Anu.PunishmentOrg.Resources.Common.Resources_ResultType.ResourceManager.GetString(type.ToString()),
                Description = description
            };
        }

        public static Result GetResult(this Enum type, Exception e, string description = null)
        {
            //Called Logger in Stored e
            return new Result
            {
                Code = (int)Convert.ChangeType(type, type.GetTypeCode()),
                Message = Anu.PunishmentOrg.Resources.Common.Resources_ResultType.ResourceManager.GetString(type.ToString()),
                Description = description
            };
        }
        public static Result GetResult(this Enum type, string args, string description = null)
        {
            return new Result
            {
                Code = (int)Convert.ChangeType(type, type.GetTypeCode()),
                Message = string.Format(Anu.PunishmentOrg.Resources.Common.Resources_ResultType.ResourceManager.GetString(type.ToString()), args),
                Description = description
            };
        }

    }
}
