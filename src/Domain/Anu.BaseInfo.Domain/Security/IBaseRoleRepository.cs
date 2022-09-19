using Anu.BaseInfo.DataModel.Security.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.Security
{
    public interface IBaseRoleRepository : Anu.Domain.IGenericRepository<BaseRole>
    {
        public Task<BaseRole> GetById(string id);
    }
}
