using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations
{
    /// <summary>
    /// PDiscoveryMinutes codes start with 2000
    /// error codes start with Minuse
    /// /// تمامی کد هایی که در دسته ی ارور قرار دارند باید منفی باشند!!!!!!!!!!!!!!!
    /// Hata kategorisindeki tüm kodlar negatif olmalıdır!!!!!!!!!!!!!!!!
    /// يجب أن تكون جميع الرموز في فئة الخطأ سالبة !!!!!!!!!!!!!!!
    /// </summary>
    public enum PDiscoveryMinutesResult
    {
        Error_to_Find_State = 20001,
        Error_UniqueNo_Is_Required = -20002,
        Execution = 20003,
        PDiscoveryMinuteSate_ConfirmAndSendToUnit = 20004,
        PDiscoveryMinuteSate_CreateCase = 20005,
        PDiscoveryMinuteSate_Expired = 20006,
        PDiscoveryMinuteSate_No_Is_NotValid = -20007,
        PDiscoveryMinuteSate_PrimRegistery = 20008,
        PDiscoveryMinuteSate_ReferToCity = 20009,
        PDiscoveryMinuteSate_ReferToUnit = 200010,
        PDiscoveryMinuteSate_SendToSmuggling = 200011,
        PDiscoveryMinuteSate_Start = 200012,
        PJudgment = 200013,
        ThePBBillGeoLocation_Is_Required = -200014
    }
}
