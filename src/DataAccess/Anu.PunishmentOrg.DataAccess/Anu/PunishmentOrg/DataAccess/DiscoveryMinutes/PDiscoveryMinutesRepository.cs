using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataAccess.DiscoveryMinutes
{
    public class PDiscoveryMinutesRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.DiscoveryMinutes.PDiscoveryMinutes>, Domain.DiscoveryMinutes.IPDiscoveryMinutesRepository
    {
        public PDiscoveryMinutesRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<DataModel.DiscoveryMinutes.PDiscoveryMinutes>> GetPDiscoveryMinutesByGeoLocation(string geoLocationCode)
        {
            return await _context.Set<DataModel.DiscoveryMinutes.PDiscoveryMinutes>().Include(x => x.TheGeoLocation).ToListAsync();
        }
        public async Task<IEnumerable<DataModel.DiscoveryMinutes.PDiscoveryMinutes>> GetPDiscoveryMinutesByAllReferences(string UniqueNo)
        {
            return await _context.Set<DataModel.DiscoveryMinutes.PDiscoveryMinutes>().Include(x => x.TheGeoLocation).ThenInclude(x => x.TheParentLocation).ToListAsync();
        }

        public async Task<IEnumerable<DataModel.DiscoveryMinutes.PDiscoveryMinutes>> getObejectStateTitleWithUniqueNo(string UniqueNo)
        {
            return await _context.Set<DataModel.DiscoveryMinutes.PDiscoveryMinutes>().Include(x => x.TheObjectState).Where(a=>a.UniqueNo==UniqueNo).ToListAsync();
        }

        public async Task<DataModel.DiscoveryMinutes.PDiscoveryMinutes> GetPDiscoveryMinutesByUniqueNo(string UniqueNo)
        {
            return await _context.Set<DataModel.DiscoveryMinutes.PDiscoveryMinutes>()
                .Where(x=>x.UniqueNo == UniqueNo)
                .Include(x => x.TheObjectState)
                .Include(x => x.TheReceiverUnit)
                .Include(x => x.TheReferUnit)
                .Include(x => x.TheCityPuoRefUnit)
                .Include(x => x.ThePCase)
                .FirstOrDefaultAsync();

        }
    }
}


