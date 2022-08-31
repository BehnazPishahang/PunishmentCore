using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations
{
    public enum MechanizedLetterResult
    {
        MechanizedLetter_CreatorUserName_Is_Null = 30131,
        MechanizedLetter_OuterOrgLetterDate_Is_Not_ValidDate = 30132,
        MechanizedLetter_OuterOrgLetterDate_Is_Null = 30133,
        MechanizedLetter_OuterOrgLetterNo_Is_Not_Digit = 30134,
        MechanizedLetter_OuterOrgLetterNo_Is_Null = 30135,
        MechanizedLetter_GMechanizedLetterTypeCode_Is_null = 30136,
        MechanizedLetter_RecieveGMechanizedLetterServiceResult_Reciver_Is_Null = 30137,
        MechanizedLetter_SenderOuterOrgCode_Is_Null = 30138,
        MechanizedLetter_SenderOuterOrgCode_Is_Not_Valid = 30139,
        MechanizedLetter_TheReceiverInnerOrgCode_Is_Not_Valid = 301310,
        MechanizedLetter_LetterText_Is_Null = 301311,
        MechanizedLetter_Request_Is_Null = 301312,
        MechanizedLetter_NAJAUnit_Is_Null = 301313,
    }
}
