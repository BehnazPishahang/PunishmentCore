using Anu.BaseInfo.DataModel.Security.Role;
using Anu.BaseInfo.Domain.Security;
using Anu.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.DataAccess.Security
{
    public class BaseRoleRepository : Anu.DataAccess.Repositories.GenericRepository<BaseRole>, Anu.BaseInfo.Domain.Security.IBaseRoleRepository
    {
        public BaseRoleRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }

        public async Task<BaseRole> GetById(string id)
        {
            var a =  await _context.Set<BaseRole>().Where(x => x.Id == id).FirstOrDefaultAsync();
            return a;
        }
    }
}
