using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.SystemConfiguration
{
    public interface ICMSOrganizationRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization>
    {
        public Task<Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization> GetByCode(string code);
    }
}
