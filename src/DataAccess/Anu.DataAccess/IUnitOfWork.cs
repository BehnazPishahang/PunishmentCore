
namespace Anu.DataAccess
{
    public partial interface IUnitOfWork : IDisposable
    {
        Anu.PunishmentOrg.Domain.Case.IPCaseRepository PCase { get; }
        Anu.PunishmentOrg.Domain.DiscoveryMinutes.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; }
        Anu.PunishmentOrg.Domain.PBillStore.IPBillSoreRepository PBillStore { get; }
        Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserRepository GFESUser { get; }
        Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserAccessRepository GFESUserAccess { get; }
        Anu.PunishmentOrg.Domain.Case.IPRegistaryTimeCaseRepository PRegistaryTimeCase { get; }
        Anu.PunishmentOrg.Domain.Terminate.IPJudgmentCaseRepository PJudgmentCase { get; }
        Anu.BaseInfo.Domain.SystemObject.IObjectStateRepository ObjectState { get; }
        Anu.PunishmentOrg.Domain.BaseInfo.IPBExchangeUnitRepository PBExchangeUnit { get; }
        Anu.PunishmentOrg.Domain.InspectionReport.IPInspectionReportRepository PInspectionReport { get; }
        Anu.PunishmentOrg.Domain.Notice.IPNoticeRepository PNotice { get; }
        Anu.BaseInfo.Domain.ExchangeData.IGMechanizedLetterTypeRepository GMechanizedLetterType { get; }
        Anu.BaseInfo.Domain.ExchangeData.INAJAUnitRepository NAJAUnit { get; }
        Anu.BaseInfo.Domain.SystemConfiguration.ICMSOrganizationRepository CMSOrganization { get; }
        Anu.BaseInfo.Domain.SystemConfiguration.ICMSUserRoleTypeRepository CMSUserRoleType { get; }
        Anu.BaseInfo.Domain.OrganizationChart.IUnitRepository Unit { get; }
        Anu.BaseInfo.Domain.SystemObject.ISystemObjectRepository SystemObject { get; }
        Anu.BaseInfo.Domain.SystemObject.ISystemFormRepository SystemForm { get; }
        Anu.BaseInfo.Domain.MechanizedLetter.IGMechanizedLetterRepository GMechanizedLetter { get; }
        Anu.BaseInfo.Domain.Security.IBaseRoleRepository BaseRole { get; }
        Anu.BaseInfo.Domain.Security.ICMSUserRepository CMSUser { get; }
        int Complete();
    }
}
