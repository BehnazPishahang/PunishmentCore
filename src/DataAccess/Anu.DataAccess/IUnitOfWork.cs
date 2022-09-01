
namespace Anu.DataAccess
{
    public partial interface IUnitOfWork : IDisposable
    {
        //Anu.PunishmentOrg.Domain.Case.IPCaseRepository PCase { get; }
        //Anu.PunishmentOrg.Domain.DiscoveryMinutes.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; }
        //Anu.PunishmentOrg.Domain.PBillStore.IPBillSoreRepository PBillStore { get; }
        //Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserRepository GFESUser { get; }
        //Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserAccessRepository GFESUserAccess { get; }
        //Anu.PunishmentOrg.Domain.Case.IPRegistaryTimeCaseRepository PRegistaryTimeCase { get; }
        //Anu.PunishmentOrg.Domain.Terminate.IPJudgmentCaseRepository PJudgmentCase { get; }
        //Anu.BaseInfo.Domain.SystemObject.IObjectStateRepository ObjectState { get; }
        //Anu.PunishmentOrg.Domain.BaseInfo.IPBExchangeUnitRepository PBExchangeUnit { get; }
        //Anu.PunishmentOrg.Domain.InspectionReport.IPInspectionReportRepository PInspectionReport { get; }
        //Anu.PunishmentOrg.Domain.Notice.IPNoticeRepository PNotice { get; }

        //Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess>
        TRepository Repositorey<TRepository>() where TRepository : Domain.IGenericRepository;

        int Complete();
    }
}
