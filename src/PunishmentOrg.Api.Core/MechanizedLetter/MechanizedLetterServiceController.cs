
using Anu.BaseInfo.ServiceModel.MechanizedLetter;
using Microsoft.AspNetCore.Mvc;

namespace Anu.BaseInfo.Api.MechanizedLetter
{
    public class MechanizedLetterServiceController : MechanizedLetterServiceControllerBase
    {
        #region Constructor
        public MechanizedLetterServiceController()
        {
        }
        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides

        public override MechanizedLetterResponse SendMechanizedLetter([FromBody] MechanizedLetterRequest request)
        {
            throw new NotImplementedException();
        }
        #endregion Overrides

        #region Methods
        #endregion Methods
    }
}