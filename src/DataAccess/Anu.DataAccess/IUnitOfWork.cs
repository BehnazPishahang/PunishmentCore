namespace Anu.DataAccess
{
    public partial interface IUnitOfWork : IDisposable
    {
        Anu.PunishmentOrg.Domain.Case.IPCaseRepository PCaseRepository { get; }
        Anu.PunishmentOrg.Domain.DiscoveryMinutes.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; }
        Anu.PunishmentOrg.Domain.PBillStore.IPBillSoreRepository PBillStoreRepository { get; }
        Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserRepository GFESUser { get; }
        Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserAccessRepository GFESUserAccess { get; }
        Anu.PunishmentOrg.Domain.Case.IPRegistaryTimeCaseRepository PRegistaryTimeCase { get; }
        Anu.PunishmentOrg.Domain.Terminate.IPJudgmentCaseRepository PJudgmentCase { get; }
        Anu.BaseInfo.Domain.SystemObject.IObjectStateRepository ObjectState { get; }
        Anu.PunishmentOrg.Domain.BaseInfo.IPBExchangeUnitRepository PBExchangeUnitRepository { get; }
        
        int Complete();
    }
}
