namespace PunishmentOrg.Domain.Interface.PunishmentOrg
{
    public interface IPDiscoveryMinutesRepository : IGenericRepository<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>
    {
        public Task<IEnumerable<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>> getObejectStateTitleWithUniqueNo(string UniqueNo);
        public Task<IEnumerable<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>> GetPDiscoveryMinutesByGeoLocation(string geoLocationCode);
    }
}