namespace PunishmentOrg.Domain.Interface
{
    public partial interface IUnitOfWork : IDisposable
    {
        PunishmentOrg.Case.IPCaseRepository PCaseRepository { get; }
        PunishmentOrg.DiscoveryMinutes.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; }
        BaseInfo.Anu.BaseInfo.FrontEndSecurity.IGFESUserRepository GFESUser { get; }
        BaseInfo.Anu.BaseInfo.FrontEndSecurity.IGFESUserAccessRepository GFESUserAccess { get; }
        PunishmentOrg.DataModelPunishmentOrgAnu.PunishmentOrg.Case.IPRegistaryTimeCaseRepository PRegistaryTimeCase { get; }
        PunishmentOrg.Anu.PunishmentOrg.Terminate.IPJudgmentCaseRepository PJudgmentCase { get; }
        BaseInfo.SystemObject.IObjectStateRepository ObjectState { get; }
        int Complete();
    }
}
