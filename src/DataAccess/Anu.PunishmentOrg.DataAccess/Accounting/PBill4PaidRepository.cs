using Anu.DataAccess;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.DataModel.Accounting;
using Anu.PunishmentOrg.Domain.Accounting;
using Microsoft.EntityFrameworkCore;

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

    public class PBill4PaidRepositoryNew : GenericRepository<DataModel.Accounting.PBill4Paid>//, IPBill4PaidRepository
    {
        public PBill4PaidRepositoryNew(ApplicationDbContext context) : base(context)
        {
        }

        public Task<PBill4Paid> GetPBill4PaidByFishNo(string fishNo)
        {
            throw new NotImplementedException();
        }
    }
}
