using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations
{
    public enum MechanizedLetterResult
    {
        MechanizedLetter_CreatorUserName_Is_Null = -60001,
        MechanizedLetter_OuterOrgLetterDate_Is_Not_ValidDate = -60002,
        MechanizedLetter_OuterOrgLetterDate_Is_Null=-60003,
        MechanizedLetter_OuterOrgLetterNo_Is_Not_Digit=-60004,
        MechanizedLetter_OuterOrgLetterNo_Is_Null=-60005,
        MechanizedLetter_GMechanizedLetterTypeCode_Is_Not_Valid=-60006,
        MechanizedLetter_RecieveGMechanizedLetterServiceResult_Reciver_Is_Null=-60007,
        MechanizedLetter_SenderOuterOrgCode_Is_Null=-60008,
        MechanizedLetter_SenderOuterOrgCode_Is_Not_Valid=-60009,
        MechanizedLetter_TheReceiverInnerOrgCode_Is_Not_Valid=-60010,
        MechanizedLetter_LetterText_Is_Null=-60011,
    }
}
