
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Commons.Validations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Microsoft.AspNetCore.Mvc;
using Utility;
using Utility.Exceptions;

namespace Anu.PunishmentOrg.Api.Gravamen
{
    public class PGravamenServiceController : PGravamenServiceControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;

        #region Constructor
        public PGravamenServiceController(Anu.DataAccess.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides

        public async override Task<PGravamenServiceResponse> RecieveGravamen([FromBody] PGravamenServiceRequest request)
        {
            var response = new PGravamenServiceResponse()
            {
                Result = new Commons.ServiceModel.ServiceResponse.Result()
            };

            try
            {



            }
            catch (AnuExceptions ex)
            {
                response.Result = ex.result;
                return response;
            }
            catch (Exception ex)
            {
                response.Result = AnuResult.Error.GetResult(ex);
                return response;
            }

            throw new NotImplementedException();
        }

        #endregion Overrides

        #region Methods
        #endregion Methods
    }
}