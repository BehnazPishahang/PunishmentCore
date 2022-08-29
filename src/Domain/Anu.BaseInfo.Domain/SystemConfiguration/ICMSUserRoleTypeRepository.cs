using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.SystemConfiguration
{
    public interface ICMSUserRoleTypeRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.SystemConfiguration.CMSUserRoleType>
    {
        public Task<Anu.BaseInfo.DataModel.SystemConfiguration.CMSUserRoleType> GetByCode(string code);
    }
}
