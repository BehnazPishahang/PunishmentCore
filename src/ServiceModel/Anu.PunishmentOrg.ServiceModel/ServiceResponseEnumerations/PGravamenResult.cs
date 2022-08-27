using System;
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
        PGravamen_Field_IsNullOrInvalid = -60001,
        PGravamen_Request_IsNullOrCorrupt=-60002,
        PGravamen_NecessaryPositions_AreNotAvailabe=-60003,
        PGravamen_PlatiffNecessaryField_IsNullOrInvalid=-60004,
        PGravamen_OffendingNecessaryField_IsNullOrInvalid=-60005,
        PGravamen_NoAttachmentAvailable=-60006,
        PGravamen_NoFileIsAttached=-60007,
        PGravamen_FileIsLargerThanAllowedThreshold=-60008,
        PGravamen_TheGeoLocation_IsRequired=-60009,
    }
}
