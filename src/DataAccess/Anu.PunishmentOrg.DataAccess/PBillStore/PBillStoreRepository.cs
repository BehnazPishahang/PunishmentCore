using Anu.PunishmentOrg.Domain.PBillStore;
using Anu.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Anu.PunishmentOrg.DataAccess.PBillStore;

public class PBillStoreRepository : GenericRepository<DataModel.BillStore.PBillStore>, IPBillStoreRepository
{
    public PBillStoreRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<DataModel.BillStore.PBillStore>> GetByNumberDate(string billNo, string billDate)
    {
        return await _context.Set<DataModel.BillStore.PBillStore>().Where(a => a.BillNo == billNo).Where(a => a.BillDate == billDate).ToListAsync();
    }
}


