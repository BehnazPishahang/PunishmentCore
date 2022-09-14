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

        public Task<PTreasuryRandomNum> Get_PTreasuryRandomNum_By_TreasuryNumber(string treasuryNumber)
        {
            throw new NotImplementedException();
        }
    }
}
