namespace PunishmentOrg.Domain.Interface
{
    public partial interface IUnitOfWork : IDisposable
    {
        PunishmentOrg.IPCaseRepository PCaseRepository { get; }
        PunishmentOrg.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; }
        IObjectStateRepository ObjectState { get; }
        int Complete();
    }
}
