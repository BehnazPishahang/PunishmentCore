
using Anu.PunishmentOrg.ServiceModel.Notice;
using Microsoft.AspNetCore.Mvc;

namespace Anu.PunishmentOrg.Api.Notice
{
    public class PNoticeServiceController : PNoticeServiceControllerBase
    {
        #region Constructor
        public PNoticeServiceController()
        {
        }
        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides
        public override PNoticeInqueryResponse InqueryPNoticeList([FromBody] PNoticePersonContract request)
        {
            throw new NotImplementedException();
        }
        #endregion Overrides

        #region Methods
        #endregion Methods
    }
}