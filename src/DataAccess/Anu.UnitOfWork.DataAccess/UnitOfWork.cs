namespace Anu.UnitOfWork.DataAccess
{
    public partial class UnitOfWork : Anu.DataAccess.IUnitOfWork
    {
        private readonly Anu.DataAccess.ApplicationDbContext _context;
        public UnitOfWork(Anu.DataAccess.ApplicationDbContext context)
        {
            _context = context;
            PDiscoveryMinutes = new PunishmentOrg.DataAccess.DiscoveryMinutes.PDiscoveryMinutesRepository(_context);
            ObjectState = new BaseInfo.DataAccess.SystemObject.ObjectStateRepository(_context);
            PCase = new PunishmentOrg.DataAccess.PCase.PCaseRepository(_context);
            GFESUser = new BaseInfo.DataAccess.FrontEndSecurity.GFESUserRepository(_context);
            GFESUserAccess = new BaseInfo.DataAccess.FrontEndSecurity.GFESUserAccessRepository(_context);
            PRegistaryTimeCase = new PunishmentOrg.DataAccess.PCase.PRegistaryTimeCaseRepository(_context);
            PJudgmentCase = new PunishmentOrg.DataAccess.Terminate.PJudgmentCaseRepository(_context);
            PBillStore = new Anu.PunishmentOrg.DataAccess.PBillStore.PBillStoreRepository(_context);
            PBExchangeUnit = new Anu.PunishmentOrg.DataAccess.BaseInfo.PBExchangeUnitRepository(_context);
            PInspectionReport = new PunishmentOrg.DataAccess.InspectionReport.PInspectionReportRepository(_context);
            PNotice = new PunishmentOrg.DataAccess.Notice.PNoticeRepository(_context);
            GMechanizedLetterType = new Anu.BaseInfo.DataAccess.ExchangeData.GMechanizedLetterTypeRepository(_context);
            NAJAUnit = new Anu.BaseInfo.DataAccess.ExchangeData.NAJAUnitRepository(_context);
            CMSOrganization = new Anu.BaseInfo.DataAccess.SystemConfiguration.CMSOrganizationRepository(_context);
            CMSUserRoleType = new Anu.BaseInfo.DataAccess.SystemConfiguration.CMSUserRoleTypeRepository(_context);
            Unit = new Anu.BaseInfo.DataAccess.OrganizationChart.UnitRepository(_context);
            SystemObject = new Anu.BaseInfo.DataAccess.SystemObject.SystemObjectRepository(_context);
            SystemForm = new Anu.BaseInfo.DataAccess.SystemObject.SystemFormRepository(_context);
            GMechanizedLetter = new Anu.BaseInfo.DataAccess.GMechanizedLetter.GMechanizedLetterRepository(_context);
            BaseRole = new Anu.BaseInfo.DataAccess.Security.BaseRoleRepository(_context);
            WorkFlowInstanceWorkItem= new Anu.BaseInfo.DataAccess.SystemConfiguration.WorkFlowInstanceWorkItemRepository(_context);
            CMSUser = new Anu.BaseInfo.DataAccess.Security.CMSUserRepository(_context);
        }
        public Anu.PunishmentOrg.Domain.DiscoveryMinutes.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; private set; }
        public Anu.PunishmentOrg.Domain.PBillStore.IPBillSoreRepository PBillStore { get; private set; }

        public Anu.BaseInfo.Domain.SystemObject.IObjectStateRepository ObjectState { get; private set; }
        public Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserRepository GFESUser { get; private set; }
        public Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserAccessRepository GFESUserAccess { get; private set; }
        public Anu.PunishmentOrg.Domain.Case.IPRegistaryTimeCaseRepository PRegistaryTimeCase { get; private set; }
        public Anu.PunishmentOrg.Domain.Case.IPCaseRepository PCase { get; private set; }
        public Anu.PunishmentOrg.Domain.Terminate.IPJudgmentCaseRepository PJudgmentCase { get; private set; }
        public Anu.PunishmentOrg.Domain.BaseInfo.IPBExchangeUnitRepository PBExchangeUnit { get; private set; }
        public Anu.BaseInfo.Domain.SystemConfiguration.ICMSOrganizationRepository CMSOrganization { get; private set; }
        public Anu.BaseInfo.Domain.SystemConfiguration.ICMSUserRoleTypeRepository CMSUserRoleType { get; private set; }
        public Anu.BaseInfo.Domain.OrganizationChart.IUnitRepository Unit { get; private set; }
        public Anu.BaseInfo.Domain.SystemObject.ISystemObjectRepository SystemObject { get; private set; }
        public Anu.BaseInfo.Domain.SystemObject.ISystemFormRepository SystemForm { get; private set; }
        public Anu.BaseInfo.Domain.MechanizedLetter.IGMechanizedLetterRepository GMechanizedLetter { get; private set; }
        public Anu.BaseInfo.Domain.Security.IBaseRoleRepository BaseRole { get; private set; }
        public Anu.BaseInfo.Domain.SystemConfiguration.IWorkFlowInstanceWorkItemRepository WorkFlowInstanceWorkItem{ get; private set; }
        public Anu.BaseInfo.Domain.Security.ICMSUserRepository CMSUser { get; private set; }

        public PunishmentOrg.Domain.InspectionReport.IPInspectionReportRepository PInspectionReport { get; private set; }
        public PunishmentOrg.Domain.Notice.IPNoticeRepository PNotice { get; private set; }
        public BaseInfo.Domain.ExchangeData.IGMechanizedLetterTypeRepository GMechanizedLetterType { get; private set; }
        public BaseInfo.Domain.ExchangeData.INAJAUnitRepository NAJAUnit { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
