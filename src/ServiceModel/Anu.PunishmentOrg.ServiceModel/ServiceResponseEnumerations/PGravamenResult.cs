﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations
{
    //! کل من علیها fun
    /// <summary>
    /// General codes start with 1000
    /// error codes start with Minuse
    /// تمامی کد هایی که در دسته ی ارور قرار دارند باید منفی باشند!!!!!!!!!!!!!!!
    /// Hata kategorisindeki tüm kodlar negatif olmalıdır!!!!!!!!!!!!!!!!
    /// يجب أن تكون جميع الرموز في فئة الخطأ سالبة !!!!!!!!!!!!!!!
    /// </summary>
    public enum PGravamenResult
    {
        PGravamen_Field_IsNullOrInvalid = -30221,
        PGravamen_Request_IsNullOrCorrupt=-30222,
        PGravamen_NecessaryPositions_AreNotAvailabe=-30223,
        PGravamen_PlatiffNecessaryField_IsNullOrInvalid=-30224,
        PGravamen_OffendingNecessaryField_IsNullOrInvalid=-30225,
        PGravamen_NoAttachmentAvailable=-30226,
        PGravamen_NoFileIsAttached=-30227,
        PGravamen_FileIsLargerThanAllowedThreshold=-30228,
        PGravamen_TheGeoLocation_IsRequired=-30229,
    }

    public enum GetPGravamenInfoResult
    {
        PGravamen_GetPGravamenInfo_Request_Is_Required              = -30281,
        PGravamen_GetPGravamenInfo_ThePGravamenContract_Is_Required = -30282,
        PGravamen_GetPGravamenInfo_FollowUpNo_Is_Required           = -30283,
        PGravamen_GetPGravamenInfo_PGravamen_NotFound               = -30284,
    }

    public enum GetPGravamenByIdResult
    {
        PGravamen_GetPGravamenById_Request_Is_Required                             = -30321,
        PGravamen_GetPGravamenById_ThePGravamenByIdContract_Is_Required            = -30322,
        PGravamen_GetPGravamenById_Id_FollowUpNo_Is_Required                       = -30323,
        PGravamen_GetPGravamenById_PGravamen_NotFound                              = -30324,
    }
    public enum GetPersonPGravamenInfoResult
    {
        PGravamen_GetPersonPGravamenInfoResult_Request_Is_Required = -30121,
        PGravamen_GetPersonPGravamenInfoResult_TheGetPersonPGravamenInfoContract_Is_Required = -30122,
        PGravamen_GetPersonPGravamenInfoResult_PersonNationalityCode_Is_Required = -30123,
        PGravamen_GetPersonPGravamenInfoResult_PersonNationalityCode_Not_Valid = -30124,
        PGravamen_GetPersonPGravamenInfoResult_PGravamens_NotFound = -30125,
    }

    public enum GetPersonPGravamenStatisticResult
    {
        PGravamen_GetPersonPGravamenStatisticResult_Request_Is_Required = -30141,
        PGravamen_GetPersonPGravamenStatisticResult_TheNationalityCode_Is_Required = -30142,
    }

}
