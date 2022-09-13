using Anu.PunishmentOrg.DataModel.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.Domain.Accounting
{
    public interface IPBill4PaidRepository : Anu.Domain.IGenericRepository<DataModel.Accounting.PBill4Paid>
    {
        abstract Task<PBill4Paid> GetPBill4PaidByFishNo(string fishNo);
    }
}
