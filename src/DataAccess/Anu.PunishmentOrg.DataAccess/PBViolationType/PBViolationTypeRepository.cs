using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.Domain.PBViolationType;

namespace Anu.PunishmentOrg.DataAccess.PBViolationType;

//! کل من علیها fun
public class PBViolationTypeRepository : GenericRepository<DataModel.BaseInfo.PBViolationType>, IPBViolationTypeRepository
{
    public PBViolationTypeRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
    {
    }

}


