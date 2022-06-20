namespace PunishmentOrg.Domain.Interface
{
    public partial interface IUnitOfWork : IDisposable
    {
        PunishmentOrg.IPCaseRepository PCaseRepository { get; }
        PunishmentOrg.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; }
        BaseInfo.Anu.BaseInfo.FrontEndSecurity.IGFESUserRepository GFESUser { get; }
        BaseInfo.Anu.BaseInfo.FrontEndSecurity.IGFESUserAccessRepository GFESUserAccess { get; }
        IObjectStateRepository ObjectState { get; }
        int Complete();
    }
}
