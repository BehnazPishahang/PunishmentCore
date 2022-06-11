using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.DataAccess.Repositories.BaseInfo.Anu.BaseInfo.SystemObject
{
    public class ObjectStateRepository : GenericRepository<Domain.Entities.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState>,
        Domain.Interface.BaseInfo.Anu.BaseInfo.SystemObject.IObjectStateRepository
    {
        public ObjectStateRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
