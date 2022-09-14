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

        public async Task<PBill4Paid> Get_PBill4Paid_By_FishNo(string fishNo)
        {
            return await _context.Set<PBill4Paid>()
                                 .Where(a => a.FishNo == fishNo)
                                 .Include(a => a.TheObjectState)
                                 .FirstOrDefaultAsync();
        }
    }
}
