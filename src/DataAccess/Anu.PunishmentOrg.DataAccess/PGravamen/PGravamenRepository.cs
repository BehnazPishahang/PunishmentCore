using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.Domain.PGravamen;

namespace Anu.PunishmentOrg.DataAccess.PGravamen;

public class PGravamenRepository : GenericRepository<DataModel.Gravamen.PGravamen>, IPGravamenRepository
{
    public PGravamenRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
    {
    }

}


