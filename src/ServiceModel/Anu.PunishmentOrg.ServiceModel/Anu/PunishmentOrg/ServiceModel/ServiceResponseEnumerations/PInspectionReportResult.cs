using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations
{
    public enum PInspectionReportResult
    {
        Error_UniqueNo_Is_Required = -40001,
        PInspectionReport_No_Is_NotValid = -40002,
        Error_to_Find_State = 40003,
        PInspectionReport_Drafted_Old = 40004,
        PInspectionReport_Refered_old = 40005,
        PInspectionReport_Drafted = 40006,
        PInspectionReport_Return_to_Registrar = 40007,
        PInspectionReport_Registered_to_ManagerConfirm = 40008,
        PInspectionReport_Received_From_SupportOrg = 40009,
        PInspectionReport_Expired = 400010,
        PInspectionReport_Returnd_to_Referrer = 400011,
        PInspectionReport_Referred = 400012,
        PInspectionReport_Referred_To_City = 400013,
        PInspectionReport_Returnd_To_Sender = 400014,
        PInspectionReport_Execution = 400015,
        PInspectionReport_PJudgment = 400016,
        PInspectionReport_RegisterCase = 400017
    }
}
