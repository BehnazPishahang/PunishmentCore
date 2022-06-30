

namespace Anu.DataAccess
{
    public partial interface IUnitOfWork : IDisposable
    {
        Anu.PunishmentOrg.Domain.Case.IPCaseRepository PCaseRepository { get; }
        Anu.PunishmentOrg.Domain.DiscoveryMinutes.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; }
        Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserRepository GFESUser { get; }
        Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserAccessRepository GFESUserAccess { get; }
        Anu.PunishmentOrg.Domain.Case.IPRegistaryTimeCaseRepository PRegistaryTimeCase { get; }
        Anu.PunishmentOrg.Domain.Terminate.IPJudgmentCaseRepository PJudgmentCase { get; }
        Anu.BaseInfo.Domain.SystemObject.IObjectStateRepository ObjectState { get; }
        int Complete();
    }
}
