using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Commons.ServiceModel.ServiceResponseEnumerations
{
    /// <summary>
    /// General codes start with 1000
    /// error codes start with Minuse
    /// تمامی کد هایی که در دسته ی ارور قرار دارند باید منفی باشند!!!!!!!!!!!!!!!
    /// Hata kategorisindeki tüm kodlar negatif olmalıdır!!!!!!!!!!!!!!!!
    /// يجب أن تكون جميع الرموز في فئة الخطأ سالبة !!!!!!!!!!!!!!!
    /// </summary>
    public enum AnuResult
    {
        Successful = 1000,
        Error = -10001,
        UserName_Or_PassWord_Is_Not_Valid = -10002,
        UserName_Or_PassWord_Is_Not_Entered = -10003,
        PropertyOrderNotFound = -10004,
        JwtTokenIsNotValid = -10005,
        NationalCode_Is_Not_Valid = -10006,
        NationalCode_Length_Is_Not_Valid = -10007,
        NationalCode_Must_Be_Number = -10008,
        PhoneNumber_Is_Not_Entered = -10009,
        PhoneNumber_Is_Not_Valid = -100010,
        User_Is_Exist = -100011,
        Error_Send_Sms = -100012,
        HttpError_Send_Sms = -100012
    }
}
