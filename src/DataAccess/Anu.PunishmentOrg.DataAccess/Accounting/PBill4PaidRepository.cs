using Anu.DataAccess;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.DataModel.Accounting;
using Anu.PunishmentOrg.Domain.Accounting;
using Anu.PunishmentOrg.Domain.PBillStore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.DataAccess.Accounting
{
    public class PBill4PaidRepository : GenericRepository<DataModel.Accounting.PBill4Paid>, IPBill4PaidRepository
    {
        public PBill4PaidRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<PBill4Paid> GetPBill4PaidByFishNo(string fishNo)
        {
            return await _context.Set<PBill4Paid>()
                                 .Where(a => a.FishNo == fishNo)
                                 .Include(a => a.TheObjectState)
                                 .FirstOrDefaultAsync();
        }
    }
}
