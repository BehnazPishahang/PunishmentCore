namespace Anu.UnitOfWork.DataAccess
{
    public partial class UnitOfWork : Anu.DataAccess.IUnitOfWork
    {
        private readonly Anu.DataAccess.ApplicationDbContext _context;
        public UnitOfWork(Anu.DataAccess.ApplicationDbContext context)
        {
            _context = context;
            //PDiscoveryMinutes = new PunishmentOrg.DataAccess.DiscoveryMinutes.PDiscoveryMinutesRepository(_context);
            //ObjectState = new BaseInfo.DataAccess.SystemObject.ObjectStateRepository(_context);
            //PCase = new PunishmentOrg.DataAccess.PCase.PCaseRepository(_context);
            //GFESUser = new BaseInfo.DataAccess.FrontEndSecurity.GFESUserRepository(_context);
            //GFESUserAccess = new BaseInfo.DataAccess.FrontEndSecurity.GFESUserAccessRepository(_context);
            //PRegistaryTimeCase = new PunishmentOrg.DataAccess.PCase.PRegistaryTimeCaseRepository(_context);
            //PJudgmentCase = new PunishmentOrg.DataAccess.Terminate.PJudgmentCaseRepository(_context);
            //PBillStore = new Anu.PunishmentOrg.DataAccess.PBillStore.PBillStoreRepository(_context);
            //PBExchangeUnit = new Anu.PunishmentOrg.DataAccess.BaseInfo.PBExchangeUnitRepository(_context);
            //PInspectionReport = new PunishmentOrg.DataAccess.InspectionReport.PInspectionReportRepository(_context);
            //PNotice = new PunishmentOrg.DataAccess.Notice.PNoticeRepository(_context);
        }
        //public Anu.PunishmentOrg.Domain.DiscoveryMinutes.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; private set; }
        //public Anu.PunishmentOrg.Domain.PBillStore.IPBillSoreRepository PBillStore { get; private set; }

        //public Anu.BaseInfo.Domain.SystemObject.IObjectStateRepository ObjectState { get; private set; }
        //public Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserRepository GFESUser { get; private set; }
        //public Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserAccessRepository GFESUserAccess { get; private set; }
        //public Anu.PunishmentOrg.Domain.Case.IPRegistaryTimeCaseRepository PRegistaryTimeCase { get; private set; }
        //public Anu.PunishmentOrg.Domain.Case.IPCaseRepository PCase { get; private set; }
        //public Anu.PunishmentOrg.Domain.Terminate.IPJudgmentCaseRepository PJudgmentCase { get; private set; }
        //public Anu.PunishmentOrg.Domain.BaseInfo.IPBExchangeUnitRepository PBExchangeUnit { get; private set; }
        //
        //public PunishmentOrg.Domain.InspectionReport.IPInspectionReportRepository PInspectionReport { get; private set; }
        //public PunishmentOrg.Domain.Notice.IPNoticeRepository PNotice { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public TRepository Repositorey<TRepository>() where TRepository : class
        {
            return (TRepository)Activator.CreateInstance(typeof(TRepository), new object[] { _context });
        }

        //var userAccess = await unitOfWork.GFESUserAccess.ValidateUserAndPassword(request.UserName, hashPass, GFESUserAccessType);


    }
}
