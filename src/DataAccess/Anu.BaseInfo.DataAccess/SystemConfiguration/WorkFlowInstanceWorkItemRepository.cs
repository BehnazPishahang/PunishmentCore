using Anu.BaseInfo.DataModel.SystemConfiguration;
using Anu.BaseInfo.Domain.Security;
using Anu.BaseInfo.Domain.SystemConfiguration;
using Anu.BaseInfo.Domain.SystemObject;
using Anu.DataAccess.Repositories;
using Anu.Domain;
using Anu.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.CalendarHelper;

namespace Anu.BaseInfo.DataAccess.SystemConfiguration
{
    public class WorkFlowInstanceWorkItemRepository : GenericRepository<Anu.BaseInfo.DataModel.SystemConfiguration.WorkFlowInstanceWorkItem>, IWorkFlowInstanceWorkItemRepository
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;

     
        public WorkFlowInstanceWorkItemRepository(Anu.DataAccess.ApplicationDbContext context, Anu.DataAccess.IUnitOfWork unitOfWork) : base(context)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Insert(string activateDate, string baseRoleId, string description, string maxDelayDate, string securityOrganizationId, string title,
                           string relatedCaseId, string relatedCaseNo, string relatedSystemObjectCaseId,
                           string relatedDocObjectId, string relatedDocId, string relatedDocNo, string RelatedDocFormId,
                           Anu.BaseInfo.Enumerations.WorkFlowActivityInstanceState state, Anu.BaseInfo.Enumerations.WorkFlowWorkItemType type, Anu.BaseInfo.Enumerations.YesNo userCanDelay,
                           string temp1, string temp2, string relatedCMSUserId = null, string RelatedCMSUserRoleTypeId = null, bool SameCaseServerForSenderAndReceiver = true, string ObjectId = null)
        {
            WorkFlowInstanceWorkItem workFlowInstanceWorkItem = new()
            {
                Id = Guid.NewGuid().ToString("N"),
                Timestamp = 1,
                MaxDelayDate = maxDelayDate,
                CreateDateTime = DateTime.Now.ToPersianDateTime(),
                ActivateDate = activateDate,
                Title = title,
                TheBaseRole = await _unitOfWork.Repositorey<IBaseRoleRepository>().GetById(baseRoleId),
                KeyField1 = temp1,
                KeyField2 = temp2,
                Description = description,
                State = state,
                Type = type,
                UserCanDelay = userCanDelay,
                TheRelatedSystemObjectCase = await _unitOfWork.Repositorey<ISystemObjectRepository>().GetById(relatedSystemObjectCaseId),
                SecurityOrganizationId = securityOrganizationId,
                RelatedCaseNo = relatedCaseNo,
                RelatedCaseId = relatedCaseId,
                TheRelatedDocObject = await _unitOfWork.Repositorey<ISystemObjectRepository>().GetById(relatedDocObjectId),
                RelatedDocId = relatedDocId,
                RelatedDocNo = relatedDocNo,
                TheRelatedDocForm = await _unitOfWork.Repositorey<ISystemFormRepository>().GetById(RelatedDocFormId),
                TheRelatedCMSUser = await _unitOfWork.Repositorey<ICMSUserRepository>().GetById(relatedCMSUserId),
                TheRelatedCMSUserRoleType = await _unitOfWork.Repositorey<ICMSUserRoleTypeRepository>().GetById(RelatedCMSUserRoleTypeId)
            };
            await _unitOfWork.Repositorey<IGenericRepository<WorkFlowInstanceWorkItem>>().Add(workFlowInstanceWorkItem);
        }
    }
}
