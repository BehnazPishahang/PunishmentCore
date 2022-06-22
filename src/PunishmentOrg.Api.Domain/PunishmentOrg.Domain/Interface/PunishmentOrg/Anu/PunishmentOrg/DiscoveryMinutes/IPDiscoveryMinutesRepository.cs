namespace PunishmentOrg.Domain.Interface.PunishmentOrg
{
    public interface IPDiscoveryMinutesRepository : IGenericRepository<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>
    {
        public Task<IEnumerable<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>> getObejectStateTitleWithUniqueNo(string UniqueNo);
        public Task<IEnumerable<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>> GetPDiscoveryMinutesByGeoLocation(string geoLocationCode);
        public Task<IEnumerable<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>> GetPDiscoveryMinutesByAllReferences(string UniqueNo);
        public Task<DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes> GetPDiscoveryMinutesByUniqueNo(string UniqueNo);

    }
}