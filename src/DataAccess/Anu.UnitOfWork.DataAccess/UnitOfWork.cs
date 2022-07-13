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
            PCaseRepository = new PunishmentOrg.DataAccess.PCase.PCaseRepository(_context);
            GFESUser = new BaseInfo.DataAccess.FrontEndSecurity.GFESUserRepository(_context);
            GFESUserAccess = new BaseInfo.DataAccess.FrontEndSecurity.GFESUserAccessRepository(_context);
            PRegistaryTimeCase = new PunishmentOrg.DataAccess.PCase.PRegistaryTimeCaseRepository(_context);
            PJudgmentCase = new PunishmentOrg.DataAccess.Terminate.PJudgmentCaseRepository(_context);
        }
        public Anu.PunishmentOrg.Domain.DiscoveryMinutes.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; private set; }
        public Anu.PunishmentOrg.Domain.PBillStore.IPBillSoreRepository PBillStoreRepository { get; private set; }

        public Anu.BaseInfo.Domain.SystemObject.IObjectStateRepository ObjectState { get; private set; }
        public Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserRepository GFESUser { get; private set; }
        public Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserAccessRepository GFESUserAccess { get; private set; }
        public Anu.PunishmentOrg.Domain.Case.IPRegistaryTimeCaseRepository PRegistaryTimeCase { get; private set; }
        public Anu.PunishmentOrg.Domain.Case.IPCaseRepository PCaseRepository { get; private set; }
        public Anu.PunishmentOrg.Domain.Terminate.IPJudgmentCaseRepository PJudgmentCase { get; private set; }
        public Anu.PunishmentOrg.Domain.BaseInfo.IPBExchangeUnitRepository PBExchangeUnitRepository { get; private set; }

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
