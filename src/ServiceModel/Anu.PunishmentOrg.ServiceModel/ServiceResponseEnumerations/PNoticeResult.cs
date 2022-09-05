using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations
{
    public enum InqueryPNoticeListResult
    {
        PNotice_GetPNoticeByNationalityCode_Request_Is_Required                   = -30201,
        PNotice_GetPNoticeByNationalityCode_ThePNoticePersonContract_Is_Required  = -30202,
        PNotice_GetPNoticeByNationalityCode_NationalityCode_Is_Required           = -30203,
        PNotice_GetPNoticeByNationalityCode_NotFound                              = -30204,
    }

    public enum ExportPNoticeResult
    {
        PNotice_ExportPNotice_Request_Is_Required                   = -30211,
        PNotice_ExportPNotice_ThePNoticeNoInputContract_Is_Required = -30212,
        PNotice_ExportPNotice_No_Is_Required                        = -30213,
        PNotice_ExportPNotice_NotFound                              = -30214,
        PNotice_ExportPNotice_Description_NotFound                  = -30215,
    }

    public enum ChangePNoticeViewByUserStatusResult
    {
        PNotice_ChangePNoticeViewByUserStatus_Request_Is_Required = -30241,
        PNotice_ChangePNoticeViewByUserStatus_ThePNoticeNoInputContract_Is_Required = -30242,
        PNotice_ChangePNoticeViewByUserStatus_PNoticeNo_Is_Required = -30243,
        PNotice_ChangePNoticeViewByUserStatus_PNotice_NotFound = -30244,
    }

    public enum GetCountOfUnSeenPNoticeByUserResult
    {
        PNotice_GetCountOfUnSeenPNoticeByUser_Request_Is_Required = -30251,
        PNotice_GetCountOfUnSeenPNoticeByUser_ThePNoticePersonContract_Is_Required = -30252,
        PNotice_GetCountOfUnSeenPNoticeByUser_NationalityCode_Is_Required = -30253,
        PNotice_GetCountOfUnSeenPNoticeByUser_PNotice_NotFound = -30254,
    }
}