using Microsoft.EntityFrameworkCore;

namespace PunishmentOrg.DataAccess.Repositories.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public class PDiscoveryMinutesRepository : GenericRepository<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>, Domain.Interface.PunishmentOrg.DiscoveryMinutes.IPDiscoveryMinutesRepository
    {
        public PDiscoveryMinutesRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>> GetPDiscoveryMinutesByGeoLocation(string geoLocationCode)
        {
            return await _context.Set<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>().Include(x => x.TheGeoLocation).ToListAsync();
        }
        public async Task<IEnumerable<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>> GetPDiscoveryMinutesByAllReferences(string UniqueNo)
        {
            return await _context.Set<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>().Include(x => x.TheGeoLocation).ThenInclude(x => x.TheParentLocation).ToListAsync();
        }

        public async Task<IEnumerable<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>> getObejectStateTitleWithUniqueNo(string UniqueNo)
        {
            return await _context.Set<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>().Include(x => x.TheObjectState).ToListAsync();
        }

        public async Task<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes> GetPDiscoveryMinutesByUniqueNo(string UniqueNo)
        {
            return await _context.Set<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>()
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


