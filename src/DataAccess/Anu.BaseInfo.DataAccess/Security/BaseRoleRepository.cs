using Anu.BaseInfo.Domain.Security;
using Anu.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.DataAccess.Security
{
    public class BaseRoleRepository : GenericRepository<Anu.BaseInfo.DataModel.Security.Role.BaseRole>, IBaseRoleRepository
    {
        public BaseRoleRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }
    }
}
