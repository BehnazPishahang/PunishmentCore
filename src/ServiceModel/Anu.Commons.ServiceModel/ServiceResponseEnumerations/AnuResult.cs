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
        HttpError_Send_Sms = -100012,
        LoginSuccessful_Sms_Send_To = 100013,
        Sms_Time_Is_Expired = -100014,
        Shahkar_NationalCode_PhoneNumber_Is_Not_Match=-100015,
        Shahkar_Could_Not_Inquiry=-100016,
        Shahkar_NationalCode_PhoneNumber_Is_Not_Valid=-100017,
        Shahkar_Unkhown_Error=-100018,
        SabteAhval_Unkhown_Error=-100019,
        SabteAhval_Not_Validate_NationalCode = -100020,
        SabteAhval_Data_Not_Match_Entered_Data = -100021,
        Sms_Limit_Send = -100022,
        Send_Login_Request_After_x_Second = -100023,
        NationalCode_Is_Not_Entered = -100024,
        FirstName_Is_Not_Entered = -100025,
        LastName_Is_Not_Entered = -100026,
        BirthDate_Is_Not_Entered = -100027,
        Sex_Is_Not_Valid = -100028,
        BirthDate_Is_Not_Valid = -100029,
        Login_Again = -100030,
        Request_Is_Not_Valid=-100031
    }
}
