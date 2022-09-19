using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.SystemConfiguration
{
    public interface IWorkFlowInstanceWorkItemRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.SystemConfiguration.WorkFlowInstanceWorkItem>
    {
        public Task Insert(string activateDate, string baseRoleId, string description, string maxDelayDate, string securityOrganizationId, string title,
                           string relatedCaseId, string relatedCaseNo, string relatedSystemObjectCaseId,
                           string relatedDocObjectId, string relatedDocId, string relatedDocNo, string RelatedDocFormId,
                           Anu.BaseInfo.Enumerations.WorkFlowActivityInstanceState state, Anu.BaseInfo.Enumerations.WorkFlowWorkItemType type, Anu.BaseInfo.Enumerations.YesNo userCanDelay,
                           string temp1, string temp2, string relatedCMSUserId = null, string RelatedCMSUserRoleTypeId = null, bool SameCaseServerForSenderAndReceiver = true, string ObjectId = null);
    }
}
