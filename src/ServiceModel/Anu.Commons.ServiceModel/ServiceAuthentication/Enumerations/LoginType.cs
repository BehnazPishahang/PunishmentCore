using System.ComponentModel;

namespace Anu.Commons.ServiceModel.ServiceAuthentication.Enumerations
{
    [Description("LoginType")]
    public enum LoginType
    {
        LoginWithSms = 1,
        LoginWithUserAndPass = 2
    }
}
