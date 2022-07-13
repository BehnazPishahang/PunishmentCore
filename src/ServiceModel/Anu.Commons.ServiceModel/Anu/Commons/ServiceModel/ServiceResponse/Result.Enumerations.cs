using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Commons.ServiceModel.ServiceResponse
{
    public enum ResultType
    {
        Successful = 10000,
        Error = 10005,
        UserName_Or_PassWord_Is_Not_Valid = 10010,
        UserName_Or_PassWord_Is_Not_Entered = 10012,
        Error_to_Find_State = 10006,
        Error_UniqueNo_Is_Required = 10001,
        Execution = 00062601,
        PDiscoveryMinuteSate_ConfirmAndSendToUnit = 000622,
        PDiscoveryMinuteSate_CreateCase = 000626,
        PDiscoveryMinuteSate_Expired = 000630,
        PDiscoveryMinuteSate_No_Is_NotValid = 10011,
        PDiscoveryMinuteSate_PrimRegistery = 000620,
        PDiscoveryMinuteSate_ReferToCity = 000625,
        PDiscoveryMinuteSate_ReferToUnit = 000624,
        PDiscoveryMinuteSate_SendToSmuggling = 000621,
        PDiscoveryMinuteSate_Start = 000628,
        PJudgment = 00062602,
        ThePBBillGeoLocation_Is_Required = 10015,
        PBillStore_Duplicate_Bill=10065
    }
}
