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
}
