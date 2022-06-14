using Anu.PunishmentOrg.DiscoveryMinutes;
using Microsoft.EntityFrameworkCore;
using PunishmentOrg.Domain.Interface.PunishmentOrg;

namespace PunishmentOrg.DataAccess.Repositories.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public class PDiscoveryMinutesRepository : GenericRepository<PDiscoveryMinutes>, Domain.Interface.PunishmentOrg.IPDiscoveryMinutesRepository
    {
        public PDiscoveryMinutesRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PDiscoveryMinutes>> GetPDiscoveryMinutesByGeoLocation(string geoLocationCode)
        {
            return await _context.Set<PDiscoveryMinutes>().Include(x => x.TheGeoLocation).ToListAsync();
        }
        public async Task<IEnumerable<PDiscoveryMinutes>> GetPDiscoveryMinutesByAllReferences(string UniqueNo)
        {
            return await _context.Set<PDiscoveryMinutes>().Include(x => x.TheGeoLocation).ThenInclude(x => x.TheParentLocation).ToListAsync();
        }

        Task<IEnumerable<PDiscoveryMinutes>> IPDiscoveryMinutesRepository.getObejectStateTitleWithUniqueNo(string UniqueNo)
        {
            throw new NotImplementedException();
        }
    }
}


