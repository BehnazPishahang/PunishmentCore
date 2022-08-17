using Anu.BaseInfo.Domain.SystemConfiguration;
using Anu.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.DataAccess.SystemConfiguration
{
    public class WorkFlowInstanceWorkItemRepository: GenericRepository<Anu.BaseInfo.DataModel.SystemConfiguration.WorkFlowInstanceWorkItem>, IWorkFlowInstanceWorkItemRepository
    {
        public WorkFlowInstanceWorkItemRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }
    }
}
