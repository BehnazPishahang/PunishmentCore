namespace Anu.PunishmentOrg.Domain.DiscoveryMinutes
{
    public interface IPDiscoveryMinutesRepository : Anu.Domain.IGenericRepository<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes>
    {
        public Task<IEnumerable<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes>> getObejectStateTitleWithUniqueNo(string UniqueNo);
        public Task<IEnumerable<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes>> GetPDiscoveryMinutesByGeoLocation(string geoLocationCode);
        public Task<IEnumerable<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes>> GetPDiscoveryMinutesByAllReferences(string UniqueNo);
        public Task<Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes> GetPDiscoveryMinutesByUniqueNo(string UniqueNo);

    }
}