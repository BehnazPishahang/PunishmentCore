﻿

namespace Anu.PunishmentOrg.Domain.PBillStore;

public interface IPBillStoreRepository : Anu.Domain.IGenericRepository<DataModel.BillStore.PBillStore>
{
    public Task<IEnumerable<DataModel.BillStore.PBillStore>> GetByNumberDate(string billNo, string billDate);
}