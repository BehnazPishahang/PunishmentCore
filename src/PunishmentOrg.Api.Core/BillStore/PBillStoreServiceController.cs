
using Anu.PunishmentOrg.ServiceModel.BillStore;
using Microsoft.AspNetCore.Mvc;

namespace Anu.PunishmentOrg.Api.BillStore
{
    public class PBillStoreServiceController : PBillStoreServiceControllerBase
    {
        #region Constructor
        public PBillStoreServiceController()
        {
        }


        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides
        public override Task<PBillStoreServiceResponse> SendPBillStore([FromBody] PBillStoreServiceRequest request)
        {
            throw new NotImplementedException();
        }
        #endregion Overrides

        #region Methods
        #endregion Methods
    }
}