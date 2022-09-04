
using Anu.BaseInfo.DataModel.SystemConfiguration;
using Anu.BaseInfo.Domain.SystemConfiguration;
using Anu.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.DataAccess.SystemConfiguration
{
    public class CMSOrganizationRepository : GenericRepository<Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization>, ICMSOrganizationRepository
    {
        public CMSOrganizationRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }

        public async Task<CMSOrganization> GetByCode(string code)
        {
            return await _context.Set<Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization>()
                .Where(x => x.Code == code)
                .Include(x => x.TheUnit)
                .FirstOrDefaultAsync();
        }

    }
}
