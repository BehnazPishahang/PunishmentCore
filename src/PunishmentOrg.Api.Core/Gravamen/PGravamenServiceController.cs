
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Microsoft.AspNetCore.Mvc;

namespace Anu.PunishmentOrg.Api.Gravamen
{
    public class PGravamenServiceController : PGravamenServiceControllerBase
    {
        #region Constructor
        public PGravamenServiceController()
        {
        }

       
        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides

         public override PGravamenServiceResponse RecieveGravamen([FromBody] PGravamenServiceRequest request)
        {

            throw new NotImplementedException();
        }

        #endregion Overrides

        #region Methods
        #endregion Methods
    }
}