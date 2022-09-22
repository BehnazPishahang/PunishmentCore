using Anu.DataAccess.Repositories;
using Anu.DataAccess;
using Anu.PunishmentOrg.DataModel.Accounting;
using Anu.PunishmentOrg.Domain.Accounting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.DataAccess.Accounting
{
    public class PTreasuryRandomNumRepository : GenericRepository<PTreasuryRandomNum>, IPTreasuryRandomNumRepository
    {
        public PTreasuryRandomNumRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<PTreasuryRandomNum>> Get_PTreasuryRandomNum_EndsWith_TreasuryNumber(string treasuryNumber)
        {
            return await _context.Set<PTreasuryRandomNum>()
                                 .Where(x => x.TreasuryNumber.EndsWith(treasuryNumber))
                                 .ToListAsync();
        }
    }
}
