using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.Domain.Interface.PunishmentOrg.Anu.PunishmentOrg.Terminate
{
    public interface IPJudgmentCaseRepository: IGenericRepository<DataModel.PunishemntOrg.Anu.PunishmentOrg.Terminate.PJudgmentCase>
    {
        public Task<IEnumerable<DataModel.PunishemntOrg.Anu.PunishmentOrg.Terminate.PJudgmentCase>> GetPJudgmentCaseByObjectID(string ObjectID);

    }
}
