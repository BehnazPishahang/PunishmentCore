using Anu.BaseInfo.Domain.Security;
using Anu.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.DataAccess.Security
{
    public class CMSUserRepository : GenericRepository<Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser>, ICMSUserRepository
    {
        public CMSUserRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }
    }

}
