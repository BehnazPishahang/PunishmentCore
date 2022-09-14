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
        abstract Task<PBill4Paid> Get_PBill4Paid_By_FishNo(string fishNo);

        abstract Task<PBill4Paid> Get_PBill4Paid_By_FishNo_With_ValidAccount(string fishNo);
    }
}
