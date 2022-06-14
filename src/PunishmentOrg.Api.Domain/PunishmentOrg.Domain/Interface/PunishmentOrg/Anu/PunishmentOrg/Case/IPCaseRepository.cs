using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.Domain.Interface.PunishmentOrg
{
    public interface IPCaseRepository : IGenericRepository<Anu.PunishmentOrg.Case.PCase>
    {
        public Task<Anu.PunishmentOrg.Case.PCase> GetTerminateCaseByNo(string no);
    }
}
