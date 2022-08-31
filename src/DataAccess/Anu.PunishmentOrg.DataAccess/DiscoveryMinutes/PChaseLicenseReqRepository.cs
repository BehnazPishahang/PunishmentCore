using Anu.DataAccess;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.Domain.DiscoveryMinutes;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataAccess.DiscoveryMinutes
{
    public class PChaseLicenseReqRepository : GenericRepository<DataModel.DiscoveryMinutes.PChaseLicenseReq>, IPChaseLicenseReqRepository
    {
        public PChaseLicenseReqRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
